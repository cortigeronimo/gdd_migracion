using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Repositorios
{
    class RepoUsuario
    {
        private String tabla = "PLEASE_HELP.Usuario";

        public List<Usuario> getUsuarios()
        {
            String query = "select * from " + tabla;
            SqlCommand command = new SqlCommand(query);
            SqlDataReader reader = Conexion.obtenerDatos(command);
            return this.DeFilasAUsuarios(reader);
        }

        public List<Usuario> DeFilasAUsuarios(SqlDataReader reader)
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                while (reader.Read())
                {
                    //lee un row, lo mapea y lo mete en la lista
                }
                return usuarios;
            }
            finally
            {
                reader.Close();
            }

        }
    }
}
