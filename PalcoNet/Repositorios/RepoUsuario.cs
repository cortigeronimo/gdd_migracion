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
    public class RepoUsuario
    {
        private String userTable = "PLEASE_HELP.Usuario";
        private String clientTable = "PLEASE_HELP.Cliente";
        private String empresaTable = "PLEASE_HELP.Empresa";

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


        public void ChangePassword(String password)
        {
            String sp = "PLEASE_HELP.SP_CAMBIAR_CONTRASEÑA";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            byte[] hashPassword = Hashing.GetSHA256Encrypt(password);

            cmd.Parameters.AddWithValue("@idUser", UserSession.UserId);
            cmd.Parameters.AddWithValue("@password", hashPassword);

            Conexion.ExecuteProcedure(cmd);
        }



        public Boolean FirstLogin(int? userId, int rolId)
        {
            String sp = "PLEASE_HELP.SP_PRIMER_LOGIN";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idUser", userId);
            cmd.Parameters.AddWithValue("@idRol", rolId);

            SqlParameter firstLogin = new SqlParameter("@primerLogin", SqlDbType.Bit);
            firstLogin.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(firstLogin);

            Conexion.ExecuteProcedure(cmd);
            return Convert.ToBoolean(firstLogin.Value);

        }

        



        //Verifica si el usario existe en la DB
        public Boolean ExistsUser(Usuario user)
        {
            DataTable table = new DataTable();
            table = GetUserRow(user);

            if (table.Rows.Count != 0)
            {
                user.id = (int)table.Rows[0]["Usuario_Id"];
                return true;
            }
            return false;

            //return table.Rows.Count != 0;
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

        //Verifica si el usuario esta habilitado y si es cliente, empresa o usuario
        public Boolean EnabledUser(Usuario user)
        {
            DataTable table = new DataTable();

            if (IsAdmin(user))
            {
                user.isAdmin = true;
                
                return true;
            }
            else
            {
                if (IsClient(user))
                {
                    user.isClient = true;
                    table = GetClientRow(user);
                    return Convert.ToBoolean(table.Rows[0]["Cli_Habilitado"]);
                }
                else
                {
                    user.isClient = false;
                    table = GetEmpresaRow(user);
                    return Convert.ToBoolean(table.Rows[0]["Emp_Habilitado"]);
                }

            }

        }


        //Registra un intento fallido del usuario en la DB
        public void AddFailedAttempt(Usuario user)
        {
            if (user.isClient)
            {
                String updateSQL = "PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_CLIENTE";
                SqlCommand command = new SqlCommand(updateSQL);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@USERID", user.id);

                Conexion.ExecuteProcedure(command);
            }
            else
            {
                String updateSQL = "PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_EMPRESA";
                SqlCommand command = new SqlCommand(updateSQL);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@USERID", user.id);

                Conexion.ExecuteProcedure(command);
            }
        }


        //Obtener el row del usuario ingresado en el login
        private DataTable GetUserRow(Usuario user)
        {
            String query = "select * from " + userTable + " where Usuario_Username = @username";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@username", user.username);

            DataTable table = new DataTable();
            table = Conexion.GetData(command);

            return table;
        }

        //Obtener el row del cliente asociado al usuario del login
        public DataTable GetClientRow(Usuario user)
        {
            String query = "select * from " + clientTable + " where Cli_Usuario = @userId";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@userId", user.id);

            DataTable table = new DataTable();
            table = Conexion.GetData(command);

            return table;
        }

        //Obtener el row de la empresa asociado al usuario del login
        private DataTable GetEmpresaRow(Usuario user)
        {
            String query = "select * from " + empresaTable + " where Emp_Usuario = @userId";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@userId", user.id);

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
                rol.id = (int)table.Rows[i][0];
                rol.nombre = table.Rows[i][1].ToString();
                rol.habilitado = (bool)table.Rows[i][2];
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


        //Verifica si usuario ingresado en el form es cliente
        private Boolean IsClient(Usuario user)
        {
            String query = "select * from " + clientTable + " where Cli_Usuario = @userId";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@userId", user.id);
            DataTable table = Conexion.GetData(command);

            return table.Rows.Count != 0;

        }

        //Resetea los intentos fallidos a cero ante un logueo correcto
        public void CleanFailedAttemps(Usuario user)
        {
            if (user.isClient)
            {
                string sp = "PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_CLIENTE";
                SqlCommand command = new SqlCommand(sp);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@USERID", user.id);

                Conexion.ExecuteProcedure(command);
            }
            else
            {
                string sp = "PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_EMPRESA";
                SqlCommand command = new SqlCommand(sp);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@USERID", user.id);

                Conexion.ExecuteProcedure(command);
            }
        }


    }
}
