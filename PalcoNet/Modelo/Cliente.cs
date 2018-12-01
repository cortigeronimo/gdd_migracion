using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Cliente : Usuario
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String tipoDocumento { get; set; }
        public decimal nroDocumento { get; set; }
        public decimal cuil { get; set; }
        public String email { get; set; }
        public long telefono { get; set; }
        public String localidad { get; set; }
        public String direccion { get; set; }
        public decimal? nroPiso { get; set; }
        public String depto { get; set; }
        public String codigoPostal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String tarjetaCredito { get; set; }
        public bool habilitado { get; set; }
        public Int16 intentosFallidos { get; set; }
        public bool baja { get; set; }
        public bool primerLogin { get; set; }

        public Cliente()
        {
        }

        public Cliente(Usuario usuario)
        {
            id = usuario.id;
            username = usuario.username;
            SetPassword(usuario.GetPassword());
            SetRoles(usuario.GetRoles());
            isAdmin = usuario.isAdmin;
        }


        public Cliente(string nombre, string apellido, string tipoDocumento, int nroDocumento, long cuil,
            string email, long telefono, string localidad, string direccion, byte nroPiso, string depto, string codPostal, DateTime fechaNac,
            string tarjetaCredito)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.nroDocumento = nroDocumento;
            this.cuil = cuil;
            this.email = email;
            this.telefono = telefono;
            this.localidad = localidad;
            this.direccion = direccion;
            this.nroPiso = nroPiso;
            this.depto = depto;
            this.codigoPostal = codPostal;
            this.fechaNacimiento = fechaNac;
            this.fechaCreacion = DateTime.Today;
            this.tarjetaCredito = tarjetaCredito;
        }

        public void SetFechaCreacion()
        {
            this.fechaCreacion = DateTime.Today;
        }
    }
}
