using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Repositorios
{
    class RepoRol
    {
        private String table = "PLEASE_HELP.Rol";

        public Rol FindRolByName(String name)
        {
            String query = "select * from " + table + " where Rol_Nombre = @name";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@name", name);
            DataTable result = Conexion.GetData(command);
            return FromRowToRol(result);
        }

        private Rol FromRowToRol(DataTable table)
        {
            if (table.Rows.Count != 1)
            {
                throw new Exception("La tabla debe tener 1 solo resultado");
            }
            Rol rol = new Rol();
            rol.id = ((int)table.Rows[0]["Rol_Id"]);
            rol.nombre = ((String)table.Rows[0]["Rol_Nombre"]);
            rol.habilitado = ((bool)table.Rows[0]["Rol_Habilitado"]);

            return rol;
        }
    }
}
