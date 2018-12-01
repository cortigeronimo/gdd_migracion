using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using PalcoNet.DTO;

namespace PalcoNet.Utils
{
    public class Page<T>
    {
        private readonly int sizePage;
        public int TotalPage { get; set; }
        public int ActualPage { get; set; }
        public List<T> Listado { get; set; }

        public Page(int totalPage, int actualPage, List<T> listado, int sizePage)
        {
            TotalPage = totalPage;
            ActualPage = actualPage;
            Listado = listado;
            this.sizePage = sizePage;
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


        public List<T> GetDataPage()
        {
            List<T> pageList = new List<T>();

            int inicio = (ActualPage - 1) * sizePage;

            int tope = ActualPage * sizePage;

            for (int i = inicio; i < tope && i < Listado.Count; i++)
            {
                pageList.Add(Listado[i]);
            }

            return pageList;
        }

    }
}
