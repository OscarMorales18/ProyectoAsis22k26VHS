using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class RentaConsultas
    {
        public MClienteRenta BuscarClientePorMembresia(int idMembresia)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
            // trae el cliente ligado a esa membresia
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT c.id_cliente, c.nombre FROM cliente c INNER JOIN membresia m ON c.id_membresia = m.id_membresia WHERE m.id_membresia = @idMembresia;",
                    objetoConexion.establecerConexion());
                cmd.Parameters.Add(new MySqlParameter("@idMembresia", idMembresia));

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                objetoConexion.cerrarConexion();

                if (dt.Rows.Count == 0)
                return null;

                DataRow fila = dt.Rows[0];

                return new MClienteRenta
                {
                    IdCliente = Convert.ToInt32(fila["id_cliente"]),
                    Nombre = fila["nombre"].ToString()
                };
            }
            // no hubo match o fallo la conexion
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar el cliente.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<MVideoCatalogo> CargarCatalogo(int cantidad)
        {
            List<MVideoCatalogo> videos = new List<MVideoCatalogo>();
            Cconexion objetoConexion = new Cconexion();

            try
            {
                // trae los videos disponibles para los checkbox
            MySqlCommand cmd = new MySqlCommand(
                    "SELECT id_video, titulo, genero, anio, precio_renta FROM video WHERE estado = 'disponible' LIMIT @cantidad;",
                    objetoConexion.establecerConexion());
                cmd.Parameters.Add(new MySqlParameter("@cantidad", cantidad));

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
                adapter.Fill(dt);

                objetoConexion.cerrarConexion();

                foreach (DataRow fila in dt.Rows)
                {
                    videos.Add(new MVideoCatalogo
                    {
                        IdVideo = Convert.ToInt32(fila["id_video"]),
                        Titulo = fila["titulo"].ToString(),
                    Genero = fila["genero"] == DBNull.Value ? "Sin género" : fila["genero"].ToString(),
                        Anio = Convert.ToInt32(fila["anio"]),
                        PrecioRenta = Convert.ToDecimal(fila["precio_renta"])
                    });
                }
            }
            // si truena la consulta dejamos la lista vacia
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el catálogo de videos.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return videos;
        }

        public bool RegistrarRenta(int idCliente, List<MVideoCatalogo> videosSeleccionados, DateTime fechaRenta, DateTime fechaLimite, decimal subtotal, decimal total)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
            // guarda la renta, sus detalles y la factura en cadena
                MySqlConnection conexion = objetoConexion.establecerConexion();

                int idEmpleado = ObtenerOCrearEmpleadoPorDefecto(conexion);

                string insertRenta = "INSERT INTO renta (fecha_renta, fecha_limite, estado, id_cliente, id_empleado) VALUES (@fechaRenta, @fechaLimite, 'activa', @idCliente, @idEmpleado);";
                MySqlCommand cmdRenta = new MySqlCommand(insertRenta, conexion);
                cmdRenta.Parameters.Add(new MySqlParameter("@fechaRenta", fechaRenta.Date));
                cmdRenta.Parameters.Add(new MySqlParameter("@fechaLimite", fechaLimite.Date));
                cmdRenta.Parameters.Add(new MySqlParameter("@idCliente", idCliente));
                cmdRenta.Parameters.Add(new MySqlParameter("@idEmpleado", idEmpleado));
                cmdRenta.ExecuteNonQuery();

                long idRenta = cmdRenta.LastInsertedId;

                foreach (MVideoCatalogo video in videosSeleccionados)
                {
                    string insertDetalle = "INSERT INTO detalle_renta (id_renta, id_video, cantidad, precio_unitario, subtotal) VALUES (@idRenta, @idVideo, 1, @precio, @precio);";
                    MySqlCommand cmdDetalle = new MySqlCommand(insertDetalle, conexion);
                    cmdDetalle.Parameters.Add(new MySqlParameter("@idRenta", idRenta));
                    cmdDetalle.Parameters.Add(new MySqlParameter("@idVideo", video.IdVideo));
                    cmdDetalle.Parameters.Add(new MySqlParameter("@precio", video.PrecioRenta));
                    cmdDetalle.ExecuteNonQuery();
                }

                string insertFactura = "INSERT INTO factura (id_renta, fecha, subtotal, descuento, total) VALUES (@idRenta, @fecha, @subtotal, 0, @total);";
                MySqlCommand cmdFactura = new MySqlCommand(insertFactura, conexion);
                cmdFactura.Parameters.Add(new MySqlParameter("@idRenta", idRenta));
                cmdFactura.Parameters.Add(new MySqlParameter("@fecha", fechaRenta.Date));
                cmdFactura.Parameters.Add(new MySqlParameter("@subtotal", subtotal));
                cmdFactura.Parameters.Add(new MySqlParameter("@total", total));
                cmdFactura.ExecuteNonQuery();

                objetoConexion.cerrarConexion();

                return true;
            }
            // algo fallo, avisamos y no dejamos nada a medias
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar la factura.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int ObtenerOCrearEmpleadoPorDefecto(MySqlConnection conexion)
        {
            string consulta = "SELECT id_empleado FROM empleado LIMIT 1;";
            MySqlCommand cmdConsulta = new MySqlCommand(consulta, conexion);
            object resultado = cmdConsulta.ExecuteScalar();

            if (resultado != null)
                return Convert.ToInt32(resultado);

            string insertEmpleado = "INSERT INTO empleado (nombre, puesto) VALUES ('Empleado Sistema', 'Cajero');";
            MySqlCommand cmdInsert = new MySqlCommand(insertEmpleado, conexion);
            cmdInsert.ExecuteNonQuery();

            return (int)cmdInsert.LastInsertedId;
        }
    }
}
