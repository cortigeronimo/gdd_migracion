using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PalcoNet.Abm_Grado;
using PalcoNet.Utils;

namespace PalcoNet.Repositorios
{
    public class RepoGradoPublicacion
    {
        private String table = "PLEASE_HELP.Grado";

        public void InsertGrado(Grado grado) {
            String query = "INSERT INTO " + table + " (Grado_Comision, Grado_Descripcion) VALUES (@comision, @descripcion)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@comision", grado.Comision);
            command.Parameters.AddWithValue("@descripcion", grado.Descripcion);
            int result = Conexion.InsertUpdateOrDeleteData(command);
            if(result < 1){
                throw new Exception("No se ha podido insertar el grado, intentelo nuevamente.");
            }
        }

        public int UpdateGrado(Grado grado)
        {
            String query = "update " + table + " set ";
            query += "Grado_Comision = @comision, ";
            query += "Grado_Descripcion = @descripcion ";
            query += "where Grado_Id = @id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@comision", grado.Comision);
            command.Parameters.AddWithValue("@descripcion", grado.Descripcion);
            command.Parameters.AddWithValue("@id", grado.Id);

            return Conexion.InsertUpdateOrDeleteData(command);
        }

        public int DeleteGrado(Grado grado)
        {
            String query = "delete from " + table + " where ";
            query += "Grado_Id = @id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@id", grado.Id);

            return Conexion.InsertUpdateOrDeleteData(command);
        }

        public List<Grado> GetGradosBy(String descripcion, String comision){
            SqlCommand command = new SqlCommand();
            String query = "select g.* from " + table + " g where 1 = 1 ";
            query += SqlHelper.AddFilterFullLikeThan("g", "Grado_Descripcion", descripcion, command);
            query += SqlHelper.AddFilterEqualsThan("g", "Grado_Comision", comision, command);
            command.CommandText = query;
            return FromRowsToGrados(Conexion.GetData(command));
        }

        public List<Grado> GetGrados()
        {
            String query = "select * from " + table;
            SqlCommand command = new SqlCommand(query);
            DataTable result = Conexion.GetData(command);
            return FromRowsToGrados(result);
        }

        public List<Grado> FromRowsToGrados(DataTable table)
        {
            List<Grado> grados = new List<Grado>();
            foreach(DataRow row in table.Rows)
            {
                int id =  (int)row["Grado_Id"];
                int comision = (int)row["Grado_Comision"];
                String descripcion = (String)row["Grado_Descripcion"];
                Grado grado = new Grado(id, comision, descripcion);
                grados.Add(grado);
            }
            return grados;

        }

        public DataTable GetGradosDataTable()
        {
            String query = "SELECT * FROM " + table;
            SqlCommand command = new SqlCommand(query);
            return Conexion.GetData(command);
        }

        public bool ExistsGrado(String nombre)
        {
            String query = "SELECT 1 FROM " + table + " WHERE Grado_Descripcion LIKE @nombre";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@nombre", nombre.ToUpper());
            return Conexion.GetData(command).Rows.Count != 0;
        }

    }
}
