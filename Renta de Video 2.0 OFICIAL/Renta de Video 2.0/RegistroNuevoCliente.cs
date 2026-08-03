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
using Renta_de_Video_2._0.Clases;

namespace Renta_de_Video_2._0.Resources
{
    public partial class RegistroNuevoCliente : Form
    {
        public RegistroNuevoCliente()
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

        private void RegistroNuevoCliente_Load(object sender, EventArgs e)
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
                // manejo de errores de cada campo Andre Gonzalez 9959-23-3117
                if (string.IsNullOrWhiteSpace(NombreCompleto.Text))
                        throw new Exception("El nombre completo es obligatorio.");

                string dpiLimpio = DPI.Text.Replace(" ", "");
             
                if (dpiLimpio.Length != 13 || !dpiLimpio.All(char.IsDigit))
                throw new Exception("El DPI debe tener 13 dígitos numéricos.");

                    string telLimpio = Telefono.Text.Replace("-", "");
           
                if (telLimpio.Length != 8 || !telLimpio.All(char.IsDigit))
                    throw new Exception("El teléfono debe tener 8 dígitos.");

               
                if (string.IsNullOrWhiteSpace(Direccion.Text))
                        throw new Exception("La dirección es obligatoria.");

            
                if (!Regex.IsMatch(Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Ingresa un correo electrónico válido.");

                // encadenacion form con Base de datose del cliente Andre Gonzalez 9959-23-3117
                MCliente nuevoCliente = new MCliente
                {
                    Nombre = NombreCompleto.Text,
                    Dpi = dpiLimpio,
                    Telefono = telLimpio,
                    Direccion = Direccion.Text,
                    Correo = Correo.Text
                };

              
                ClienteConsultas consultas = new ClienteConsultas();
                    int idMembresia = consultas.AgregarCliente(nuevoCliente);

                // manejo de error guardado en base de datos Andre Gonzalez 9959-23-3117
                if (idMembresia <= 0)
                throw new Exception("No se pudo guardar el cliente en la base de datos.");


                string nuevoCodigo = "MEM-" + idMembresia.ToString("D4");
                Codigo_de_membresia.Text = nuevoCodigo;

                MessageBox.Show("Cliente registrado correctamente en la base de datos.\nCódigo de membresía: " + nuevoCodigo,
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // manejo de error Andre Gonzalez 9959-23-3117
            catch (Exception ex)
            {
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
