using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using PalcoNet.Repositorios;
using System.Windows.Forms;
using PalcoNet.Utils;

namespace PalcoNet.Registro_de_Usuario.ClienteStrategy
{
    public abstract class ClienteStrategy
    {

        public virtual void BuildCliente(Cliente cliente) {
            return;
        }

        public virtual void Execute(RepoCliente repoCliente, Cliente cliente)
        {
            try
            {
                repoCliente.InsertCliente(cliente);
                MessageBox.Show(Messagges.OPERACION_EXITOSA);
            }
            catch (Exception)
            {
                MessageBox.Show(Messagges.ERROR_INESPERADO);
            }
        }
    }
}
