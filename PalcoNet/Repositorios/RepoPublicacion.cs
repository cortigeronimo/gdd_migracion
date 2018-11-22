using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


using PalcoNet.Modelo;

namespace PalcoNet.Repositorios
{
    public class RepoPublicacion
    {
        public void InsertPublicacion(Publicacion publicacion)
        {
            RepoUbicacion repoUbicacion = new RepoUbicacion();

            String sp = "PLEASE_HELP.SP_GENERAR_PUBLICACION";

            SqlCommand cmd = new SqlCommand(sp);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fechaInicio", publicacion.FechaInicio);
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

            int ubicacionPublicacionID = Convert.ToInt32(publicacionId.Value);

            //insert de ubicaciones
            repoUbicacion.InsertUbicaciones(ubicacionPublicacionID, publicacion.Ubicaciones);
        }

        
        public void InsertPublicacionesList(List<Publicacion> publicacionList)
        {
            foreach (Publicacion p in publicacionList)
            {
                InsertPublicacion(p);
            }
        }

       
    }
}
