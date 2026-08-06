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

                // Obtener el ID autogenerado del cliente Andre Gonzalez 9959-23-3117
                long idCliente = cmdCliente.LastInsertedId;

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
    }
}
