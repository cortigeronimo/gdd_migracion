using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PalcoNet.Vistas;
using PalcoNet.Modelo;
using PalcoNet.Repositorios;
using PalcoNet.Config;
using PalcoNet.Utils;

namespace PalcoNet.Comprar
{
    public partial class FormAgregarTarjetaCredito : CustomForm
    {
        private RepoCliente repoCliente = new RepoCliente();

        public FormAgregarTarjetaCredito()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            repoCliente.AddNroTarjetaCredito(UserSession.UserId, txtTarjetaCredito.Text);
            this.DialogResult = DialogResult.OK;        
                 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtTarjetaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }


    }
}
