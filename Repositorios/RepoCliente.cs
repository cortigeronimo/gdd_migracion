using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using System.Data;
using System.Data.SqlClient;
using PalcoNet.Config;

namespace PalcoNet.Repositorios
{
    public class RepoCliente : Repository
    {
        private String clienteTable = "PLEASE_HELP.Cliente";

        public void InsertCliente(Cliente cliente)
        {
            String sp = "PLEASE_HELP.SP_ALTA_CLIENTE";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nombre", cliente.nombre);
            command.Parameters.AddWithValue("@apellido", cliente.apellido);
            command.Parameters.AddWithValue("@tipo_doc", cliente.tipoDocumento);
            command.Parameters.AddWithValue("@nro_doc", cliente.nroDocumento);
            command.Parameters.AddWithValue("@cuil", cliente.cuil);
            command.Parameters.AddWithValue("@email", cliente.email);
            command.Parameters.AddWithValue("@telefono", cliente.telefono);
            command.Parameters.AddWithValue("@localidad", cliente.localidad);
            command.Parameters.AddWithValue("@direccion", cliente.direccion);
            if (cliente.nroPiso == null) command.Parameters.AddWithValue("@nropiso", DBNull.Value); else command.Parameters.AddWithValue("@nropiso", cliente.nroPiso);
            
            command.Parameters.AddWithValue("@depto", cliente.depto);
            command.Parameters.AddWithValue("@codpostal", cliente.codigoPostal);
            command.Parameters.AddWithValue("@fechanac", cliente.fechaNacimiento);
            command.Parameters.AddWithValue("@fechacreacion", cliente.fechaCreacion);
            command.Parameters.AddWithValue("@tarjetacredito", cliente.tarjetaCredito);
            command.Parameters.AddWithValue("@firstLogin", 1);            
            command.Parameters.AddWithValue("@username", cliente.username);
            command.Parameters.AddWithValue("@password", cliente.GetPassword());    

            if (Conexion.InsertUpdateOrDeleteData(command) < 2)
                throw new Exception("No se ha podido registrar el cliente, intentelo nuevamente.");
        }

        public List<Cliente> GetClientesByFilter(String nombre, String apellido, String documento, String email)
        {
            String query = "SELECT * FROM " + clienteTable + " WHERE 1 = 1 ";

            if (nombre != String.Empty)
            {
                query += "AND Cli_Nombre LIKE " + "'%" + nombre + "%' ";
            }

            if (apellido != String.Empty)
            {
                query += "AND Cli_Apellido LIKE " + "'%" + apellido + "%' ";
            }

            if (documento != String.Empty)
            {
                query += "AND Cli_Nro_Documento = " + documento + " ";

            }

            if (email != String.Empty)
            {
                query += "AND Cli_Email LIKE " + "'%" + email + "%' ";
            }

            SqlCommand command = new SqlCommand(query);
            return FromRowsToClientes(Conexion.GetData(command));
        }         

        //Verifica DNI y cuil
        public Boolean ExistsDNIAndCuil(int? user, String tipoDoc, String nroDoc, String cuil)
        {
            String query = "SELECT * FROM ";
            query += clienteTable;
            query += " WHERE Cli_Usuario != @user";
            //query += " AND Cli_Tipo_Documento = @tipoDoc";
            query += " AND (Cli_Nro_Documento = @nroDoc";
            query += " OR Cli_Cuil = @cuil)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@tipoDoc", tipoDoc);
            command.Parameters.AddWithValue("@nroDoc", nroDoc);
            command.Parameters.AddWithValue("@cuil", cuil);


            DataTable table = Conexion.GetData(command);
            return table.Rows.Count != 0;
        }



        //Verifica DNI y cuil para Insert
        //public Boolean ExistsDNIAndCuil(String tipoDoc, String nroDoc, String cuil)
        //{
        //    String query = "SELECT * FROM ";
        //    query += clienteTable;
            
        //    query += " WHERE (Cli_Tipo_Documento = @tipoDoc";
        //    query += " AND Cli_Nro_Documento = @nroDoc)";
        //    query += " OR Cli_Cuil = @cuil";

        //    SqlCommand command = new SqlCommand(query);
        //    command.Parameters.AddWithValue("@tipoDoc", tipoDoc);
        //    command.Parameters.AddWithValue("@nroDoc", nroDoc);
        //    command.Parameters.AddWithValue("@cuil", cuil);


        //    DataTable table = Conexion.GetData(command);
        //    return table.Rows.Count != 0;
        //}

