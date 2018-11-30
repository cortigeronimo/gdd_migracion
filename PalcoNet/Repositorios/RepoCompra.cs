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
        public List<DetalleCompra> GetComprasUsuario(int? userId)
        {
            String sp = "PLEASE_HELP.SP_GET_HISTORIAL_CLIENTE";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idUser", userId);

            DataTable comprasTable = Conexion.GetData(command);

            return FromRowsToList(comprasTable);
        }

        private List<DetalleCompra> FromRowsToList(DataTable comprasTable)
        {
            List<DetalleCompra> comprasList = new List<DetalleCompra>();

            foreach (DataRow row in comprasTable.Rows)
            {
                DetalleCompra compra = new DetalleCompra();
                compra.FechaCompra = Convert.ToDateTime(row["Compra_Fecha"]);
                compra.Precio = Convert.ToInt32(row["Ubicacion_Precio"]);
                compra.MetodoDePago = row["Compra_Metodo_Pago"].ToString();
                compra.DescripcionUbicacion = row["Ubicacion_Descripcion"].ToString();
                compra.Fila = row["Ubicacion_Fila"].ToString();
                compra.Asiento = Convert.ToInt32(row["Ubicacion_Asiento"]);
                compra.FechaEvento = Convert.ToDateTime(row["Compra_Fecha_Evento"]);
                compra.DescripcionPublicacion = row["Compra_Publicacion_Descripcion"].ToString();

                comprasList.Add(compra);
            }

            return comprasList;
        }

        public void GenerateCompras(List<Ubicacion> ubicacionesList, int? userId, String medioPago, String compraEmail)
        {
            String sp = "PLEASE_HELP.SP_COMPRAR_ENTRADA";

            foreach (Ubicacion u in ubicacionesList)
            {
                SqlCommand cmd = new SqlCommand(sp);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@compraCliente", userId);
                cmd.Parameters.AddWithValue("@compraFecha", SystemDate.GetDate());
                cmd.Parameters.AddWithValue("@compraMedioPago", medioPago);
                cmd.Parameters.AddWithValue("@compraEmail", compraEmail);
                cmd.Parameters.AddWithValue("@compraFila", u.Fila);
                cmd.Parameters.AddWithValue("@compraAsiento", u.Asiento);
                cmd.Parameters.AddWithValue("@compraPublicacion", u.Publicacion);
                cmd.Parameters.AddWithValue("@compraPrecio", u.Precio);

                Conexion.ExecuteProcedure(cmd);
            }
        }


    }
}
