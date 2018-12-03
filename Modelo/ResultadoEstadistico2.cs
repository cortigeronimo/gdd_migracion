using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Modelo
{
    class ResultadoEstadistico2
    {
        private int userId;
        public int ClienteID { get { return userId; } }

        private string cliente;
        public string Cliente { get { return cliente; } }

        private int puntosVencidos;
        public int PuntosVencidos { get { return puntosVencidos; } }

        public ResultadoEstadistico2(int userId, string cliente, int puntos)
        {
            this.userId = userId;
            this.cliente = cliente;
            this.puntosVencidos = puntos;
        }
    }
}
