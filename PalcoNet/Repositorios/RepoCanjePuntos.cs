using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PalcoNet.Modelo;
using PalcoNet.Utils;

namespace PalcoNet.Repositorios
{
    class RepoCanjePuntos
    {
        private String table = "PLEASE_HELP.Premio";

        public List<Premio> GetPremiosBy(String puntos)
        {
            SqlCommand command = new SqlCommand();
            String query = "select p.* from " + table + " p where 1 = 1 ";
            query += SqlHelper.AddFilter("p", "Premio_puntos", puntos, command);
            command.CommandText = query;
            return FromRowsToPremios(Conexion.GetData(command));
        }

        public List<Premio> FromRowsToPremios(DataTable table)
        {
            List<Premio> grados = new List<Premio>();
            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["Premio_Id"];
                String descripcion = (String)row["Premio_Descripcion"];
                int puntos = (int) row["Premio_Puntos"];
                Premio premio = new Premio(id, descripcion, puntos);
                grados.Add(premio);
            }
            return grados;

        }
    }
}
