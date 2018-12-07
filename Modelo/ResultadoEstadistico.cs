using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    class ResultadoEstadistico
    {
        private string razonSocial;
        public string RazonSocial { get { return this.razonSocial; } }

        private string grado;
        public string Grado { get { return this.grado; } }

        private int sinVender;
        public int SinVender { get { return this.sinVender; } }

        public ResultadoEstadistico(string razonSocial, string grado, int cantSinVender)
        {
            this.razonSocial = razonSocial;
            this.grado = grado == null ? "" : grado;
            this.sinVender = cantSinVender;
        }
    }
}
