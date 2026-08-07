using Renta_de_Video_2._0.Clases;
using System;
using System.Windows.Forms;

namespace Renta_de_Video_2._0
{
    public partial class Auditoria : Form
    {
        public Auditoria()
        {
            InitializeComponent();
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            Cauditoria objAuditoria = new Cauditoria();
            objAuditoria.MostrarAuditoria(dgv_auditoria);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cauditoria objAuditoria = new Cauditoria();
            objAuditoria.BuscarAuditoria(dgv_auditoria, txt_buscar.Text.Trim());
        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnRefrescar_Click(object sender, EventArgs e)
        {
            Cauditoria objAuditoria = new Cauditoria();
            objAuditoria.MostrarAuditoria(dgv_auditoria);
            txt_buscar.Clear();
        }
    }
}