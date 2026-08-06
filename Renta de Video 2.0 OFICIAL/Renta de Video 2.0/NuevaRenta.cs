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
    public partial class NuevaRenta : Form
    {
        private MClienteRenta clienteSeleccionado = null;
        private List<MVideoCatalogo> catalogoVideos = new List<MVideoCatalogo>();

        public NuevaRenta()
        {
            InitializeComponent();

            this.Load += NuevaRenta_Load;
            checkBox1.CheckedChanged += Checkbox_CheckedChanged;
            checkBox2.CheckedChanged += Checkbox_CheckedChanged;
            checkBox3.CheckedChanged += Checkbox_CheckedChanged;
            checkBox4.CheckedChanged += Checkbox_CheckedChanged;
        }

        private void NuevaRenta_Load(object sender, EventArgs e)
        {
            RentaConsultas consultas = new RentaConsultas();
            catalogoVideos = consultas.CargarCatalogo(4);

            CheckBox[] checkboxes = { checkBox1, checkBox2, checkBox3, checkBox4 };
            Label[] labelsTitulo = { label5, label9, label16, label1 };
            Label[] labelsInfo = { label2, label15, label17, label3 };

            for (int i = 0; i < checkboxes.Length; i++)
            {
                if (i < catalogoVideos.Count)
                {
                    MVideoCatalogo video = catalogoVideos[i];
                    labelsTitulo[i].Text = video.Titulo;
                    labelsInfo[i].Text = video.Genero + " - Q" + video.PrecioRenta.ToString("0.00");
                    checkboxes[i].Tag = video;
                }
                else
                {
                    checkboxes[i].Enabled = false;
                    labelsTitulo[i].Text = "No disponible";
                    labelsInfo[i].Text = "";
                }
            }
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            decimal nuevoSubtotal = 0;
            CheckBox[] checkboxes = { checkBox1, checkBox2, checkBox3, checkBox4 };

            foreach (CheckBox chk in checkboxes)
            {
                if (chk.Checked && chk.Tag is MVideoCatalogo video)
                    nuevoSubtotal += video.PrecioRenta;
            }

            Subtotal.Text = "Q" + nuevoSubtotal.ToString("0.00");
            totalapagar.Text = "Q" + nuevoSubtotal.ToString("0.00");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void membresia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
            // validamos el codigo antes de ir a la base
                string codigoTexto = membresia.Text.Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(codigoTexto))
                throw new Exception("Ingresa un código de membresía.");

            string numeroTexto = codigoTexto.Replace("MEM-", "");

                if (!int.TryParse(numeroTexto, out int idMembresia))
                    throw new Exception("El código de membresía no es válido.");

                RentaConsultas consultas = new RentaConsultas();
            clienteSeleccionado = consultas.BuscarClientePorMembresia(idMembresia);

                if (clienteSeleccionado == null)
                    throw new Exception("No se encontró ningún cliente con ese código de membresía.");

                MessageBox.Show("Cliente encontrado: " + clienteSeleccionado.Nombre,
                    "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // si algo sale mal mostramos el mensaje
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RentaFactura_Click(object sender, EventArgs e)
        {
            try
            {
                // aca armamos la renta con lo que el usuario marco
                if (clienteSeleccionado == null)
                throw new Exception("Primero busca un cliente por su código de membresía.");

                List<MVideoCatalogo> seleccionados = new List<MVideoCatalogo>();
            CheckBox[] checkboxes = { checkBox1, checkBox2, checkBox3, checkBox4 };

                foreach (CheckBox chk in checkboxes)
                {
                        if (chk.Checked && chk.Tag is MVideoCatalogo video)
                    seleccionados.Add(video);
                }

                if (seleccionados.Count == 0)
                    throw new Exception("Selecciona al menos una película para rentar.");

                decimal totalCalculado = 0;
                foreach (MVideoCatalogo video in seleccionados)
                totalCalculado += video.PrecioRenta;

                DateTime fechaHoy = DateTime.Now;
            DateTime fechaDevolucion = fechaHoy.AddDays(3);

                RentaConsultas consultas = new RentaConsultas();
                bool rentaGuardada = consultas.RegistrarRenta(clienteSeleccionado.IdCliente, seleccionados, fechaHoy, fechaDevolucion, totalCalculado, totalCalculado);

                if (!rentaGuardada)
                    throw new Exception("No se pudo generar la factura en la base de datos.");

                fencharent.Text = fechaHoy.ToString("dd/MM/yyyy");
                fechalim.Text = fechaDevolucion.ToString("dd/MM/yyyy");
            Subtotal.Text = "Q" + totalCalculado.ToString("0.00");
                totalapagar.Text = "Q" + totalCalculado.ToString("0.00");

                MessageBox.Show("Renta registrada y factura generada correctamente.",
                    "Renta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // atrapamos cualquier fallo al guardar
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fencharent_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechalim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalapagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pelicula1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pelicula2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pelicula3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pelicula4_Paint(object sender, PaintEventArgs e)
        {

        }

        // solo abre el form de Devolucion, sin pasar datos
        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Devolucion());
        }

        private void AbrirFormInPanel(Form formulario)
        {
            menu menuPrincipal = Application.OpenForms.OfType<menu>().FirstOrDefault();

            if (menuPrincipal != null)
            {
                menuPrincipal.AbrirFormInPanel(formulario);
            }
        }
    }
}
