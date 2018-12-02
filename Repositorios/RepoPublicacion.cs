using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


using PalcoNet.Modelo;
using PalcoNet.Config;
using PalcoNet.Abm_Grado;
using PalcoNet.DTO;

namespace PalcoNet.Repositorios
{
    public class RepoPublicacion
    {
        private String publicacionTable = "PLEASE_HELP.Publicacion";


        public Boolean ExistsPublicacionMismaHora(long codigoPublicacion, String descripcion, DateTime fechaHora)
        {
            String query = "PLEASE_HELP.SP_PUBLICACIONES_MISMA_FECHAHORA";

            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoPublicacion", codigoPublicacion);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@fechaEvento", fechaHora);

            DataTable result = Conexion.GetData(cmd);

            return result.Rows.Count != 0;

        }


        public void InsertOrUpdatePublicacion(Publicacion publicacion)
        {
            String codigo = Convert.ToString(publicacion.Codigo);
            if (codigo == "0")
                InsertPublicacion(publicacion);
            else
                UpdatePublicacion(publicacion);

        }

        public void UpdatePublicacion(Publicacion publicacion)
        {
            String sp = "PLEASE_HELP.SP_UPDATE_PUBLICACION";

            SqlCommand cmd = new SqlCommand(sp);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoPublicacion", publicacion.Codigo);

            if (publicacion.Estado.Descripcion == "PUBLICADA")
                cmd.Parameters.AddWithValue("@fechaInicio", SystemDate.GetDate());
            else
                cmd.Parameters.AddWithValue("@fechaInicio", DBNull.Value);

            cmd.Parameters.AddWithValue("@fechaEvento", publicacion.FechaEvento);
            cmd.Parameters.AddWithValue("@descripcion", publicacion.Descripcion);
            cmd.Parameters.AddWithValue("@direccion", publicacion.Direccion);
            cmd.Parameters.AddWithValue("@rubroId", publicacion.Rubro.Id);
            cmd.Parameters.AddWithValue("@gradoId", publicacion.Grado.Id);
            
            cmd.Parameters.AddWithValue("@estadoId", publicacion.Estado.Id);

            Conexion.ExecuteProcedure(cmd);

            RepoUbicacion repoUbicacion = new RepoUbicacion();

            
            repoUbicacion.DeleteAndAddNewUbicaciones(publicacion.Codigo, publicacion.Ubicaciones);

        }

        public void InsertPublicacion(Publicacion publicacion)
        {
            RepoUbicacion repoUbicacion = new RepoUbicacion();

            String sp = "PLEASE_HELP.SP_GENERAR_PUBLICACION";

            SqlCommand cmd = new SqlCommand(sp);

            cmd.CommandType = CommandType.StoredProcedure;


            if(publicacion.Estado.Descripcion == "PUBLICADA")
                cmd.Parameters.AddWithValue("@fechaInicio", SystemDate.GetDate());
            else
                cmd.Parameters.AddWithValue("@fechaInicio", DBNull.Value);
            
            cmd.Parameters.AddWithValue("@fechaEvento", publicacion.FechaEvento);
            cmd.Parameters.AddWithValue("@descripcion", publicacion.Descripcion);
            cmd.Parameters.AddWithValue("@direccion", publicacion.Direccion);
            cmd.Parameters.AddWithValue("@rubroId", publicacion.Rubro.Id);
            cmd.Parameters.AddWithValue("@gradoId", publicacion.Grado.Id);
            cmd.Parameters.AddWithValue("@empresaId", publicacion.Empresa.id);
            cmd.Parameters.AddWithValue("@estadoId", publicacion.Estado.Id);

            SqlParameter publicacionId = new SqlParameter("@idPublicacion", SqlDbType.Int);
            publicacionId.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(publicacionId);

            Conexion.ExecuteProcedure(cmd);

            long ubicacionPublicacionID = Convert.ToInt64(publicacionId.Value);

            //Insert de Ubicaciones
            repoUbicacion.InsertUbicaciones(ubicacionPublicacionID, publicacion.Ubicaciones);


        }

        
        public void InsertPublicacionesList(List<Publicacion> publicacionList)
        {
            foreach (Publicacion p in publicacionList)
            {
                InsertPublicacion(p);
            }
        }

