using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet
{
    public class Conexion
    {
        public SqlConnection con { get; set; }

        public Conexion()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["palconet"].ConnectionString);
        }


    }
}
