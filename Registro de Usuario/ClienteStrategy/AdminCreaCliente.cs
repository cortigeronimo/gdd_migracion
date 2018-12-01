using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Registro_de_Usuario.ClienteStrategy
{
    public class AdminCreaCliente : ClienteStrategy
    {
        public override void BuildCliente(Modelo.Cliente cliente)
        {
            base.BuildCliente(cliente);
            cliente.username = "USUARIO" + cliente.cuil;
            cliente.SetPassword(cliente.cuil.ToString());
        }
    }
}
