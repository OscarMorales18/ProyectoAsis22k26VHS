using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cvideos
    {
        // Mostrar datos de la tabla video
        public void mostrarVideos(DataGridView tablaVideos)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                tablaVideos.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT * FROM video;",
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaVideos.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lograron mostrar los registros.\nError: " + ex.Message);
            }
        }
    }
}
