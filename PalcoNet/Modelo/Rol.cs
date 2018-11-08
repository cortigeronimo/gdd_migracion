using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Rol
    {
        private String nombre;
        private bool habilitado;

        //public Rol(string nombre, bool habilitado)
        //{
        //    this.nombre = nombre;
        //    this.habilitado = habilitado;
        //}

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
