using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cdevolucion
    {
        Cconexion conexion = new Cconexion();

        public void registrarDevolucion(int idRenta, int idEmpleado, DateTime fechaDevolucion, int diasAtraso, decimal montoMora)
        {
            try
            {
                // insertar devolucion sin mora
                MySqlCommand cmdDev = new MySqlCommand(
                    "INSERT INTO devolucion (id_renta, id_empleado, id_mora, fecha_devolucion, estado) " +
                    "VALUES (@idRenta, @idEmpleado, NULL, @fechaDev, 'completada');",
                    conexion.establecerConexion());

                cmdDev.Parameters.AddWithValue("@idRenta", idRenta);
                cmdDev.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cmdDev.Parameters.AddWithValue("@fechaDev", fechaDevolucion);
                cmdDev.ExecuteNonQuery();

                // obtener id de la devolucion recien insertada
                int idDevolucion = (int)cmdDev.LastInsertedId;

                // 2 - si hay mora insertarla
                if (diasAtraso > 0)
                {
                    MySqlCommand cmdMora = new MySqlCommand(
                        "INSERT INTO mora (id_devolucion, dias_atraso, monto, estado_pago) " +
                        "VALUES (@idDev, @dias, @monto, 'pendiente');",
                        conexion.establecerConexion());

                    cmdMora.Parameters.AddWithValue("@idDev", idDevolucion);
                    cmdMora.Parameters.AddWithValue("@dias", diasAtraso);
                    cmdMora.Parameters.AddWithValue("@monto", montoMora);
                    cmdMora.ExecuteNonQuery();

                    int idMora = (int)cmdMora.LastInsertedId;

                    // 3 - actualizar devolucion con id_mora
                    MySqlCommand cmdActDev = new MySqlCommand(
                        "UPDATE devolucion SET id_mora = @idMora WHERE id_devolucion = @idDev;",
                        conexion.establecerConexion());

                    cmdActDev.Parameters.AddWithValue("@idMora", idMora);
                    cmdActDev.Parameters.AddWithValue("@idDev", idDevolucion);
                    cmdActDev.ExecuteNonQuery();
                }

                // 4 - actualizar renta a completada
                MySqlCommand cmdRenta = new MySqlCommand(
                    "UPDATE renta SET estado = 'completada' WHERE id_renta = @idRenta;",
                    conexion.establecerConexion());

                cmdRenta.Parameters.AddWithValue("@idRenta", idRenta);
                cmdRenta.ExecuteNonQuery();

                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar devolución.\nError: " + ex.Message);
            }
        }
    }
}