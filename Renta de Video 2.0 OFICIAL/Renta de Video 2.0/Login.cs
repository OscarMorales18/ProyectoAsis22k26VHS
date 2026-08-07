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

            txt_password.PasswordChar = '*';

            pictureBox5.Click += pictureBox5_Click;
            btn_salir.Click += OnSalir_Click;
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


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void OnSesion_Click(object sender, EventArgs e)
        {
            string sUsuarioInput = txt_usuario.Text.Trim();
            string sPassInput = txt_password.Text.Trim();

            if (string.IsNullOrEmpty(sUsuarioInput) || string.IsNullOrEmpty(sPassInput))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CusuarioCRUD objUsuarioCrud = new CusuarioCRUD();

            if (objUsuarioCrud.ValidarUsuario(sUsuarioInput, sPassInput))
            {
                MessageBox.Show($"Bienvenido {SesionUsuario.Usuario} ({SesionUsuario.Rol})", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                menu objFormMenu = new menu();
                objFormMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}