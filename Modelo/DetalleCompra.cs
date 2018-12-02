using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class DetalleCompra
    {
        public DateTime FechaCompra { get; set; }
        public String MetodoDePago { get; set; }
        public String Fila { get; set; }
        public Decimal Asiento { get; set; }
        public Decimal Precio { get; set; }
        public String DescripcionUbicacion { get; set; }
        public String DescripcionPublicacion { get; set; }
        public DateTime FechaEvento { get; set; }
    }
}
