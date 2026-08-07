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

        public DataTable funVideosRentados(int idMembresia)
        {
            DataTable dt = new DataTable();

            string consulta = @"
        SELECT 
            v.id_video         AS Id_Video,
            v.titulo           AS Titulo,
            r.fecha_renta      AS Fecha_Renta,
            r.fecha_limite     AS Fecha_Limite,
            dr.precio_unitario AS Precio,
            r.id_renta         AS Id_Renta
        FROM membresia m
        INNER JOIN cliente c        ON m.id_cliente = c.id_cliente
        INNER JOIN renta r          ON c.id_cliente = r.id_cliente
        INNER JOIN detalle_renta dr ON r.id_renta = dr.id_renta
        INNER JOIN video v          ON dr.id_video = v.id_video
        WHERE m.id_membresia = @idMembresia
        AND r.estado = 'activa';";

            MySqlCommand cmd = new MySqlCommand(
                consulta,
                conexion.establecerConexion()
            );

            cmd.Parameters.AddWithValue("@idMembresia", idMembresia);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            conexion.cerrarConexion();

            return dt;
        }
    }
}