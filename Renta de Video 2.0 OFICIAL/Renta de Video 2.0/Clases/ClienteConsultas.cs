using MySqlConnector;
using System;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    //manej de conexion con MySQL workbench Andre Gonzalez 9959-23-3117
    internal class ClienteConsultas
    {
        public bool AgregarCliente(MCliente cliente)
        {
            Cconexion objetoConexion = new Cconexion();

            try
            {
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string insertCliente = "INSERT INTO cliente (nombre, dpi, telefono, direccion, correo) VALUES (@nombre, @dpi, @telefono, @direccion, @correo);";
                MySqlCommand cmdCliente = new MySqlCommand(insertCliente, conexion);
                cmdCliente.Parameters.Add(new MySqlParameter("@nombre", cliente.Nombre));
                cmdCliente.Parameters.Add(new MySqlParameter("@dpi", cliente.Dpi));
                cmdCliente.Parameters.Add(new MySqlParameter("@telefono", cliente.Telefono));
                cmdCliente.Parameters.Add(new MySqlParameter("@direccion", cliente.Direccion));
                cmdCliente.Parameters.Add(new MySqlParameter("@correo", cliente.Correo));

                int filasAfectadas = cmdCliente.ExecuteNonQuery();

                objetoConexion.cerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el cliente en la base de datos.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
