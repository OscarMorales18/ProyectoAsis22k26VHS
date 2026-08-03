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
    public partial class InventarioLista : Form
    {
        public InventarioLista()
        {
            InitializeComponent();
            //base de datos  (Evelyn Andrade 9959-23-1224)
            Clases.Cvideos objetoVideos = new Clases.Cvideos();
            objetoVideos.mostrarVideos(dgwVideo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        // llenado de texbox - (Evelyn Andrade 9959-23-1224)
        private void dgwVideo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwVideo.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgwVideo.SelectedRows[0];

                txtCodigo.Text = fila.Cells["codigo"].Value.ToString();
                txtTitulo.Text = fila.Cells["titulo"].Value.ToString();
                txtGenero.Text = fila.Cells["genero"].Value.ToString();
                txtDirector.Text = fila.Cells["director"].Value.ToString();
                txtAnio.Text = fila.Cells["anio"].Value.ToString();
                txtCopias.Text = fila.Cells["stock"].Value.ToString();
                txtEstado.Text = fila.Cells["estado"].Value.ToString();
            }
        }

        //(Evelyn Andrade 9959-23-1224)
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();
            objetoVideo.buscarVideo(dgwVideo, txtBuscar.Text);
            actualizarConteo(); //conteo videos
        }

        //comboBox para filtrar por CLASIFICACION (Evelyn Andrade 9959-23-1224)
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();

            if (cmbClasificacion.SelectedItem.ToString() == "clasificacion")
            {
                objetoVideo.mostrarVideos(dgwVideo);
            }
            else
            {
                objetoVideo.filtrarPorClasificacion(dgwVideo, cmbClasificacion.SelectedItem.ToString());
                actualizarConteo();
            }
        }

        private void InventarioLista_Load(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();
            objetoVideo.mostrarVideos(dgwVideo);
            // contador de videos (Evelyn Andrade 9959-23-1224)
            actualizarConteo();

            cmbClasificacion.SelectedIndex = 0;
            cmbGenero.SelectedIndex = 0;

            //texbox desabilitados  (Evelyn Andrade 9959-23-1224)
            txtCodigo.Enabled = false;
            txtTitulo.Enabled = false;
            txtGenero.Enabled = false;
            txtDirector.Enabled = false;
            txtAnio.Enabled = false;
            txtCopias.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();

            if (cmbGenero.SelectedItem.ToString() == "Todos los géneros")
            {
                objetoVideo.mostrarVideos(dgwVideo);
            }
            else
            {
                objetoVideo.filtrarPorGenero(dgwVideo, cmbGenero.SelectedItem.ToString());
                actualizarConteo();
            }
        }

        //actualizar el conteo de videos mostrados (Evelyn Andrade 9959-23-1224)
        private void actualizarConteo()
        {
            int total = dgwVideo.Rows.Count - 1;
            lblConteo.Text = "MOSTRANDO " + total + " VIDEOS";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtTitulo.Enabled = true;
            txtGenero.Enabled = true;
            txtDirector.Enabled = true;
            txtAnio.Enabled = true;
            txtCopias.Enabled = true;
            txtEstado.Enabled = true;
            //visibilidad
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
        }

        //boton guardar cambios Evelyn Andrade 9959-23-1224
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();

            objetoVideo.editarVideo(
                txtCodigo.Text,
                txtTitulo.Text,
                txtGenero.Text,
                txtDirector.Text,
                int.Parse(txtAnio.Text),
                int.Parse(txtCopias.Text),
                txtEstado.Text
            );

            MessageBox.Show("Video actualizado correctamente.");

            txtCodigo.Enabled = false;
            txtTitulo.Enabled = false;
            txtGenero.Enabled = false;
            txtDirector.Enabled = false;
            txtAnio.Enabled = false;
            txtCopias.Enabled = false;
            txtEstado.Enabled = false;

            btnGuardar.Visible = false;
            btnEditar.Visible = true;

            objetoVideo.mostrarVideos(dgwVideo);
            actualizarConteo();
        }

        //boton eliminar video Evelyn Sofia Andrade Luna 9959-23-1224
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecciona un video primero.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que quieres eliminar el video " + txtTitulo.Text + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Cvideos objetoVideo = new Cvideos();
                objetoVideo.eliminarVideo(txtCodigo.Text);

                MessageBox.Show("Video eliminado correctamente.");

                txtCodigo.Text = "";
                txtTitulo.Text = "";
                txtGenero.Text = "";
                txtDirector.Text = "";
                txtAnio.Text = "";
                txtCopias.Text = "";
                txtEstado.Text = "";

                objetoVideo.mostrarVideos(dgwVideo);
                actualizarConteo();
            }
        }

        //abre form InventarioRegistro Evelyn Andrade 9959-23-1224
        private void btnNuevoVideo_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms["menu"];
            if (menuPrincipal is menu formMenu)
            {
                formMenu.AbrirFormInPanel(new InventarioRegistro());
            }
        }

        private void lblConteo_Click(object sender, EventArgs e)
        {

        }
    }
}