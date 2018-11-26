using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class DetalleCompra
    {
        public DateTime fechaCompra { get; set; }
        public String metodoDePago { get; set; }
        public int fila { get; set; }
        public int asiento { get; set; }
        public float precio { get; set; }
        public String descripcionUbicacion { get; set; }
        public String descripcionPublicacion { get; set; }
        public DateTime fechaEvento { get; set; }
    }
}
