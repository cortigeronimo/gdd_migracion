using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using PalcoNet.Modelo;

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

        public List<String> GetRubrosDescripcion()
        {
            String query = "SELECT * FROM PLEASE_HELP.Rubro";
            SqlCommand command = new SqlCommand(query);

            DataTable rubrosTable = Conexion.GetData(command);

            return FromRowsToList(rubrosTable);

        }

        private List<String> FromRowsToList(DataTable rubrosTable)
        {
            List<String> rubrosList = new List<String>();

            foreach (DataRow row in rubrosTable.Rows)
            {
                String rubroDescripcion;
                rubroDescripcion = row["Rubro_Descripcion"].ToString();

                rubrosList.Add(rubroDescripcion);
            }

            return rubrosList;
        }
    }
}
