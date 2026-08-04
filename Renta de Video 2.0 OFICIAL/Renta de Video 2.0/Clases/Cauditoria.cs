using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace Renta_de_Video_2._0.Clases
{
    public class Cauditoria
    {
        public static void ConfigurarUsuarioBD(MySqlConnection conexion)
        {
            try
            {
                // Validar que no envíe una cadena vacía
                string usuario = string.IsNullOrWhiteSpace(SesionUsuario.Usuario) ? "Sistema" : SesionUsuario.Usuario;

                string query = "SET @app_usuario = @usuario;";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al establecer @app_usuario: " + ex.Message);
            }
        }
        public void MostrarAuditoria(DataGridView tabla)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();
                string query = @"SELECT 
                    id_auditoria AS 'ID',
                    tabla_afectada AS 'Tabla',
                    operacion AS 'Operación',
                    id_registro_afectado AS 'ID Reg.',
                    datos_anteriores AS 'Datos Anteriores',
                    datos_nuevos AS 'Datos Nuevos',
                    usuario_app AS 'Usuario App',
                    usuario_db AS 'Usuario BD',
                    fecha_hora AS 'Fecha y Hora'
                    FROM auditoria 
                    ORDER BY fecha_hora DESC;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                da.Fill(dt);

                tabla.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarAuditoria(DataGridView tabla, string busqueda)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();
                string query = @"SELECT 
                    id_auditoria AS 'ID',
                    tabla_afectada AS 'Tabla',
                    operacion AS 'Operación',
                    id_registro_afectado AS 'ID Reg.',
                    datos_anteriores AS 'Datos Anteriores',
                    datos_nuevos AS 'Datos Nuevos',
                    usuario_app AS 'Usuario App',
                    usuario_db AS 'Usuario BD',
                    fecha_hora AS 'Fecha y Hora'
                    FROM auditoria 
                    WHERE tabla_afectada LIKE @busqueda 
                       OR operacion LIKE @busqueda 
                       OR usuario_app LIKE @busqueda 
                    ORDER BY fecha_hora DESC;";

                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tabla.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en auditoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}