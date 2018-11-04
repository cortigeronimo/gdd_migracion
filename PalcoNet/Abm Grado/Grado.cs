using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Grado
{
    public class Grado
    {
        private int comision;
        private String descripcion;

        public Grado(int comision, String descripcion){
            this.comision = comision;
            this.descripcion = descripcion;
        }

        public void SetComision(int value) {
            comision = value;
        }

        public void SetDescripcion(String value)
        {
            descripcion = value;
        }

        public int GetComision(){
            return comision;
        }

        public String GetDescripcion()
        {
            return descripcion;
        }

    }
}