        public int UpdateCliente(Cliente cliente)
        {
            String query = "UPDATE " + clienteTable + " SET ";
            query += "Cli_Tarjeta_Credito = @tarjetaCredito, ";
            query += "Cli_Nombre = @nombre, ";
            query += "Cli_Apellido = @apellido, ";
            query += "Cli_Tipo_Documento = @tipoDoc, ";
            query += "Cli_Nro_Documento = @nroDoc, ";
            query += "Cli_Cuil = @cuil, ";
            query += "Cli_Email = @email, ";
            query += "Cli_Telefono = @telefono, ";
            query += "Cli_Localidad = @localidad, ";
            query += "Cli_Direccion = @direccion, ";
            query += "Cli_Nro_Piso = @nroPiso, ";
            query += "Cli_Depto = @depto, ";
            query += "Cli_Cod_Postal = @codPostal, ";
            query += "Cli_Fecha_Nac = @fechaNac, ";
            query += "Cli_Fecha_Creacion = @fechaCreacion ";
            query += "WHERE Cli_Usuario = @idUsuario";

            SqlCommand cmd = new SqlCommand(query);

            if (String.IsNullOrEmpty(cliente.tarjetaCredito)) cmd.Parameters.AddWithValue("@tarjetaCredito", DBNull.Value); else cmd.Parameters.AddWithValue("@tarjetaCredito", cliente.tarjetaCredito);
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
            cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDocumento);
            cmd.Parameters.AddWithValue("@nroDoc", cliente.nroDocumento);
            cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
            cmd.Parameters.AddWithValue("@localidad", cliente.localidad);
            cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
            if (cliente.nroPiso == Byte.MinValue) cmd.Parameters.AddWithValue("@nroPiso", DBNull.Value); else cmd.Parameters.AddWithValue("@nroPiso", cliente.nroPiso);
            if (String.IsNullOrEmpty(cliente.depto)) cmd.Parameters.AddWithValue("@depto", DBNull.Value); else cmd.Parameters.AddWithValue("@depto", cliente.depto);
            if (String.IsNullOrEmpty(cliente.codigoPostal)) cmd.Parameters.AddWithValue("@codPostal", DBNull.Value); else cmd.Parameters.AddWithValue("@codPostal", cliente.codigoPostal);
            cmd.Parameters.AddWithValue("@fechaNac", cliente.fechaNacimiento);
            cmd.Parameters.AddWithValue("@fechaCreacion", cliente.fechaCreacion);
            cmd.Parameters.AddWithValue("@idUsuario", cliente.id);

            return Conexion.InsertUpdateOrDeleteData(cmd);
        }

        public int AltaBajaCliente(int? id, bool baja)
        {
            String query = "UPDATE " + clienteTable + " SET ";
            query += "Cli_Baja = @baja, ";
            query += "Cli_Habilitado = @habilitado, ";
            query += "Cli_Intentos_Fallidos = 0 ";
            query += "WHERE Cli_Usuario = @id";

            SqlCommand cmd = new SqlCommand(query);

            if (baja)
            {
                cmd.Parameters.AddWithValue("@baja", 0);
                cmd.Parameters.AddWithValue("@habilitado", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@baja", 1);
                cmd.Parameters.AddWithValue("@habilitado", 0);
            }
                


            cmd.Parameters.AddWithValue("@id", id);

            return Conexion.InsertUpdateOrDeleteData(cmd);
        }

        public Boolean HasCreditCard(int? userId)
        {
            Usuario user = new Usuario();
            user.id = userId;

            DataTable table = new RepoUsuario().GetClientRow(user);

            return table.Rows[0]["Cli_Tarjeta_Credito"] != DBNull.Value;
        }

        public void AddNroTarjetaCredito(int? idUser, String nroTarjeta)
        {
            String sp = "PLEASE_HELP.SP_ADD_NRO_TARJETA_CREDITO";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userId", idUser);
            cmd.Parameters.AddWithValue("@numeroTarjeta", nroTarjeta);

            Conexion.ExecuteProcedure(cmd);
         
        }

        public String GetEmailCliente(int? idUser)
        {
            Usuario user = new Usuario();
            user.id = idUser;

            DataTable table = new RepoUsuario().GetClientRow(user);

            return table.Rows[0]["Cli_Email"].ToString();
        }

        private List<Cliente> FromRowsToClientes(DataTable table)
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow row in table.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.id = GetValueOrNull<int?>(row["Cli_Usuario"]);
                cliente.nombre = GetValueOrNull<String>(row["Cli_Nombre"]);
                cliente.apellido = GetValueOrNull<String>(row["Cli_Apellido"]);
                cliente.tipoDocumento = GetValueOrNull<String>(row["Cli_Tipo_Documento"]);
                cliente.nroDocumento = GetValueOrNull<decimal>(row["Cli_Nro_Documento"]);
                cliente.cuil = GetValueOrNull<decimal>(row["Cli_Cuil"]);
                cliente.email = GetValueOrNull<String>(row["Cli_Email"]);
                cliente.telefono = Convert.ToInt64(GetValueOrNull<decimal>(row["Cli_Telefono"]));           //cambié int por decimal 4/12
                cliente.localidad = GetValueOrNull<String>(row["Cli_Localidad"]);
                cliente.direccion = GetValueOrNull<String>(row["Cli_Direccion"]);
                cliente.nroPiso = GetValueOrNull<decimal>(row["Cli_Nro_Piso"]);
                cliente.depto = GetValueOrNull<String>(row["Cli_Depto"]);
                cliente.codigoPostal = GetValueOrNull<String>(row["Cli_Cod_Postal"]);
                cliente.fechaNacimiento = GetValueOrNull<DateTime>(row["Cli_Fecha_Nac"]);
                cliente.fechaCreacion = GetValueOrNull<DateTime>(row["Cli_Fecha_Creacion"]);
                cliente.tarjetaCredito = GetValueOrNull<String>(row["Cli_Tarjeta_Credito"]);
                cliente.habilitado = GetValueOrNull<bool>(row["Cli_Habilitado"]);
                cliente.intentosFallidos = GetValueOrNull<Int16>(row["Cli_Intentos_Fallidos"]);
                cliente.baja = GetValueOrNull<bool>(row["Cli_Baja"]);
                cliente.primerLogin = GetValueOrNull<bool>(row["Cli_Primer_Login"]);
                clientes.Add(cliente);
            }
            return clientes;
        }
        
    }
}
