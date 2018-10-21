using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace PalcoNet
{
    public class Parametro
    {
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }

        //param de entrada
        public Parametro(String _nombre, Object _valor)
        {
            Nombre = _nombre;
            Valor = _valor;
            Direccion = ParameterDirection.Input;
        }

        //param de salida
        public Parametro(String _nombre, SqlDbType _tipoDato, Int32 _tamaño)
        {
            Nombre = _nombre;
            TipoDato = _tipoDato;
            Tamaño = _tamaño;
            Direccion = ParameterDirection.Output;
        }
    }
}
