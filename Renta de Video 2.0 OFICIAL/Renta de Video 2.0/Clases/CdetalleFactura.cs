using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    // Inicio de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "04/08/2026"
  internal class CdetalleFactura{
   
    public void mostrarDetalleFactura(DataGridView dgv_detalleFactura, int iIdFactura) {
        
      Cconexion objetoConexion = new Cconexion();
      try {
           
             dgv_detalleFactura.DataSource = null;
             MySqlDataAdapter adapter = new MySqlDataAdapter(
             "SELECT v.titulo AS Video, dr.precio_unitario AS Precio_Renta, mo.monto AS Mora, dr.subtotal AS Subtotal " +
             "FROM detalle_renta dr " +
             "INNER JOIN video v ON dr.id_video = v.id_video " +
             "INNER JOIN renta r ON dr.id_renta = r.id_renta " +
             "INNER JOIN factura f ON f.id_renta = r.id_renta " +
             "LEFT JOIN devolucion dv ON dv.id_renta = r.id_renta " +
             "LEFT JOIN mora mo ON mo.id_devolucion = dv.id_devolucion " +
             "WHERE f.id_factura = " + iIdFactura + ";",
             objetoConexion.establecerConexion());

             DataTable dt = new DataTable();
             adapter.Fill(dt);

             dgv_detalleFactura.DataSource = dt;
             objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lograron mostrar los registros.\nError: " + ex.Message);
            }
    }
    public void mostrarInfoFactura(TextBox txt_cliente, TextBox txt_fecha, TextBox txt_totalPagar, int iIdFactura) {
        
       Cconexion objetoConexion = new Cconexion();
       try {
      
         MySqlCommand comando = new MySqlCommand(
            "SELECT c.nombre, f.fecha, f.total " +
            "FROM factura f " +
            "INNER JOIN renta r ON f.id_renta = r.id_renta " +
            "INNER JOIN cliente c ON r.id_cliente = c.id_cliente " +
            "WHERE f.id_factura = " + iIdFactura + ";",
            objetoConexion.establecerConexion());

          MySqlDataReader lector = comando.ExecuteReader();

          if (lector.Read()) {
              txt_cliente.Text = lector["nombre"].ToString();
              txt_fecha.Text = Convert.ToDateTime(lector["fecha"]).ToString("dd/MM/yyyy");
              txt_totalPagar.Text = lector["total"].ToString();
          }

          objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la información.\nError: " + ex.Message);
            }
        }
    }
    // Fin de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "04/08/2026"
}

