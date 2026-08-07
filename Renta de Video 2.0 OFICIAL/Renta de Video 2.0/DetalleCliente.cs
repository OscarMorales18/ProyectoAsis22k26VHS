using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Renta_de_Video_2._0.Clases;

namespace Renta_de_Video_2._0
{
    public partial class DetalleCliente : Form
    {
        private int _iIdClienteActual = 0;

        public DetalleCliente()
        {
            InitializeComponent();
        }

        public DetalleCliente(int idCliente) : this()
        {
            _iIdClienteActual = idCliente;
            this.Load += DetalleCliente_Load;
        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteConsultas objConsulta = new ClienteConsultas();
                MClienteDetalle objCliente = objConsulta.ObtenerPorId(_iIdClienteActual);

                if (objCliente == null)
                    throw new Exception("No se encontró información para este cliente.");

                txt_nombreCompleto.Text = objCliente.Nombre;
                txt_dpi.Text = objCliente.Dpi;
                txt_telefono.Text = objCliente.Telefono;
                txt_direccion.Text = objCliente.Direccion;
                txt_correo.Text = objCliente.Correo;
                contadordeRenta.Value = objCliente.NoRentas;
                txt_codigoMembresia.Text = objCliente.IdMembresia > 0 ? "MEM-" + objCliente.IdMembresia.ToString("D4") : "Sin membresía";

                chk_si.Checked = objCliente.Descuento;
                chk_no.Checked = !objCliente.Descuento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigodeMembresia_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContadordeRenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void si_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_si.Checked)
                chk_no.Checked = false;
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_no.Checked)
                chk_si.Checked = false;
        }

        private void NombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iIdClienteActual <= 0)
                    throw new Exception("No hay un cliente cargado para guardar. Búscalo primero desde Buscar Cliente.");

                if (string.IsNullOrWhiteSpace(txt_nombreCompleto.Text))
                    throw new Exception("El nombre completo es obligatorio.");

                string sDpiLimpio = txt_dpi.Text.Replace(" ", "");
                if (sDpiLimpio.Length != 13 || !sDpiLimpio.All(char.IsDigit))
                    throw new Exception("El DPI debe tener 13 dígitos numéricos.");

                string sTelLimpio = txt_telefono.Text.Replace("-", "");
                if (sTelLimpio.Length != 8 || !sTelLimpio.All(char.IsDigit))
                    throw new Exception("El teléfono debe tener 8 dígitos.");

                if (string.IsNullOrWhiteSpace(txt_direccion.Text))
                    throw new Exception("La dirección es obligatoria.");

                if (!Regex.IsMatch(txt_correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Ingresa un correo electrónico válido.");

                if (string.IsNullOrWhiteSpace(txt_codigoMembresia.Text))
                    throw new Exception("El código de membresía es obligatorio.");

                MClienteDetalle objCambios = new MClienteDetalle
                {
                    IdCliente = _iIdClienteActual,
                    Nombre = txt_nombreCompleto.Text.Trim(),
                    Dpi = sDpiLimpio,
                    Telefono = sTelLimpio,
                    Direccion = txt_direccion.Text.Trim(),
                    Correo = txt_correo.Text.Trim(),
                    NoRentas = (int)contadordeRenta.Value,
                    Descuento = chk_si.Checked
                };

                ClienteConsultas objConsulta = new ClienteConsultas();
                objConsulta.ActualizarCliente(objCambios);

                string sDescuento = chk_si.Checked ? "Sí" : "No";

                MessageBox.Show(
                    "Datos del cliente actualizados correctamente.\n" +
                    "Rentas realizadas: " + contadordeRenta.Value + "\n" +
                    "Descuento disponible: " + sDescuento,
                    "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
