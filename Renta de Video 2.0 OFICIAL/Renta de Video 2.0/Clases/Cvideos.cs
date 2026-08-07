using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cvideos
    {
        //para buscar un video por nombre del video - (Evelyn Andrade 9959-23-1224)
        public void buscarVideo(DataGridView tablaVideos, string nombre)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                tablaVideos.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT codigo, titulo, genero, director, anio, stock, estado FROM video WHERE titulo LIKE @nombre;",
                    objetoConexion.establecerConexion());

                adapter.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaVideos.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar.\nError: " + ex.Message);
            }
        }
        // para buscar un video por clasificacion(combobox) - (Evelyn Andrade 9959-23-1224)
        public void filtrarPorClasificacion(DataGridView tablaVideos, string clasificacion)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                tablaVideos.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT codigo, titulo, genero, director, anio, stock, idioma, estado FROM video WHERE clasificacion = @clasificacion;",
                    objetoConexion.establecerConexion());

                adapter.SelectCommand.Parameters.AddWithValue("@clasificacion", clasificacion);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaVideos.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar.\nError: " + ex.Message);
            }
        }

        // para filtrar un video por genero(combobox)  - (Evelyn Andrade 9959-23-1224)
        public void filtrarPorGenero(DataGridView tablaVideos, string genero)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                tablaVideos.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT codigo, titulo, genero, director, anio, stock, estado FROM video WHERE genero = @genero;",
                    objetoConexion.establecerConexion());

                adapter.SelectCommand.Parameters.AddWithValue("@genero", genero);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaVideos.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar.\nError: " + ex.Message);
            }
        }



        // Mostrar datos de la tabla video  (Evelyn Andrade 9959-23-1224)
        public void mostrarVideos(DataGridView tablaVideos)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                tablaVideos.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT codigo, titulo, genero, director, anio, stock, estado, idioma FROM video;",
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaVideos.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lograron mostrar los registros.\nError: " + ex.Message);
            }
        }

        // metodo editar video (Evelyn Andrade 9959-23-1224)

        public void editarVideo(string codigo, string titulo, string genero, string director, int anio, int stock, string estado)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE video SET titulo = @titulo, genero = @genero, director = @director, anio = @anio, stock = @stock, estado = @estado WHERE codigo = @codigo;",
                    objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@director", director);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar.\nError: " + ex.Message);
            }
        }

        // metodo para eliminar video  (Evelyn Andrade 9959-23-1224)
        // devuelve true si se borro de verdad, false si se dio de baja o si fallo
        public bool eliminarVideo(string codigo)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM video WHERE codigo = @codigo;",
                    objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                objetoConexion.cerrarConexion();
                return true;
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                // esta pelicula ya tiene compras o rentas asociadas, no se puede borrar de verdad
                objetoConexion.cerrarConexion();
                darDeBajaVideo(codigo);
                return false;
            }
            catch (Exception ex)
            {
                objetoConexion.cerrarConexion();
                MessageBox.Show("Error al eliminar.\nError: " + ex.Message);
                return false;
            }
        }

        // baja logica cuando el video ya tiene historial y no se puede borrar fisicamente
        private void darDeBajaVideo(string codigo)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE video SET estado = 'dado_de_baja' WHERE codigo = @codigo;",
                    objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                objetoConexion.cerrarConexion();

                MessageBox.Show("Esta película ya tiene compras o rentas registradas, así que no se puede eliminar por completo. Se marcó como 'dado de baja' en su lugar.",
                    "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja el video.\nError: " + ex.Message);
            }
        }


        //generar codigo de video (Evelyn Andrade 9959-23-1224)
        public string generarCodigo()
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                // el catalogo real usa el prefijo VHS- con 4 digitos, no VID
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT MAX(CAST(SUBSTRING(codigo, 5) AS UNSIGNED)) FROM video WHERE codigo LIKE 'VHS-%';",
                    objetoConexion.establecerConexion());

                object resultado = cmd.ExecuteScalar();
                int ultimo = resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
                int siguiente = ultimo + 1;

                objetoConexion.cerrarConexion();

                return "VHS-" + siguiente.ToString("D4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar código.\nError: " + ex.Message);
                return "";
            }
        }

        //verifica si el video ya existe (Evelyn Andrade 9959-23-1224)

        public bool tituloExiste(string titulo)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM video WHERE titulo = @titulo;",
                    objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@titulo", titulo);
                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                objetoConexion.cerrarConexion();

                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar título.\nError: " + ex.Message);
                return false;
            }
        }

        //insertar datos de video (Evelyn Andrade 9959-23-1224)
        public void insertarVideo(string codigo, string titulo, string genero, string director, int anio, decimal precio, int stock, string clasificacion, int duracion)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO video (codigo, titulo, genero, director, anio, precio_renta, stock, estado, clasificacion, duracion, idioma) " +
                    "VALUES (@codigo, @titulo, @genero, @director, @anio, @precio, @stock, 'disponible', @clasificacion, @duracion, 'Español');",
                    objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@director", director);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                cmd.Parameters.AddWithValue("@duracion", duracion);

                cmd.ExecuteNonQuery();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el video.\nError: " + ex.Message);
            }
        }

        public void actualizarStock(int idVideo)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE video SET stock = stock + 1 WHERE id_video = @idVideo;",
                    objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@idVideo", idVideo);
                cmd.ExecuteNonQuery();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar stock.\nError: " + ex.Message);
            }
        }
    }
}
