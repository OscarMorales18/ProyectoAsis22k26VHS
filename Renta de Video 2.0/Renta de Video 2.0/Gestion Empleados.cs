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
    public partial class Gestion_Empleados : Form
    {
        public Gestion_Empleados()
        {
            InitializeComponent();
        }
        private void Gestion_Empleados_Load(object sender, EventArgs e)
        {
            cmbRol.Items.AddRange(new string[] { "Admin", "Empleado" });
            cmbEstado.Items.AddRange(new string[] { "Activo", "Inactivo" });

            dataGridView1.Rows.Add("U001", "Andre Gonzalez", "agonzalez", "Admin", "Activo");
            dataGridView1.Rows.Add("U002", "Karla Ruiz", "kruiz", "Empleado", "Activo");
        }

        // metodo compartido para no repetir las mismas validaciones en cada boton
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(usu.Text))
                throw new Exception("El usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(contra.Text))
                throw new Exception("La contraseña es obligatoria.");
            if (string.IsNullOrWhiteSpace(NombreCompleto.Text))
                throw new Exception("El nombre completo es obligatorio.");
            if (cmbRol.SelectedItem == null)
                throw new Exception("Selecciona un rol.");
            if (cmbEstado.SelectedItem == null)
                throw new Exception("Selecciona un estado.");
            return true;
        }

        

        private void usu_TextChanged(object sender, EventArgs e)
        {

        }

        private void contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            // valida los campos y agrega el nuevo usuario a la tabla
            try
            {
                ValidarCampos();
                string nuevoCodigo = "U" + (dataGridView1.Rows.Count + 1).ToString("D3");
                dataGridView1.Rows.Add(nuevoCodigo, NombreCompleto.Text, usu.Text, cmbRol.Text, cmbEstado.Text);
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // si ValidarCampos lanza el error, se atrapa aqui
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void editar_Click(object sender, EventArgs e)
        {
            // exige una fila seleccionada, valida los campos y actualiza esa fila
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para editar.");

                ValidarCampos();
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                fila.Cells[1].Value = NombreCompleto.Text;
                fila.Cells[2].Value = usu.Text;
                fila.Cells[3].Value = cmbRol.Text;
                fila.Cells[4].Value = cmbEstado.Text;

                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // atrapa la falta de seleccion o cualquier error de ValidarCampos
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            // pide confirmacion antes de borrar la fila seleccionada
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para eliminar.");

                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
            }
            // por si no hay fila seleccionada
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // valida antes de confirmar que los cambios quedaron guardados
            try
            {
                ValidarCampos();
                MessageBox.Show("Los cambios se guardaron correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
