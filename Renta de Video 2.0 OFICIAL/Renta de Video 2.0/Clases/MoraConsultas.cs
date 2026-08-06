using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class MoraConsultas
    {
        public List<MMoraPendiente> CargarMorasPendientes(int idCliente)
        {
            List<MMoraPendiente> moras = new List<MMoraPendiente>();
            Cconexion objetoConexion = new Cconexion();

            try
            {
                // trae las moras sin pagar de este cliente
            MySqlCommand cmd = new MySqlCommand(
                    @"SELECT mo.id_mora, r.id_renta, mo.dias_atraso, mo.monto
                      FROM mora mo
                      INNER JOIN devolucion d ON mo.id_devolucion = d.id_devolucion
                      INNER JOIN renta r ON d.id_renta = r.id_renta
                      WHERE r.id_cliente = @idCliente AND mo.estado_pago = 'pendiente';",
                    objetoConexion.establecerConexion());
                cmd.Parameters.Add(new MySqlParameter("@idCliente", idCliente));

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
                adapter.Fill(dt);

                objetoConexion.cerrarConexion();

                foreach (DataRow fila in dt.Rows)
                {
                    moras.Add(new MMoraPendiente
                    {
                        IdMora = Convert.ToInt32(fila["id_mora"]),
                        IdRenta = Convert.ToInt32(fila["id_renta"]),
                    DiasAtraso = Convert.ToInt32(fila["dias_atraso"]),
                        Monto = Convert.ToDecimal(fila["monto"])
                    });
                }
            }
            // si truena dejamos la lista vacia
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las moras pendientes.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return moras;
        }

        public bool MarcarMoraPagada(int idMora)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
            // actualiza el estado de la mora a pagado
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE mora SET estado_pago = 'pagado' WHERE id_mora = @idMora;",
                    objetoConexion.establecerConexion());
                cmd.Parameters.Add(new MySqlParameter("@idMora", idMora));
                cmd.ExecuteNonQuery();

                objetoConexion.cerrarConexion();
                return true;
            }
            // no se pudo actualizar el pago
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo marcar la mora como pagada.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
