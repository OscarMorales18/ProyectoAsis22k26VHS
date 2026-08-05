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
using Renta_de_Video_2._0.Resources;

namespace Renta_de_Video_2._0
{
    public partial class FormWalkthriught2 : Form
    {
        public FormWalkthriught2()
        {
            InitializeComponent();

            if (SesionUsuario.Rol == "Empleado")
            {
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string entrada = Codigo_Membresia.Text.Trim();

                if (string.IsNullOrWhiteSpace(entrada))
                    throw new Exception("Ingresa un código de membresía para buscar.");

                // Si el usuario escribe solo un número (ej: "1"), se auto-formatea a "MEM-0001"
                string codigoBuscado = entrada;
                if (int.TryParse(entrada, out int idNum))
                {
                    codigoBuscado = "MEM-" + idNum.ToString("D4");
                    Codigo_Membresia.Text = codigoBuscado; // Auto-completa el cuadro de texto
                }

                dataGridView1.Rows.Clear();

                Cconexion c = new Cconexion();
                MySqlConnection conn = c.establecerConexion();

                try
                {
                    string query = @"SELECT nombre, dpi, telefono, direccion, correo 
                            FROM cliente 
                            WHERE codigo_membresia = @codigo 
                               OR id_cliente = @idNum";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigoBuscado);
                    cmd.Parameters.AddWithValue("@idNum", int.TryParse(entrada, out int id) ? id : 0);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool encontrado = false;

                        while (reader.Read())
                        {
                            encontrado = true;
                            dataGridView1.Rows.Add(
                                reader.IsDBNull(0) ? "" : reader.GetString("nombre"),
                                reader.IsDBNull(1) ? "" : reader.GetString("dpi"),
                                reader.IsDBNull(2) ? "" : reader.GetString("telefono"),
                                reader.IsDBNull(3) ? "" : reader.GetString("direccion"),
                                reader.IsDBNull(4) ? "" : reader.GetString("correo")
                            );
                        }

                        if (!encontrado)
                        {
                            MessageBox.Show("No se encontró ningún cliente con la membresía " + codigoBuscado,
                                            "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                finally
                {
                    c.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //abrir al menu
        private void AbrirFormInPanel(Form formulario)
        {
            menu menuPrincipal = Application.OpenForms.OfType<menu>().FirstOrDefault();

            if (menuPrincipal != null)
            {
                menuPrincipal.AbrirFormInPanel(formulario);
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void Codigo_Membresia_TextChanged(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panelContenedor_Paint(object sender, PaintEventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormWalkthriught3());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistroNuevoCliente());
        }
    }
}