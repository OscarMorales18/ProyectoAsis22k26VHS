using Renta_de_Video_2._0.Clases;
using System;
using System.Windows.Forms;

namespace Renta_de_Video_2._0
{
    public partial class Lista_Facturas : Form
    {
        public Lista_Facturas()
        {
            InitializeComponent();
            // Elimina la barra de título superior dentro del contenedor
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void porcliente_TextChanged(object sender, EventArgs e) { }

        // Inicio de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "31/07/2026"
        private void OnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(porcliente.Text))
                    throw new Exception("Ingresa el ID del cliente.");

                int iIdCliente = int.Parse(porcliente.Text);
                Cfacturas objFacturas = new Cfacturas();
                objFacturas.mostrarFacturas(dvg_facturas, iIdCliente);
                MessageBox.Show("Búsqueda de cliente realizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Fin de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "31/07/2026"
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvg_facturas.SelectedRows.Count == 0)
                    throw new Exception("Selecciona una factura de la tabla para ver el detalle.");

                // Carga Detalle_De_Factura dentro del panel contenedor del menú
                Form menuPrincipal = Application.OpenForms["menu"];
                if (menuPrincipal is menu formMenu)
                {
                    formMenu.AbrirFormInPanel(new Detalle_De_Factura());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Lista_Facturas_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}