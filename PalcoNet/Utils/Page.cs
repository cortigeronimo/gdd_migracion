using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;

namespace PalcoNet.Utils
{
    public class Page
    {
        public int TotalPage { get; set; }
        public int ActualPage { get; set; }
        public List<DetalleCompra> DetallesCompras { get; set; }

        public Page(int totalPage, int actualPage, List<DetalleCompra> detallesCompras)
        {
            TotalPage = totalPage;
            ActualPage = actualPage;
            DetallesCompras = detallesCompras;
        }

        public int nextPage()
        {
            if(ActualPage < TotalPage){
                ActualPage++;
            }
            return ActualPage;
        }

        public int backPage()
        {
            if (ActualPage > 1)
            {
                ActualPage--;
            }
            return ActualPage;
        }




        public List<DetalleCompra> GetComprasPage()
        {
            List<DetalleCompra> pageList = new List<DetalleCompra>();

            int inicio = (ActualPage - 1) * 10;

            int tope = ActualPage * 10;

            for (int i = inicio; i < tope && i < DetallesCompras.Count; i++)
            {
                pageList.Add(DetallesCompras[i]);
            }

            return pageList;
        }

    }
}
