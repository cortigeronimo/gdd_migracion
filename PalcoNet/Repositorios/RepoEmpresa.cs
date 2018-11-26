﻿using System;
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

        public List<Empresa> GetEmpresasByFilter(string razonSocial, string cuit, string email)
        {
            string query = "SELECT * FROM " + table + " WHERE 1=1";
            DataTable result;
            SqlCommand cmd = new SqlCommand(query);
            if (razonSocial != "")
            {
                query += " AND Emp_Razon_Social LIKE @razonSocial";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@razonSocial", razonSocial);
            }
            if (cuit != "")
            {
                query += " AND Emp_Cuit = @cuit";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@cuit", cuit);
            }
            if (email != "")
            {
                query += " AND Emp_Email LIKE @email";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@email", email);
            }

            result = Conexion.GetData(cmd);
            return FromRowsToEmpresas(result);
        }

        private List<Empresa> FromRowsToEmpresas(DataTable table)
        {
            List<Empresa> empresas = new List<Empresa>();
            int i = 0;
            while (i < table.Rows.Count)
            {
                Empresa empresa = 
                    new Empresa((string)table.Rows[i]["Emp_Razon_Social"], 
                                (long)table.Rows[i]["Emp_Cuit"],
                                (String)table.Rows[i]["Emp_Ciudad"],
                                (string)table.Rows[i]["Emp_Email"],
                                (long)table.Rows[i]["Emp_Telefono"],
                                (string)table.Rows[i]["Emp_Localidad"],
                                (string)table.Rows[i]["Emp_Direccion"],
                                (byte)table.Rows[i]["Emp_Piso"],
                                (string)table.Rows[i]["Emp_Depto"],
                                (string)table.Rows[i]["Emp_Cod_Postal"]);
                empresas.Add(empresa);
                i++;
            }
            return empresas;
        }
    }
}
