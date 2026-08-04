using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    // manejo de conexion con MySQL workbench Andre Gonzalez 9959-23-3117
    internal class ClienteConsultas
    {
        // inserción de cliente, generación de código de membresía MEM-0000 y obtención del ID generado Andre Gonzalez 9959-23-3117
        public int AgregarCliente(MCliente cliente)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlConnection conexion = objetoConexion.establecerConexion();

                // encadenación con la auditoría de la BD Andre Gonzalez 9959-23-3117
                Cauditoria.ConfigurarUsuarioBD(conexion);

                // 1. Inserción de los datos principales del cliente Andre Gonzalez 9959-23-3117
                string insertCliente = "INSERT INTO cliente (nombre, dpi, telefono, direccion, correo) VALUES (@nombre, @dpi, @telefono, @direccion, @correo);";
                MySqlCommand cmdCliente = new MySqlCommand(insertCliente, conexion);
                cmdCliente.Parameters.Add(new MySqlParameter("@nombre", cliente.Nombre));
                cmdCliente.Parameters.Add(new MySqlParameter("@dpi", cliente.Dpi));
                cmdCliente.Parameters.Add(new MySqlParameter("@telefono", cliente.Telefono));
                cmdCliente.Parameters.Add(new MySqlParameter("@direccion", cliente.Direccion));
                cmdCliente.Parameters.Add(new MySqlParameter("@correo", cliente.Correo));

                cmdCliente.ExecuteNonQuery();

                // Obtener el ID autogenerado del cliente Andre Gonzalez 9959-23-3117
                int idGenerado = Convert.ToInt32(cmdCliente.LastInsertedId);

                // 2. Generación y actualización del código de membresía con formato MEM-0000 Andre Gonzalez 9959-23-3117
                if (idGenerado > 0)
                {
                    string codigoMembresia = "MEM-" + idGenerado.ToString("D4");
                    string updateCodigo = "UPDATE cliente SET codigo_membresia = @codigo WHERE id_cliente = @id;";

                    MySqlCommand cmdUpdate = new MySqlCommand(updateCodigo, conexion);
                    cmdUpdate.Parameters.Add(new MySqlParameter("@codigo", codigoMembresia));
                    cmdUpdate.Parameters.Add(new MySqlParameter("@id", idGenerado));
                    cmdUpdate.ExecuteNonQuery();
                }

                objetoConexion.cerrarConexion();

                return idGenerado;
            }
            catch (Exception ex)
            {
                // manejo de error inserción cliente Andre Gonzalez 9959-23-3117
                MessageBox.Show("No se pudo registrar el cliente en la base de datos.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}