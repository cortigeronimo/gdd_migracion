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
        private String tabla = "PLEASE_HELP.Grado";

        public void InsertGrado(Grado grado) {
            String query = "INSERT INTO " + tabla + " (Grado_Comision, Grado_Descripcion) VALUES (@comision, @descripcion)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@comision", grado.GetComision());
            command.Parameters.AddWithValue("@descripcion", grado.GetDescripcion());
            int result = Conexion.insertData(command);
            if(result < 1){
                throw new Exception("No se ha podido insertar el grado, intentelo nuevamente.");
            }
        }


        /*
        public List<Grado> GetGrados()
        {
            String query = "select * from " + tabla;
            SqlCommand command = new SqlCommand(query);
            SqlDataReader reader = Conexion.obtenerDatos(command);
            return FromRowsToGrados(reader);
        }

        public List<Grado> FromRowsToGrados(SqlDataReader reader)
        {
            List<Grado> grados = new List<Grado>();
            try
            {
                while (reader.Read())
                {
                    //lee un row, lo mapea y lo mete en la lista
                }
                return grados;
            }
            finally
            {
                reader.Close();
            }

        }
        */

        public List<Grado> GetGrados()
        {
            String query = "select * from " + tabla;
            SqlCommand command = new SqlCommand(query);
            DataTable table = new DataTable();
            table = Conexion.GetData(command);
            return FromRowsToGrados(table);
        }

        public List<Grado> FromRowsToGrados(DataTable table)
        {
            List<Grado> grados = new List<Grado>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                //lee un row, lo mapea y lo mete en la lista
                int comision = (int)table.Rows[i]["Grado_Comision"];
                String descripcion = table.Rows[i]["Grado_Descripcion"].ToString();
                Grado grado = new Grado(comision, descripcion);
                grados.Add(grado);
                i++;
            }
            return grados;

        }


    }
}
