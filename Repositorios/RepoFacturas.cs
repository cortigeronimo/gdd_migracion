using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PalcoNet.Repositorios
{
    public class RepoFacturas : Repository
    {
        private String table = "PLEASE_HELP.Factura";

        public void RendirComisiones(int cantidadARendir, Decimal idPublicacion)
        {
            String sp = "PLEASE_HELP.SP_RENDIR_COMISIONES";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cantidadARendir", cantidadARendir);
            command.Parameters.AddWithValue("@idPublicacion", idPublicacion);

            if (Conexion.InsertUpdateOrDeleteData(command) < 1)
            {
                throw new Exception();
            }
        }
    }
}
