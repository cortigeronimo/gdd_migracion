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
        private String usuarioTable = "PLEASE_HELP.Usuario";

        public void InsertCliente(Cliente cliente)
        {
            String sp = "PLEASE_HELP.SP_ALTA_CLIENTE";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@tipo_doc", cliente.TipoDocumento);
            command.Parameters.AddWithValue("@nro_doc", cliente.NroDocumento);
            command.Parameters.AddWithValue("@cuil", cliente.CUIL);
            command.Parameters.AddWithValue("@email", cliente.Email);
            command.Parameters.AddWithValue("@telefono", cliente.Telefono);
            command.Parameters.AddWithValue("@localidad", cliente.Localidad);
            command.Parameters.AddWithValue("@direccion", cliente.Direccion);
            command.Parameters.AddWithValue("@nropiso", cliente.NroPiso);
            command.Parameters.AddWithValue("@depto", cliente.Depto);
            command.Parameters.AddWithValue("@codpostal", cliente.CodigoPostal);
            command.Parameters.AddWithValue("@fechanac", cliente.FechaNacimiento);
            command.Parameters.AddWithValue("@fechacreacion", cliente.FechaCreacion);
            command.Parameters.AddWithValue("@tarjetacredito", cliente.TarjetaCredito);

            int result = Conexion.insertData(command);
            if (result < 2)
                throw new Exception("No se ha podido registrar el cliente, intentelo nuevamente.");
        }

    }
}
