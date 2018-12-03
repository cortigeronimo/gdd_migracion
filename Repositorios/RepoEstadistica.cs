using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace PalcoNet.Repositorios
{
    class RepoEstadistica : Repository
    {
        public List<ResultadoEstadistico> GetTop5Empresas(int anio, int trimestre)
        {
            string query = "EXEC PLEASE_HELP.SP_TOP5_EMPRESAS @anio , @trimestre";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@anio", anio);
            cmd.Parameters.AddWithValue("@trimestre", trimestre);
            DataTable result = Conexion.GetData(cmd);
            return FromRowsToResultadoEstadistico(result);
        }

        private List<ResultadoEstadistico> FromRowsToResultadoEstadistico(DataTable table)
        {
            List<ResultadoEstadistico> top5 = new List<ResultadoEstadistico>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                ResultadoEstadistico empresa =
                    new ResultadoEstadistico((string)table.Rows[i]["Emp_Razon_Social"], GetValueOrNull<string>(table.Rows[i]["Pub_Grado"]), table.Rows[i]["Mes"].ToString(), (int)table.Rows[i]["Localidades no vendidas"]);
                top5.Add(empresa);
                i++;
            }
            return top5;
        }

        public List<ResultadoEstadistico3> GetTop5ClientesCompras(int anio, int trimestre)
        {
            List<ResultadoEstadistico3> top5 = new List<ResultadoEstadistico3>();
            var empresas = new RepoEmpresa().GetEmpresas();
            string query = "EXEC PLEASE_HELP.SP_TOP5_CLIENTES_COMPRAS @trimestre , @anio , @empresa";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@trimestre", trimestre);
            cmd.Parameters.AddWithValue("@anio", anio);
            empresas.ForEach(e =>
            {
                cmd.Parameters.AddWithValue("@empresa", e.razonSocial);
                DataTable result = Conexion.GetData(cmd);
                var clientesComprasEmpresa = FromRowsToResultadoEstadistico3(result);
                top5.AddRange(clientesComprasEmpresa);
            });
            return top5;
        }

        private List<ResultadoEstadistico3> FromRowsToResultadoEstadistico3(DataTable table)
        {
            List<ResultadoEstadistico3> top5 = new List<ResultadoEstadistico3>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                ResultadoEstadistico3 cliente =
                    new ResultadoEstadistico3((int)table.Rows[i]["Cli_Usuario"], (string)table.Rows[i]["Cli_Apellido"] + (string)table.Rows[i]["Cli_Nombre"],
                                                    (int)table.Rows[i]["CantCompras"], (string)table.Rows[i]["Emp_Razon_Social"]);
                top5.Add(cliente);
                i++;
            }

            return top5;
        }
    }
}
