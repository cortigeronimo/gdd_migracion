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
        private int id;
        private int comision;
        private String descripcion;

        public Grado()
        {
        }

        public Grado(int id, int comision, String descripcion)
        {
            this.id = id;
            this.comision = comision;
            this.descripcion = descripcion.ToUpper();
        }

        public Grado(int comision, String descripcion){
            this.comision = comision;
            this.descripcion = descripcion.ToUpper();
        }

        public void SetComision(int value) {
            comision = value;
        }

        public void SetDescripcion(String value)
        {
            descripcion = value.ToUpper();
        }

        public int GetComision(){
            return comision;
        }

        public String GetDescripcion()
        {
            return descripcion;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id) 
        {
            this.id = id;
        }

    }
}
