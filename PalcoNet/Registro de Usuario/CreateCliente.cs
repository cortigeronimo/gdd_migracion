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

namespace PalcoNet.Registro_de_Usuario
{
    public partial class CreateCliente : CustomForm
    {
        String errorMessage;
        private Usuario usuario;

        private RepoCliente repoCliente = new RepoCliente();

        public CreateCliente(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        public CreateCliente()
        {
            this.usuario = new Usuario();
            this.usuario.username = "";
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean verificacionOK = false;
            errorMessage = String.Empty;

            if (AllTextBoxOK())
            {
                if (ExistsDNIAndCuil())
                {
                    AddErrorToErrorMessage("El DNI y/o cuil ingresado ya existe en el sistema.");
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    verificacionOK = true;
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }


            if (usuario.username != String.Empty && verificacionOK)
            {
                Cliente cliente = new Cliente(usuario);
                ReadAllTextBox(cliente);
                repoCliente.InsertCliente(cliente);
                MessageBox.Show("Cliente registrado correctamente.");
                this.Close();
            }
            else if (usuario.username == String.Empty && verificacionOK)
            {
                Cliente cliente = new Cliente();
                
                ReadAllTextBox(cliente);
                //cliente.username = "USUARIO" + cliente.nroDocumento.ToString();
                //cliente.SetPassword(cliente.nroDocumento.ToString());
                repoCliente.InsertCliente(cliente);
                MessageBox.Show("Cliente registrado correctamente.\n" + "Datos de login generados: \nUSERNAME: " + cliente.username + "\nPASSWORD: " + cliente.nroDocumento.ToString());
                ClearAllTextBox();
            }
                
            
        }

        //VERIFICA TODOS LOS TEXTBOXS Y CARGA FRASES A LA CADENA DE ERROR
        private Boolean AllTextBoxOK()
        {
            errorMessage = "Error al intentar registrar el nuevo cliente: \n";
            int errorCount = 0;

            if (String.IsNullOrEmpty(txtNombre.Text)) { AddErrorToErrorMessage("El campo nombre está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(txtApellido.Text)) { AddErrorToErrorMessage("El campo apellido está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(comboBoxTipoDoc.Text)) { AddErrorToErrorMessage("El campo tipo de documento está vacio."); errorCount++; };
            if (String.IsNullOrEmpty(txtNumeroDocumento.Text)) { AddErrorToErrorMessage("El campo número de documento está vacio."); errorCount++; }
                else if (txtNumeroDocumento.Text.ToString().Length < 7) { AddErrorToErrorMessage("El campo número de documento debe tener 7 dígitos como mínimo."); errorCount++; }
            if (String.IsNullOrEmpty(txtCuil.Text)) { AddErrorToErrorMessage("El campo cuil está vacio."); errorCount++; }
                else if (txtCuil.Text.ToString().Length < 10) { AddErrorToErrorMessage("El campo cuil debe tener 10 dígitos como mínimo."); errorCount++; }
            if (String.IsNullOrEmpty(txtEmail.Text)) { AddErrorToErrorMessage("El campo email está vacio."); errorCount++; }
                else if (!txtEmail.Text.ToString().Contains('@')) { AddErrorToErrorMessage("El email ingresado no es valido."); errorCount++; }
            if (String.IsNullOrEmpty(txtTelefono.Text)) { AddErrorToErrorMessage("El campo teléfono está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(txtDireccion.Text)) { AddErrorToErrorMessage("El campo calle y número está vacio."); errorCount++; }
            if (String.IsNullOrEmpty(txtLocalidad.Text)) { AddErrorToErrorMessage("El campo localidad está vacio."); errorCount++; }

            if (errorCount > 0)
            {
                AddErrorToErrorMessage("\nComplete los campos obligatorios.");
                return false;
            }
            return true;
            //falta verificar que cuil ingresado sea valido
        }

        //VERIFICA SI YA EXISTE UN NRO DE DOC Y/O CUIL EN EL SISTEMA
        private Boolean ExistsDNIAndCuil()
        {
            String tipoDoc = comboBoxTipoDoc.SelectedItem.ToString();
            String nroDoc = txtNumeroDocumento.Text;
            String cuil = txtCuil.Text;

            return repoCliente.ExistsDNIAndCuil(tipoDoc, nroDoc, cuil);
        }

        //CARGA LOS VALORES INGRESADOS EN LOS TEXTBOX A UN OBJETO CLIENTE
        private void ReadAllTextBox(Cliente cliente)
        {
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.tipoDocumento = comboBoxTipoDoc.SelectedItem.ToString();
            cliente.nroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
            cliente.cuil = Convert.ToInt64(txtCuil.Text);
            cliente.email = txtEmail.Text;
            cliente.telefono = Convert.ToInt64(txtTelefono.Text);
            cliente.direccion = txtDireccion.Text;
            if (txtNumPiso.Text == String.Empty)
                cliente.nroPiso = Byte.MinValue;
            else
                cliente.nroPiso = Convert.ToByte(txtNumPiso.Text);  
            cliente.depto = txtDepartamento.Text;
            cliente.localidad = txtLocalidad.Text;
            cliente.codigoPostal = txtCodigoPostal.Text;
            cliente.fechaNacimiento = pickerFechaNacimiento.Value;
            cliente.SetFechaCreacion();
            cliente.tarjetaCredito = txtTarjetaCredito.Text;
            
        }


        //LIMPIA TODOS LOS TEXTBOX
        private void ClearAllTextBox()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumeroDocumento.Clear();
            txtCuil.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtNumPiso.Clear();
            txtDepartamento.Clear();
            txtLocalidad.Clear();
            txtCodigoPostal.Clear();
            txtTarjetaCredito.Clear();
        }

        //AGREGA UNA FRASE A LA CADENA DE ERROR
        private void AddErrorToErrorMessage(String error)
        {
            errorMessage += "\n" + error;
        }


        //RESTRICCIONES A LOS TEXTBOX
        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtNumPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void comboBoxTipoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDireccion.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellido.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDepartamento.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocalidad.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodigoPostal.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtTarjetaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        



    }
}
