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
        public List<ResultadoEstadistico> GetTop5Empresas(int anio, int trimestre, int grado)
        {
            string query = "EXEC PLEASE_HELP.SP_TOP5_EMPRESAS @anio , @trimestre , @grado";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@anio", anio);
            cmd.Parameters.AddWithValue("@trimestre", trimestre);
            cmd.Parameters.AddWithValue("@grado", grado);
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
                    new ResultadoEstadistico((string)table.Rows[i]["Emp_Razon_Social"], GetValueOrNull<string>(table.Rows[i]["Pub_Grado"]), (int)table.Rows[i]["Localidades no vendidas"]);
                top5.Add(empresa);
                i++;
            }
            return top5;
        }

        public List<ResultadoEstadistico3> GetTop5ClientesCompras(int anio, int trimestre, int? empresaId)
        {
            List<ResultadoEstadistico3> top5 = new List<ResultadoEstadistico3>();
            string query = "EXEC PLEASE_HELP.SP_TOP5_CLIENTES_COMPRAS @trimestre , @anio , @empresa";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@trimestre", trimestre);
            cmd.Parameters.AddWithValue("@anio", anio);
            cmd.Parameters.AddWithValue("@empresa", empresaId);
            DataTable result = Conexion.GetData(cmd);
            top5 = FromRowsToResultadoEstadistico3(result);
            return top5;
        }

        private List<ResultadoEstadistico3> FromRowsToResultadoEstadistico3(DataTable table)
        {
            List<ResultadoEstadistico3> top5 = new List<ResultadoEstadistico3>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                int id = (int)table.Rows[i]["Cli_Usuario"];
                string clienteNombre = (string)table.Rows[i]["Cli_Apellido"] + " " + (string)table.Rows[i]["Cli_Nombre"];
                int cant = Convert.ToInt32(table.Rows[i]["CantCompras"]);
                string empresa = (string)table.Rows[i]["Emp_Razon_Social"];
                ResultadoEstadistico3 cliente = new ResultadoEstadistico3(id, clienteNombre, cant, empresa);
                top5.Add(cliente);
                i++;
            }

            return top5;
        }

        public List<ResultadoEstadistico2> GetTop5ClientesPuntos(int anio, int trimestre)
        {
            List<ResultadoEstadistico2> top5 = new List<ResultadoEstadistico2>();
            string query = "EXEC PLEASE_HELP.SP_TOP5_CLIENTES_PUNTOS @trimestre , @anio ";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@trimestre", trimestre);
            cmd.Parameters.AddWithValue("@anio", anio);
            DataTable result = Conexion.GetData(cmd);
            return FromRowsToResultadoEstadistico2(result);
        }

        private List<ResultadoEstadistico2> FromRowsToResultadoEstadistico2(DataTable table)
        {
            List<ResultadoEstadistico2> top5 = new List<ResultadoEstadistico2>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                int id = Convert.ToInt32(table.Rows[i]["Cli_Usuario"]);
                string clienteNombre = Convert.ToString(table.Rows[i]["Cli_Apellido"]) + " " + Convert.ToString(table.Rows[i]["Cli_Nombre"]);
                int puntos = Convert.ToInt32(table.Rows[i]["PuntosVencidos"]);
                ResultadoEstadistico2 cliente = new ResultadoEstadistico2(id,clienteNombre,puntos);
                top5.Add(cliente);
                i++;
            }
            return top5;
        }
    }
}
