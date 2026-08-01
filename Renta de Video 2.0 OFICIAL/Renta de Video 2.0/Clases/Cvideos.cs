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

        public void eliminarVideo(string codigo)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar.\nError: " + ex.Message);
            }
        }
    }
}
