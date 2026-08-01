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
    public partial class Lista_Facturas : Form
    {
        public Lista_Facturas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void porcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(porcliente.Text))
                    throw new Exception("Ingresa el nombre de un cliente para buscar.");

                bool encontrado = false;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[2].Value == null) continue;
                    bool coincide = fila.Cells[2].Value.ToString().ToLower().Contains(porcliente.Text.ToLower());
                    fila.Visible = coincide;
                    if (coincide) encontrado = true;
                }

                if (!encontrado)
                    throw new Exception("No se encontraron facturas para ese cliente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void verdetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    throw new Exception("Selecciona una factura de la tabla para ver el detalle.");

                new Detalle_De_Factura().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Lista_Facturas_Load(object sender, EventArgs e)
        {

        }
    }
}
