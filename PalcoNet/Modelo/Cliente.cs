using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    public class Cliente : Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public int NroDocumento { get; set; }
        public string CUIL { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public byte NroPiso { get; set; }
        public string Depto { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string TarjetaCredito { get; set; }
        public bool Habilitado { get; set; }
        public byte IntentosFallidos { get; set; }
        public bool Baja { get; set; }

        public Cliente(string nombre, string apellido, string tipoDocumento, int nroDocumento, string cuil,
            string email, int telefono, string localidad, string direccion, byte nroPiso, string depto, string codPostal, DateTime fechaNac, DateTime fechaCreacion,
            string tarjetaCredito)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocumento = tipoDocumento;
            this.NroDocumento = nroDocumento;
            this.CUIL = cuil;
            this.Email = email;
            this.Telefono = telefono;
            this.Localidad = localidad;
            this.Direccion = direccion;
            this.NroPiso = nroPiso;
            this.Depto = depto;
            this.CodigoPostal = codPostal;
            this.FechaNacimiento = fechaNac;
            this.FechaCreacion = fechaCreacion;
            this.TarjetaCredito = tarjetaCredito;
        }

    }
}
