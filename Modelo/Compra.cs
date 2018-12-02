using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Compra
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Decimal Cantidad { get; set; }
        public DateTime FechaCompra { get; set; }
        public String MetodoPago { get; set; }
        public String Email { get; set; }
        public DateTime FechaRendida { get; set; }
        public String Fila { get; set; }
        public String Asiento { get; set; }
        public Publicacion Publicacion { get; set; }
    }
}
