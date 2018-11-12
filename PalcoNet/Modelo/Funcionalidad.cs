using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Funcionalidad
    {
        private int id;
        private string nombre;

        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
        }


        public Funcionalidad(int _id, string _nombre)
        {
            this.id = _id;
            this.nombre = _nombre;
        }
    }
}
