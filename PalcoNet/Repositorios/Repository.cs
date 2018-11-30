using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Repositorios
{
    abstract class Repository
    {
        protected T GetValueOrNull<T>(Object posibleNullable)
        {
            /*if (Nullable.GetUnderlyingType(typeof(T)) != null)
            {
                throw new Exception("No se aceptan tipos que no acepten nulos");
            }*/
            return (posibleNullable != DBNull.Value)? (T)posibleNullable : default(T);
        }
    }
}
