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
    public partial class InventarioRegistro : Form
    {
        private bool bActualizando = false;

        public InventarioRegistro()
        {
            InitializeComponent();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventarioRegistro_Load(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();
            txt_codigo.Text = objetoVideo.generarCodigo();
            txt_codigo.Enabled = false;

            cmb_genero.SelectedIndex = 0;
            cmb_clasificacion.SelectedIndex = 0;

            txt_previoTitulo.Enabled = false;
            txt_prevAnio.Enabled = false;
            txt_previoCopias.Enabled = false;
            txt_previoEstado.Enabled = false;

            txt_previoEstado.Text = "DISPONIBLE";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms["menu"];
            if (menuPrincipal is menu formMenu)
            {
                formMenu.AbrirFormInPanel(new InventarioLista());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txt_titulo.Text == "")
            {
                MessageBox.Show("El título no puede estar vacío.");
                txt_titulo.Focus();
                return;
            }

            if (txt_titulo.Text.Length < 2)
            {
                MessageBox.Show("El título es demasiado corto.");
                txt_titulo.Focus();
                return;
            }

            if (txt_titulo.Text.All(char.IsDigit))
            {
                MessageBox.Show("El título no puede ser solo números.");
                txt_titulo.Focus();
                return;
            }

            Cvideos objetoVideo = new Cvideos();
            if (objetoVideo.tituloExiste(txt_titulo.Text))
            {
                MessageBox.Show("Ya existe una película con ese título.");
                txt_titulo.Clear();
                txt_titulo.Focus();
                return;
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            actualizarVistaPrevia();
        }

        private void cmbGenero_Leave(object sender, EventArgs e)
        {
            if (cmb_genero.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar un género.");
                cmb_genero.Focus();
                return;
            }
        }

        private void txtDirector_Leave(object sender, EventArgs e)
        {
            if (txt_director.Text == "")
            {
                MessageBox.Show("El director no puede estar vacío.");
                txt_director.Focus();
                return;
            }

            if (txt_director.Text.Length < 3)
            {
                MessageBox.Show("El nombre del director es demasiado corto.");
                txt_director.Focus();
                return;
            }

            if (txt_director.Text.All(char.IsDigit))
            {
                MessageBox.Show("El director no puede ser solo números.");
                txt_director.Focus();
                return;
            }

            foreach (char letra in txt_director.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ' && letra != '.')
                {
                    MessageBox.Show("El director solo puede contener letras.");
                    txt_director.Clear();
                    txt_director.Focus();
                    return;
                }
            }
        }

        private void txtDirector_TextChanged(object sender, EventArgs e)
        {
            actualizarVistaPrevia();
        }

        //ingresar año pelicula
        private void nudAnio_Leave(object sender, EventArgs e)
        {
            if (nud_anio.Value < 1888)
            {
                MessageBox.Show("El año no puede ser antes de 1888.");
                nud_anio.Value = 1888;
                nud_anio.Focus();
                return;
            }

            if (nud_anio.Value > 2025)
            {
                MessageBox.Show("El año no puede ser mayor al año actual.");
                nud_anio.Value = 2026;
                nud_anio.Focus();
                return;
            }
        }

        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {
            actualizarVistaPrevia();
        }

        private void nudCopias_Leave(object sender, EventArgs e)
        {
            if (nud_copias.Value < 1)
            {
                MessageBox.Show("Debe haber al menos 1 copia disponible.");
                nud_copias.Value = 1;
                nud_copias.Focus();
                return;
            }

            if (nud_copias.Value > 100)
            {
                MessageBox.Show("No se pueden registrar más de 100 copias.");
                nud_copias.Value = 100;
                nud_copias.Focus();
                return;
            }
        }

        private void nudCopias_ValueChanged(object sender, EventArgs e)
        {
            actualizarVistaPrevia();
        }

        private void nudDuracion_Leave(object sender, EventArgs e)
        {
            if (nud_duracion.Value < 1)
            {
                MessageBox.Show("La duración debe ser mayor a 0 minutos.");
                nud_duracion.Value = 1;
                nud_duracion.Focus();
                return;
            }
        }

        private void cmbClasificacion_Leave(object sender, EventArgs e)
        {
            if (cmb_clasificacion.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar una clasificación.");
                cmb_clasificacion.Focus();
                return;
            }
        }

        private void nudPrecio_Leave(object sender, EventArgs e)
        {
            if (nud_precio.Value < 1)
            {
                MessageBox.Show("El precio debe ser mayor a Q1.00.");
                nud_precio.Value = 1;
                nud_precio.Focus();
                return;
            }
        }

        private void actualizarVistaPrevia()
        {
            if (bActualizando) return;

            bActualizando = true;

            txt_previoTitulo.Text = txt_titulo.Text;
            txt_prevAnio.Text = txt_director.Text + " - " + nud_anio.Value.ToString();
            txt_previoCopias.Text = nud_copias.Value.ToString();
            txt_previoEstado.Text = "disponible";

            bActualizando = false;
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult dlgRespuesta = MessageBox.Show(
        "¿Seguro que quieres cancelar el registro?\nSe perderán los datos ingresados.",
        "Confirmar cancelación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (dlgRespuesta == DialogResult.Yes)
            {
                // limpiar todos los campos
                txt_titulo.Clear();
                txt_director.Clear();
                cmb_genero.SelectedIndex = 0;
                cmb_clasificacion.SelectedIndex = 0;
                nud_anio.Value = 2000;
                nud_copias.Value = 1;
                nud_duracion.Value = 1;
                nud_precio.Value = 1;

                // limpiar vista previa
                txt_previoTitulo.Text = "";
                txt_prevAnio.Text = "";
                txt_previoCopias.Text = "";
                txt_previoEstado.Text = "disponible";

                // regenerar codigo
                Cvideos objetoVideo = new Cvideos();
                txt_codigo.Text = objetoVideo.generarCodigo();
            }
        }

        private void OnGuardar_Video_Click(object sender, EventArgs e)
        {
            // validar que no haya campos vacíos
            if (txt_titulo.Text == "" || txt_director.Text == "" ||
                cmb_genero.SelectedIndex == 0 || cmb_clasificacion.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor completa todos los campos antes de guardar.");
                return;
            }

            Cvideos objetoVideo = new Cvideos();

            objetoVideo.insertarVideo(
                txt_codigo.Text,
                txt_titulo.Text,
                cmb_genero.SelectedItem.ToString(),
                txt_director.Text,
                (int)nud_anio.Value,
                nud_precio.Value,
                (int)nud_copias.Value,
                cmb_clasificacion.SelectedItem.ToString(),
                (int)nud_duracion.Value
            );

            MessageBox.Show("Video guardado correctamente.");

            // regresar al inventario
            Form menuPrincipal = Application.OpenForms["menu"];
            if (menuPrincipal is menu formMenu)
            {
                formMenu.AbrirFormInPanel(new InventarioLista());
            }
        }
    }
}      