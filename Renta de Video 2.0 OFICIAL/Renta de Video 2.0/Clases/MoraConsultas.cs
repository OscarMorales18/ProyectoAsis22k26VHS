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
            List<MMoraPendiente> lst_Moras = new List<MMoraPendiente>();
            Cconexion objConexion = new Cconexion();

            try
            {
                // trae las moras sin pagar de este cliente
            MySqlCommand objCmd = new MySqlCommand(
                    @"SELECT mo.id_mora, r.id_renta, mo.dias_atraso, mo.monto
                      FROM mora mo
                      INNER JOIN devolucion d ON mo.id_devolucion = d.id_devolucion
                      INNER JOIN renta r ON d.id_renta = r.id_renta
                      WHERE r.id_cliente = @idCliente AND mo.estado_pago = 'pendiente';",
                    objConexion.establecerConexion());
                objCmd.Parameters.Add(new MySqlParameter("@idCliente", idCliente));

                MySqlDataAdapter objAdapter = new MySqlDataAdapter(objCmd);
            DataTable objDt = new DataTable();
                objAdapter.Fill(objDt);

                objConexion.cerrarConexion();

                foreach (DataRow objFila in objDt.Rows)
                {
                    lst_Moras.Add(new MMoraPendiente
                    {
                        IdMora = Convert.ToInt32(objFila["id_mora"]),
                        IdRenta = Convert.ToInt32(objFila["id_renta"]),
                    DiasAtraso = Convert.ToInt32(objFila["dias_atraso"]),
                        Monto = Convert.ToDecimal(objFila["monto"])
                    });
                }
            }
            // si truena dejamos la lista vacia
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las moras pendientes.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lst_Moras;
        }

        public bool MarcarMoraPagada(int idMora)
        {
            Cconexion objConexion = new Cconexion();

            try
            {
            // actualiza el estado de la mora a pagado
                MySqlCommand objCmd = new MySqlCommand(
                    "UPDATE mora SET estado_pago = 'pagado' WHERE id_mora = @idMora;",
                    objConexion.establecerConexion());
                objCmd.Parameters.Add(new MySqlParameter("@idMora", idMora));
                objCmd.ExecuteNonQuery();

                objConexion.cerrarConexion();
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
