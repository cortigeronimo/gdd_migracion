using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using PalcoNet.Config;

using PalcoNet.Modelo;

namespace PalcoNet.Repositorios
{
    class RepoUsuario
    {
        private String userTable = "PLEASE_HELP.Usuario";
        private String clientTable = "PLEASE_HELP.Cliente";

        //Esto era para mostrar un recorrer un datareader pero no funciona con la conexion cerrada... 
        /*
        public List<Usuario> GetUsuarios()
        {
            String query = "select * from " + userTable;
            SqlCommand command = new SqlCommand(query);
            SqlDataReader reader = Conexion.GetData(command);
            return this.RowsToUsers(reader);
        }

        public List<Usuario> RowsToUsers(SqlDataReader reader)
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
        */

        //Verifica si el usario existe en la DB
        public Boolean ExistsUser(Usuario user)
        {
            DataTable table = new DataTable();
            table = GetUserRow(user);

            return table.Rows.Count != 0;
        }

        //Verifica si la contraseña ingresada es correcta
        public Boolean ValidPassword(Usuario user)
        {
            byte[] textboxPassword = user.GetPassword();

            DataTable table = new DataTable();
            table = GetUserRow(user);

            byte[] dbPassword = (byte[])(table.Rows[0]["Usuario_Password"]);

            return Hashing.EqualPasswords(textboxPassword, dbPassword);
          
        }

        //Verifica si el usuario esta habilitado
        public Boolean EnabledUser(Usuario user)
        {
            DataTable table = new DataTable();
            table = GetClientRow(user);

            if (IsAdmin(user))
            {
                user.isAdmin = true;
                return true;
            }
            else
            {
                return Convert.ToBoolean(table.Rows[0]["Cli_Habilitado"]);
            }
        
        }


        /*
        public int GetFailedAttempts(Usuario user)
        {
            DataTable table = new DataTable();
            table = GetClientRow(user);

            return ((int)table.Rows[0]["Cli_Intentos_Fallidos"]);
        }
        */


        //Registra un intento fallido del usuario en la DB
        public void AddFailedAttempt(Usuario user)
        {
            String updateSQL = "PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS";
            SqlCommand command = new SqlCommand(updateSQL);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", user.username);

            Conexion.ExecuteProcedure(command);
        }


        //Obtener el row del usuario ingresado en el login
        private DataTable GetUserRow(Usuario user)
        {
            String query = "select * from " + userTable + " where Usuario_Username = @user";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@user", user.username);

            DataTable table = new DataTable();
            table = Conexion.GetData(command);

            return table;
        }

        //Obtener el row del cliente asociado al usuario del login
        private DataTable GetClientRow(Usuario user)
        {
            String query = "select * from " + clientTable + " inner join " + userTable + " on Cli_Usuario = Usuario_Id and Usuario_Username = @user";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@user", user.username);

            DataTable table = new DataTable();
            table = Conexion.GetData(command);

            return table;
        }

        
        //Obtener lista de roles de usuario
        private List<Rol> GetRolesUsuario(Usuario user)
        {
            String query = "PLEASE_HELP.SP_LISTA_ROLES_USUARIO";
            SqlCommand command = new SqlCommand(query);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@USERNAME", user.username);

            DataTable table = new DataTable();
            table = Conexion.GetData(command);

            //Seteo en el objeto usuario los objetos roles obtenidos
            user.SetRoles(FromRowsToRoles(table));

            return user.GetRoles();
        }

        //Pasar de datatable a lista de objetos
        private List<Rol> FromRowsToRoles(DataTable table)
        {
            List<Rol> roles = new List<Rol>();
            int i = 0;
            while (table.Rows.Count > i)
            {
                Rol rol = new Rol();
                rol.nombre = table.Rows[i][0].ToString();
                roles.Add(rol);
                i++;
            }
            return roles;
        }

        //Toma la lista de roles del usuario y verifica si tiene el rol de ADMIN
        private Boolean IsAdmin(Usuario user)
        {
            List<Rol> list = new List<Rol>();
            list = GetRolesUsuario(user);

            int i = 0;
            while (list.Count > i)
            {
                string nombreRol = list[i].nombre;
                if (nombreRol == "ADMINISTRATIVO")
                    return true;
                else
                    i++;     
            }

            return false;
        }

        //Resetea los intentos fallidos a cero ante un logueo correcto
        public void CleanFailedAttemps(Usuario user)
        {
            string username = user.username;

            string sp = "PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@USERNAME", username);

            Conexion.ExecuteProcedure(command);
        }


    }
}
