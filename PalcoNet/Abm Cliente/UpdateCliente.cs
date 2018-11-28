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
    public partial class UpdateCliente : CustomForm
    {
        Cliente cliente;
        String errorMessage;

        public UpdateCliente(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RepoCliente repoCliente = new RepoCliente();
            errorMessage = "";

            if (TextBoxOK())
            {
                if (ExistsDNIAndCuil(txtID.Text.ToString(), comboBoxTipoDocumento.SelectedItem.ToString(), txtNroDocumento.Text.ToString(), txtCuil.Text.ToString()))
                {
                    AddErrorToErrorMessage("El DNI y/o cuil ingresado ya existe el sistema.");
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    Cliente updatedClient = new Cliente();

                    updatedClient.id = Convert.ToInt32(txtID.Text);
                    updatedClient.tarjetaCredito = txtTarjetaCredito.Text;
                    updatedClient.nombre = txtNombre.Text;
                    updatedClient.apellido = txtApellido.Text;
                    updatedClient.tipoDocumento = comboBoxTipoDocumento.SelectedItem.ToString();
                    updatedClient.nroDocumento = Convert.ToInt32(txtNroDocumento.Text);
                    updatedClient.cuil = Convert.ToInt64(txtCuil.Text);
                    updatedClient.email = txtEmail.Text;
                    updatedClient.telefono = Convert.ToInt64(txtTelefono.Text);
                    updatedClient.direccion = txtDireccion.Text;
                    if (txtNroPiso.Text == String.Empty)
                        updatedClient.nroPiso = Byte.MinValue;
                    else
                        updatedClient.nroPiso = Convert.ToByte(txtNroPiso.Text);
                    updatedClient.depto = txtDepto.Text;
                    updatedClient.localidad = txtLocalidad.Text;
                    updatedClient.codigoPostal = txtCodigoPostal.Text;
                    updatedClient.fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                    updatedClient.fechaCreacion = dateTimePickerFechaCreacion.Value;

                    int result = repoCliente.UpdateCliente(updatedClient);
                    if (result > 0)
                    {
                        MessageBox.Show("La actualización se completo sin errores");
                        FormManager.getInstance().OpenAndClose(new ListCliente(), this);
                    }

                    else
                    {
                        MessageBox.Show("Error inesperado, intente nuevamente");
                    }
                        
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
            

        }

        private void UpdateCliente_Load(object sender, EventArgs e)
        {
            txtID.Text = cliente.id.ToString();
            txtTarjetaCredito.Text = cliente.tarjetaCredito.ToString();
            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            comboBoxTipoDocumento.SelectedItem = cliente.tipoDocumento;
            txtNroDocumento.Text = cliente.nroDocumento.ToString();
            if (cliente.cuil == long.MinValue) txtCuil.Text = String.Empty; else txtCuil.Text = cliente.cuil.ToString();
            txtEmail.Text = cliente.email;
            if (cliente.telefono == long.MinValue) txtTelefono.Text = String.Empty; else txtTelefono.Text = cliente.telefono.ToString();
            txtDireccion.Text = cliente.direccion;
            if (cliente.nroPiso == byte.MinValue) txtNroPiso.Text = String.Empty; else txtNroPiso.Text = cliente.nroPiso.ToString();
            txtDepto.Text = cliente.depto;
            txtLocalidad.Text = cliente.localidad;
            txtCodigoPostal.Text = cliente.codigoPostal;
            dateTimePickerFechaNacimiento.Value = cliente.fechaNacimiento;
            dateTimePickerFechaCreacion.Value = cliente.fechaCreacion;
        }

        private Boolean TextBoxOK()
        {
            errorMessage = "Error al intentar guardar los datos ingresados: \n";
            int errorCount = 0;

            if (String.IsNullOrEmpty(txtNombre.Text)) { AddErrorToErrorMessage("El campo nombre está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(txtApellido.Text)) { AddErrorToErrorMessage("El campo apellido está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(comboBoxTipoDocumento.Text)) { AddErrorToErrorMessage("El campo tipo de documento está vacio."); errorCount++; };
            if (String.IsNullOrEmpty(txtNroDocumento.Text)) { AddErrorToErrorMessage("El campo número de documento está vacio."); errorCount++; }
                else if (txtNroDocumento.Text.ToString().Length < 7) { AddErrorToErrorMessage("El campo número de documento debe tener 7 dígitos como mínimo."); errorCount++; }
            if (String.IsNullOrEmpty(txtCuil.Text)) { AddErrorToErrorMessage("El campo cuil está vacio."); errorCount++; }
                else if (txtCuil.Text.ToString().Length < 10) { AddErrorToErrorMessage("El campo cuil debe tener 10 dígitos como mínimo."); errorCount++; }
            if (String.IsNullOrEmpty(txtEmail.Text)) { AddErrorToErrorMessage("El campo email está vacio."); errorCount++; }
                else if (!txtEmail.Text.ToString().Contains('@')) { AddErrorToErrorMessage("El email ingresado no es valido."); errorCount++; }
            if (String.IsNullOrEmpty(txtTelefono.Text)) { AddErrorToErrorMessage("El campo teléfono está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(txtDireccion.Text)) { AddErrorToErrorMessage("El campo calle y número está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(txtLocalidad.Text)) { AddErrorToErrorMessage("El campo localidad está vacio."); errorCount++; }

            //if (!txtCuil.Text.ToString().Contains(txtNroDocumento.Text.ToString()) && (comboBoxTipoDocumento.SelectedText.ToString() == "DNI")) { AddErrorToErrorMessage("El CUIL ingresado no es válido."); errorCount++; }
                       
            if (errorCount > 0)
            {
                AddErrorToErrorMessage("\nComplete los campos obligatorios.");
                return false;
            }    
            return true;
        }

        private Boolean ExistsDNIAndCuil(String idUser, String tipoDoc, String nroDoc, String cuil)
        {
            RepoCliente repoCliente = new RepoCliente();
            return repoCliente.ExistsDNIAndCuil(idUser, tipoDoc, nroDoc, cuil);
        }

        private void AddErrorToErrorMessage(String error)
        {
            errorMessage += "\n" + error;
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtNroPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTarjetaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellido.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void comboBoxTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDireccion.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDepto.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocalidad.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodigoPostal.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void groupBoxUpdateCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().OpenAndClose(new ListCliente(), this);
        }

        private void txtCuil_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
