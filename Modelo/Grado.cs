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
        private String descripcion;
        public String Descripcion 
        {
            get
            {
                return this.descripcion;
            }
            set {
                this.descripcion = value.ToUpper();
            } 
        }

        public Grado()
        {
        }

        public Grado(int id, int comision, String descripcion)
        {
            this.Id = id;
            this.Comision = comision;
            this.Descripcion = descripcion;
        }

        public Grado(int comision, String descripcion){
            this.Comision = comision;
            this.Descripcion = descripcion;
        }

        public override string ToString()
        {
            return this.descripcion;
        }

    }
}
