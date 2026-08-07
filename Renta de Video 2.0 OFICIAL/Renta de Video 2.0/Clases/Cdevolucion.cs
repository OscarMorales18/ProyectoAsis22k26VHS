using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cdevolucion
    {
        Cconexion objConexion = new Cconexion();

        public void registrarDevolucion(int idRenta, int idEmpleado, DateTime fechaDevolucion, int diasAtraso, decimal montoMora)
        {
            try
            {
                // insertar devolucion sin mora
                MySqlCommand objCmdDev = new MySqlCommand(
                    "INSERT INTO devolucion (id_renta, id_empleado, id_mora, fecha_devolucion, estado) " +
                    "VALUES (@idRenta, @idEmpleado, NULL, @fechaDev, 'completada');",
                    objConexion.establecerConexion());

                objCmdDev.Parameters.AddWithValue("@idRenta", idRenta);
                objCmdDev.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                objCmdDev.Parameters.AddWithValue("@fechaDev", fechaDevolucion);
                objCmdDev.ExecuteNonQuery();

                // obtener id de la devolucion recien insertada
                int idDevolucion = (int)objCmdDev.LastInsertedId;

                // 2 - si hay mora insertarla
                if (diasAtraso > 0)
                {
                    MySqlCommand objCmdMora = new MySqlCommand(
                        "INSERT INTO mora (id_devolucion, dias_atraso, monto, estado_pago) " +
                        "VALUES (@idDev, @dias, @monto, 'pendiente');",
                        objConexion.establecerConexion());

                    objCmdMora.Parameters.AddWithValue("@idDev", idDevolucion);
                    objCmdMora.Parameters.AddWithValue("@dias", diasAtraso);
                    objCmdMora.Parameters.AddWithValue("@monto", montoMora);
                    objCmdMora.ExecuteNonQuery();

                    int idMora = (int)objCmdMora.LastInsertedId;

                    // 3 - actualizar devolucion con id_mora
                    MySqlCommand objCmdActDev= new MySqlCommand(
                        "UPDATE devolucion SET id_mora = @idMora WHERE id_devolucion = @idDev;",
                        objConexion.establecerConexion());

                    objCmdActDev.Parameters.AddWithValue("@idMora", idMora);
                    objCmdActDev.Parameters.AddWithValue("@idDev", idDevolucion);
                    objCmdActDev.ExecuteNonQuery();
                }

                // 4 - actualizar renta a completada
                MySqlCommand objCmdRenta= new MySqlCommand(
                    "UPDATE renta SET estado = 'completada' WHERE id_renta = @idRenta;",
                    objConexion.establecerConexion());

                objCmdRenta.Parameters.AddWithValue("@idRenta", idRenta);
                objCmdRenta.ExecuteNonQuery();

                objConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar devolución.\nError: " + ex.Message);
            }
        }
    }
}