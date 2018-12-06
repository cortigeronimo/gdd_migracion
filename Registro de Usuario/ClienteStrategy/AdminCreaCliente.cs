using PalcoNet.Modelo;
using PalcoNet.Repositorios;
using PalcoNet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Registro_de_Usuario.ClienteStrategy
{
    public class AdminCreaCliente : ClienteStrategy
    {
        public override void BuildCliente(Modelo.Cliente cliente)
        {
            base.BuildCliente(cliente);
            cliente.username = "USUARIO" + cliente.nroDocumento;
            cliente.SetPassword(cliente.nroDocumento.ToString());          
        }

        public override void Execute(RepoCliente repoCliente, Cliente cliente)
        {
            try
            {
                repoCliente.InsertCliente(cliente);
                MessageBox.Show(Messages.OPERACION_EXITOSA);
                MessageBox.Show("Los datos autogenerados para el login son:\nUsername: " + cliente.username + "\nPassword: " + cliente.GetPassword(), "Info");
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.ERROR_INESPERADO);
            }

        }
    }
}
