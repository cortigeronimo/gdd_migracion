using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public abstract class TipoUsuario
    {
        public Usuario usuario { get; set; }
        public String email { get; set; }
        public long telefono { get; set; }
        public String localidad { get; set; }
        public String direccion { get; set; }
        public int nroPiso { get; set; }
        public String departamento { get; set; }
        public String codigoPostal { get; set; }
        public bool isHabilitado { get; set; }
        public int intentosFallidos { get; set; }
        public bool baja { get; set; }
    }
}
