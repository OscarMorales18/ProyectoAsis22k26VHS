using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cconexion
    {
        MySqlConnection conex = new MySqlConnection();

        static String servidor = "localhost";
        static String bd = "RentaVideoVHS";
        static String usuario = "root";             
        static String contrasenia = "Josue2608"; 

        String cadenaConexion =
        "Server=" + servidor + ";" +
        "Database=" + bd + ";" +
        "User ID=" + usuario + ";" +
        "Password=" + contrasenia + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó correctamente a la Base de Datos.\nError: " + ex.Message);
            }

            return conex;
        }

        public void cerrarConexion()
        {
            if (conex.State == System.Data.ConnectionState.Open)
            {
                conex.Close();
            }
        }
    }
}