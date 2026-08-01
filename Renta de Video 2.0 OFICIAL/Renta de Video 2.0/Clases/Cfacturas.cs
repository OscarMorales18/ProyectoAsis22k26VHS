using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    // Inicio de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "31/07/2026"
  internal class Cfacturas {
    public void mostrarFacturas(DataGridView dgv_facturas, int iIdCliente) {
      Cconexion objetoConexion = new Cconexion();

      try {
           dgv_facturas.DataSource = null;
           MySqlDataAdapter adapter = new MySqlDataAdapter(
           "SELECT * FROM factura f " +
           "INNER JOIN renta r ON f.id_renta = r.id_renta " +
           "INNER JOIN cliente c ON r.id_cliente = c.id_cliente " +
           "WHERE r.id_cliente = " + iIdCliente + ";",
           objetoConexion.establecerConexion());

           DataTable dt = new DataTable();
           adapter.Fill(dt);

           dgv_facturas.DataSource = dt;
           objetoConexion.cerrarConexion();
      }
      catch (Exception ex) {
      MessageBox.Show("No se lograron mostrar los registros.\nError: " + ex.Message);
      }
    }
  }
    // Fin de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "31/07/2026"
}
