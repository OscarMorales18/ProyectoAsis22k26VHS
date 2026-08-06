using System;

namespace Renta_de_Video_2._0.Clases
{
    internal class MMoraPendiente
    {
        public int IdMora { get; set; }
        public int IdRenta { get; set; }
        public int DiasAtraso { get; set; }
        public decimal Monto { get; set; }
    }
}
