using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Rol
    {
<<<<<<< HEAD
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
=======
        public int id { get; set; }
        public String nombre { get; set; }
        public bool habilitado { get; set; }

        //public Rol(string nombre, bool habilitado)
        //{
        //    this.nombre = nombre;
        //    this.habilitado = habilitado;
        //}
>>>>>>> 496d760215dc286e030a031e26985c104a37e7ec
    }
}
