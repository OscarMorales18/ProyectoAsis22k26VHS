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

        private void Buscar_Click(object sender, EventArgs e)
        {
            // trae las moras pendientes del cliente dueño de esa membresia
            try
            {
                string entrada = Buscar_cliente.Text.Trim();

                if (string.IsNullOrWhiteSpace(entrada))
                    throw new Exception("Ingresa el código de membresía del cliente.");

                string codigoTexto = entrada.ToUpper();
                string numeroTexto = codigoTexto.Replace("MEM-", "");

                if (!int.TryParse(numeroTexto, out int idMembresia))
                    throw new Exception("El código de membresía no es válido.");

                RentaConsultas consultaRenta = new RentaConsultas();
                MClienteRenta cliente = consultaRenta.BuscarClientePorMembresia(idMembresia);

                if (cliente == null)
                    throw new Exception("No se encontró ningún cliente con esa membresía.");

                MoraConsultas consultaMora = new MoraConsultas();
                List<MMoraPendiente> moras = consultaMora.CargarMorasPendientes(cliente.IdCliente);

                dataGridView1.Rows.Clear();

                if (moras.Count == 0)
                    throw new Exception("Este cliente no tiene moras pendientes.");

                string codigoMembresiaTexto = "MEM-" + idMembresia.ToString("D4");
                decimal totalAcumulado = 0;

                foreach (MMoraPendiente mora in moras)
                {
                    int indiceFila = dataGridView1.Rows.Add(
                        cliente.Nombre,
                        codigoMembresiaTexto,
                        "REN-" + mora.IdRenta.ToString("D4"),
                        mora.DiasAtraso,
                        "Q" + mora.Monto.ToString("0.00")
                    );
                    dataGridView1.Rows[indiceFila].Tag = mora.IdMora;

                    totalAcumulado += mora.Monto;
                }

                totalmora.Text = "Q" + totalAcumulado.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void totalmora_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marcarpago_Click(object sender, EventArgs e)
        {
            // marca la mora seleccionada como pagada en la base de datos
            try
            {
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Tag == null)
                    throw new Exception("Selecciona una mora de la tabla para marcar su pago.");

                int idMora = (int)dataGridView1.CurrentRow.Tag;

                MoraConsultas consultaMora = new MoraConsultas();
                bool actualizado = consultaMora.MarcarMoraPagada(idMora);

                if (!actualizado)
                    throw new Exception("No se pudo marcar la mora como pagada.");

                dataGridView1.CurrentRow.Cells[4].Value = "Q0.00";

                MessageBox.Show("Mora marcada como pagada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
