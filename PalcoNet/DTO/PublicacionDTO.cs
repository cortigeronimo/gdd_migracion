using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;

namespace PalcoNet.DTO
{
    public class PublicacionDTO
    {
        public long Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEvento { get; set; }
        public String Descripcion { get; set; }
        public String Direccion { get; set; }
        public String Rubro { get; set; }
        public String Grado { get; set; }
        public int Empresa { get; set; }
        public String Estado { get; set; }
        public int Stock { get; set; }

        public int Comision { get; set; }

        public List<Ubicacion> Ubicaciones { get; set; }

        
    }
}
