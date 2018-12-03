using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    class ResultadoEstadistico3
    {
        public int UsuarioId;
        public string Cliente;
        public int CantCompras;
        public string Empresa;

        public ResultadoEstadistico3(int id, string cliente, int cant, string emp)
        {
            this.UsuarioId = id;
            this.Cliente = cliente;
            this.CantCompras = cant;
            this.Empresa = emp;
        }
    }
}
