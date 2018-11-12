using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PalcoNet.Modelo;
using PalcoNet.Config;

namespace PalcoNet
{
    public class Usuario
    {
        public int id { get; set; }
        public String username { get; set; }
        private byte[] password;
        public bool isAdmin { get; set; }

        private List<Rol> listaRoles = new List<Rol>();


        public List<Rol> GetRoles()
        {
            return listaRoles;
        }

        public void SetRoles(List<Rol> roles)
        {
            this.listaRoles = roles;
        }

        public void AddRol(Rol rol)
        {
            this.listaRoles.Add(rol);
        }

        public void ClearRolesList()
        {
            this.listaRoles.Clear();
        }

        public int CountRoles()
        {
            return this.listaRoles.Count;
        }

        public void SetPassword(String password){
            this.password = Hashing.GetSHA256Encrypt(password);
        }

        public void SetPassword(byte[] password)
        {
            this.password = password;
        }

        public byte[] GetPassword()
        {
            return this.password;
        }
    }


}
