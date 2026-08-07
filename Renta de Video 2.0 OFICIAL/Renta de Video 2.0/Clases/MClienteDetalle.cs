using System;

namespace Renta_de_Video_2._0.Clases
{
    internal class MClienteDetalle
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Dpi { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int NoRentas { get; set; }
        public bool Descuento { get; set; }
        public int IdMembresia { get; set; }
    }
}
