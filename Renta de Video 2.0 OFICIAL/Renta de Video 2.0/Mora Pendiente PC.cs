using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renta_de_Video_2._0.Clases;

namespace Renta_de_Video_2._0
{
    public partial class Mora_Pendiente_PC : Form
    {
        public Mora_Pendiente_PC()
        {
            InitializeComponent();
        }

        private void Buscar_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalmora_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string sEntrada = txt_buscarCliente.Text.Trim();

                if (string.IsNullOrWhiteSpace(sEntrada))
                    throw new Exception("Ingresa el código de membresía del cliente.");

                string sCodigoTexto = sEntrada.ToUpper();
                string sNumeroTexto = sCodigoTexto.Replace("MEM-", "");

                if (!int.TryParse(sNumeroTexto, out int iIdMembresia))
                    throw new Exception("El código de membresía no es válido.");

                RentaConsultas objConsultaRenta = new RentaConsultas();
                MClienteRenta objCliente = objConsultaRenta.BuscarClientePorMembresia(iIdMembresia);

                if (objCliente == null)
                    throw new Exception("No se encontró ningún cliente con esa membresía.");

                MoraConsultas consultaMora = new MoraConsultas();
                List<MMoraPendiente> lst_Moras = consultaMora.CargarMorasPendientes(objCliente.IdCliente);

                dgv_moras.Rows.Clear();

                if (lst_Moras.Count == 0)
                    throw new Exception("Este cliente no tiene moras pendientes.");

                string sCodigoMembresia = "MEM-" + iIdMembresia.ToString("D4");
                decimal deTotalAcumulado = 0;

                foreach (MMoraPendiente mora in lst_Moras)
                {
                    int indiceFila = dgv_moras.Rows.Add(
                        objCliente.Nombre,
                        sCodigoMembresia,
                        "REN-" + mora.IdRenta.ToString("D4"),
                        mora.DiasAtraso,
                        "Q" + mora.Monto.ToString("0.00")
                    );
                    dgv_moras.Rows[indiceFila].Tag = mora.IdMora;

                    deTotalAcumulado += mora.Monto;
                }

                txt_totalMora.Text = "Q" + deTotalAcumulado.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnMarcarpago_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_moras.CurrentRow == null || dgv_moras.CurrentRow.Tag == null)
                    throw new Exception("Selecciona una mora de la tabla para marcar su pago.");

                int iIdMora = (int)dgv_moras.CurrentRow.Tag;

                MoraConsultas objConsultaMora = new MoraConsultas();
                bool bActualizado = objConsultaMora.MarcarMoraPagada(iIdMora);

                if (!bActualizado)
                    throw new Exception("No se pudo marcar la mora como pagada.");

                dgv_moras.CurrentRow.Cells[4].Value = "Q0.00";

                MessageBox.Show("Mora marcada como pagada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
