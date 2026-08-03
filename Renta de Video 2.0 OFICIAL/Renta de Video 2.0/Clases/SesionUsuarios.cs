using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renta_de_Video_2._0.Clases
{
    public static class SesionUsuario
    {
        public static ulong IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Nombre { get; set; }
        public static string Rol { get; set; }
        public static ulong IdEmpleado { get; set; }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            Usuario = string.Empty;
            Nombre = string.Empty;
            Rol = string.Empty;
            IdEmpleado = 0;
        }
    }
}