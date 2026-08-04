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
            Cauditoria auditoria = new Cauditoria();
            auditoria.MostrarAuditoria(dgvAuditoria);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cauditoria auditoria = new Cauditoria();
            auditoria.BuscarAuditoria(dgvAuditoria, txtBuscar.Text.Trim());
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cauditoria auditoria = new Cauditoria();
            auditoria.MostrarAuditoria(dgvAuditoria);
            txtBuscar.Clear();
        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}