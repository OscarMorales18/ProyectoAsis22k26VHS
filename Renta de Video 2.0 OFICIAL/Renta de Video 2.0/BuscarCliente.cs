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
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // busca al cliente ligado a la membresia escrita en el cuadro de texto
            try
            {
                string entrada = Codigo_Membresia.Text.Trim();

                if (string.IsNullOrWhiteSpace(entrada))
                    throw new Exception("Ingresa un código de membresía para buscar.");

                // Si el usuario escribe solo un número (ej: "1"), se auto-formatea a "MEM-0001"
                string codigoBuscado = entrada;
                if (int.TryParse(entrada, out int idNum))
                {
                    codigoBuscado = "MEM-" + idNum.ToString("D4");
                    Codigo_Membresia.Text = codigoBuscado; // Auto-completa el cuadro de texto
                }

                int idMembresia;
                if (codigoBuscado.StartsWith("MEM-", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(codigoBuscado.Substring(4), out idMembresia))
                        throw new Exception("El código de membresía no tiene un formato válido.");
                }
                else if (!int.TryParse(codigoBuscado, out idMembresia))
                {
                    throw new Exception("El código de membresía no tiene un formato válido.");
                }

                dataGridView1.Rows.Clear();

                ClienteConsultas consulta = new ClienteConsultas();
                MClienteDetalle cliente = consulta.BuscarPorMembresia(idMembresia);

                // si no aparece nada se le avisa al usuario en vez de dejar la tabla vacia sin explicar
                if (cliente == null)
                {
                    MessageBox.Show("No se encontró ningún cliente con la membresía " + codigoBuscado,
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int indiceFila = dataGridView1.Rows.Add(cliente.Nombre, cliente.Dpi, cliente.Telefono, cliente.Direccion, cliente.Correo);
                dataGridView1.Rows[indiceFila].Tag = cliente.IdCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button3_Click(object sender, EventArgs e)
        {
            // se usa CurrentRow y no SelectedRows porque la tabla no está en modo FullRowSelect,
            // asi que basta con hacer click en cualquier celda de la fila del cliente
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Tag == null)
            {
                MessageBox.Show("Selecciona un cliente de la tabla para ver su detalle.",
                                "Falta selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClienteSeleccionado = (int)dataGridView1.CurrentRow.Tag;
            AbrirFormInPanel(new DetalleCliente(idClienteSeleccionado));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistroNuevoCliente());
        }
    }
}