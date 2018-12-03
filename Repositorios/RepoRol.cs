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
        public static readonly String ROL_CLIENTE = "CLIENTE";
        public static readonly String ROL_ADMINISTRATIVO = "ADMINISTRATIVO";
        public static readonly String ROL_EMPRESA = "EMPRESA";

        public List<Funcionalidad> GetFuncionalidades(string filter)
        {
            String query = "SELECT * FROM PLEASE_HELP.Funcionalidad f WHERE f.Func_Desc LIKE @filtro ORDER BY f.Func_Id;";
            SqlCommand command = new SqlCommand(query);
            string filtro = "%"+filter+"%";
            command.Parameters.AddWithValue("@filtro", filtro);
            DataTable result = Conexion.GetData(command);
            return FromRowsToFuncionalidades(result);
        }

        public List<Funcionalidad> GetFuncionalidades(int rolId)
        {
            String query = "SELECT rf.Rol_Id, f.* FROM PLEASE_HELP.Rol_Funcionalidad rf INNER JOIN PLEASE_HELP.Funcionalidad f ON rf.Func_Id = f.Func_Id WHERE rf.Rol_Id = @idRol ORDER BY f.Func_Id;";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@idRol", rolId);
            DataTable result = Conexion.GetData(command);
            return FromRowsToFuncionalidades(result);
        }

        public List<Rol> FindClienteAndEmpresaRolOnlyEnableEnable()
        {
            String query = "SELECT * FROM PLEASE_HELP.Rol r ";
            query += "WHERE Rol_nombre IN ('" + ROL_CLIENTE + "', '" + ROL_EMPRESA + "') ";
            query += "AND Rol_Habilitado = 1";
            SqlCommand command = new SqlCommand(query);
            DataTable result = Conexion.GetData(command);
            return FromRowsToRoles(result);
        }

        public List<Rol> GetRoles()
        {
            String query = "select * from " + table + " WHERE Rol_Baja = 0;";
            SqlCommand cmd = new SqlCommand(query);
            DataTable result = Conexion.GetData(cmd);
            return FromRowsToRoles(result);
        }
        
        public List<Rol> GetRolesByFilter(string nombre, bool habilitado, string funcionalidad)
        {
            SqlCommand command;
            if (funcionalidad != "")
            {
                string query = "SELECT distinct r.* FROM PLEASE_HELP.Rol r INNER JOIN PLEASE_HELP.Rol_Funcionalidad rf ON r.Rol_Id = rf.Rol_Id INNER JOIN PLEASE_HELP.Funcionalidad f ON rf.Func_Id = f.Func_Id WHERE r.Rol_Baja = 0 AND f.Func_Desc = @funcionalidad AND r.Rol_Habilitado = @habilitado AND r.Rol_Nombre LIKE @nombre ;";
                command = new SqlCommand(query);
                command.Parameters.AddWithValue("@funcionalidad", funcionalidad);
            }
            else
            {
                string query = "SELECT * FROM PLEASE_HELP.Rol r WHERE r.Rol_Baja = 0 AND r.Rol_Habilitado = @habilitado AND r.Rol_Nombre LIKE @nombre ;";
                command = new SqlCommand(query);
            }
            command.Parameters.AddWithValue("@habilitado", habilitado);
            string nombre2 = "%" + nombre + "%";
            command.Parameters.AddWithValue("@nombre", nombre2);
            DataTable result = Conexion.GetData(command);
            List<Rol> roles = FromRowsToRoles(result);
            return roles;
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
            String query = "select * from " + table + " where Rol_Baja = 0 AND Rol_Nombre = @name";
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

        public void UpdateRol(Rol rol)
        {
            string query = "UPDATE " + table + " SET Rol_Nombre = @nombre , Rol_Habilitado = @habilitado WHERE Rol_Id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
            cmd.Parameters.AddWithValue("@habilitado", rol.Habilitado);
            cmd.Parameters.AddWithValue("@id", rol.Id);
            int result = (int)Conexion.InsertUpdateOrDeleteData(cmd);
            if (result < 1)
            {
                throw new Exception("No se pudo modificar el rol");
            }
            if (!rol.Habilitado)
            {
                DeleteRolFromUsers(rol);
            }
            UpdateFuncionalidades(rol);

        }

        public void DeleteRolFromUsers(Rol rol)
        {
            string query = "DELETE PLEASE_HELP.Usuario_Rol WHERE Rol_Id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", rol.Id);
            //TODO validar posibles fallas
            int result2 = (int)Conexion.InsertUpdateOrDeleteData(cmd);
        }

        public void UpdateFuncionalidades(Rol rol)
        {
            string query = "DELETE PLEASE_HELP.Rol_Funcionalidad WHERE Rol_Id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", rol.id);
            //TODO Validar posibles fallas
            int result = (int)Conexion.InsertUpdateOrDeleteData(cmd);
            rol.funcionalidades.ForEach(f => InsertFuncionalidad(f.Id, rol.Id));
        }

        public void CreateRol(Rol rol)
        {

            string query = "INSERT INTO " + table + "(Rol_Nombre, Rol_Habilitado) VALUES (@nombre, 1)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@nombre", rol.nombre);
            int result = Conexion.InsertUpdateOrDeleteData(cmd);
            if (result < 1)
            {
                throw new Exception("No se pudo crear el rol");
            }

            string query2 = "SELECT Rol_Id FROM " + table + " WHERE Rol_Baja = 0 AND Rol_Nombre = @nombre";
            SqlCommand cmd2 = new SqlCommand(query2);
            cmd2.Parameters.AddWithValue("@nombre", rol.nombre);
            rol.id = (int)Conexion.GetData(cmd2).Rows[0]["Rol_Id"];

            rol.funcionalidades.ForEach(f => InsertFuncionalidad(f.Id, rol.Id));
        }

        public void InsertFuncionalidad(int funcId, int rolId)
        {
            string query = "INSERT INTO PLEASE_HELP.Rol_Funcionalidad(Rol_Id, Func_Id) VALUES (@rolId, @funcId);";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@rolId", rolId);
            cmd.Parameters.AddWithValue("@funcId", funcId);
            int result = (int)Conexion.InsertUpdateOrDeleteData(cmd);
            //TODO Validar posibles fallas.
        }

        public bool ExisteRol(string nombre)
        {
            string query = "SELECT COUNT(*) cantidad FROM " + table + " where Rol_Baja = 0 AND Rol_Nombre = @nombre";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@nombre", nombre);
            DataTable result = Conexion.GetData(command);
            return (int)result.Rows[0]["cantidad"] > 0;

        }

        public void DeleteRol(Rol rol)
        {
            string query = "UPDATE " + table + " SET Rol_Habilitado = 0 , Rol_Baja = 1 WHERE Rol_Id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", rol.Id);
            int result = (int)Conexion.InsertUpdateOrDeleteData(cmd);
            if (result < 1)
            {
                throw new Exception("Error al eliminar el rol");
            }
            DeleteRolFromUsers(rol);
        }
    }
}
