using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private int idClienteActual = 0;

        public DetalleCliente()
        {
            InitializeComponent();
        }

        // constructor real, se usa cuando viene desde Buscar Cliente con un cliente ya elegido
        public DetalleCliente(int idCliente) : this()
        {
            idClienteActual = idCliente;
            this.Load += DetalleCliente_Load;
        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            // precarga los datos del cliente que se buscó en el form anterior
            try
            {
                ClienteConsultas consulta = new ClienteConsultas();
                MClienteDetalle cliente = consulta.ObtenerPorId(idClienteActual);

                if (cliente == null)
                    throw new Exception("No se encontró información para este cliente.");

                NombreCompleto.Text = cliente.Nombre;
                DPI.Text = cliente.Dpi;
                Telefono.Text = cliente.Telefono;
                Dirección.Text = cliente.Direccion;
                Correo.Text = cliente.Correo;
                ContadordeRenta.Value = cliente.NoRentas;
                CodigodeMembresia.Text = cliente.IdMembresia > 0 ? "MEM-" + cliente.IdMembresia.ToString("D4") : "Sin membresía";

                si.Checked = cliente.Descuento;
                No.Checked = !cliente.Descuento;
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
            // son dos checkbox independientes pero deben comportarse como uno solo de opcion
            if (si.Checked)
                No.Checked = false;
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {
            if (No.Checked)
                si.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // valida los datos editados del cliente y los guarda en la base de datos
            try
            {
                if (idClienteActual <= 0)
                    throw new Exception("No hay un cliente cargado para guardar. Búscalo primero desde Buscar Cliente.");

                if (string.IsNullOrWhiteSpace(NombreCompleto.Text))
                    throw new Exception("El nombre completo es obligatorio.");

                string dpiLimpio = DPI.Text.Replace(" ", "");
                if (dpiLimpio.Length != 13 || !dpiLimpio.All(char.IsDigit))
                    throw new Exception("El DPI debe tener 13 dígitos numéricos.");

                string telLimpio = Telefono.Text.Replace("-", "");
                if (telLimpio.Length != 8 || !telLimpio.All(char.IsDigit))
                    throw new Exception("El teléfono debe tener 8 dígitos.");

                if (string.IsNullOrWhiteSpace(Dirección.Text))
                    throw new Exception("La dirección es obligatoria.");

                if (!Regex.IsMatch(Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Ingresa un correo electrónico válido.");

                if (string.IsNullOrWhiteSpace(CodigodeMembresia.Text))
                    throw new Exception("El código de membresía es obligatorio.");

                MClienteDetalle cambios = new MClienteDetalle
                {
                    IdCliente = idClienteActual,
                    Nombre = NombreCompleto.Text.Trim(),
                    Dpi = dpiLimpio,
                    Telefono = telLimpio,
                    Direccion = Dirección.Text.Trim(),
                    Correo = Correo.Text.Trim(),
                    NoRentas = (int)ContadordeRenta.Value,
                    Descuento = si.Checked
                };

                ClienteConsultas consulta = new ClienteConsultas();
                consulta.ActualizarCliente(cambios);

                string descuento = si.Checked ? "Sí" : "No";

                MessageBox.Show(
                    "Datos del cliente actualizados correctamente.\n" +
                    "Rentas realizadas: " + ContadordeRenta.Value + "\n" +
                    "Descuento disponible: " + descuento,
                    "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // si algo de lo de arriba falla, cae aqui y se muestra el mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void NombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
