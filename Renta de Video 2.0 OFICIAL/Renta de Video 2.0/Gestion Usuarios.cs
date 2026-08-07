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
        private string _sUsuarioEnEdicion = null;

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
            lbl_nombreUsuario.Text = SesionUsuario.Usuario;
            lbl_rol.Text = SesionUsuario.Rol;
        }

        private void AplicarPermisos()
        {
            string sRol = SesionUsuario.Rol;
            switch (sRol)
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

            Cconexion objConexion = new Cconexion();
            MySqlConnection objConn = objConexion.establecerConexion();

            try
            {
                string sQuery = "SELECT usuario, contrasena, id_empleado, rol, estado FROM usuario";
                MySqlCommand objCmd = new MySqlCommand(sQuery, objConn);

                using (MySqlDataReader objReader = objCmd.ExecuteReader())
                {
                    while (objReader.Read())
                    {
                        dgv_usuarios.Rows.Add(
                            objReader.GetString("usuario"),
                            objReader.GetString("contrasena"),
                            objReader.GetInt32("id_empleado"),
                            objReader.GetString("rol"),
                            objReader.GetBoolean("estado") ? "1" : "0"
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
                objConexion.cerrarConexion();
            }
        }

        // Validación de campos antes de agregar o editar un usuario - Oscar Morales 9959-23-3070
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_usuario.Text))
                throw new Exception("El usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(txt_contrasena.Text))
                throw new Exception("La contraseña es obligatoria.");
            if (string.IsNullOrWhiteSpace(txt_idEmpleado.Text))
                throw new Exception("El código de empleado es obligatorio.");
            if (cmb_rol.SelectedItem == null)
                throw new Exception("Selecciona un rol.");
            if (cmb_estado.SelectedItem == null)
                throw new Exception("Selecciona un estado.");
            return true;
        }

        // Método para limpiar los campos del formulario - Oscar Morales 9959-23-3070
        private void LimpiarCampos()
        {
            txt_usuario.Clear();
            txt_contrasena.Clear();
            txt_idEmpleado.Clear();
            cmb_rol.SelectedIndex = -1;
            cmb_estado.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                if (!int.TryParse(txt_idEmpleado.Text, out int iIdEmpleado))
                {
                    MessageBox.Show("El código de empleado debe ser un número.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cconexion c = new Cconexion();
                MySqlConnection objConn = c.establecerConexion();

                Cauditoria.ConfigurarUsuarioBD(objConn);

                try
                {
                    string sQueryCheck = "SELECT COUNT(*) FROM empleado WHERE id_empleado = @id";
                    MySqlCommand objCmdCheck = new MySqlCommand(sQueryCheck, objConn);
                    objCmdCheck.Parameters.AddWithValue("@id", iIdEmpleado);
                    long lExiste = (long)objCmdCheck.ExecuteScalar();

                    if (lExiste == 0)
                    {
                        MessageBox.Show("No existe ningún empleado con ese código.", "Empleado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sQuery = @"INSERT INTO usuario (usuario, contrasena, id_empleado, rol, estado) 
                                  VALUES (@usuario, @contrasena, @id_empleado, @rol, @estado)";

                    MySqlCommand objCmd = new MySqlCommand(sQuery, objConn);
                    objCmd.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                    objCmd.Parameters.AddWithValue("@contrasena", txt_contrasena.Text);
                    objCmd.Parameters.AddWithValue("@id_empleado", iIdEmpleado);
                    objCmd.Parameters.AddWithValue("@rol", cmb_rol.Text);
                    objCmd.Parameters.AddWithValue("@estado", cmb_estado.Text == "1");

                    objCmd.ExecuteNonQuery();

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

        private void OnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_usuarios.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para editar.");

                DataGridViewRow fila = dgv_usuarios.SelectedRows[0];

                _sUsuarioEnEdicion = fila.Cells["Usuario"].Value.ToString();

                txt_usuario.Text = fila.Cells["Usuario"].Value.ToString();
                txt_contrasena.Text = fila.Cells["Contraseña"].Value.ToString();
                txt_idEmpleado.Text = fila.Cells["CodigoEmpleado"].Value.ToString();
                cmb_rol.Text = fila.Cells["Rol"].Value.ToString();
                cmb_estado.Text = fila.Cells["Estado"].Value.ToString();

                btn_eliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_usuarios.SelectedRows.Count == 0)
                    throw new Exception("Selecciona un usuario de la tabla para eliminar.");

                DialogResult dlgRespuesta = MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgRespuesta == DialogResult.Yes)
                {
                    string sSeleccionUsu = dgv_usuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();
                    Cconexion c = new Cconexion();
                    MySqlConnection objConn = c.establecerConexion();

                    Cauditoria.ConfigurarUsuarioBD(objConn);

                    try
                    {
                        string sQuery = "DELETE FROM usuario WHERE usuario = @usuario";
                        MySqlCommand objCmd = new MySqlCommand(sQuery, objConn);
                        objCmd.Parameters.AddWithValue("@usuario", sSeleccionUsu);
                        objCmd.ExecuteNonQuery();

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

        private void OnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                if (_sUsuarioEnEdicion == null)
                {
                    MessageBox.Show("Primero selecciona un usuario de la tabla y presiona Editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_idEmpleado.Text, out int iIdEmpleado))
                {
                    MessageBox.Show("El código de empleado debe ser un número.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cconexion c = new Cconexion();
                MySqlConnection objConn = c.establecerConexion();

                // configuramos el usuario de auditoría para MySQL - Oscar Morales 9959-23-3070
                Cauditoria.ConfigurarUsuarioBD(objConn);

                try
                {
                    string sQueryCheck = "SELECT COUNT(*) FROM empleado WHERE id_empleado = @id";
                    MySqlCommand objCmdCheck = new MySqlCommand(sQueryCheck, objConn);
                    objCmdCheck.Parameters.AddWithValue("@id", iIdEmpleado);
                    long lExiste = (long)objCmdCheck.ExecuteScalar();

                    if (lExiste == 0)
                    {
                        MessageBox.Show("No existe ningún empleado con ese código.", "Empleado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sQuery = @"UPDATE usuario 
                                  SET usuario = @usuario, contrasena = @contrasena, id_empleado = @id_empleado, rol = @rol, estado = @estado
                                  WHERE usuario = @usuarioOriginal";

                    MySqlCommand objCmd = new MySqlCommand(sQuery, objConn);
                    objCmd.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                    objCmd.Parameters.AddWithValue("@contrasena", txt_contrasena.Text);
                    objCmd.Parameters.AddWithValue("@id_empleado", iIdEmpleado);
                    objCmd.Parameters.AddWithValue("@rol", cmb_rol.Text);
                    objCmd.Parameters.AddWithValue("@estado", cmb_estado.Text == "1");
                    objCmd.Parameters.AddWithValue("@usuarioOriginal", _sUsuarioEnEdicion);

                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Los cambios se guardaron correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _sUsuarioEnEdicion = null;
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
    }
}