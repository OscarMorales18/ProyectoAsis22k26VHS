using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renta_de_Video_2._0.Clases
{
    internal class Cusuario
    {
        // Usar UInt64 para coincidir con columnas AUTO_INCREMENT UNSIGNED (BIGINT UNSIGNED)
        public ulong Id{ get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public ulong IdEmpleado { get; set; }
        public string Rol {  get; set; }
        public char Estado { get; set; }
        
    }
}
