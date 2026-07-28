using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Renta_de_Video_2._0.Clases
{
    internal class Cconexion
    {

        SqlConnection conex = new SqlConnection ();

       static String servidor = @"LAPTOP-OG2AN672\SQLEXPRESS01";
       static String bd = "RentaVideoVHS";
       static String usuario = "root3";
       static String contrasenia = "12345";
       static String puerto = "1433";

        String cadenaConexion =
     "Data Source=" + servidor + ";" +
     "Initial Catalog=" + bd + ";" +
     "User ID=" + usuario + ";" +
    "Password=" + contrasenia + ";" +
    "TrustServerCertificate=True;";

        public SqlConnection establecerConexion()
        {
            try {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente la Base de Datos");

            }
            catch(Exception ex) {

                MessageBox.Show("NO se conecto correctamente la Base de Datos, error:"+ ex.ToString());
            }

            return conex;
        }

        public void cerrarConexion() {
            conex.Close();
        }
    }
}
