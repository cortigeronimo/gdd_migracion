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
using PalcoNet.Utils;
using PalcoNet.Config;

namespace PalcoNet.Comprar
{
    public partial class FormMediosDePago : CustomForm
    {
        public String medioDePago;
        public String compraEmail;

        private RepoCliente repoCliente = new RepoCliente();

        public FormMediosDePago()
        {
            InitializeComponent();
            comboBoxMedioPago.SelectedItem = "Tarjeta De Credito";
            txtEmailFacturacion.Text = repoCliente.GetEmailCliente(UserSession.UserId);
        }

        private ValidatorData ValidateForm()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtEmailFacturacion.Text, ValidatorData.REGEX_EMAIL);
            return validator;
        }

        private void btnAceptarMedioDePago_Click(object sender, EventArgs e)
        {
            if (ValidatorData.validateEmptyFields(this.groupBoxMedioPago)) return;
            if (ValidateForm().ShowIfThereAreErrors()) return;

            medioDePago = comboBoxMedioPago.SelectedItem.ToString();
            compraEmail = txtEmailFacturacion.Text;

            this.DialogResult = DialogResult.OK;
                                 
        }
     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        



    }
}
