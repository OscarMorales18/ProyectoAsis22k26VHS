using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cconexion
    {
        private MySqlConnection conex = new MySqlConnection();

        static String sServidor= "localhost";
        static String sBd= "RentaVideoVHS";
        static String sUsuario = "video";
        static String sContrasenia= "12345";

     
        private String sCadenaConexion=
            "Server=" + sServidor+ ";" +
            "Database=" + sBd+ ";" +
            "User ID=" + sUsuario + ";" +
            "Password=" + sContrasenia+ ";" +
            "Allow User Variables=True;";

        public MySqlConnection establecerConexion()
        {
            try
            {
                if (conex.State != ConnectionState.Open)
                {
                    conex.ConnectionString = sCadenaConexion;
                    conex.Open();
                }

                string sUsuarioActual= string.IsNullOrWhiteSpace(SesionUsuario.Usuario) ? "Sistema" : SesionUsuario.Usuario;

                using (MySqlCommand objCmdUser = new MySqlCommand("SET @app_usuario = @usr;", conex))
                {
                    objCmdUser.Parameters.AddWithValue("@usr", sUsuarioActual);
                    objCmdUser.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó correctamente a la Base de Datos.\nError: " + ex.Message);
            }

            return conex;
        }

        public void cerrarConexion()
        {
            if (conex.State == ConnectionState.Open)
            {
                conex.Close();
            }
        }
    }
}