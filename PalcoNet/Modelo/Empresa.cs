using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Empresa : Usuario
    {
        public String razonSocial { get; set; }
        public long cuit { get; set; }
        public String ciudad { get; set; }
        public String email { get; set; }
        public long telefono { get; set; }
        public String localidad { get; set; }
        public String direccion { get; set; }
        public byte nroPiso { get; set; }
        public String depto { get; set; }
        public String codigoPostal { get; set; }
        public bool habilitado { get; set; }
        public byte intentosFallidos { get; set; }
        public bool baja { get; set; }

        public String RazonSocial { get { return razonSocial; } }

        public Empresa()
        {
        }

        public Empresa(Usuario usuario)
        {
            id = usuario.id;
            username = usuario.username;
            SetPassword(usuario.GetPassword());
            SetRoles(usuario.GetRoles());
            isAdmin = usuario.isAdmin;
        }

        public Empresa(string razonSocial, long cuit, String ciudad,
            string email, long telefono, string localidad, string direccion, byte nroPiso, string depto, string codPostal)
        {
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            this.ciudad = ciudad;
            this.email = email;
            this.telefono = telefono;
            this.localidad = localidad;
            this.direccion = direccion;
            this.nroPiso = nroPiso;
            this.depto = depto;
            this.codigoPostal = codPostal;
        }
    }
}
