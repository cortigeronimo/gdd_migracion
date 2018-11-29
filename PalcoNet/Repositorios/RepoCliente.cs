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
    public class RepoCliente
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
            if (cliente.nroPiso == Byte.MinValue) command.Parameters.AddWithValue("@nropiso", DBNull.Value); else command.Parameters.AddWithValue("@nropiso", cliente.nroPiso);
            if (String.IsNullOrEmpty(cliente.depto)) command.Parameters.AddWithValue("@depto", DBNull.Value); else command.Parameters.AddWithValue("@depto", cliente.depto);
            if (String.IsNullOrEmpty(cliente.codigoPostal)) command.Parameters.AddWithValue("@codpostal", DBNull.Value); else command.Parameters.AddWithValue("@codpostal", cliente.codigoPostal);
            command.Parameters.AddWithValue("@fechanac", cliente.fechaNacimiento);
            command.Parameters.AddWithValue("@fechacreacion", cliente.fechaCreacion);
            if (String.IsNullOrEmpty(cliente.tarjetaCredito)) command.Parameters.AddWithValue("@tarjetacredito", DBNull.Value); else command.Parameters.AddWithValue("@tarjetacredito", cliente.tarjetaCredito);

            if (String.IsNullOrEmpty(cliente.username))
            {
                cliente.username = "USUARIO" + cliente.nroDocumento.ToString();
                cliente.SetPassword(cliente.nroDocumento.ToString());

                command.Parameters.AddWithValue("@firstLogin", 1);
            }
            else
            {
                command.Parameters.AddWithValue("@firstLogin", 0);
            }
            
            command.Parameters.AddWithValue("@username", cliente.username);
            command.Parameters.AddWithValue("@password", cliente.GetPassword());
            

            if (Conexion.InsertUpdateOrDeleteData(command) < 2)
                throw new Exception("No se ha podido registrar el cliente, intentelo nuevamente.");
        }

        public DataTable GetTable(Cliente cliente)
        {
            String query = BuildQuery(cliente);

            SqlCommand command = new SqlCommand(query);
            DataTable table = Conexion.GetData(command);
            return table;
        }

        public int GetPuntosClienteById(int id)
        {
            String query = "SELECT Cli_Puntos FROM " + clienteTable + " WHERE Cli_Usuario = @Id";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", id);
            return (int)Conexion.GetData(command).Rows[0]["Cli_Puntos"];
        }


        private String BuildQuery(Cliente cliente)
        {
            String query = "SELECT * FROM " + clienteTable + " ";
            Boolean firstWhere = true;
            Boolean hasWhere = false;

            if (cliente.nombre != String.Empty)
            {
                query += "WHERE Cli_Nombre LIKE " + "'%" + cliente.nombre + "%' " + "AND ";
                firstWhere = false;
                hasWhere = true;
            }

            if (cliente.apellido != String.Empty)
            {
                if (firstWhere)
                {
                    query += "WHERE Cli_Apellido LIKE " + "'%" + cliente.apellido + "%' " + "AND ";
                    firstWhere = false;
                }
                else
                {
                    query += "Cli_Apellido LIKE " + "'%" + cliente.apellido + "%' " + "AND ";
                }
                hasWhere = true;
            }

            if (cliente.nroDocumento != 0)
            {
                if (firstWhere)
                {
                    query += "WHERE Cli_Nro_Documento = " + cliente.nroDocumento + " AND ";
                    firstWhere = false;
                }
                else
                {
                    query += "Cli_Nro_Documento = " + cliente.nroDocumento + " AND ";
                }
                hasWhere = true;
            }

            if (cliente.email != String.Empty)
            {
                if (firstWhere)
                {
                    query += "WHERE Cli_Email LIKE " + "'%" + cliente.email + "%' " + "AND ";
                    firstWhere = false;
                }
                else 
                {
                    query += "Cli_Email LIKE " + "'%" + cliente.email + "%' " + "AND ";
                }
                hasWhere = true;
            }

            if (hasWhere)
                query = query.Substring(0, query.Length - 4);
            return query;
        }

        //Verifica DNI y cuil para Update
        public Boolean ExistsDNIAndCuil(String user, String tipoDoc, String nroDoc, String cuil)
        {
            String query = "SELECT * FROM ";
            query += clienteTable;
            query += " WHERE Cli_Usuario != @user";
            query += " AND Cli_Tipo_Documento = @tipoDoc";
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
        public Boolean ExistsDNIAndCuil(String tipoDoc, String nroDoc, String cuil)
        {
            String query = "SELECT * FROM ";
            query += clienteTable;
            
            query += " WHERE (Cli_Tipo_Documento = @tipoDoc";
            query += " AND Cli_Nro_Documento = @nroDoc)";
            query += " OR Cli_Cuil = @cuil";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@tipoDoc", tipoDoc);
            command.Parameters.AddWithValue("@nroDoc", nroDoc);
            command.Parameters.AddWithValue("@cuil", cuil);


            DataTable table = Conexion.GetData(command);
            return table.Rows.Count != 0;
        }

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

        public int AltaBajaCliente(Cliente cliente)
        {
            String query = "UPDATE " + clienteTable + " SET ";
            query += "Cli_Baja = @baja, ";
            query += "Cli_Habilitado = @habilitado, ";
            query += "Cli_Intentos_Fallidos = 0 ";
            query += "WHERE Cli_Usuario = @id";

            SqlCommand cmd = new SqlCommand(query);

            if (cliente.baja == true)
            {
                cmd.Parameters.AddWithValue("@baja", 0);
                cmd.Parameters.AddWithValue("@habilitado", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@baja", 1);
                cmd.Parameters.AddWithValue("@habilitado", 0);
            }
                


            cmd.Parameters.AddWithValue("@id", cliente.id);

            return Conexion.InsertUpdateOrDeleteData(cmd);
        }

        public Boolean TieneNroTarjeta(int userId)
        {
            Usuario user = new Usuario();
            user.id = userId;

            DataTable table = new RepoUsuario().GetClientRow(user);

            return table.Rows[0]["Cli_Tarjeta_Credito"] != DBNull.Value;
        }

        public void AddNroTarjetaCredito(int idUser, String nroTarjeta)
        {
            String sp = "PLEASE_HELP.SP_ADD_NRO_TARJETA_CREDITO";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userId", idUser);
            cmd.Parameters.AddWithValue("@numeroTarjeta", nroTarjeta);

            Conexion.ExecuteProcedure(cmd);
         
        }
        
    }
}
