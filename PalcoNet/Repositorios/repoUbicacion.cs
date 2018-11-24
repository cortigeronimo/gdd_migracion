using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using PalcoNet.Modelo;
using PalcoNet.Config;

namespace PalcoNet.Repositorios
{
    public class RepoUbicacion
    {
        public void InsertUbicaciones(long publicacionId, List<Ubicacion> ubicacionesList)
        {
            foreach (Ubicacion u in ubicacionesList)
            {
                String sp = "PLEASE_HELP.SP_INSERTAR_UBICACION";
                SqlCommand cmd = new SqlCommand(sp);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPublicacion", publicacionId);
                cmd.Parameters.AddWithValue("@fila", u.Fila);
                cmd.Parameters.AddWithValue("@asiento", u.Asiento);
                cmd.Parameters.AddWithValue("@precio", u.Precio);
                cmd.Parameters.AddWithValue("@descripcion", u.Descripcion);

                Conexion.ExecuteProcedure(cmd);
            }
        }

        public void DeleteAndAddNewUbicaciones(long publicacionId, List<Ubicacion> ubicacionesList)
        {
            String sp = "PLEASE_HELP.SP_DELETE_PUBLICACION_UBICACIONES";
            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoPublicacion", publicacionId);
            Conexion.ExecuteProcedure(cmd);

            InsertUbicaciones(publicacionId, ubicacionesList);
        }


        public List<Ubicacion> GetUbicacionesByUser()
        {
            String sp = "PLEASE_HELP.SP_GET_UBICACIONES_BY_USER";

            SqlCommand cmd = new SqlCommand(sp);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idUser", LoggedInUser.ID);

            return FromRowsToUbicaciones(Conexion.GetData(cmd));
            
        }

        private List<Ubicacion> FromRowsToUbicaciones(DataTable table)
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();

            foreach (DataRow row in table.Rows)
            {
                Ubicacion ubicacion = new Ubicacion();

                ubicacion.Fila = Convert.ToChar(row["Ubicacion_Fila"]);
                ubicacion.Asiento = Convert.ToInt32(row["Ubicacion_Asiento"]);
                ubicacion.Precio = Convert.ToInt32(row["Ubicacion_Precio"]);
                ubicacion.Descripcion = Convert.ToString(row["Ubicacion_Descripcion"]);
                ubicacion.Publicacion = Convert.ToInt64(row["Ubicacion_Publicacion"]);

                ubicaciones.Add(ubicacion);
            }

            return ubicaciones;
        }
    }
}
