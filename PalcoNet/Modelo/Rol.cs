using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Rol
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public bool habilitado { get; set; }

        //public Rol(string nombre, bool habilitado)
        //{
        //    this.nombre = nombre;
        //    this.habilitado = habilitado;
        //}
    }
}
