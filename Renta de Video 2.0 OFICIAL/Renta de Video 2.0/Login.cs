using Renta_de_Video_2._0.Clases;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // 1. Fuerza el ocultamiento con asteriscos (*) desde el inicio
            textBox2.PasswordChar = '*';

            // 2. Vinculación de eventos
            pictureBox5.Click += pictureBox5_Click;
            button2.Click += button2_Click;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioInput = textBox1.Text.Trim(); // TextBox de Usuario
            string passInput = textBox2.Text.Trim();    // TextBox de Contraseña

            if (string.IsNullOrEmpty(usuarioInput) || string.IsNullOrEmpty(passInput))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CusuarioCRUD usuarioCrud = new CusuarioCRUD();

            if (usuarioCrud.ValidarUsuario(usuarioInput, passInput))
            {
                MessageBox.Show($"Bienvenido {SesionUsuario.Usuario} ({SesionUsuario.Rol})", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el Dashboard / Menú Principal
                menu formMenu = new menu();
                formMenu.Show();
                this.Hide(); // Oculta el Login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Alterna entre '*' (oculto) y '\0' (texto visible)
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0'; // Muestra la contraseña en texto plano
            }
            else
            {
                textBox2.PasswordChar = '*';  // Oculta la contraseña con ******
            }
        }

        // Cierra completamente la aplicación
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}