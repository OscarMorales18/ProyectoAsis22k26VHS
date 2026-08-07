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
                string sUsuario= string.IsNullOrWhiteSpace(SesionUsuario.Usuario) ? "Sistema" : SesionUsuario.Usuario;

                string sQuery = "SET @app_usuario = @usuario;";
                using (MySqlCommand objCmd = new MySqlCommand(sQuery, conexion))
                {
                    objCmd.Parameters.AddWithValue("@usuario", sUsuario);
                    objCmd.ExecuteNonQuery();
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
                Cconexion objConexion = new Cconexion();
                string sQuery = @"SELECT 
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

                MySqlDataAdapter objDa = new MySqlDataAdapter(sQuery, objConexion.establecerConexion());
                DataTable objDt = new DataTable();
                objDa.Fill(objDt);

                tabla.DataSource = objDt;
                objConexion.cerrarConexion();
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
                Cconexion objConexion = new Cconexion();
                string sQuery = @"SELECT 
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

                MySqlCommand objCmd = new MySqlCommand(sQuery, objConexion.establecerConexion());
                objCmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                MySqlDataAdapter objDa = new MySqlDataAdapter(objCmd);
                DataTable objDt = new DataTable();
                objDa.Fill(objDt);

                tabla.DataSource = objDt;
                objConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en auditoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}