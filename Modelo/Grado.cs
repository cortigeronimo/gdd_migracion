using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;

namespace PalcoNet.Abm_Grado
{
    public class Grado
    {
        public int Id {get; set;}
        public int Comision { get; set; }
        public String Descripcion { get; set; }

        public Grado()
        {
        }

        public Grado(int id, int comision, String descripcion)
        {
            this.Id = id;
            this.Comision = comision;
            this.Descripcion = descripcion.ToUpper();
        }

        public Grado(int comision, String descripcion){
            this.Comision = comision;
            this.Descripcion = descripcion.ToUpper();
        }

    }
}
