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
        public int nroDocumento { get; set; }
        public String cuil { get; set; }
        public String email { get; set; }
        public int telefono { get; set; }
        public String localidad { get; set; }
        public String direccion { get; set; }
        public byte nroPiso { get; set; }
        public String depto { get; set; }
        public String codigoPostal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String tarjetaCredito { get; set; }
        public bool habilitado { get; set; }
        public byte intentosFallidos { get; set; }
        public bool baja { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, string tipoDocumento, int nroDocumento, string cuil,
            string email, int telefono, string localidad, string direccion, byte nroPiso, string depto, string codPostal, DateTime fechaNac, DateTime fechaCreacion,
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
            this.fechaCreacion = fechaCreacion;
            this.tarjetaCredito = tarjetaCredito;
        }
    }
}
