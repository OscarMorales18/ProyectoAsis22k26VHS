using Renta_de_Video_2._0.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renta_de_Video_2._0
{
    public partial class FormWalkthriught2 : Form
    {
        public FormWalkthriught2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Codigo_Membresia.Text))
                    throw new Exception("Ingresa un código de membresía para buscar.");

                if (!Codigo_Membresia.Text.StartsWith("MEM-"))
                    throw new Exception("El código de membresía debe tener el formato MEM-0000.");

                dataGridView1.Rows.Clear();

                // Datos de ejemplo simulados (mientras no hay base de datos real)
                if (Codigo_Membresia.Text == "MEM-0001")
                {
                    dataGridView1.Rows.Add("Ana Gómez", "1234567890123", "12345678", "Zona 1, Ciudad", "ana@correo.com");
                }
                else
                {
                    throw new Exception("No se encontró ningún cliente con ese código de membresía.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Codigo_Membresia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}