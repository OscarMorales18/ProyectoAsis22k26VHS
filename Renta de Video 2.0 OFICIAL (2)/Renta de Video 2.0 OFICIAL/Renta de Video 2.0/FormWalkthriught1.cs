using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Renta_de_Video_2._0.Resources
{
    public partial class FormWalkthriught1 : Form
    {
        // contador para ir generando los codigos de membresia (MEM-0001, MEM-0002...)
        private static int contadorMembresias = 1;
        public FormWalkthriught1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormWalkthriught1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // valido que no venga vacio el nombre
                if (string.IsNullOrWhiteSpace(NombreCompleto.Text))
                    throw new Exception("El nombre completo es obligatorio.");

                // quito espacios y me fijo que el dpi tenga los 13 numeros
                string dpiLimpio = DPI.Text.Replace(" ", "");
                if (dpiLimpio.Length != 13 || !dpiLimpio.All(char.IsDigit))
                    throw new Exception("El DPI debe tener 13 dígitos numéricos.");

                // mismo caso pero para el telefono, 8 digitos sin el guion
                string telLimpio = Telefono.Text.Replace("-", "");
                if (telLimpio.Length != 8 || !telLimpio.All(char.IsDigit))
                    throw new Exception("El teléfono debe tener 8 dígitos.");

                if (string.IsNullOrWhiteSpace(Direccion.Text))
                    throw new Exception("La dirección es obligatoria.");

                if (!Regex.IsMatch(Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Ingresa un correo electrónico válido.");

                string nuevoCodigo = "MEM-" + contadorMembresias.ToString("D4");
                contadorMembresias++;
                Codigo_de_membresia.Text = nuevoCodigo;

                MessageBox.Show("Cliente registrado correctamente.\nCódigo de membresía: " + nuevoCodigo,
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // aqui cae cualquiera de los throw de arriba (o algun error que no contemple)
                // y en vez de que se caiga el programa solo muestro el mensaje
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void DPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Codigo_de_membresia_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
