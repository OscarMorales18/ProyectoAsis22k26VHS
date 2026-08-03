using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renta_de_Video_2._0.Clases
{
    internal class CusuarioCRUD
    {
        private Cconexion conexionMysql;
        private List<Cusuario> mUsuarios;

        public CusuarioCRUD()
        {
            conexionMysql = new Cconexion();
            mUsuarios = new List<Cusuario>();
        }

        public List<Cusuario> getUsuarios(string filtro)
        {
            string QUERY = "SELECT * FROM usuario ";
            mUsuarios.Clear();
            MySqlDataReader mReader = null;

            try
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    QUERY += " WHERE " +
                        "CONCAT(id_usuario) LIKE '%" + filtro + "%' OR " +
                        "usuario LIKE '%" + filtro + "%' OR " +
                        "contrasena LIKE '%" + filtro + "%' OR " +
                        "CONCAT(id_empleado) LIKE '%" + filtro + "%' OR " +
                        "rol LIKE '%" + filtro + "%' OR " +
                        "estado LIKE '%" + filtro + "%'";
                }

                System.Diagnostics.Debug.WriteLine("CusuarioCRUD.getUsuarios - QUERY: " + QUERY);

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMysql.establecerConexion();
                mReader = mComando.ExecuteReader();

                Cusuario mUsuario = null;
                while (mReader.Read())
                {
                    mUsuario = new Cusuario();

                    int idxId = mReader.GetOrdinal("id_usuario");
                    int idxUsuario = mReader.GetOrdinal("usuario");
                    int idxContrasena = mReader.GetOrdinal("contrasena");
                    int idxIdEmpleado = mReader.GetOrdinal("id_empleado");
                    int idxRol = mReader.GetOrdinal("rol");

                    mUsuario.id = mReader.GetUInt64(idxId);
                    mUsuario.usuario = mReader.IsDBNull(idxUsuario) ? string.Empty : mReader.GetString(idxUsuario);
                    mUsuario.contrasena = mReader.IsDBNull(idxContrasena) ? string.Empty : mReader.GetString(idxContrasena);
                    mUsuario.id_empleado = mReader.GetUInt64(idxIdEmpleado);
                    mUsuario.rol = mReader.IsDBNull(idxRol) ? string.Empty : mReader.GetString(idxRol);

                    object estadoVal = mReader.GetValue(mReader.GetOrdinal("estado"));
                    string estadoStr = estadoVal != null ? estadoVal.ToString() : string.Empty;
                    mUsuario.estado = !string.IsNullOrEmpty(estadoStr) ? estadoStr[0] : '\0';

                    mUsuarios.Add(mUsuario);
                }

                mReader.Close();
                conexionMysql.cerrarConexion();
            }
            catch (Exception)
            {
                conexionMysql.cerrarConexion();
                throw;
            }

            return mUsuarios;
        }

        internal bool agregarUsuario(Cusuario mUsuario)
        {
            try
            {
                string INSERT = "INSERT INTO usuario (usuario, contrasena, id_empleado, rol, estado) VALUES (@usuario, @contrasena, @id_empleado, @rol, @estado)";

                MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.establecerConexion());
                mCommand.Parameters.AddWithValue("@usuario", mUsuario.usuario);
                mCommand.Parameters.AddWithValue("@contrasena", mUsuario.contrasena);
                mCommand.Parameters.AddWithValue("@id_empleado", mUsuario.id_empleado);
                mCommand.Parameters.AddWithValue("@rol", mUsuario.rol);

                var pEstado = mCommand.CreateParameter();
                pEstado.ParameterName = "@estado";
                pEstado.DbType = System.Data.DbType.Byte;
                pEstado.Value = (mUsuario.estado == '1') ? (byte)1 : (byte)0;
                mCommand.Parameters.Add(pEstado);

                bool resultado = mCommand.ExecuteNonQuery() > 0;
                conexionMysql.cerrarConexion();

                return resultado;
            }
            catch (Exception)
            {
                conexionMysql.cerrarConexion();
                throw;
            }
        }

        public bool validarLogin(string usuarioIngresado, string contrasenaIngresada)
        {
            string QUERY = "SELECT * FROM usuario WHERE usuario = @usuario AND contrasena = @contrasena AND (estado = 1 OR estado = '1') LIMIT 1";

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY, conexionMysql.establecerConexion());
                mComando.Parameters.AddWithValue("@usuario", usuarioIngresado);
                mComando.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                MySqlDataReader mReader = mComando.ExecuteReader();

                if (mReader.Read())
                {
                    // Llenar las propiedades de la clase estática SesionUsuario
                    SesionUsuario.IdUsuario = mReader.GetUInt64(mReader.GetOrdinal("id_usuario"));
                    SesionUsuario.Usuario = mReader.IsDBNull(mReader.GetOrdinal("usuario")) ? string.Empty : mReader.GetString(mReader.GetOrdinal("usuario"));
                    SesionUsuario.Rol = mReader.IsDBNull(mReader.GetOrdinal("rol")) ? string.Empty : mReader.GetString(mReader.GetOrdinal("rol"));
                    SesionUsuario.IdEmpleado = mReader.GetUInt64(mReader.GetOrdinal("id_empleado"));

                    mReader.Close();
                    conexionMysql.cerrarConexion();
                    return true; // Usuario autenticado
                }

                mReader.Close();
                conexionMysql.cerrarConexion();
                return false; // Credenciales incorrectas o usuario inactivo
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en validarLogin: " + ex.Message);
                conexionMysql.cerrarConexion();
                throw;
            }
        }

        public bool ValidarUsuario(string usuarioIngresado, string contrasenaIngresada)
        {
            return validarLogin(usuarioIngresado, contrasenaIngresada);
        }
    }
}