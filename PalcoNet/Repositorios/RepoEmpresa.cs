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
    class RepoEmpresa
    {
        private String table = "PLEASE_HELP.Empresa";

        public void InsertEmpresa(Empresa empresa)
        {
            String sp = "PLEASE_HELP.SP_ALTA_EMPRESA";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@razonSocial", empresa.razonSocial);
            command.Parameters.AddWithValue("@cuit", empresa.cuit);
            command.Parameters.AddWithValue("@email", empresa.email);
            command.Parameters.AddWithValue("@telefono", empresa.telefono);
            command.Parameters.AddWithValue("@localidad", empresa.localidad);
            command.Parameters.AddWithValue("@direccion", empresa.direccion);
            command.Parameters.AddWithValue("@nropiso", empresa.nroPiso);
            command.Parameters.AddWithValue("@depto", empresa.depto);
            command.Parameters.AddWithValue("@codpostal", empresa.codigoPostal);
            command.Parameters.AddWithValue("@ciudad", empresa.ciudad);
            command.Parameters.AddWithValue("@username", empresa.username);
            command.Parameters.AddWithValue("@password", empresa.GetPassword());

            if (Conexion.InsertUpdateOrDeleteData(command) < 2)
                throw new Exception("No se ha podido registrar la empresa, intentelo nuevamente.");
        }
    }
}