        public DataTable GetPublicacionesToEditForm(String descripcion)
        {
            String query = "PLEASE_HELP.SP_LISTA_PUBLICACIONES";

            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idUser", UserSession.UserId);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);

            return Conexion.GetData(cmd);
        }

        public void CambiarEstadoPublicacion(Publicacion publicacion, String estado)
        {
            String query = "PLEASE_HELP.SP_CAMBIAR_ESTADO_PUBLICACION";

            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.StoredProcedure;

            if(estado == "PUBLICADA")
                cmd.Parameters.AddWithValue("@fechaPublicacion", SystemDate.GetDate());
            else
                cmd.Parameters.AddWithValue("@fechaPublicacion", DBNull.Value);

            cmd.Parameters.AddWithValue("@codigoPublicacion", publicacion.Codigo);
            cmd.Parameters.AddWithValue("@estado", estado);
             

            Conexion.ExecuteProcedure(cmd);
        }

        public List<PublicacionDTO> GetPublicacionesActivas()
        {
            String sp = "PLEASE_HELP.SP_GET_PUBLICACIONES_ACTIVAS";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable publicacionesTable = Conexion.GetData(cmd);

            return FromRowsToList(publicacionesTable);
        }

        private List<PublicacionDTO> FromRowsToList(DataTable publicacionesTable)
        {
            List<PublicacionDTO> publicacionesList = new List<PublicacionDTO>();

            foreach (DataRow row in publicacionesTable.Rows)
            {
                PublicacionDTO publicacion = new PublicacionDTO();

                publicacion.Codigo = Convert.ToInt64(row["Pub_Codigo"]);
                publicacion.Descripcion = row["Pub_Descripcion"].ToString();
                publicacion.FechaEvento = Convert.ToDateTime(row["Pub_Fecha_Evento"]);
                publicacion.Direccion = row["Pub_Direccion"].ToString();

                //new
                publicacion.Rubro = row["Pub_Rubro"].ToString();

                

                publicacion.Stock = Convert.ToInt32(row["Pub_Stock"]);

                if (row["Pub_Comision"] == DBNull.Value)
                    publicacion.Comision = 0;
                else
                    publicacion.Comision = Convert.ToInt32(row["Pub_Comision"]);

                publicacionesList.Add(publicacion);
            }

            return publicacionesList;
        }

        public List<PublicacionDTO> GetPublicacionesByFilter(List<String> rubrosList, DateTime desde, DateTime hasta, String descripcion)
        {
            DataTable filteredTable = new DataTable();

            String sp = "PLEASE_HELP.SP_GET_PUBLICACIONES_ACTIVAS";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fechaDesde", desde);
            cmd.Parameters.AddWithValue("@fechaHasta", hasta);

            if (!String.IsNullOrEmpty(descripcion))
            {
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
            }
            

            DataTable sourceTable = Conexion.GetData(cmd);
            filteredTable = sourceTable.Clone();


            if (rubrosList.Count == 0)
            {
                return FromRowsToList(sourceTable);
            }
            else
            {
                String sqlWhere = String.Empty;
                
                String sqlOrder = "Pub_Comision DESC";

                foreach (String rubro in rubrosList)
                {                   
                    sqlWhere += "Pub_Rubro = '" + rubro + "' OR ";                   
                }

                sqlWhere = sqlWhere.Substring(0, sqlWhere.Length - 4);

                DataRow[] filteredRows = sourceTable.Select(sqlWhere, sqlOrder);

                //foreach (DataRow row in filteredRows)
                //{
                //    filteredTable.ImportRow(row);
                //}

                //filteredTable = filteredRows.CopyToDataTable();

                if (filteredRows.Any())
                    filteredTable = filteredRows.CopyToDataTable();

                return FromRowsToList(filteredTable);
            }

            

            
        }
       
    }
}
