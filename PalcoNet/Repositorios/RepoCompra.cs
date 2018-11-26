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
    public class RepoCompra
    {
        public List<DetalleCompra> GetComprasUsuario()
        {
            String sp = "PLEASE_HELP.SP_GET_HISTORIAL_CLIENTE";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idUser", LoggedInUser.ID);

            DataTable comprasTable = Conexion.GetData(command);

            return FromRowsToList(comprasTable);
        }

        private List<DetalleCompra> FromRowsToList(DataTable comprasTable)
        {
            List<DetalleCompra> comprasList = new List<DetalleCompra>();

            foreach (DataRow row in comprasTable.Rows)
            {
                DetalleCompra compra = new DetalleCompra();
                compra.fechaCompra = Convert.ToDateTime(row["Compra_Fecha"]);
                compra.precio = Convert.ToInt32(row["Ubicacion_Precio"]);
                compra.metodoDePago = row["Compra_Metodo_Pago"].ToString();
                compra.descripcionUbicacion = row["Ubicacion_Descripcion"].ToString();
                compra.fila = row["Ubicacion_Fila"].ToString();
                compra.asiento = Convert.ToInt32(row["Ubicacion_Asiento"]);
                compra.fechaEvento = Convert.ToDateTime(row["Compra_Fecha_Evento"]);
                compra.descripcionPublicacion = row["Compra_Publicacion_Descripcion"].ToString();

                comprasList.Add(compra);
            }

            return comprasList;
        }
    }
}
