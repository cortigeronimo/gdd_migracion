using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PalcoNet.Modelo;

namespace PalcoNet
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        private List<Rol> listaRoles = new List<Rol>();


        public List<Rol> GetRoles()
        {
            return listaRoles;
        }

        public void SetRoles(List<Rol> roles)
        {
            this.listaRoles = roles;
        }

        public void ClearRolesList()
        {
            this.listaRoles.Clear();
        }

        public int CantRoles()
        {
            return this.listaRoles.Count;
        }
    }


}
