using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Modelo;
using PalcoNet.Utils;
using System.Windows.Forms;

namespace PalcoNet.Registro_de_Usuario.ClienteStrategy
{
    public class AdminUpdateCliente : ClienteStrategy
    {
        private CheckBox checkbox;

        public AdminUpdateCliente(CheckBox checkbox)
        {
            this.checkbox = checkbox;
        }

        public override void BuildCliente(Cliente cliente)
        {
            base.BuildCliente(cliente);
        }

        public override void Execute(Repositorios.RepoCliente repoCliente, Cliente cliente)
        {
            try
            {
                cliente.baja = checkbox.Checked;
                repoCliente.UpdateCliente(cliente);
                MessageBox.Show(Messages.DATOS_ACTUALIZADOS);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.ERROR_INESPERADO);
            }

        }
    }
}
