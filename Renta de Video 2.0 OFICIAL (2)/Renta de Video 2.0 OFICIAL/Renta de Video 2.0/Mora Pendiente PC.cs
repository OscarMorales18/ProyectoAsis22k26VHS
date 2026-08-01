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
    public partial class Mora_Pendiente_PC : Form
    {
        public Mora_Pendiente_PC()
        {
            InitializeComponent();
        }

        private void Buscar_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Buscar_cliente.Text))
                    throw new Exception("Ingresa el nombre de un cliente para buscar.");

                bool encontrado = false;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[0].Value == null) continue;
                    bool coincide = fila.Cells[0].Value.ToString().ToLower().Contains(Buscar_cliente.Text.ToLower());
                    fila.Visible = coincide;
                    if (coincide) encontrado = true;
                }

                if (!encontrado)
                    throw new Exception("No se encontraron moras pendientes para ese cliente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void totalmora_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marcarpago_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un cliente de la tabla para marcar su pago.");

                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                filaSeleccionada.Cells[4].Value = "Q0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
