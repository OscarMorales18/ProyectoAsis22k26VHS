using MySqlConnector;
using System.Data;

namespace Renta_de_Video_2._0.Clases
{
    internal class CCliente
    {
        Cconexion conexion = new Cconexion();

        public DataTable funBuscarCliente(int membresia)
        {
            DataTable dt = new DataTable();

            string consulta = @"
             SELECT
              cliente.nombre AS Nombre_C,
               cliente.dpi AS DPI,
              cliente.telefono AS Telefono,
             cliente.direccion AS Direccion,
              cliente.correo AS Correo,
              IFNULL(cliente.no_rentas, 0) AS No_Rentas,
              IFNULL(cliente.descuento, 0) AS Descuento
             FROM cliente
            INNER JOIN membresia
             ON cliente.id_cliente = membresia.id_cliente
            WHERE membresia.id_membresia = @membresia;";

            MySqlCommand cmd = new MySqlCommand(
                consulta,
                conexion.establecerConexion()
            );

            cmd.Parameters.AddWithValue("@membresia", membresia);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            conexion.cerrarConexion();

            return dt;
        }
    }
}
