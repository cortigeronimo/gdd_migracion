using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.DTO
{
    public class PublicacionPorFacturarDTO
    {
        public long Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEvento { get; set; }
        public String Descripcion { get; set; }
        public String Direccion { get; set; }
        public String Rubro { get; set; }
        public String Grado { get; set; }
        public int Comision { get; set; }
        public int CantidadCompras { get; set; }
        public float MontoTotal { get; set; }

    }
}
