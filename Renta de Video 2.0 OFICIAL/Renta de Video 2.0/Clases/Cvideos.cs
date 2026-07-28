using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cvideos
    {
//mostrar datos de la tabla video 
        public void mostrarVideos(DataGridView tablaVideos) {

            Cconexion objetoConexion = new Cconexion();

            try
            {
                tablaVideos.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter("select * from video;", objetoConexion.establecerConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaVideos.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex){

                MessageBox.Show("NO SE LOGRO MOSTRAR LOS REGISTROS, error: "+ ex.ToString());

            }
        }

       
    }
}
