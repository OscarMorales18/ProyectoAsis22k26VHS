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
        public ulong id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public ulong id_empleado { get; set; }
        public string rol {  get; set; }
        public char estado { get; set; }
        
    }
}
