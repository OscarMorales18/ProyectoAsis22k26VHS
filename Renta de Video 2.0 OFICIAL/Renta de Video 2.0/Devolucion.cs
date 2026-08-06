using Renta_de_Video_2._0.Clases;
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
    public partial class Devolucion : Form
    {
        private bool limpiando = false;

        public Devolucion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtMembresia.Text == "")
            {
                MessageBox.Show("Ingresa un código de membresía.");
                txtMembresia.Focus();
                return;
            }

            if (!txtMembresia.Text.All(char.IsDigit))
            {
                MessageBox.Show("El código de membresía solo puede contener números.");
                txtMembresia.Clear();
                txtMembresia.Focus();
                return;
            }

            CCliente objetoCliente = new CCliente();
            DataTable dt = objetoCliente.funBuscarCliente(int.Parse(txtMembresia.Text));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ningún cliente con ese código de membresía.");
                txtMembresia.Clear();
                txtMembresia.Focus();
                return;
            }

            txtNombreCliente.Text = dt.Rows[0]["Nombre_C"].ToString();

            // cargar videos rentados
            DataTable dtVideos = objetoCliente.funVideosRentados(int.Parse(txtMembresia.Text));

            if (dtVideos.Rows.Count == 0)
            {
                MessageBox.Show("Este cliente no tiene videos rentados activos.");
                dgwVideod.DataSource = null;
                return;
            }

            dgwVideod.DataSource = dtVideos;
        }

        private void dtpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            if (limpiando) return;

            if (dgwVideod.Rows.Count <= 1)
            {
                MessageBox.Show("Primero busca un cliente con videos rentados.");
                return;
            }

            DateTime fechaDevolucion = dtpDevolucion.Value.Date;
            DateTime fechaLimite = Convert.ToDateTime(dgwVideod.Rows[0].Cells["Fecha_Limite"].Value);

            if (fechaDevolucion < fechaLimite.AddDays(-30))
            {
                MessageBox.Show("La fecha de devolución no puede ser tan antigua.");
                dtpDevolucion.Value = DateTime.Today;
                return;
            }

            // calcular dias de atraso
            int diasAtraso = 0;
            if (fechaDevolucion > fechaLimite)
            {
                diasAtraso = (fechaDevolucion - fechaLimite).Days;
            }

            // calcular subtotal sumando precios de todos los videos
            decimal subtotal = 0;
            foreach (DataGridViewRow fila in dgwVideod.Rows)
            {
                if (fila.Cells["Precio"].Value != null && fila.Cells["Precio"].Value.ToString() != "")
                {
                    subtotal += Convert.ToDecimal(fila.Cells["Precio"].Value);
                }
            }

            // mora es Q5 por dia de atraso
            decimal mora = diasAtraso * 5;
            decimal total = subtotal + mora;

            // mostrar resultados
            lblFechaLimite.Text = fechaLimite.ToString("dd/MM/yyyy");
            lblFechaDevolucion.Text = fechaDevolucion.ToString("dd/MM/yyyy");
            lblDiasAtraso.Text = diasAtraso.ToString() + " días";
            lblSubtotal.Text = "Q" + subtotal.ToString("F2");
            lblMora.Text = "Q" + mora.ToString("F2");
            lblTotal.Text = "Q" + total.ToString("F2");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgwVideod.Rows.Count <= 1)
            {
                MessageBox.Show("No hay videos para devolver.");
                return;
            }

            if (lblTotal.Text == "")
            {
                MessageBox.Show("Selecciona una fecha de devolución primero.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Confirmas la devolución?\nTotal a pagar: " + lblTotal.Text,
                "Confirmar devolución",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                int idRenta = Convert.ToInt32(dgwVideod.Rows[0].Cells["Id_Renta"].Value);
                int diasAtraso = int.Parse(lblDiasAtraso.Text.Replace(" días", ""));
                decimal mora = decimal.Parse(lblMora.Text.Replace("Q", ""));
                int idEmpleado = 1; // aquí pon el id del empleado de sesión

                Cdevolucion objetoDevolucion = new Cdevolucion();
                objetoDevolucion.registrarDevolucion(
                    idRenta,
                    idEmpleado,
                    dtpDevolucion.Value.Date,
                    diasAtraso,
                    mora
                );

                // actualizar stock de cada video
                Cvideos objetoVideo = new Cvideos();
                foreach (DataGridViewRow fila in dgwVideod.Rows)
                {
                    if (fila.Cells["Id_Video"].Value != null &&
                        fila.Cells["Id_Video"].Value.ToString() != "")
                    {
                        int idVideo = Convert.ToInt32(fila.Cells["Id_Video"].Value);
                        objetoVideo.actualizarStock(idVideo);
                    }
                }

                MessageBox.Show("Devolución registrada correctamente.");

                // limpiar el form
                limpiando = true;

                txtMembresia.Clear();
                txtNombreCliente.Clear();
                dgwVideod.DataSource = null;
                lblFechaLimite.Text = "";
                lblFechaDevolucion.Text = "";
                lblDiasAtraso.Text = "";
                lblSubtotal.Text = "";
                lblMora.Text = "";
                lblTotal.Text = "";
                dtpDevolucion.Value = DateTime.Today;

                limpiando = false;
            }
        }
    }
}