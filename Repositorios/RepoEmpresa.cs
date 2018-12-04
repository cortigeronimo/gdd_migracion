using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using System.Data;
using System.Data.SqlClient;
using PalcoNet.Utils;
using PalcoNet.DTO;

namespace PalcoNet.Repositorios
{
    class RepoEmpresa : Repository
    {
        private String table = "PLEASE_HELP.Empresa";

        public void DeleteEmpresa(Empresa empresa) {
            String sp = "PLEASE_HELP.SP_BAJA_EMPRESA";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", empresa.id);

            if (Conexion.InsertUpdateOrDeleteData(command) < 1)
            {
                throw new Exception("No se ha podido eliminar la información de la empresa");
            }
        }


        public void UpdateEmpresa(Empresa empresa) {

            String sp = "PLEASE_HELP.SP_MODIFICACION_EMPRESA";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", empresa.id);
            command.Parameters.AddWithValue("@razonSocial", empresa.razonSocial);
            command.Parameters.AddWithValue("@cuit", empresa.cuit);
            command.Parameters.AddWithValue("@email", empresa.email);
            command.Parameters.AddWithValue("@telefono", empresa.telefono);
            command.Parameters.AddWithValue("@localidad", empresa.localidad);
            command.Parameters.AddWithValue("@direccion", empresa.direccion);
            if (empresa.nroPiso == null) command.Parameters.AddWithValue("@nropiso", DBNull.Value); else command.Parameters.AddWithValue("@nropiso", empresa.nroPiso);
            command.Parameters.AddWithValue("@depto", empresa.depto);
            command.Parameters.AddWithValue("@codpostal", empresa.codigoPostal);
            command.Parameters.AddWithValue("@ciudad", empresa.ciudad);
            command.Parameters.AddWithValue("@baja", empresa.baja);

            if (Conexion.InsertUpdateOrDeleteData(command) < 1)
            {
                throw new Exception("No se ha podido actualizar la información de la empresa");
            }
        }

        public Empresa FindEmpresaById(long idEmpresa)
        {
            string query = "SELECT * FROM " + table + " WHERE Emp_Usuario = @idEmpresa";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
            return FromRowsToEmpresas(Conexion.GetData(cmd))[0];
        }

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
            if (empresa.nroPiso == null) command.Parameters.AddWithValue("@nropiso", DBNull.Value); else command.Parameters.AddWithValue("@nropiso", empresa.nroPiso);
            command.Parameters.AddWithValue("@depto", empresa.depto);
            command.Parameters.AddWithValue("@codpostal", empresa.codigoPostal);
            command.Parameters.AddWithValue("@ciudad", empresa.ciudad);
            command.Parameters.AddWithValue("@username", empresa.username);
            command.Parameters.AddWithValue("@password", empresa.GetPassword());
            command.Parameters.AddWithValue("@firstLogin", empresa.primerLogin);

            if (Conexion.InsertUpdateOrDeleteData(command) < 2)
                throw new Exception("No se ha podido registrar la empresa, intentelo nuevamente.");
        }

        public List<Empresa> GetEmpresasByFilter(string razonSocial, string cuit, string email)
        {
            string query = "SELECT * FROM " + table + " WHERE 1=1";
            DataTable result;
            SqlCommand cmd = new SqlCommand(query);
            if (razonSocial != "")
            {
                query += " AND Emp_Razon_Social LIKE '%' + @razonSocial + '%'";
                cmd.Parameters.AddWithValue("@razonSocial", razonSocial);
            }
            if (cuit != "")
            {
                query += " AND Emp_Cuit LIKE '%' + @cuit + '%'";
                cmd.Parameters.AddWithValue("@cuit", cuit);
            }
            if (email != "")
            {
                query += " AND Emp_Email LIKE '%' + @email + '%'";
                cmd.Parameters.AddWithValue("@email", email);
            }


            cmd.CommandText = query;
            result = Conexion.GetData(cmd);
            return FromRowsToEmpresas(result);
        }

