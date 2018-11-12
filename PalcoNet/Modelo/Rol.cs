using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Rol
    {
        private int id;
        private string nombre;
        private bool habilitado;

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

        public string GetNombre()
        {
            return this.nombre;
        }

        public Boolean GetHabilitado()
        {
            return this.habilitado;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetHabilitado(Boolean habilitado)
        {
            this.habilitado = habilitado;
        }
    }
}
