using Renta_de_Video_2._0.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace Renta_de_Video_2._0
{
    public partial class Detalle_De_Factura : Form
    {

        public Detalle_De_Factura()
        {
            InitializeComponent();
        }

        // Inicio de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "04/08/2026"
        private void OnRegresar_Click(object sender, EventArgs e)
        {

            try
            {
                new Lista_Facturas().Show();
                this.Hide();
            }

            catch (Exception ex)
            {

                MessageBox.Show("No se pudo regresar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void OnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_codigo.Text))
                    throw new Exception("Ingresa el código de la factura.");

                string sCodigo = txt_codigo.Text.Trim().ToUpper();
                string sNumero = sCodigo.Replace("FACT-", "");
                int iIdFactura = int.Parse(sNumero);

                CdetalleFactura objdetalle = new CdetalleFactura();
                objdetalle.mostrarInfoFactura(txt_cliente, txt_fecha, txt_totalPagar, iIdFactura);
                objdetalle.mostrarDetalleFactura(dgv_detalleFactura, iIdFactura);
                MessageBox.Show("Búsqueda realizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (FormatException)
            {
                MessageBox.Show("El código debe tener el formato FACT-0000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormInPanel(Form formulario)
        {
            menu menuPrincipal = Application.OpenForms.OfType<menu>().FirstOrDefault();

            if (menuPrincipal != null)
            {
                menuPrincipal.AbrirFormInPanel(formulario);
            }
        }

        private void OnMora_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Mora_Pendiente_PC());
        }
        // Fin de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "04/08/2026"
    }
}
