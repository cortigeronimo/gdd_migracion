using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PalcoNet.Repositorios
{
    class RepoRol
    {
        private string table = "PLEASE_HELP.Rol";

        public List<Funcionalidad> GetFuncionalidades(string filter)
        {
            String query = "SELECT * FROM PLEASE_HELP.Funcionalidad f WHERE f.Func_Desc LIKE @filtro ORDER BY f.Func_Id;";
            SqlCommand command = new SqlCommand(query);
            string filtro = "%"+filter+"%";
            command.Parameters.AddWithValue("@filtro", filtro);
            DataTable result = Conexion.GetData(command);
            return FromRowsToFuncionalidades(result);
        }

        public List<Rol> GetRoles()
        {
            String query = "select * from " + table + " ;";
            SqlCommand cmd = new SqlCommand(query);
            DataTable result = Conexion.GetData(cmd);
            return FromRowsToRoles(result);
        }

        private List<Funcionalidad> FromRowsToFuncionalidades(DataTable table)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                Funcionalidad funcionalidad = new Funcionalidad((int)table.Rows[i]["Func_Id"],(string)table.Rows[i]["Func_Desc"]);
                funcionalidades.Add(funcionalidad);
                i++;
            }
            return funcionalidades;
        }

        private List<Rol> FromRowsToRoles(DataTable table)
        {
            List<Rol> roles = new List<Rol>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                Rol rol = new Rol((int)table.Rows[i]["Rol_Id"], (string)table.Rows[i]["Rol_Nombre"], (bool)table.Rows[i]["Rol_Habilitado"]);
                roles.Add(rol);
                i++;
            }
            return roles;
        }

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
            Rol rol = new Rol((int)table.Rows[0]["Rol_Id"],(String)table.Rows[0]["Rol_Nombre"],(bool)table.Rows[0]["Rol_Habilitado"]);

            return rol;
        }

        public DataTable GetFuncionalidades(Rol rol)
        {
            String sp = "PLEASE_HELP.SP_LISTA_FUNCIONALIDADES";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idRol", rol.Id);

            return Conexion.GetData(command);
        }
    }
}
