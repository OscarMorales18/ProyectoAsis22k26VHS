using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Renta_de_Video_2._0
{
    public partial class FormWalkthriught3 : Form
    {
        public FormWalkthriught3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigodeMembresia_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContadordeRenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void si_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // valida los datos editados del cliente y muestra el resumen actualizado
            try
            {
                if (string.IsNullOrWhiteSpace(NombreCompleto.Text))
                    throw new Exception("El nombre completo es obligatorio.");

                string dpiLimpio = DPI.Text.Replace(" ", "");
                if (dpiLimpio.Length != 13 || !dpiLimpio.All(char.IsDigit))
                    throw new Exception("El DPI debe tener 13 dígitos numéricos.");

                string telLimpio = Telefono.Text.Replace("-", "");
                if (telLimpio.Length != 8 || !telLimpio.All(char.IsDigit))
                    throw new Exception("El teléfono debe tener 8 dígitos.");

                if (string.IsNullOrWhiteSpace(Dirección.Text))
                    throw new Exception("La dirección es obligatoria.");

                if (!Regex.IsMatch(Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Ingresa un correo electrónico válido.");

                if (string.IsNullOrWhiteSpace(CodigodeMembresia.Text))
                    throw new Exception("El código de membresía es obligatorio.");

                string descuento = si.Checked ? "Sí" : "No";

                MessageBox.Show(
                    "Datos del cliente actualizados correctamente.\n" +
                    "Rentas realizadas: " + ContadordeRenta.Value + "\n" +
                    "Descuento disponible: " + descuento,
                    "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // si algo de lo de arriba falla, cae aqui y se muestra el mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void NombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
