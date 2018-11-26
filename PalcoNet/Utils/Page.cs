using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;

namespace PalcoNet.Utils
{
    public class Page<T>
    {
        public int TotalPage { get; set; }
        public int ActualPage { get; set; }
        public List<T> Listado { get; set; }

        public Page(int totalPage, int actualPage, List<T> listado)
        {
            TotalPage = totalPage;
            ActualPage = actualPage;
            Listado = listado;
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


        public List<T> GetComprasPage()
        {
            List<T> pageList = new List<T>();

            int inicio = (ActualPage - 1) * 10;

            int tope = ActualPage * 10;

            for (int i = inicio; i < tope && i < Listado.Count; i++)
            {
                pageList.Add(Listado[i]);
            }

            return pageList;
        }

    }
}
