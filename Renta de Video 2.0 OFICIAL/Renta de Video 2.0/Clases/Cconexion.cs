using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cconexion
    {
        private MySqlConnection conex = new MySqlConnection();

        static String servidor = "10.122.252.171";
        static String bd = "RentaVideoVHS";
        static String usuario = "root";
        static String contrasenia = "12345";

     
        private String cadenaConexion =
            "Server=" + servidor + ";" +
            "Database=" + bd + ";" +
            "User ID=" + usuario + ";" +
            "Password=" + contrasenia + ";" +
            "Allow User Variables=True;";

        public MySqlConnection establecerConexion()
        {
            try
            {
                // Se abre la conexión si no está abierta
                if (conex.State != ConnectionState.Open)
                {
                    conex.ConnectionString = cadenaConexion;
                    conex.Open();
                }

                // se asigna el usuario actual en la sesión a la variable de MySQL
                string usuarioActual = string.IsNullOrWhiteSpace(SesionUsuario.Usuario) ? "Sistema" : SesionUsuario.Usuario;

                using (MySqlCommand cmdUser = new MySqlCommand("SET @app_usuario = @usr;", conex))
                {
                    cmdUser.Parameters.AddWithValue("@usr", usuarioActual);
                    cmdUser.ExecuteNonQuery();
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