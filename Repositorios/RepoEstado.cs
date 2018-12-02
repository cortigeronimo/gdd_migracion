using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using PalcoNet.Config;
using PalcoNet.Modelo;
using PalcoNet.Utils;

namespace PalcoNet.Repositorios
{
    public class RepoEstado
    {
        public DataTable GetEstadosToGenerarPubForm()
        {
            String sp = "PLEASE_HELP.SP_GET_ESTADOS_TO_GENERAR_PUBLICACION";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;
            return Conexion.GetData(cmd);
        }
    }
}
