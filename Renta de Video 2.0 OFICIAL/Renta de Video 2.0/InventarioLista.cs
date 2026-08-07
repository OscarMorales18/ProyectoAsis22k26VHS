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
            Clases.Cvideos objetoVideo = new Clases.Cvideos();
            objetoVideo.mostrarVideos(dgv_video);
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
            if (dgv_video.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv_video.SelectedRows[0];

                txt_codigo.Text = fila.Cells["codigo"].Value.ToString();
                txt_titulo.Text = fila.Cells["titulo"].Value.ToString();
                txt_genero.Text = fila.Cells["genero"].Value.ToString();
                txt_director.Text = fila.Cells["director"].Value.ToString();
                txt_anio.Text = fila.Cells["anio"].Value.ToString();
                txt_copias.Text = fila.Cells["stock"].Value.ToString();
                txt_estado.Text = fila.Cells["estado"].Value.ToString();
            }
        }

        //(Evelyn Andrade 9959-23-1224)
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();
            objetoVideo.buscarVideo(dgv_video, txt_buscar.Text);
            actualizarConteo(); //conteo videos
        }

        //comboBox para filtrar por CLASIFICACION (Evelyn Andrade 9959-23-1224)
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();

            if (cmb_clasificacion.SelectedItem.ToString() == "clasificacion")
            {
                objetoVideo.mostrarVideos(dgv_video);
            }
            else
            {
                objetoVideo.filtrarPorClasificacion(dgv_video, cmb_clasificacion.SelectedItem.ToString());
                actualizarConteo();
            }
        }

        private void InventarioLista_Load(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();
            objetoVideo.mostrarVideos(dgv_video);
            // contador de videos (Evelyn Andrade 9959-23-1224)
            actualizarConteo();

            cmb_clasificacion.SelectedIndex = 0;
            cmb_genero.SelectedIndex = 0;

            //texbox desabilitados  (Evelyn Andrade 9959-23-1224)
            txt_codigo.Enabled = false;
            txt_titulo.Enabled = false;
            txt_genero.Enabled = false;
            txt_director.Enabled = false;
            txt_anio.Enabled = false;
            txt_copias.Enabled = false;
            txt_estado.Enabled = false;
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();

            if (cmb_genero.SelectedItem.ToString() == "Todos los géneros")
            {
                objetoVideo.mostrarVideos(dgv_video);
            }
            else
            {
                objetoVideo.filtrarPorGenero(dgv_video, cmb_genero.SelectedItem.ToString());
                actualizarConteo();
            }
        }

        private void actualizarConteo()
        {
            int total = dgv_video.Rows.Count - 1;
            lblConteo.Text = "MOSTRANDO " + total + " VIDEOS";
        }


        private void lblConteo_Click(object sender, EventArgs e)
        {

        }

        private void OnGuardar_Click(object sender, EventArgs e)
        {
            Cvideos objetoVideo = new Cvideos();

            objetoVideo.editarVideo(
                txt_codigo.Text,
                txt_titulo.Text,
                txt_genero.Text,
                txt_director.Text,
                int.Parse(txt_anio.Text),
                int.Parse(txt_copias.Text),
                txt_estado.Text
            );

            MessageBox.Show("Video actualizado correctamente.");

            txt_codigo.Enabled = false;
            txt_titulo.Enabled = false;
            txt_genero.Enabled = false;
            txt_director.Enabled = false;
            txt_anio.Enabled = false;
            txt_copias.Enabled = false;
            txt_estado.Enabled = false;

            btn_guardar.Visible = false;
            btn_editar.Visible = true;

            objetoVideo.mostrarVideos(dgv_video);
            actualizarConteo();
        }

        private void OnEditar_Click(object sender, EventArgs e)
        {
            txt_titulo.Enabled = true;
            txt_genero.Enabled = true;
            txt_director.Enabled = true;
            txt_anio.Enabled = true;
            txt_copias.Enabled = true;
            txt_estado.Enabled = true;
            //visibilidad
            btn_guardar.Visible = true;
            btn_editar.Visible = false;
        }

        private void OnEliminar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Selecciona un video primero.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que quieres eliminar el video " + txt_titulo.Text + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Cvideos objetoVideo = new Cvideos();
                bool seElimino = objetoVideo.eliminarVideo(txt_codigo.Text);

                if (seElimino)
                    MessageBox.Show("Video eliminado correctamente.");

                txt_codigo.Text = "";
                txt_titulo.Text = "";
                txt_genero.Text = "";
                txt_director.Text = "";
                txt_anio.Text = "";
                txt_copias.Text = "";
                txt_estado.Text = "";

                objetoVideo.mostrarVideos(dgv_video);
                actualizarConteo();
            }
        }

        private void OnNuevoVideo_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms["menu"];
            if (menuPrincipal is menu formMenu)
            {
                formMenu.AbrirFormInPanel(new InventarioRegistro());
            }
        }
    }
    
}