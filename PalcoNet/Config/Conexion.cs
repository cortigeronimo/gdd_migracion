using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet
{
    public class Conexion
    {

        public static DataTable GetData(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["palconet"].ConnectionString))
            {
                DataTable table = new DataTable();
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //cargo la datatable con el contenido del reader
                table.Load(reader);
               
                return table;
            }
        }

         
       

        public static void ExecuteProcedure(SqlCommand command)
        {       
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["palconet"].ConnectionString))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public static int insertData(SqlCommand command){
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["palconet"].ConnectionString))
            {
                command.Connection = connection;
                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                return i;
            }
        }




        /*
        public void ejecutarSP(String nombreSP, List<Parametro> listaParametros)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                abrirConexion();
                cmd = new SqlCommand(nombreSP, con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (listaParametros != null)
                {
                    for (int i = 0; i < listaParametros.Count; i++) 
                    {
                        if (listaParametros[i].Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(listaParametros[i].Nombre, listaParametros[i].Valor);
                        }

                        if (listaParametros[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(listaParametros[i].Nombre, listaParametros[i].TipoDato, listaParametros[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }

                    cmd.ExecuteNonQuery();

                    //Recuperar parametros de salida
                    for (int i = 0; i < listaParametros.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                        {
                            listaParametros[i].Valor = cmd.Parameters[i].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            cerrarConexion();
        }
         * */



        //EJECUTAR QUERY (sin parametros de salida)
        /*
        public DataTable ejecutarQuery(String nombreSP, List<Parametro> listaParametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter(nombreSP, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (listaParametros != null)
                {
                    for (int i = 0; i < listaParametros.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(listaParametros[i].Nombre, listaParametros[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }*/


    }
}
