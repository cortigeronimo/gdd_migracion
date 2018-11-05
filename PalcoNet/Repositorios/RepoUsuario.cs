using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using PalcoNet.Config;

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

        public Boolean ExistsUser(Usuario user)
        {
            DataTable table = new DataTable();
            table = GetUserRow(user);

            if (table.Rows.Count != 0)
                return true;
            return false;
        }


        public Boolean ValidPassword(Usuario user)
        {
            byte[] textboxPassword = Hashing.GetSHA256Encrypt(user.Password);

            DataTable table = new DataTable();
            table = GetUserRow(user);

            byte[] dbPassword = (byte[])(table.Rows[0]["Usuario_Password"]);

            if (Hashing.EqualPasswords(textboxPassword, dbPassword))
                return true;
            return false;
          
        }


        public Boolean EnabledUser(Usuario user)
        {
            DataTable table = new DataTable();
            table = GetClientRow(user);

            if (IsAdmin(user))
            {
                user.IsAdmin = true;
                return true;
            }
            else
            {
                if (Convert.ToBoolean(table.Rows[0]["Cli_Habilitado"]))
                    return true;
                return false;
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

        public void AddFailedAttempt(Usuario user)
        {
            String updateSQL = "PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS";
            SqlCommand command = new SqlCommand(updateSQL);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", user.Username);

            Conexion.ExecuteProcedure(command);
        }


        //Obtener el row del usuario ingresado en el login
        private DataTable GetUserRow(Usuario user)
        {
            String query = "select * from " + userTable + " where Usuario_Username = @user";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@user", user.Username);

            DataTable table = new DataTable();
            table = Conexion.GetData(command);

            return table;
        }

        //Obtener el row del cliente asociado al usuario del login
        private DataTable GetClientRow(Usuario user)
        {
            String query = "select * from " + clientTable + " inner join " + userTable + " on Cli_Usuario = Usuario_Id and Usuario_Username = @user";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@user", user.Username);

            DataTable table = new DataTable();
            table = Conexion.GetData(command);

            return table;
        }

        //Verifica si el susuario tiene rol de admin
        private Boolean IsAdmin(Usuario user)
        {
            String SP = "PLEASE_HELP.SP_VERIFICAR_ADMIN";
            SqlCommand command = new SqlCommand(SP);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", user.Username);

            SqlParameter returnParameter = command.Parameters.Add("@esAdmin", SqlDbType.Bit);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            
            Conexion.ExecuteProcedure(command);

            return Convert.ToBoolean(returnParameter.Value);
        }

    }
}
