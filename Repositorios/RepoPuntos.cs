using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PalcoNet.Config;

namespace PalcoNet.Repositorios
{
    public class RepoPuntos : Repository
    {
        private String table = "PLEASE_HELP.Puntuacion";

        public int GetPuntosClienteById(int? id)
        {
            String query = "SELECT COALESCE(SUM(Puntuacion_Cantidad), 0) as puntos FROM " + table
                 + " WHERE Puntuacion_Cliente = @Id AND Puntuacion_Fecha_Vencimiento > @fechaActual";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@fechaActual", SystemDate.GetDate());
            return (int)Conexion.GetData(command).Rows[0]["puntos"];
        }
    }
}
