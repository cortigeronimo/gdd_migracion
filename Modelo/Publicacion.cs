using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PalcoNet.Modelo;
using PalcoNet.Abm_Grado;

namespace PalcoNet.Modelo
{
    public class Publicacion
    {
        public long Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEvento { get; set; }
        public String Descripcion { get; set; }
        public String Direccion { get; set; }
        public Rubro Rubro { get; set; }
        public Grado Grado { get; set; }
        public Empresa Empresa { get; set; }
        public Estado Estado { get; set; }

        public List<Ubicacion> Ubicaciones { get; set; }

        public int Stock { get; set; }

    }
}
