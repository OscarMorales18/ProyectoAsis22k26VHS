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

namespace Renta_de_Video_2._0
{
    public partial class Gestion_Empleados : Form
    {
        // Variable para almacenar el usuario en edición - Oscar Morales 9959-23-3070
        private string usuarioEnEdicion = null;

        public Gestion_Empleados()
        {
            InitializeComponent();
            this.Load += Cargar_Usuarios;
            CargarDatosUsuario();
            AplicarPermisos();
        }

        private void Cargar_Usuarios(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarDatosUsuario()
        {
            lblNombreUsuario.Text = SesionUsuario.Usuario;
            lblRol.Text = SesionUsuario.Rol;
        }

        private void AplicarPermisos()
        {
            string rol = SesionUsuario.Rol;
            switch (rol)
            {
                case "Administrador":
                    btn_eliminar.Enabled = false;
                    break;

                case "Auditor":
                    btn_eliminar.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Rol no reconocido o sesión no válida.", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        // Cargamos los datos a la tabla - Oscar Morales 9959-23-3070
        private void CargarUsuarios()
        {
            dgv_usuarios.Rows.Clear();

            Cconexion c = new Cconexion();
            MySqlConnection conn = c.establecerConexion();

            try
            {
                string query = "SELECT usuario, contrasena, id_empleado, rol, estado FROM usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv_usuarios.Rows.Add(
                            reader.GetString("usuario"),
                            reader.GetString("contrasena"),
                            reader.GetInt32("id_empleado"),
                            reader.GetString("rol"),
                            reader.GetBoolean("estado") ? "1" : "0"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.cerrarConexion();
            }
        }

        // Validación de campos antes de agregar o editar un usuario - Oscar Morales 9959-23-3070
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_usuario.Text))
                throw new Exception("El usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(txt_contrasena.Text))
                throw new Exception("La contraseña es obligatoria.");
            if (string.IsNullOrWhiteSpace(txt_idempleado.Text))
                throw new Exception("El código de empleado es obligatorio.");
            if (cmb_rol.SelectedItem == null)
                throw new Exception("Selecciona un rol.");
            if (cmb_estado.SelectedItem == null)
                throw new Exception("Selecciona un estado.");
            return true;
        }

        // Boton para aceptar el registro de un usuario - Oscar Morales 9959-23-3070
        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                if (!int.TryParse(txt_idempleado.Text, out int idEmpleado))
                {
                    MessageBox.Show("El código de empleado debe ser un número.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cconexion c = new Cconexion();
                MySqlConnection conn = c.establecerConexion();

                // CONFIGURAR USUARIO DE AUDITORÍA PARA MYSQL
                Cauditoria.ConfigurarUsuarioBD(conn);

                try
                {
                    string queryCheck = "SELECT COUNT(*) FROM empleado WHERE id_empleado = @id";
                    MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@id", idEmpleado);
                    long existe = (long)cmdCheck.ExecuteScalar();

                    if (existe == 0)
                    {
                        MessageBox.Show("No existe ningún empleado con ese código.", "Empleado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = @"INSERT INTO usuario (usuario, contrasena, id_empleado, rol, estado) 
                                  VALUES (@usuario, @contrasena, @id_empleado, @rol, @estado)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txt_contrasena.Text);
                    cmd.Parameters.AddWithValue("@id_empleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@rol", cmb_rol.Text);
                    cmd.Parameters.AddWithValue("@estado", cmb_estado.Text == "1");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarUsuarios();
                    LimpiarCampos();
                }
                finally
                {
                    c.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Boton para seleccionar el registro de un usuario - Oscar Morales 9959-23-3070
        private void editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_usuarios.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para editar.");

                DataGridViewRow fila = dgv_usuarios.SelectedRows[0];

                usuarioEnEdicion = fila.Cells["Usuario"].Value.ToString();

                txt_usuario.Text = fila.Cells["Usuario"].Value.ToString();
                txt_contrasena.Text = fila.Cells["Contraseña"].Value.ToString();
                txt_idempleado.Text = fila.Cells["CodigoEmpleado"].Value.ToString();
                cmb_rol.Text = fila.Cells["Rol"].Value.ToString();
                cmb_estado.Text = fila.Cells["Estado"].Value.ToString();

                btn_eliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Boton para eliminar el registro de un usuario - Oscar Morales 9959-23-3070
        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_usuarios.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para eliminar.");

                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string Seleccionusu = dgv_usuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();
                    Cconexion c = new Cconexion();
                    MySqlConnection conn = c.establecerConexion();

                    // CONFIGURAR USUARIO DE AUDITORÍA PARA MYSQL
                    Cauditoria.ConfigurarUsuarioBD(conn);

                    try
                    {
                        string query = "DELETE FROM usuario WHERE usuario = @usuario";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@usuario", Seleccionusu);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                    }
                    finally
                    {
                        c.cerrarConexion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                if (usuarioEnEdicion == null)
                {
                    MessageBox.Show("Primero selecciona un usuario de la tabla y presiona Editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_idempleado.Text, out int idEmpleado))
                {
                    MessageBox.Show("El código de empleado debe ser un número.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cconexion c = new Cconexion();
                MySqlConnection conn = c.establecerConexion();

                // configuramos el usuario de auditoría para MySQL - Oscar Morales 9959-23-3070
                Cauditoria.ConfigurarUsuarioBD(conn);

                try
                {
                    string queryCheck = "SELECT COUNT(*) FROM empleado WHERE id_empleado = @id";
                    MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@id", idEmpleado);
                    long existe = (long)cmdCheck.ExecuteScalar();

                    if (existe == 0)
                    {
                        MessageBox.Show("No existe ningún empleado con ese código.", "Empleado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = @"UPDATE usuario 
                                  SET usuario = @usuario, contrasena = @contrasena, id_empleado = @id_empleado, rol = @rol, estado = @estado
                                  WHERE usuario = @usuarioOriginal";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txt_contrasena.Text);
                    cmd.Parameters.AddWithValue("@id_empleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@rol", cmb_rol.Text);
                    cmd.Parameters.AddWithValue("@estado", cmb_estado.Text == "1");
                    cmd.Parameters.AddWithValue("@usuarioOriginal", usuarioEnEdicion);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los cambios se guardaron correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    usuarioEnEdicion = null;
                    LimpiarCampos();
                    CargarUsuarios();
                    btn_eliminar.Enabled = true;
                }
                finally
                {
                    c.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para limpiar los campos del formulario - Oscar Morales 9959-23-3070
        private void LimpiarCampos()
        {
            txt_usuario.Clear();
            txt_contrasena.Clear();
            txt_idempleado.Clear();
            cmb_rol.SelectedIndex = -1;
            cmb_estado.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}