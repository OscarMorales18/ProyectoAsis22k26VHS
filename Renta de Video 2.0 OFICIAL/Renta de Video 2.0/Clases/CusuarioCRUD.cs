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
            // Asegurarse de no acumular resultados de llamadas previas
            mUsuarios.Clear();
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    // Usar CONCAT para convertir columnas numéricas a texto y permitir LIKE
                    QUERY += " WHERE " +
                        "CONCAT(id_usuario) LIKE '%" + filtro + "%' OR " +
                        "usuario LIKE '%" + filtro + "%' OR " +
                        "contrasena LIKE '%" + filtro + "%' OR " +
                        "CONCAT(id_empleado) LIKE '%" + filtro + "%' OR " +
                        "rol LIKE '%" + filtro + "%' OR " +
                        "estado LIKE '%" + filtro + "%'";
                }

                // Registro para depuración: mostrar la consulta que se ejecuta
                System.Diagnostics.Debug.WriteLine("CusuarioCRUD.getUsuarios - QUERY: " + QUERY);

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMysql.establecerConexion();
                mReader = mComando.ExecuteReader();

                Cusuario mUsuario = null;
                while (mReader.Read())
                {
                    mUsuario = new Cusuario();
                    // Usar los nombres reales de columna devueltos por la consulta
                    // Obtener índices de columnas y leer usando ordinales (más seguro)
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
                    // Leer estado de forma robusta: obtener el valor y convertir a string luego tomar primer carácter
                    object estadoVal = mReader.GetValue(mReader.GetOrdinal("estado"));
                    string estadoStr = estadoVal != null ? estadoVal.ToString() : string.Empty;
                    mUsuario.estado = !string.IsNullOrEmpty(estadoStr) ? estadoStr[0] : '\0';
                    mUsuarios.Add(mUsuario);
                }

                mReader.Close();
                // Asegurarse de cerrar la conexión después de usar el reader
                conexionMysql.cerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }


            return mUsuarios;
        }

        internal bool agregarUsuario(Cusuario mUsuario)
        {
            string INSERT = "INSERT INTO usuario (usuario, contrasena, id_empleado, rol, estado) VALUES (@usuario, @contrasena, @id_empleado, @rol, @estado)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.establecerConexion());
            mCommand.Parameters.AddWithValue("@usuario", mUsuario.usuario);
            mCommand.Parameters.AddWithValue("@contrasena", mUsuario.contrasena);
            mCommand.Parameters.AddWithValue("@id_empleado", mUsuario.id_empleado);
            mCommand.Parameters.AddWithValue("@rol", mUsuario.rol);

            // Enviar 'estado' como valor numérico (TINYINT) en lugar de char para evitar errores de longitud
            var pEstado = mCommand.CreateParameter();
            pEstado.ParameterName = "@estado";
            // Usar DbType.Byte para mapear a TINYINT en la base de datos de forma segura
            pEstado.DbType = System.Data.DbType.Byte;
            pEstado.Value = (mUsuario.estado == '1') ? (byte)1 : (byte)0;
            mCommand.Parameters.Add(pEstado);

            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}
