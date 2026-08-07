using MySqlConnector;
using System.Data;

namespace Renta_de_Video_2._0.Clases
{
    internal class CCliente
    {
        Cconexion objConexion = new Cconexion();

        public DataTable funBuscarCliente(int membresia)
        {
            DataTable objDt = new DataTable();

            string sConsulta = @"
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

            MySqlCommand objCmd = new MySqlCommand(
                sConsulta,
                objConexion.establecerConexion()
            );

            objCmd.Parameters.AddWithValue("@membresia", membresia);

            MySqlDataAdapter objDa = new MySqlDataAdapter(objCmd);
            objDa.Fill(objDt);

            objConexion.cerrarConexion();

            return objDt;
        }

        public DataTable funVideosRentados(int idMembresia)
        {
            DataTable objDt = new DataTable();

            string sConsulta = @"
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

            MySqlCommand objCmd = new MySqlCommand(
                sConsulta,
                objConexion.establecerConexion()
            );

            objCmd.Parameters.AddWithValue("@idMembresia", idMembresia);

            MySqlDataAdapter objDa = new MySqlDataAdapter(objCmd);
            objDa.Fill(objDt);

            objConexion.cerrarConexion();

            return objDt;
        }
    }
}