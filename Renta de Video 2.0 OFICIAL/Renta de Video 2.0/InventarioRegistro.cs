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
        public InventarioRegistro()
        {
            InitializeComponent();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventarioRegistro_Load(object sender, EventArgs e)
        {

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
    }
}