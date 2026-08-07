using MySqlConnector;
using Renta_de_Video_2._0.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Renta_de_Video_2._0.Clases;

namespace Renta_de_Video_2._0
{
    public partial class Reportes_Generales : Form
    {
        public Reportes_Generales()
        {
            InitializeComponent();
            CargarTablaUsuarios();
            CargarTablaEmpleados();
            CargarTablaVideos();
            CargarTablaRentas(); 
            CargarTablaMora();
        }

        //Proceso para cargar la tabla de usuarios desde la base de datos - Oscar Morales 9959-23-3070
        private void CargarTablaUsuarios()
        {
            dvg_Usuarios.Rows.Clear();

            Cconexion c = new Cconexion();
            MySqlConnection conn = c.establecerConexion();

            try
            {
                string query = "SELECT id_usuario, usuario, contrasena, id_empleado, rol, estado FROM usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dvg_Usuarios.Rows.Add(
                            reader.GetInt32("id_usuario"),
                            reader.GetString("usuario"),
                            reader.GetString("contrasena"),
                            reader.GetInt32("id_empleado"),
                            reader.GetString("rol"),
                            reader.GetBoolean("estado") ? "1" : "0"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.cerrarConexion();
            }
        }

        //Proceso para cargar la tabla de empleados desde la base de datos - Oscar Morales 9959-23-3070
        private void CargarTablaEmpleados()
        {
            dvg_Empleados.Rows.Clear();

            Cconexion c = new Cconexion();
            MySqlConnection conn = c.establecerConexion();

            try
            {
                string query = "SELECT id_empleado, nombre, puesto, telefono FROM empleado";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dvg_Empleados.Rows.Add(
                            reader.GetInt32("id_empleado"),
                            reader.GetString("nombre"),
                            reader.GetString("puesto"),
                            reader.GetString("telefono")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.cerrarConexion();
            }
        }

        //Proceso para cargar la tabla de videos desde la base de datos - Oscar Morales 9959-23-3070
        private void CargarTablaVideos()
        {
            dvg_Videos.Rows.Clear();

            Cconexion c = new Cconexion();
            MySqlConnection conn = c.establecerConexion();

            try
            {
                string query = "SELECT id_video, titulo, genero, precio_renta, stock, estado, anio, clasificacion, duracion, idioma FROM video";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dvg_Videos.Rows.Add(
                            reader.GetInt32("id_video"),
                            reader.GetString("titulo"),
                            reader.GetString("genero"),
                            reader.GetDecimal("precio_renta"),
                            reader.GetInt32("stock"),
                            reader.GetString("estado"),
                            reader.GetInt16("anio"),
                            reader.GetString("clasificacion"),
                            reader.GetInt32("duracion"),
                            reader.GetString("idioma")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.cerrarConexion();
            }
        }

        //Proceso para cargar la tabla de rentas desde la base de datos - Oscar Morales 9959-23-3070
        private void CargarTablaRentas()
        {
            dvg_Rentas.Rows.Clear();

            Cconexion c = new Cconexion();
            MySqlConnection conn = c.establecerConexion();

            try
            {
                string query = "SELECT id_renta, fecha_renta, fecha_limite, estado, id_cliente, id_empleado FROM renta";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dvg_Rentas.Rows.Add(
                            reader.GetInt32("id_renta"),
                            reader.GetDateTime("fecha_renta"),
                            reader.GetDateTime("fecha_limite"),
                            reader.GetString("estado"),
                            reader.GetInt16("id_cliente"),
                            reader.GetInt16("id_empleado")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.cerrarConexion();
            }
        }

        //Proceso para cargar la tabla de mora desde la base de datos - Oscar Morales 9959-23-3070
        private void CargarTablaMora()
        {
            dvg_Mora.Rows.Clear();

            Cconexion c = new Cconexion();
            MySqlConnection conn = c.establecerConexion();

            try
            {
                string query = "SELECT id_mora, id_devolucion, dias_atraso, monto, estado_pago FROM mora";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dvg_Mora.Rows.Add(
                            reader.GetInt32("id_mora"),
                            reader.GetInt32("id_devolucion"),
                            reader.GetInt32("dias_atraso"),
                            reader.GetInt32("monto"),
                            reader.GetString("estado_pago")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.cerrarConexion();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reportes_Generales_Load(object sender, EventArgs e)
        {

        }
    }
}
