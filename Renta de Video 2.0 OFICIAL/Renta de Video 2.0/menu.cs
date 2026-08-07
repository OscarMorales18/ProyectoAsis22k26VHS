using Renta_de_Video_2._0.Clases;       // Referencia a la clase SesionUsuario
using Renta_de_Video_2._0.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;  // Librería para mover ventana por la barra de título
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renta_de_Video_2._0
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            // 1. Aplica permisos según el rol del usuario conectado (Victor Samayoa 0901-23-3424)
            AplicarPermisos();
            CargarDatosUsuario();

            // 2. Vincula los eventos Clic de todos los botones con sus correspondientes formularios
            btninicio.Click += btninicio_Click;
            button6.Click += btnClientes_Click;
            button2.Click += btnInventario_Click;
            button3.Click += btnRentas_Click;
            button4.Click += btnFacturacion_Click;
            button5.Click += btnUsuarios_Click;
            //button1.Click += btninicio_Click;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            lblNombreUsuario.Text = SesionUsuario.Usuario;
            lblRol.Text = SesionUsuario.Rol;
        }

        // Método para ocultar/mostrar botones del menú según el rol (Victor Samayoa 0901-23-3424)
        private void AplicarPermisos()
        {
            string rol = SesionUsuario.Rol;

            switch (rol)
            {
                case "Empleado":
                    btninicio.Enabled = true; // inicio
                    button6.Enabled = true;   // clientes y membresias
                    button2.Enabled = true;   // inventario
                    button3.Enabled = true;   // rentas y devoluciones
                    button4.Enabled = true;   // facturacion y mora
                    button5.Enabled = false;  // gestion de usuarios (desactivado)
                    button1.Enabled = false;  // seguridad del sistema (desactivado)

                    break;

                case "Administrador":
                    btninicio.Enabled = true; // inicio
                    button6.Enabled = true;   // clientes y membresias
                    button2.Enabled = true;   // inventario
                    button3.Enabled = true;   // rentas y devoluciones
                    button4.Enabled = true;   // facturacion y mora
                    button5.Enabled = true;   // gestion de usuarios 
                    button1.Enabled = false;  // seguridad del sistema (desactivado)
                    break;

                case "Auditor":
                    btninicio.Enabled = true; // inicio
                    button6.Enabled = true;   // clientes y membresias
                    button2.Enabled = true;   // inventario
                    button3.Enabled = true;   // rentas y devoluciones
                    button4.Enabled = true;   // facturacion y mora
                    button5.Enabled = true;   // gestion de usuarios 
                    button1.Enabled = true;   // seguridad del sistema 
                    break;

                default:
                    MessageBox.Show("Rol no reconocido o sesión no válida.", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

        // Evento del menú hamburguesa - (Evelyn Andrade 9959-23-1224)
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 64;
            }
            else
            {
                MenuVertical.Width = 250;
            }

            CentrarFormulario();
        }

        // Método para cargar formularios dentro del Panel Contenedor (Evelyn Andrade 9959-23-1224)
        public void AbrirFormInPanel(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.StartPosition = FormStartPosition.Manual;

            panelContenedor.Controls.Add(formulario);

            formulario.Location = new Point(
                (panelContenedor.Width - formulario.Width) / 2,
                (panelContenedor.Height - formulario.Height) / 2
            );

            panelContenedor.Tag = formulario;

            formulario.Show();
        }

        //centrar los form 

        private void CentrarFormulario()
        {
            if (panelContenedor.Controls.Count > 0)
            {
                Form frm = panelContenedor.Controls[0] as Form;

                if (frm != null)
                {
                    frm.Location = new Point(
                        (panelContenedor.Width - frm.Width) / 2,
                        (panelContenedor.Height - frm.Height) / 2
                    );
                }
            }
        }






        // 1 inicio (Victor Samayoa 0901-23-3424)
        private void btninicio_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            AbrirFormInPanel(new InicioDashboard());
        }

        // 2 clientes (Victor Samayoa 0901-23-3424)
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new BuscarCliente());
        }

        // 3 inventario (Victor Samayoa 0901-23-3424)
        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new InventarioLista());
        }

        // 4 rentas (Victor Samayoa 0901-23-3424)
        private void btnRentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new NuevaRenta());
        }

        // 5 facturación (Victor Samayoa 0901-23-3424)
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Lista_Facturas());
        }

        // 6 gestión de usuarios (Victor Samayoa 0901-23-3424)
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Gestion_Empleados());
        }

        // 7 seguridad del sistema (Victor Samayoa 0901-23-3424)
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Auditoria());
        }

        // Métodos secundarios dejados por compatibilidad
        private void button1_Click(object sender, EventArgs e) { }

        private void button2_Click_1(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }

        // Evento cerrar ventana (Evelyn Andrade 9959-23-1224)
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento minimizar (Evelyn Andrade 9959-23-1224)
        private void iconmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Mover ventana con el mouse (Evelyn Andrade 9959-23-1224)
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void panelContenedor_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void BarraTitulo_Paint(object sender, PaintEventArgs e) { }
        private void MenuVertical_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        // Métodos requeridos por las referencias en menu.Designer.cs
        private void label1_Click_2(object sender, EventArgs e) { }
        private void label1_Click_3(object sender, EventArgs e) { }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión actual?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                SesionUsuario.Usuario = string.Empty;
                SesionUsuario.Rol = string.Empty;

                Login loginForm = new Login();
                loginForm.Show();

                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}