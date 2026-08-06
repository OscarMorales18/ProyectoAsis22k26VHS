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
        private bool actualizando = false;

        public InventarioRegistro()
        {
            InitializeComponent();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventarioRegistro_Load(object sender, EventArgs e)
        {
            //genera codigo automatico - (Evelyn Andrade 9959-23-1224)
            Cvideos objetoVideo = new Cvideos();
            txtCodigo.Text = objetoVideo.generarCodigo();
            txtCodigo.Enabled = false;
            //combo
            cmbGenero.SelectedIndex = 0;
            cmbClasificacion.SelectedIndex = 0;
            //vista previa
            prevtitulo.Enabled = false;
            prevdirea.Enabled = false;
            prevco.Enabled = false;
            preves.Enabled = false;
            // Estado siempre inicia en disponible
            preves.Text = "DISPONIBLE";
        }

        // Regresar a la lista dentro del mismo panel del menú
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
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("El título no puede estar vacío.");
                txtTitulo.Focus();
                return;
            }

            if (txtTitulo.Text.Length < 2)
            {
                MessageBox.Show("El título es demasiado corto.");
                txtTitulo.Focus();
                return;
            }

            if (txtTitulo.Text.All(char.IsDigit))
            {
                MessageBox.Show("El título no puede ser solo números.");
                txtTitulo.Focus();
                return;
            }

            Cvideos objetoVideo = new Cvideos();
            if (objetoVideo.tituloExiste(txtTitulo.Text))
            {
                MessageBox.Show("Ya existe una película con ese título.");
                txtTitulo.Clear();
                txtTitulo.Focus();
                return;
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            actualizarVistaPrevia();
        }

        private void cmbGenero_Leave(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar un género.");
                cmbGenero.Focus();
                return;
            }
        }

        private void txtDirector_Leave(object sender, EventArgs e)
        {
            if (txtDirector.Text == "")
            {
                MessageBox.Show("El director no puede estar vacío.");
                txtDirector.Focus();
                return;
            }

            if (txtDirector.Text.Length < 3)
            {
                MessageBox.Show("El nombre del director es demasiado corto.");
                txtDirector.Focus();
                return;
            }

            if (txtDirector.Text.All(char.IsDigit))
            {
                MessageBox.Show("El director no puede ser solo números.");
                txtDirector.Focus();
                return;
            }

            foreach (char letra in txtDirector.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ' && letra != '.')
                {
                    MessageBox.Show("El director solo puede contener letras.");
                    txtDirector.Clear();
                    txtDirector.Focus();
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
            if (nudAnio.Value < 1888)
            {
                MessageBox.Show("El año no puede ser antes de 1888.");
                nudAnio.Value = 1888;
                nudAnio.Focus();
                return;
            }

            if (nudAnio.Value > 2025)
            {
                MessageBox.Show("El año no puede ser mayor al año actual.");
                nudAnio.Value = 2026;
                nudAnio.Focus();
                return;
            }
        }

        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {
            actualizarVistaPrevia();
        }

        //disponibilidad de copias
        private void nudCopias_Leave(object sender, EventArgs e)
        {
            if (nudCopias.Value < 1)
            {
                MessageBox.Show("Debe haber al menos 1 copia disponible.");
                nudCopias.Value = 1;
                nudCopias.Focus();
                return;
            }

            if (nudCopias.Value > 100)
            {
                MessageBox.Show("No se pueden registrar más de 100 copias.");
                nudCopias.Value = 100;
                nudCopias.Focus();
                return;
            }
        }

        private void nudCopias_ValueChanged(object sender, EventArgs e)
        {
            actualizarVistaPrevia();
        }

        // duracion de la pelicula en minutos
        private void nudDuracion_Leave(object sender, EventArgs e)
        {
            if (nudDuracion.Value < 1)
            {
                MessageBox.Show("La duración debe ser mayor a 0 minutos.");
                nudDuracion.Value = 1;
                nudDuracion.Focus();
                return;
            }
        }

        // clasificacion de la pelicula
        private void cmbClasificacion_Leave(object sender, EventArgs e)
        {
            if (cmbClasificacion.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar una clasificación.");
                cmbClasificacion.Focus();
                return;
            }
        }

        // precio de renta de la pelicula
        private void nudPrecio_Leave(object sender, EventArgs e)
        {
            if (nudPrecio.Value < 1)
            {
                MessageBox.Show("El precio debe ser mayor a Q1.00.");
                nudPrecio.Value = 1;
                nudPrecio.Focus();
                return;
            }
        }

        // actualiza vista previa en tiempo real
        private void actualizarVistaPrevia()
        {
            if (actualizando) return;

            actualizando = true;

            prevtitulo.Text = txtTitulo.Text;
            prevdirea.Text = txtDirector.Text + " - " + nudAnio.Value.ToString();
            prevco.Text = nudCopias.Value.ToString();
            preves.Text = "disponible";

            actualizando = false;
        }

        private void GuardarVideo_Click(object sender, EventArgs e)
        {
            // validar que no haya campos vacíos
            if (txtTitulo.Text == "" || txtDirector.Text == "" ||
                cmbGenero.SelectedIndex == 0 || cmbClasificacion.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor completa todos los campos antes de guardar.");
                return;
            }

            Cvideos objetoVideo = new Cvideos();

            objetoVideo.insertarVideo(
                txtCodigo.Text,
                txtTitulo.Text,
                cmbGenero.SelectedItem.ToString(),
                txtDirector.Text,
                (int)nudAnio.Value,
                nudPrecio.Value,
                (int)nudCopias.Value,
                cmbClasificacion.SelectedItem.ToString(),
                (int)nudDuracion.Value
            );

            MessageBox.Show("Video guardado correctamente.");

            // regresar al inventario
            Form menuPrincipal = Application.OpenForms["menu"];
            if (menuPrincipal is menu formMenu)
            {
                formMenu.AbrirFormInPanel(new InventarioLista());
            }
        }

        // boton cancelar , regresa al inventario
        private void btncancelari_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Seguro que quieres cancelar el registro?\nSe perderán los datos ingresados.",
        "Confirmar cancelación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                // limpiar todos los campos
                txtTitulo.Clear();
                txtDirector.Clear();
                cmbGenero.SelectedIndex = 0;
                cmbClasificacion.SelectedIndex = 0;
                nudAnio.Value = 2000;
                nudCopias.Value = 1;
                nudDuracion.Value = 1;
                nudPrecio.Value = 1;

                // limpiar vista previa
                prevtitulo.Text = "";
                prevdirea.Text = "";
                prevco.Text = "";
                preves.Text = "disponible";

                // regenerar codigo
                Cvideos objetoVideo = new Cvideos();
                txtCodigo.Text = objetoVideo.generarCodigo();
            }
        }
    }
}      