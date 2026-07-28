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
    public partial class Detalle_De_Factura : Form
    {
        public Detalle_De_Factura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalPagar_TextChanged(object sender, EventArgs e)
        {
            // regresa a la lista de facturas
            try
            {
                new Lista_Facturas().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo regresar a la lista de facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CalcularTotal()
        {
            // suma los subtotales de la tabla para sacar el total a pagar
            try
            {
                decimal total = 0;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[3].Value == null) continue;
                    string subtotalTexto = fila.Cells[3].Value.ToString().Replace("Q", "");
                    total += Convert.ToDecimal(subtotalTexto);
                }
                TotalPagar.Text = "Q" + total.ToString("0.00");
            }
            // si algun subtotal no se puede convertir a numero, cae aqui
            catch (FormatException)
            {
                MessageBox.Show("Uno de los subtotales no es un valor numérico válido.", "Error de cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TotalPagar.Text = "Q0.00";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
