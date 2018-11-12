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

            command.Parameters.AddWithValue("@nombre", cliente.nombre);
            command.Parameters.AddWithValue("@apellido", cliente.apellido);
            command.Parameters.AddWithValue("@tipo_doc", cliente.tipoDocumento);
            command.Parameters.AddWithValue("@nro_doc", cliente.nroDocumento);
            command.Parameters.AddWithValue("@cuil", cliente.cuil);
            command.Parameters.AddWithValue("@email", cliente.email);
            command.Parameters.AddWithValue("@telefono", cliente.telefono);
            command.Parameters.AddWithValue("@localidad", cliente.localidad);
            command.Parameters.AddWithValue("@direccion", cliente.direccion);
            command.Parameters.AddWithValue("@nropiso", cliente.nroPiso);
            command.Parameters.AddWithValue("@depto", cliente.depto);
            command.Parameters.AddWithValue("@codpostal", cliente.codigoPostal);
            command.Parameters.AddWithValue("@fechanac", cliente.fechaNacimiento);
            command.Parameters.AddWithValue("@fechacreacion", cliente.fechaCreacion);
            command.Parameters.AddWithValue("@tarjetacredito", cliente.tarjetaCredito);

            int result = Conexion.insertOrUpdateData(command);
            if (result < 2)
                throw new Exception("No se ha podido registrar el cliente, intentelo nuevamente.");
        }

    }
}
