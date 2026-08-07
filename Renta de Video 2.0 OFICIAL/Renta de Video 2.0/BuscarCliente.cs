using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Renta_de_Video_2._0.Clases;
using Renta_de_Video_2._0.Resources;

namespace Renta_de_Video_2._0
{
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();

            if (SesionUsuario.Rol == "Empleado")
            {
                btn_registro.Visible = false;
                btn_detalleCliente.Visible = false;
            }
        }

        //abrir al menu
        private void AbrirFormInPanel(Form formulario)
        {
            menu menuPrincipal = Application.OpenForms.OfType<menu>().FirstOrDefault();

            if (menuPrincipal != null)
            {
                menuPrincipal.AbrirFormInPanel(formulario);
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void Codigo_Membresia_TextChanged(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panelContenedor_Paint(object sender, PaintEventArgs e) { }

        private void OnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string sEntrada = txt_codigoMembresia.Text.Trim();

                if (string.IsNullOrWhiteSpace(sEntrada))
                    throw new Exception("Ingresa un código de membresía para buscar.");

                string sCodigoBuscado = sEntrada;
                if (int.TryParse(sEntrada, out int iIdNum))
                {
                    sCodigoBuscado = "MEM-" + iIdNum.ToString("D4");
                    txt_codigoMembresia.Text = sCodigoBuscado;
                }

                int iIdMembresia;
                if (sCodigoBuscado.StartsWith("MEM-", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(sCodigoBuscado.Substring(4), out iIdMembresia))
                        throw new Exception("El código de membresía no tiene un formato válido.");
                }
                else if (!int.TryParse(sCodigoBuscado, out iIdMembresia))
                {
                    throw new Exception("El código de membresía no tiene un formato válido.");
                }

                dgv_cliente.Rows.Clear();

                ClienteConsultas objConsulta = new ClienteConsultas();
                MClienteDetalle objCliente = objConsulta.BuscarPorMembresia(iIdMembresia);

                if (objCliente == null)
                {
                    MessageBox.Show("No se encontró ningún cliente con la membresía " + sCodigoBuscado,
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int iIndiceFila = dgv_cliente.Rows.Add(objCliente.Nombre, objCliente.Dpi, objCliente.Telefono, objCliente.Direccion, objCliente.Correo);
                dgv_cliente.Rows[iIndiceFila].Tag = objCliente.IdCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void On_Registro(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistroNuevoCliente());
        }

        private void On_Detalle(object sender, EventArgs e)
        {
            if (dgv_cliente.CurrentRow == null || dgv_cliente.CurrentRow.Tag == null)
            {
                MessageBox.Show("Selecciona un cliente de la tabla para ver su detalle.",
                                "Falta selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int iIdClienteSeleccionado = (int)dgv_cliente.CurrentRow.Tag;
            AbrirFormInPanel(new DetalleCliente(iIdClienteSeleccionado));
        }
    }
}