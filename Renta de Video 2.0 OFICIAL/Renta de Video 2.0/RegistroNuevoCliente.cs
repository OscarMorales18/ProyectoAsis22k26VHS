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

        // Inicio de código de "André De Jesús González Camey" con carné: "9959-23-3117" en la fecha de: "04/08/2026"
        private void OnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombreCompleto.Text))
                        throw new Exception("El nombre completo es obligatorio.");

                string sDpiLimpio = txt_dpi.Text.Replace(" ", "");
             
                if (sDpiLimpio.Length != 13 || !sDpiLimpio.All(char.IsDigit))
                throw new Exception("El DPI debe tener 13 dígitos numéricos.");

                    string sTelLimpio= txt_telefono.Text.Replace("-", "");
           
                if (sTelLimpio.Length != 8 || !sTelLimpio.All(char.IsDigit))
                    throw new Exception("El teléfono debe tener 8 dígitos.");

               
                if (string.IsNullOrWhiteSpace(txt_direccion.Text))
                        throw new Exception("La dirección es obligatoria.");

            
                if (!Regex.IsMatch(txt_correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Ingresa un correo electrónico válido.");

                MCliente objNuevoCliente = new MCliente
                {
                    Nombre = txt_nombreCompleto.Text,
                    Dpi = sDpiLimpio,
                    Telefono = sTelLimpio,
                    Direccion = txt_direccion.Text,
                    Correo = txt_correo.Text
                };

              
                ClienteConsultas objConsultas = new ClienteConsultas();
                    int iIdMembresia= objConsultas.AgregarCliente(objNuevoCliente);

                if (iIdMembresia<= 0)
                throw new Exception("No se pudo guardar el cliente en la base de datos.");


                string sNuevoCodigo= "MEM-" + iIdMembresia.ToString("D4");
                txt_codigoMembresia.Text = sNuevoCodigo;

                MessageBox.Show("Cliente registrado correctamente en la base de datos.\nCódigo de membresía: " + sNuevoCodigo,
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Fin de código de "André De Jesús González Camey" con carné: "9959-23-3117" en la fecha de: "04/08/2026"


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
