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
    }
}
