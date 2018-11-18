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
        public int Asiento { get; set; }
        public float Precio { get; set; }
        public String Descripcion { get; set; }
        public Boolean SinNumerar { get; set; }
    }
}
