using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PalcoNet.Config;

namespace PalcoNet.Repositorios
{
    public class RepoFactura : Repository
    {
        private String table = "PLEASE_HELP.Factura";

        public void RendirComisiones(int cantidadARendir, Decimal idPublicacion)
        {
            String sp = "PLEASE_HELP.SP_RENDIR_COMISIONES";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cantidadARendir", cantidadARendir);
            command.Parameters.AddWithValue("@idPublicacion", idPublicacion);
            command.Parameters.AddWithValue("@fechaActual", SystemDate.GetDate());

            if (Conexion.InsertUpdateOrDeleteData(command) < 1)
            {
                throw new Exception();
            }
        }
    }
}