        private List<Empresa> FromRowsToEmpresas(DataTable table)
        {
            List<Empresa> empresas = new List<Empresa>();
            foreach (DataRow row in table.Rows)
            {
                Empresa empresa = new Empresa();
                empresa.id = GetValueOrNull<int?>(row["Emp_Usuario"]);
                empresa.razonSocial = GetValueOrNull<String>(row["Emp_Razon_Social"]);
                empresa.cuit = GetValueOrNull<String>(row["Emp_Cuit"]);
                empresa.ciudad = GetValueOrNull<String>(row["Emp_Ciudad"]);
                empresa.email = GetValueOrNull<String>(row["Emp_Email"]);
                empresa.telefono = GetValueOrNull<decimal?>(row["Emp_Telefono"]);
                empresa.localidad = GetValueOrNull<String>(row["Emp_Localidad"]);
                empresa.direccion = GetValueOrNull<String>(row["Emp_Direccion"]);
                empresa.nroPiso = GetValueOrNull<decimal?>(row["Emp_Piso"]);
                empresa.depto = GetValueOrNull<String>(row["Emp_Depto"]);
                empresa.codigoPostal = GetValueOrNull < String > (row["Emp_Cod_Postal"]);
                empresa.habilitado = GetValueOrNull<bool>(row["Emp_Habilitado"]);
                empresa.intentosFallidos = GetValueOrNull<Int16>(row["Emp_Intentos_Fallidos"]);
                empresa.baja = GetValueOrNull<bool>(row["Emp_Baja"]);
                empresa.primerLogin = GetValueOrNull<bool>(row["Emp_Primer_Login"]);
                empresas.Add(empresa);
            }
            return empresas;
        }

        

        public bool RepiteCUIT(string cuit, Boolean hasToUpdate, int? empresaId)
        {
            string query = "SELECT COUNT(*) Total FROM PLEASE_HELP.Empresa WHERE Emp_Cuit = @cuit AND Emp_Usuario != @empresaId";
            var cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@cuit", cuit);

            if (hasToUpdate) cmd.Parameters.AddWithValue("@empresaId", empresaId); else cmd.Parameters.AddWithValue("@empresaId", 0);

            var result = Conexion.GetData(cmd);
            return (int)result.Rows[0]["Total"] > 0;
        }


        public bool RepiteRazonSocial(string razonSocial, Boolean hasToUpdate, int? empresaId )
        {
            string query = "SELECT COUNT(*) Total FROM PLEASE_HELP.Empresa WHERE Emp_Razon_Social = @razonSocial AND Emp_Usuario != @empresaId";
            var cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@razonSocial", razonSocial);

            if (hasToUpdate) cmd.Parameters.AddWithValue("@empresaId", empresaId); else cmd.Parameters.AddWithValue("@empresaId", 0);

            var result = Conexion.GetData(cmd);
            return (int)result.Rows[0]["Total"] > 0;
        }



        public List<EmpresaPorFacturarDTO> FindAllEmpresasToCheckIn()
        {
            String sp = "PLEASE_HELP.SP_BUSCAR_EMPRESAS_POR_FACTURAR";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            return FromRowsToEmpresasToCheckIn(Conexion.GetData(command));
        }

        private List<EmpresaPorFacturarDTO> FromRowsToEmpresasToCheckIn(DataTable table)
        {
            List<EmpresaPorFacturarDTO> empresasToCheckIn = new List<EmpresaPorFacturarDTO>();
            foreach (DataRow row in table.Rows)
            {
                EmpresaPorFacturarDTO empresaToCheckIn = new EmpresaPorFacturarDTO();
                empresaToCheckIn.Id = GetValueOrNull<int>(row["Emp_Usuario"]);
                empresaToCheckIn.RazonSocial = GetValueOrNull<String>(row["Emp_Razon_Social"]);
                empresaToCheckIn.Cuit = GetValueOrNull<String>(row["Emp_Cuit"]);
                empresaToCheckIn.Ciudad = GetValueOrNull<String>(row["Emp_Ciudad"]);
                empresaToCheckIn.Localidad = GetValueOrNull<String>(row["Emp_Localidad"]);
                empresaToCheckIn.Direccion = GetValueOrNull<String>(row["Emp_Direccion"]);
                empresaToCheckIn.NroPiso = GetValueOrNull<decimal?>(row["Emp_Piso"]);
                empresaToCheckIn.Depto = GetValueOrNull<String>(row["Emp_Depto"]);
                empresaToCheckIn.MontoPorFacturar = GetValueOrNull<decimal?>(row["Monto Total Por Facturar"]);
                empresaToCheckIn.CantidadPublicaciones = GetValueOrNull<int>(row["Cantidad Publicaciones"]);
                empresasToCheckIn.Add(empresaToCheckIn);
            }
            return empresasToCheckIn;
        }

        public List<Empresa> GetEmpresas()
        {
            string query = "SELECT * FROM " + table;
            SqlCommand cmd = new SqlCommand(query);
            DataTable result = Conexion.GetData(cmd);
            return FromRowsToEmpresas(result);
        }
    }
}
