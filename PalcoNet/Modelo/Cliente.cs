using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    class Cliente : TipoUsuario
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String tipoDocumento { get; set; }
        public long numeroDocumento { get; set; }
        public long cuil { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String tarjetaCredito { get; set; }
        

 
        
    }
}
