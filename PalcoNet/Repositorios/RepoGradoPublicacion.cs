using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PalcoNet.Abm_Grado;

namespace PalcoNet.Repositorios
{
    public class RepoGradoPublicacion
    {
        private String table = "PLEASE_HELP.Grado";

        public void InsertGrado(Grado grado) {
            String query = "INSERT INTO " + table + " (Grado_Comision, Grado_Descripcion) VALUES (@comision, @descripcion)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@comision", grado.GetComision());
            command.Parameters.AddWithValue("@descripcion", grado.GetDescripcion());
            int result = Conexion.insertOrUpdateData(command);
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
            command.Parameters.AddWithValue("@comision", grado.GetComision());
            command.Parameters.AddWithValue("@descripcion", grado.GetDescripcion());
            command.Parameters.AddWithValue("@id", grado.getId());

            return Conexion.insertOrUpdateData(command);
        }

        public DataTable GetGradosBy(Grado grado){
            String query = "select g.* from " + table + " g ";
            query += "where g.Grado_Comision = @comision ";
            query += "and g.Grado_Descripcion = @descripcion";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@comision", grado.GetComision());
            command.Parameters.AddWithValue("@descripcion", grado.GetDescripcion());
            Console.WriteLine(query);
            return Conexion.GetData(command);
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
            int i = 0;
            while (i < table.Rows.Count)
            {
                //lee un row, lo mapea y lo mete en la lista
                int comision = (int)table.Rows[i]["Grado_Comision"];
                String descripcion = (String)table.Rows[i]["Grado_Descripcion"];
                Grado grado = new Grado(comision, descripcion);
                grados.Add(grado);
                i++;
            }
            return grados;

        }


    }
}
