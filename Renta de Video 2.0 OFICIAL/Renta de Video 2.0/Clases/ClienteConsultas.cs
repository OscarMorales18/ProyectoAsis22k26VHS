using MySqlConnector;
using System;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace Renta_de_Video_2._0.Clases
{
    //manej de conexion con MySQL workbench Andre Gonzalez 9959-23-3117
    internal class ClienteConsultas
    {
        public int AgregarCliente(MCliente cliente)
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
                cmdCliente.ExecuteNonQuery();

                long idCliente = cmdCliente.LastInsertedId;

                long idTipoMembresia = ObtenerOCrearTipoMembresia(conexion);

                string insertMembresia = "INSERT INTO membresia (id_cliente, id_tipo_membresia, fecha_inicio, videos_acumulados) VALUES (@idCliente, @idTipo, CURDATE(), 0);";
                MySqlCommand cmdMembresia = new MySqlCommand(insertMembresia, conexion);
                cmdMembresia.Parameters.Add(new MySqlParameter("@idCliente", idCliente));
                cmdMembresia.Parameters.Add(new MySqlParameter("@idTipo", idTipoMembresia));
                cmdMembresia.ExecuteNonQuery();

                long idMembresia = cmdMembresia.LastInsertedId;

                string updateCliente = "UPDATE cliente SET id_membresia = @idMembresia WHERE id_cliente = @idCliente;";
                MySqlCommand cmdUpdate = new MySqlCommand(updateCliente, conexion);
                cmdUpdate.Parameters.Add(new MySqlParameter("@idMembresia", idMembresia));
                cmdUpdate.Parameters.Add(new MySqlParameter("@idCliente", idCliente));
                cmdUpdate.ExecuteNonQuery();

                objetoConexion.cerrarConexion();

                return (int)idMembresia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el cliente en la base de datos.\nError: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private long ObtenerOCrearTipoMembresia(MySqlConnection conexion)
        {
            string consultaTipo = "SELECT id_tipo_membresia FROM tipo_membresia LIMIT 1;";
            MySqlCommand cmdConsulta = new MySqlCommand(consultaTipo, conexion);
            object resultado = cmdConsulta.ExecuteScalar();

            if (resultado != null)
                return Convert.ToInt64(resultado);

            string insertTipo = "INSERT INTO tipo_membresia (tipo, descuento_disponible) VALUES ('Básica', 0);";
            MySqlCommand cmdInsertTipo = new MySqlCommand(insertTipo, conexion);
            cmdInsertTipo.ExecuteNonQuery();

            return cmdInsertTipo.LastInsertedId;
        }
    }
}
