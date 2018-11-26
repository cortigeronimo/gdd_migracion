using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    class Premio
    {
        public int id { get; set; }
        public String descripcion { get; set; }
        public int puntos { get; set; }
        
        public Premio(int id, String descripcion, int puntos)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.puntos = puntos;
        }

        public override string ToString()
        {
            return descripcion + " -> " + puntos.ToString() + " puntos";
        }
    }
}
