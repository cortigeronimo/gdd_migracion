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
    public class RepoCompra : Repository
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

        public List<DetalleCompra> FindComprasToCheckIn(decimal idPublicacion)
        {
            String sp = "PLEASE_HELP.SP_BUSCAR_COMPRAR_PARA_FACTURAR";
            SqlCommand command = new SqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idPublicacion", idPublicacion);

            DataTable comprasTable = Conexion.GetData(command);

            return FromRowsToList(comprasTable);
        }

        private List<DetalleCompra> FromRowsToList(DataTable comprasTable)
        {
            List<DetalleCompra> comprasList = new List<DetalleCompra>();

            foreach (DataRow row in comprasTable.Rows)
            {
                DetalleCompra compra = new DetalleCompra();
                compra.FechaCompra = GetValueOrNull<DateTime>(row["Compra_Fecha"]);
                compra.Precio = GetValueOrNull<Decimal>(row["Ubicacion_Precio"]);
                compra.MetodoDePago = GetValueOrNull<String>(row["Compra_Metodo_Pago"]);
                compra.DescripcionUbicacion = GetValueOrNull<String>(row["Ubicacion_Descripcion"]);
                compra.Fila = GetValueOrNull<String>(row["Ubicacion_Fila"]);
                compra.Asiento = GetValueOrNull<Decimal>(row["Ubicacion_Asiento"]);
                compra.FechaEvento = GetValueOrNull<DateTime>(row["Compra_Fecha_Evento"]);
                compra.DescripcionPublicacion = GetValueOrNull<String>(row["Compra_Publicacion_Descripcion"]);

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
