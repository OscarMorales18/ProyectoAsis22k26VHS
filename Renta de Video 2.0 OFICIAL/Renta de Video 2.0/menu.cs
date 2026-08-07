using Renta_de_Video_2._0.Clases;       
using Renta_de_Video_2._0.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;  
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

           
            btn_inicio.Click += btninicio_Click;
            btn_clientesMembresias.Click += btnClientes_Click;
            btn_inventario.Click += btnInventario_Click;
            btn_rentasDevoluciones.Click += btnRentas_Click;
            btn_facturasMoras.Click += btnFacturacion_Click;
            btn_gestionUsuarios.Click += btnUsuarios_Click;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            lbl_nombreUsuario.Text = SesionUsuario.Usuario;
            lbl_rol.Text = SesionUsuario.Rol;
        }

        // Método para ocultar/mostrar botones del menú según el rol (Victor Samayoa 0901-23-3424)
        private void AplicarPermisos()
        {
            string sRol = SesionUsuario.Rol;

            switch (sRol)
            {
                case "Empleado":
                    btn_inicio.Enabled = true; 
                    btn_clientesMembresias.Enabled = true;   
                    btn_inventario.Enabled = true;  
                    btn_rentasDevoluciones.Enabled = true;   
                    btn_facturasMoras.Enabled = true;   
                    btn_gestionUsuarios.Enabled = false;  
                    btn_seguridad.Enabled = false;  

                    break;

                case "Administrador":
                    btn_inicio.Enabled = true; 
                    btn_clientesMembresias.Enabled = true;   
                    btn_inventario.Enabled = true;   
                    btn_rentasDevoluciones.Enabled = true;   
                    btn_facturasMoras.Enabled = true;   
                    btn_gestionUsuarios.Enabled = true;   
                    btn_seguridad.Enabled = false;  
                    break;

                case "Auditor":
                    btn_inicio.Enabled = true; 
                    btn_clientesMembresias.Enabled = true;  
                    btn_inventario.Enabled = true;   
                    btn_rentasDevoluciones.Enabled = true;  
                    btn_facturasMoras.Enabled = true;   
                    btn_gestionUsuarios.Enabled = true;   
                    btn_seguridad.Enabled = true;   
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
            if (menuVertical.Width == 290)
            {
                menuVertical.Width = 64;
            }
            else
            {
                menuVertical.Width = 290;
            }

            CentrarFormulario();
        }

        // Método para cargar formularios dentro del Panel Contenedor (Evelyn Andrade 9959-23-1224)
        public void AbrirFormInPanel(Form formulario)
        {
            pnl_contenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.StartPosition = FormStartPosition.Manual;

            pnl_contenedor.Controls.Add(formulario);

            formulario.Location = new Point(
                (pnl_contenedor.Width - formulario.Width) / 2,
                (pnl_contenedor.Height - formulario.Height) / 2
            );

            pnl_contenedor.Tag = formulario;

            formulario.Show();
        }

        //centrar los form 

        private void CentrarFormulario()
        {
            if (pnl_contenedor.Controls.Count > 0)
            {
                Form frm = pnl_contenedor.Controls[0] as Form;

                if (frm != null)
                {
                    frm.Location = new Point(
                        (pnl_contenedor.Width - frm.Width) / 2,
                        (pnl_contenedor.Height - frm.Height) / 2
                    );
                }
            }
        }

        // 1 inicio (Victor Samayoa 0901-23-3424)
        private void btninicio_Click(object sender, EventArgs e)
        {
            if (this.pnl_contenedor.Controls.Count > 0)
                this.pnl_contenedor.Controls.RemoveAt(0);
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


        private void label1_Click_2(object sender, EventArgs e) { }
        private void label1_Click_3(object sender, EventArgs e) { }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dlgConfirmacion = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión actual?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dlgConfirmacion == DialogResult.Yes)
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