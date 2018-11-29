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

namespace PalcoNet.Comprar
{
    public partial class FormMediosDePago : CustomForm
    {
        public String medioDePago;

        public FormMediosDePago()
        {
            InitializeComponent();
            comboBoxMedioPago.SelectedItem = "Tarjeta De Credito";
        }

        private void btnAceptarMedioDePago_Click(object sender, EventArgs e)
        {
            medioDePago = comboBoxMedioPago.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void FormMediosDePago_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



    }
}
