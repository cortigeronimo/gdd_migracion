using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Ubicacion
    {
        public Char Fila { get; set; }
        public Decimal Asiento { get; set; }
        public Decimal Precio { get; set; }
        public String Descripcion { get; set; }
        public Decimal Publicacion { get; set; }
        //public Boolean SinNumerar { get; set; }
    }
}
