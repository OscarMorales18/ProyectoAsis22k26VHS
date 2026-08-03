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
    public partial class Gestion_Empleados : Form
    {
        private List<Cusuario> mUsuarios;
        private Cusuario mUsuario;
        private CusuarioCRUD mUsuariosCRUD;
        public Gestion_Empleados()
        {
            InitializeComponent();
            mUsuarios = new List<Cusuario>();
            mUsuariosCRUD = new CusuarioCRUD();

            cargarUsuarios();
        }

        private void cargarUsuarios(string filtro = "")
        {
            dvgUsuarios.Rows.Clear();
            dvgUsuarios.Refresh();
            mUsuarios.Clear();
            mUsuarios = mUsuariosCRUD.getUsuarios(filtro);

            mUsuario = new Cusuario(); 

            for (int i = 0; i < mUsuarios.Count(); i++)
            {
                dvgUsuarios.RowTemplate.Height = 20;
                // Convertir valores a string al añadir a columnas tipo texto para evitar InvalidCastException
                dvgUsuarios.Rows.Add(
                    mUsuarios[i].id.ToString(),
                    mUsuarios[i].usuario ?? string.Empty,
                    mUsuarios[i].contrasena ?? string.Empty,
                    mUsuarios[i].id_empleado.ToString(),
                    mUsuarios[i].rol ?? string.Empty,
                    mUsuarios[i].estado.ToString());
            }
        }

        private void Gestion_Empleados_Load(object sender, EventArgs e)
        {
            cmbRol.Items.AddRange(new string[] { "Admin", "Empleado" });
            cmbEstado.Items.AddRange(new string[] { "Activo", "Inactivo" });

            // Añadir filas de ejemplo con el orden correcto de columnas: Codigo, Usuario, Contraseña, Id_Empleado, Rol, Estado
            dvgUsuarios.Rows.Add("U001", "Andre Gonzalez", "agonzalez", "1", "Admin", "Activo");
            dvgUsuarios.Rows.Add("U002", "Karla Ruiz", "kruiz", "2", "Empleado", "Activo");
        }

        // metodo compartido para no repetir las mismas validaciones en cada boton
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_usu.Text))
                throw new Exception("El usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(txt_contra.Text))
                throw new Exception("La contraseña es obligatoria.");
            if (string.IsNullOrWhiteSpace(txt_idemple.Text))
                throw new Exception("El Id del empleado es obligatorio.");
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

                // Validación explícita del Id de empleado antes de proceder
                if (string.IsNullOrWhiteSpace(txt_idemple.Text) || !ulong.TryParse(txt_idemple.Text.Trim(), out var idEmp))
                {
                    MessageBox.Show("Introduzca un Id de empleado válido antes de agregar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Preparar el objeto mUsuario con valores correctos
                mUsuario = new Cusuario();
                mUsuario.usuario = txt_usu.Text?.Trim() ?? string.Empty;
                // Si existe un campo de contraseña en el formulario, asignarlo aquí; si no, dejar vacío
                try
                {
                    var found = Controls.Find("txt_contra", true);
                    if (found != null && found.Length > 0 && found[0] is TextBox tb)
                        mUsuario.contrasena = tb.Text.Trim();
                }
                catch { }
                mUsuario.id_empleado = idEmp;
                // Normalizar rol desde el combo (ajustar si necesita mapeo específico)
                mUsuario.rol = cmbRol.Text?.Trim() ?? string.Empty;
                // Estado como char '1' o '0'
                mUsuario.estado = cmbEstado.Text.Trim().StartsWith("A", StringComparison.OrdinalIgnoreCase) ? '1' : '0';

                // Añadir fila al DataGridView con el orden: Usuario, Contraseña, ID_Empleado, Rol, Estado
                dvgUsuarios.Rows.Add(mUsuario.usuario, mUsuario.contrasena ?? string.Empty, mUsuario.id_empleado, mUsuario.rol, mUsuario.estado == '1' ? "1" : "0");
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // si ValidarCampos lanza el error, se atrapa aqui
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cargarDatosUsuario();

            if (mUsuariosCRUD.agregarUsuario(mUsuario))
            {
                MessageBox.Show("Usuario agregado a la base de datos correctamente.");
                cargarUsuarios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario a la base de datos.");
            }
        }

        private void LimpiarCampos()
        {
            txt_usu.Text = "";
            txt_contra.Text = "";
            txt_idemple.Text = "";
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        private void cargarDatosUsuario()
        {
            mUsuario.usuario = txt_usu.Text.Trim();
            mUsuario.contrasena = txt_contra.Text.Trim();

            // Parse seguro del Id de empleado para evitar FormatException
            var idText = txt_idemple.Text.Trim();
            if (!ulong.TryParse(idText, out var idEmpleado))
            {
                // Como se valida previamente en agregar_Click, aquí fijamos 0 como valor por defecto
                // o se puede manejar de otra forma (lanzar excepción controlada)
                idEmpleado = 0;
            }
            mUsuario.id_empleado = idEmpleado;

            mUsuario.rol = cmbRol.Text.Trim();
            var estadoText = cmbEstado.Text.Trim().ToLowerInvariant();
            // Mapear texto del estado a '1' (Activo) o '0' (Retirado) para guardar en BD
            if (estadoText == "activo" || estadoText == "a" || estadoText == "1")
            {
                mUsuario.estado = '1';
            }
            else if (estadoText == "retirado" || estadoText == "r" || estadoText == "0")
            {
                mUsuario.estado = '0';
            }
            else
            {
                // Valor por defecto si el texto no coincide
                mUsuario.estado = '0';
            }

        }

        private void editar_Click(object sender, EventArgs e)
        {
            // exige una fila seleccionada, valida los campos y actualiza esa fila
            try
            {
                if (dvgUsuarios.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para editar.");

                ValidarCampos();
                DataGridViewRow fila = dvgUsuarios.SelectedRows[0];
                // Mantener la columna Id_Empleado (índice 3) intacta si no hay control para editarla
                fila.Cells[1].Value = txt_idemple.Text;
                fila.Cells[2].Value = txt_usu.Text;
                fila.Cells[4].Value = cmbRol.Text;
                fila.Cells[5].Value = cmbEstado.Text;

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
                if (dvgUsuarios.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para eliminar.");

                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dvgUsuarios.Rows.Remove(dvgUsuarios.SelectedRows[0]);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_busca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txt_busca.Text.Trim();
                System.Diagnostics.Debug.WriteLine($"Gestion_Empleados: buscar filtro='{filtro}'");
                cargarUsuarios(filtro);
            }
            catch (Exception ex)
            {
                // Mostrar error sin cerrar la ventana
                MessageBox.Show("Error al buscar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
