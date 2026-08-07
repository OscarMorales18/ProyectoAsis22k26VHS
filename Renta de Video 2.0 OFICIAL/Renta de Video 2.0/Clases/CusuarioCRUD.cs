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
            string sQuery = "SELECT * FROM usuario ";
            mUsuarios.Clear();
            MySqlDataReader objReader= null;

            try
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    sQuery += " WHERE " +
                        "CONCAT(id_usuario) LIKE '%" + filtro + "%' OR " +
                        "usuario LIKE '%" + filtro + "%' OR " +
                        "contrasena LIKE '%" + filtro + "%' OR " +
                        "CONCAT(id_empleado) LIKE '%" + filtro + "%' OR " +
                        "rol LIKE '%" + filtro + "%' OR " +
                        "estado LIKE '%" + filtro + "%'";
                }

                System.Diagnostics.Debug.WriteLine("CusuarioCRUD.getUsuarios - QUERY: " + sQuery);

                MySqlCommand mComando = new MySqlCommand(sQuery);
                mComando.Connection = conexionMysql.establecerConexion();
                objReader= mComando.ExecuteReader();

                Cusuario mUsuario = null;
                while (objReader.Read())
                {
                    mUsuario = new Cusuario();

                    int idxId = objReader.GetOrdinal("id_usuario");
                    int idxUsuario = objReader.GetOrdinal("usuario");
                    int idxContrasena = objReader.GetOrdinal("contrasena");
                    int idxIdEmpleado = objReader.GetOrdinal("id_empleado");
                    int idxRol = objReader.GetOrdinal("rol");

                    mUsuario.Id = objReader.GetUInt64(idxId);
                    mUsuario.Usuario = objReader.IsDBNull(idxUsuario) ? string.Empty : objReader.GetString(idxUsuario);
                    mUsuario.Contrasena = objReader.IsDBNull(idxContrasena) ? string.Empty : objReader.GetString(idxContrasena);
                    mUsuario.IdEmpleado = objReader.GetUInt64(idxIdEmpleado);
                    mUsuario.Rol = objReader.IsDBNull(idxRol) ? string.Empty : objReader.GetString(idxRol);

                    object estadoVal = objReader.GetValue(objReader.GetOrdinal("estado"));
                    string estadoStr = estadoVal != null ? estadoVal.ToString() : string.Empty;
                    mUsuario.Estado = !string.IsNullOrEmpty(estadoStr) ? estadoStr[0] : '\0';

                    mUsuarios.Add(mUsuario);
                }

                objReader.Close();
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
                string sInsert = "INSERT INTO usuario (usuario, contrasena, id_empleado, rol, estado) VALUES (@usuario, @contrasena, @id_empleado, @rol, @estado)";

                MySqlCommand objCommand = new MySqlCommand(sInsert, conexionMysql.establecerConexion());
                objCommand.Parameters.AddWithValue("@usuario", mUsuario.Usuario);
                objCommand.Parameters.AddWithValue("@contrasena", mUsuario.Contrasena);
                objCommand.Parameters.AddWithValue("@id_empleado", mUsuario.IdEmpleado);
                objCommand.Parameters.AddWithValue("@rol", mUsuario.Rol);

                var pEstado = objCommand.CreateParameter();
                pEstado.ParameterName = "@estado";
                pEstado.DbType = System.Data.DbType.Byte;
                pEstado.Value = (mUsuario.Estado == '1') ? (byte)1 : (byte)0;
                objCommand.Parameters.Add(pEstado);

                bool bResultado= objCommand.ExecuteNonQuery() > 0;
                conexionMysql.cerrarConexion();

                return bResultado;
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
                MySqlCommand objComando = new MySqlCommand(QUERY, conexionMysql.establecerConexion());
                objComando.Parameters.AddWithValue("@usuario", usuarioIngresado);
                objComando.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                MySqlDataReader objReader= objComando.ExecuteReader();

                if (objReader.Read())
                {
                    SesionUsuario.IdUsuario = objReader.GetUInt64(objReader.GetOrdinal("id_usuario"));
                    SesionUsuario.Usuario = objReader.IsDBNull(objReader.GetOrdinal("usuario")) ? string.Empty : objReader.GetString(objReader.GetOrdinal("usuario"));
                    SesionUsuario.Rol = objReader.IsDBNull(objReader.GetOrdinal("rol")) ? string.Empty : objReader.GetString(objReader.GetOrdinal("rol"));
                    SesionUsuario.IdEmpleado = objReader.GetUInt64(objReader.GetOrdinal("id_empleado"));

                    objReader.Close();
                    conexionMysql.cerrarConexion();
                    return true; 
                }

                objReader.Close();
                conexionMysql.cerrarConexion();
                return false; 
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