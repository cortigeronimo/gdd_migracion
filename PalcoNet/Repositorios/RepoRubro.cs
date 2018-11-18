using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Repositorios
{
    public class RepoRubro
    {
        public DataTable GetRubros()
        {
            String query = "SELECT * FROM PLEASE_HELP.Rubro";
            SqlCommand command = new SqlCommand(query);
            return Conexion.GetData(command);
        }
    }
}
