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

namespace PalcoNet.Abm_Cliente
{
    public partial class CreateCliente : CustomForm
    {
        RepoCliente repo = new RepoCliente();
        Cliente cliente;


        public CreateCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }


        private void ClearAllTextBox()
        {
            txtApellido.Clear();
            txtCodigoPostal.Clear();
            numCuil.Value = numCuil.Minimum;
            txtDepto.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtLocalidad.Clear();
            txtNombre.Clear();
            numNumeroDocumento.Value = numNumeroDocumento.Minimum;
            numPiso.Value = numPiso.Minimum;
            txtTarjetaCredito.Clear();
            numTelefono.Value = numTelefono.Minimum;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                ReadAllTextBox();
                repo.InsertClienteCreatedByAdmin(cliente);
                MessageBox.Show("Cliente registrado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese todos los datos solicitados.");
                
            }
        }

        private void ReadAllTextBox()
        {
            cliente = new Cliente(txtNombre.Text, txtApellido.Text, comboBoxTipoDoc.SelectedItem.ToString(), (int)numNumeroDocumento.Value, (long)numCuil.Value, txtEmail.Text, (long)numTelefono.Value,
                txtLocalidad.Text, txtDireccion.Text, Convert.ToByte(numPiso.Value), txtDepto.Text, txtCodigoPostal.Text, Convert.ToDateTime(dateTimePickerFechaNac.Text), txtTarjetaCredito.Text);

          
        }
    }
}
