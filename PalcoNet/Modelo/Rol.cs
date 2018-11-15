using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Rol
    {
        public int id;
        public string nombre;
        public bool habilitado;

        public string Nombre { get { return nombre; } }
        public bool Habilitado { get { return habilitado; } }
        public int Id { get { return id; } }

        public Rol(){}

        public Rol(int id, string nombre, bool habilitado)
        {
            this.id = id;
            this.nombre = nombre;
            this.habilitado = habilitado;
        }

    }
}
