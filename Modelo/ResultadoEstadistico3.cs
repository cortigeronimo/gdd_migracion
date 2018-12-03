using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    class ResultadoEstadistico3
    {
        public string empresa;
        public string Empresa { get { return this.empresa; } }

        public int usuarioId;
        public int UsuarioId { get { return this.usuarioId; } }

        public string cliente;
        public string Cliente { get { return this.cliente; } }

        public int cantCompras;
        public int CantCompras { get { return this.cantCompras; } }


        public ResultadoEstadistico3(int id, string cliente, int cant, string emp)
        {
            this.usuarioId = id;
            this.cliente = cliente;
            this.cantCompras = cant;
            this.empresa = emp;
        }
    }
}
