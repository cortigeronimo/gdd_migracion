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
    public class RepoUbicacion
    {
        public void InsertUbicaciones(int publicacionId, List<Ubicacion> ubicacionesList)
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
    }
}
