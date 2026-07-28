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
            //base de datos
            Clases.Cvideos objetoVideos = new Clases.Cvideos();
            objetoVideos.mostrarVideos(dgwVideos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSlideIL_Click(object sender, EventArgs e)
        {
            if (panelV.Width == 195)
            {
                panelV.Width = 65;
            }
            else
                panelV.Width = 195;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
