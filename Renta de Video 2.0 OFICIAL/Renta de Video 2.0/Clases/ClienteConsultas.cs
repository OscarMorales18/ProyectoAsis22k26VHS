using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    // manejo de conexion con MySQL workbench Andre Gonzalez 9959-23-3117
    internal class ClienteConsultas
    {
        // inserción de cliente, creación de membresía real y obtención del ID generado Andre Gonzalez 9959-23-3117
        public int AgregarCliente(MCliente cliente)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlConnection conexion = objetoConexion.establecerConexion();

                // encadenación con la auditoría de la BD Andre Gonzalez 9959-23-3117
                Cauditoria.ConfigurarUsuarioBD(conexion);

                // 1. Inserción de los datos principales del cliente Andre Gonzalez 9959-23-3117
                string insertCliente = "INSERT INTO cliente (nombre, dpi, telefono, direccion, correo) VALUES (@nombre, @dpi, @telefono, @direccion, @correo);";
                MySqlCommand cmdCliente = new MySqlCommand(insertCliente, conexion);
                cmdCliente.Parameters.Add(new MySqlParameter("@nombre", cliente.Nombre));
                cmdCliente.Parameters.Add(new MySqlParameter("@dpi", cliente.Dpi));
                cmdCliente.Parameters.Add(new MySqlParameter("@telefono", cliente.Telefono));
                cmdCliente.Parameters.Add(new MySqlParameter("@direccion", cliente.Direccion));
                cmdCliente.Parameters.Add(new MySqlParameter("@correo", cliente.Correo));

                cmdCliente.ExecuteNonQuery();

                // OJO: no se usa cmdCliente.LastInsertedId porque el trigger trg_cliente_insert
                // hace su propio INSERT en auditoria justo despues, y eso pisa el ultimo id
                // autogenerado de la conexion (termina devolviendo el id_auditoria, no el id_cliente)
                string buscarIdInsertado = "SELECT id_cliente FROM cliente WHERE dpi = @dpi ORDER BY id_cliente DESC LIMIT 1;";
                MySqlCommand cmdBuscarId = new MySqlCommand(buscarIdInsertado, conexion);
                cmdBuscarId.Parameters.Add(new MySqlParameter("@dpi", cliente.Dpi));
                long idCliente = Convert.ToInt64(cmdBuscarId.ExecuteScalar());

                // 2. Crear la membresía real ligada a este cliente Andre Gonzalez 9959-23-3117
                long idTipoMembresia = ObtenerOCrearTipoMembresia(conexion);

                string insertMembresia = "INSERT INTO membresia (id_cliente, id_tipo_membresia, fecha_inicio, videos_acumulados) VALUES (@idCliente, @idTipo, CURDATE(), 0);";
                MySqlCommand cmdMembresia = new MySqlCommand(insertMembresia, conexion);
                cmdMembresia.Parameters.Add(new MySqlParameter("@idCliente", idCliente));
                cmdMembresia.Parameters.Add(new MySqlParameter("@idTipo", idTipoMembresia));
                cmdMembresia.ExecuteNonQuery();

                long idMembresia = cmdMembresia.LastInsertedId;

                // 3. Enlazar la membresía generada de vuelta al cliente Andre Gonzalez 9959-23-3117
                string updateCliente = "UPDATE cliente SET id_membresia = @idMembresia WHERE id_cliente = @idCliente;";
                MySqlCommand cmdUpdate = new MySqlCommand(updateCliente, conexion);
                cmdUpdate.Parameters.Add(new MySqlParameter("@idMembresia", idMembresia));
                cmdUpdate.Parameters.Add(new MySqlParameter("@idCliente", idCliente));
                cmdUpdate.ExecuteNonQuery();

                objetoConexion.cerrarConexion();

                return (int)idMembresia;
            }
            catch (Exception ex)
            {
                // manejo de error inserción cliente Andre Gonzalez 9959-23-3117
                MessageBox.Show("No se pudo registrar el cliente en la base de datos.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private long ObtenerOCrearTipoMembresia(MySqlConnection conexion)
        {
            string consultaTipo = "SELECT id_tipo_membresia FROM tipo_membresia LIMIT 1;";
            MySqlCommand cmdConsulta = new MySqlCommand(consultaTipo, conexion);
            object resultado = cmdConsulta.ExecuteScalar();

            if (resultado != null)
                return Convert.ToInt64(resultado);

            string insertTipo = "INSERT INTO tipo_membresia (tipo, descuento_disponible) VALUES ('Básica', 0);";
            MySqlCommand cmdInsertTipo = new MySqlCommand(insertTipo, conexion);
            cmdInsertTipo.ExecuteNonQuery();

            return cmdInsertTipo.LastInsertedId;
        }

        // localiza al cliente dueño de una membresía puntual, usado desde Buscar Cliente
        public MClienteDetalle BuscarPorMembresia(int idMembresia)
        {
            Cconexion objetoConexion = new Cconexion();
            MClienteDetalle resultado = null;

            try
            {
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = @"SELECT c.id_cliente, c.nombre, c.dpi, c.telefono, c.direccion, c.correo, c.no_rentas, c.descuento, c.id_membresia
                                  FROM cliente c
                                  INNER JOIN membresia m ON c.id_membresia = m.id_membresia
                                  WHERE m.id_membresia = @idMembresia;";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.Add(new MySqlParameter("@idMembresia", idMembresia));

                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        resultado = new MClienteDetalle
                        {
                            IdCliente = lector.GetInt32("id_cliente"),
                            Nombre = lector.GetString("nombre"),
                            Dpi = lector.GetString("dpi"),
                            Telefono = lector.GetString("telefono"),
                            Direccion = lector.GetString("direccion"),
                            Correo = lector.GetString("correo"),
                            NoRentas = lector.IsDBNull(lector.GetOrdinal("no_rentas")) ? 0 : lector.GetInt32("no_rentas"),
                            Descuento = !lector.IsDBNull(lector.GetOrdinal("descuento")) && lector.GetBoolean("descuento"),
                            IdMembresia = lector.GetInt32("id_membresia")
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // se avisa si algo truena al buscar por membresia
                MessageBox.Show("Ocurrió un problema al buscar el cliente.\nError: " + ex.Message,
                    "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }

            return resultado;
        }

        // trae la info completa de un cliente por su id, para precargar Detalle Cliente
        public MClienteDetalle ObtenerPorId(int idCliente)
        {
            Cconexion objetoConexion = new Cconexion();
            MClienteDetalle resultado = null;

            try
            {
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "SELECT id_cliente, nombre, dpi, telefono, direccion, correo, no_rentas, descuento, id_membresia FROM cliente WHERE id_cliente = @id;";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.Add(new MySqlParameter("@id", idCliente));

                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        resultado = new MClienteDetalle
                        {
                            IdCliente = lector.GetInt32("id_cliente"),
                            Nombre = lector.GetString("nombre"),
                            Dpi = lector.GetString("dpi"),
                            Telefono = lector.GetString("telefono"),
                            Direccion = lector.GetString("direccion"),
                            Correo = lector.GetString("correo"),
                            NoRentas = lector.IsDBNull(lector.GetOrdinal("no_rentas")) ? 0 : lector.GetInt32("no_rentas"),
                            Descuento = !lector.IsDBNull(lector.GetOrdinal("descuento")) && lector.GetBoolean("descuento"),
                            IdMembresia = lector.IsDBNull(lector.GetOrdinal("id_membresia")) ? 0 : lector.GetInt32("id_membresia")
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la información del cliente.\nError: " + ex.Message,
                    "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }

            return resultado;
        }

        // guarda los cambios capturados en Detalle Cliente
        public void ActualizarCliente(MClienteDetalle cliente)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlConnection conexion = objetoConexion.establecerConexion();
                Cauditoria.ConfigurarUsuarioBD(conexion);

                string query = @"UPDATE cliente SET nombre = @nombre, dpi = @dpi, telefono = @telefono,
                                  direccion = @direccion, correo = @correo, no_rentas = @noRentas, descuento = @descuento
                                  WHERE id_cliente = @id;";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.Add(new MySqlParameter("@nombre", cliente.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@dpi", cliente.Dpi));
                cmd.Parameters.Add(new MySqlParameter("@telefono", cliente.Telefono));
                cmd.Parameters.Add(new MySqlParameter("@direccion", cliente.Direccion));
                cmd.Parameters.Add(new MySqlParameter("@correo", cliente.Correo));
                cmd.Parameters.Add(new MySqlParameter("@noRentas", cliente.NoRentas));
                cmd.Parameters.Add(new MySqlParameter("@descuento", cliente.Descuento));
                cmd.Parameters.Add(new MySqlParameter("@id", cliente.IdCliente));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // si el update falla el usuario se entera del motivo aqui
                MessageBox.Show("No se pudieron guardar los cambios del cliente.\nError: " + ex.Message,
                    "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }
        }
    }
}
