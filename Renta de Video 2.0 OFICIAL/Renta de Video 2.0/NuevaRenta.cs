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
    // Inicio de código de "André De Jesús González Camey" con carné: "9959-23-3117" en la fecha de: "03/08/2026"
    public partial class NuevaRenta : Form
    {
        private MClienteRenta _clienteSeleccionado = null;
        private List<MVideoCatalogo> _lst_catalogoVideos = new List<MVideoCatalogo>();

        public NuevaRenta()
        {
            InitializeComponent();

            this.Load += NuevaRenta_Load;
            chk_1.CheckedChanged += Checkbox_CheckedChanged;
            chk_2.CheckedChanged += Checkbox_CheckedChanged;
            chk_3.CheckedChanged += Checkbox_CheckedChanged;
            chk_4.CheckedChanged += Checkbox_CheckedChanged;
        }

        private void NuevaRenta_Load(object sender, EventArgs e)
        {
            RentaConsultas consultas = new RentaConsultas();
            _lst_catalogoVideos = consultas.CargarCatalogo(4);

            CheckBox[] arr_checkboxes = { chk_1, chk_2, chk_3, chk_4 };
            Label[] arr_labelsTitulo = { label5, label9, label16, label1 };
            Label[] arr_labelsInfo = { label2, label15, label17, label3 };

            for (int i = 0; i < arr_checkboxes.Length; i++)
            {
                if (i < _lst_catalogoVideos.Count)
                {
                    MVideoCatalogo video = _lst_catalogoVideos[i];
                    arr_labelsTitulo[i].Text = video.Titulo;
                    arr_labelsInfo[i].Text = video.Genero + " - Q" + video.PrecioRenta.ToString("0.00");
                    arr_checkboxes[i].Tag = video;
                }
                else
                {
                    arr_checkboxes[i].Enabled = false;
                    arr_labelsTitulo[i].Text = "No disponible";
                    arr_labelsInfo[i].Text = "";
                }
            }
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            decimal deNuevoSubtotal = 0;
            CheckBox[] arr_checkboxes = { chk_1, chk_2, chk_3, chk_4 };

            foreach (CheckBox chk in arr_checkboxes)
            {
                if (chk.Checked && chk.Tag is MVideoCatalogo video)
                    deNuevoSubtotal += video.PrecioRenta;
            }

            txt_subtotal.Text = "Q" + deNuevoSubtotal.ToString("0.00");
            txt_totalapagar.Text = "Q" + deNuevoSubtotal.ToString("0.00");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void membresia_TextChanged(object sender, EventArgs e)
        {

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


        private void AbrirFormInPanel(Form formulario)
        {
            menu menuPrincipal = Application.OpenForms.OfType<menu>().FirstOrDefault();

            if (menuPrincipal != null)
            {
                menuPrincipal.AbrirFormInPanel(formulario);
            }
        }

        private void OnDevolucion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Devolucion());
        }

        private void OnRenta_Factura_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteSeleccionado == null)
                    throw new Exception("Primero busca un cliente por su código de membresía.");

                List<MVideoCatalogo> lst_seleccionados = new List<MVideoCatalogo>();
                CheckBox[] arr_checkboxes = { chk_1, chk_2, chk_3, chk_4 };

                foreach (CheckBox chk in arr_checkboxes)
                {
                    if (chk.Checked && chk.Tag is MVideoCatalogo video)
                        lst_seleccionados.Add(video);
                }

                if (lst_seleccionados.Count == 0)
                    throw new Exception("Selecciona al menos una película para rentar.");

                decimal deTotalCalculado = 0;
                foreach (MVideoCatalogo video in lst_seleccionados)
                    deTotalCalculado += video.PrecioRenta;

                DateTime dFechaHoy = DateTime.Now;
                DateTime dFechaDevolucion = dFechaHoy.AddDays(3);

                RentaConsultas consultas = new RentaConsultas();
                bool bRentaGuardada = consultas.RegistrarRenta(_clienteSeleccionado.IdCliente, lst_seleccionados, dFechaHoy, dFechaDevolucion, deTotalCalculado, deTotalCalculado);

                if (!bRentaGuardada)
                    throw new Exception("No se pudo generar la factura en la base de datos.");

                txt_fechaRenta.Text = dFechaHoy.ToString("dd/MM/yyyy");
                txt_fechaLimite.Text = dFechaDevolucion.ToString("dd/MM/yyyy");
                txt_subtotal.Text = "Q" + deTotalCalculado.ToString("0.00");
                txt_totalapagar.Text = "Q" + deTotalCalculado.ToString("0.00");

                MessageBox.Show("Renta registrada y factura generada correctamente.",
                    "Renta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnBuscar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string sCodigoTexto = txt_membresia.Text.Trim().ToUpper();

                    if (string.IsNullOrWhiteSpace(sCodigoTexto))
                        throw new Exception("Ingresa un código de membresía.");

                    string sNumeroTexto = sCodigoTexto.Replace("MEM-", "");

                    if (!int.TryParse(sNumeroTexto, out int iIdMembresia))
                        throw new Exception("El código de membresía no es válido.");

                    RentaConsultas consultas = new RentaConsultas();
                    _clienteSeleccionado = consultas.BuscarClientePorMembresia(iIdMembresia);

                    if (_clienteSeleccionado == null)
                        throw new Exception("No se encontró ningún cliente con ese código de membresía.");

                    MessageBox.Show("Cliente encontrado: " + _clienteSeleccionado.Nombre,
                        "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void OnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Fin de código de "André De Jesús González Camey" con carné: "9959-23-3117" en la fecha de: "03/08/2026"
    }

}
