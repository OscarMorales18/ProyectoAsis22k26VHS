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
        private bool _bLimpiando = false;

        public Devolucion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            if (_bLimpiando) return;

            if (dgv_video.Rows.Count <= 1)
            {
                MessageBox.Show("Primero busca un cliente con videos rentados.");
                return;
            }

            DateTime dFechaDevolucion= dtpDevolucion.Value.Date;
            DateTime dFechaLimite= Convert.ToDateTime(dgv_video.Rows[0].Cells["Fecha_Limite"].Value);

            if (dFechaDevolucion< dFechaLimite.AddDays(-30))
            {
                MessageBox.Show("La fecha de devolución no puede ser tan antigua.");
                dtpDevolucion.Value = DateTime.Today;
                return;
            }

            int iDiasAtraso= 0;
            if (dFechaDevolucion> dFechaLimite)
            {
                iDiasAtraso= (dFechaDevolucion- dFechaLimite).Days;
            }

            decimal deSubtotal= 0;
            foreach (DataGridViewRow fila in dgv_video.Rows)
            {
                if (fila.Cells["Precio"].Value != null && fila.Cells["Precio"].Value.ToString() != "")
                {
                    deSubtotal+= Convert.ToDecimal(fila.Cells["Precio"].Value);
                }
            }

            decimal deMora= iDiasAtraso* 5;
            decimal deTotal = deSubtotal+ deMora;

            lbl_fechaLimite.Text = dFechaLimite.ToString("dd/MM/yyyy");
            lbl_fechaDevolucion.Text = dFechaDevolucion.ToString("dd/MM/yyyy");
            lbl_diasAtraso.Text = iDiasAtraso.ToString() + " días";
            lbl_subtotal.Text = "Q" + deSubtotal.ToString("F2");
            lbl_mora.Text = "Q" + deMora.ToString("F2");
            lbl_total.Text = "Q" + deTotal.ToString("F2");
        }

        private void OnBuscar_Click(object sender, EventArgs e)
        {
            if (txt_membresia.Text == "")
            {
                MessageBox.Show("Ingresa un código de membresía.");
                txt_membresia.Focus();
                return;
            }

            if (!txt_membresia.Text.All(char.IsDigit))
            {
                MessageBox.Show("El código de membresía solo puede contener números.");
                txt_membresia.Clear();
                txt_membresia.Focus();
                return;
            }

            CCliente objCliente= new CCliente();
            DataTable objDt= objCliente.funBuscarCliente(int.Parse(txt_membresia.Text));

            if (objDt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ningún cliente con ese código de membresía.");
                txt_membresia.Clear();
                txt_membresia.Focus();
                return;
            }

            txt_nombreCliente.Text = objDt.Rows[0]["Nombre_C"].ToString();

            // cargar videos rentados
            DataTable objDtVideos= objCliente.funVideosRentados(int.Parse(txt_membresia.Text));

            if (objDtVideos.Rows.Count == 0)
            {
                MessageBox.Show("Este cliente no tiene videos rentados activos.");
                dgv_video.DataSource = null;
                return;
            }

            dgv_video.DataSource = objDtVideos;
        }

        private void OnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgv_video.Rows.Count <= 1)
            {
                MessageBox.Show("No hay videos para devolver.");
                return;
            }

            if (lbl_total.Text == "")
            {
                MessageBox.Show("Selecciona una fecha de devolución primero.");
                return;
            }

            DialogResult dlgRespuesta= MessageBox.Show(
                "¿Confirmas la devolución?\nTotal a pagar: " + lbl_total.Text,
                "Confirmar devolución",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dlgRespuesta== DialogResult.Yes)
            {
                int iIdRenta= Convert.ToInt32(dgv_video.Rows[0].Cells["Id_Renta"].Value);
                int iDiasAtraso= int.Parse(lbl_diasAtraso.Text.Replace(" días", ""));
                decimal deMora= decimal.Parse(lbl_mora.Text.Replace("Q", ""));
                int iIdEmpleado= 1;

                Cdevolucion objDevolucion= new Cdevolucion();
                objDevolucion.registrarDevolucion(
                    iIdRenta,
                    iIdEmpleado,
                    dtpDevolucion.Value.Date,
                    iDiasAtraso,
                    deMora
                );

                // actualizar stock de cada video
                Cvideos objVideo= new Cvideos();
                foreach (DataGridViewRow fila in dgv_video.Rows)
                {
                    if (fila.Cells["Id_Video"].Value != null &&
                        fila.Cells["Id_Video"].Value.ToString() != "")
                    {
                        int iIdVideo= Convert.ToInt32(fila.Cells["Id_Video"].Value);
                        objVideo.actualizarStock(iIdVideo);
                    }
                }

                MessageBox.Show("Devolución registrada correctamente.");

                // limpiar el form
                _bLimpiando = true;

                txt_membresia.Clear();
                txt_nombreCliente.Clear();
                dgv_video.DataSource = null;
                lbl_fechaLimite.Text = "";
                lbl_fechaDevolucion.Text = "";
                lbl_diasAtraso.Text = "";
                lbl_subtotal.Text = "";
                lbl_mora.Text = "";
                lbl_total.Text = "";
                dtpDevolucion.Value = DateTime.Today;

                _bLimpiando = false;
            }
        }
    }

}