using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.DTO;
using System.Data;
using System.Data.SqlClient;
using PalcoNet.Config;

namespace PalcoNet.Repositorios
{
    class RepoPremio
    {
        public List<PremioDTO> GetPremios(int? clientId)
        {
            String sp = "PLEASE_HELP.SP_GET_PREMIOS";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clienteId", clientId);

            DataTable premios = Conexion.GetData(command);

            return FromRowsToList(premios);
        }

        public List<PremioDTO> FromRowsToList(DataTable premios) {
            List<PremioDTO> premiosDTO = new List<PremioDTO>();

            foreach (DataRow row in premios.Rows)
            {
                PremioDTO premioDTO = new PremioDTO();
                premioDTO.Amount = Convert.ToInt32(row["Cantidad"]);
                premioDTO.Descripcion = Convert.ToString(row["Descripcion"]);
                premioDTO.Puntos = Convert.ToInt32(row["Puntos"]);
                premiosDTO.Add(premioDTO);
            }

            return premiosDTO;
        }
    }
}
