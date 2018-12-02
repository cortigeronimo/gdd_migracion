using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.DTO
{
    public class EmpresaPorFacturarDTO
    {
        public int Id { get; set; }
        public String RazonSocial { get; set; }
        public String Cuit { get; set; }
        public String Localidad { get; set; }
        public String Ciudad { get; set; }
        public String Direccion { get; set; }
        public decimal? NroPiso { get; set; }
        public String Depto { get; set; }
        public int CantidadPublicaciones { get; set; }
        public decimal? MontoPorFacturar { get; set; }
    }
}
