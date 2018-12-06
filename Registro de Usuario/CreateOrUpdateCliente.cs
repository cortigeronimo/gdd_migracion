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
using PalcoNet.Registro_de_Usuario.ClienteStrategy;

namespace PalcoNet.Registro_de_Usuario
{
    public partial class CreateOrUpdateCliente : CustomForm
    {
        private Cliente cliente;
        private RepoCliente repoCliente = new RepoCliente();
        private ClienteStrategy.ClienteStrategy clienteStrategy;

        //El usuario se da de alta
        public CreateOrUpdateCliente(Usuario usuario)
        {
            InitializeComponent();
            checkBoxBaja.Visible = false;
            cliente = new Cliente(usuario);
            cliente.id = 0;
            cliente.primerLogin = false;  
            clienteStrategy = new ClienteSignUp();
            this.Text = "Registrar Cliente";
            this.groupBoxCliente.Text = "Registro Cliente";
        }

        //El admin lo quiere crear
        public CreateOrUpdateCliente() {
            InitializeComponent();
            checkBoxBaja.Visible = false;
            cliente = new Cliente();
            cliente.primerLogin = true;
            clienteStrategy = new AdminCreaCliente();
            this.Text = "Crear Cliente";
            this.groupBoxCliente.Text = "Creación Cliente";
        }

        //El admin lo quiere modificar
        public CreateOrUpdateCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            InitializeTextsBoxes(cliente);
            clienteStrategy = new AdminUpdateCliente(checkBoxBaja);
            this.Text = "Modificar Cliente";
            this.groupBoxCliente.Text = "Modificación Cliente";
        }

        private void InitializeTextsBoxes(Cliente cliente)
        {
            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            comboBoxTipoDoc.SelectedItem = cliente.tipoDocumento;
            txtNumeroDocumento.Text = cliente.nroDocumento.ToString();
            txtCuil.Text = cliente.cuil.ToString();
            txtEmail.Text = cliente.email;
            txtTelefono.Text = cliente.telefono.ToString();
            txtDireccion.Text = cliente.direccion;
            txtNumPiso.Text = cliente.nroPiso.ToString();
            txtDepartamento.Text = cliente.depto;
            txtLocalidad.Text = cliente.localidad;
            txtCodigoPostal.Text = cliente.codigoPostal;
            pickerFechaNacimiento.Value = cliente.fechaNacimiento;
            txtTarjetaCredito.Text = cliente.tarjetaCredito;
            checkBoxBaja.Checked = cliente.baja;  
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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
            checkBoxBaja.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateFields().ShowIfThereAreErrors()) return;
            if (repoCliente.ExistsDNIAndCuil(cliente.id, comboBoxTipoDoc.SelectedItem.ToString(), txtNumeroDocumento.Text, txtCuil.Text))
            {
                MessageBox.Show("Ya existe un Cliente con el mismo Dni y Cuil");
                return;
            }

            ReadAllTextBox(cliente);
            clienteStrategy.BuildCliente(cliente);
            clienteStrategy.Execute(repoCliente, cliente);
            this.CloseThis();
        }

        private ValidatorData ValidateFields()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtNombre.Text, ValidatorData.REGEX_NOMBRE);
            validator.ValidateTextWithRegex(txtApellido.Text, ValidatorData.REGEX_APELLIDO);
            validator.ValidateTextWithRegex(txtNumeroDocumento.Text, ValidatorData.REGEX_NUMERO_DOCUMENTO);
            validator.ValidateTextWithRegex(txtCuil.Text, ValidatorData.REGEX_CUIL);
            validator.ValidateTextWithRegex(txtEmail.Text, ValidatorData.REGEX_EMAIL);
            validator.ValidateTextWithRegex(txtTelefono.Text, ValidatorData.REGEX_TELEFONO);
            validator.ValidateTextWithRegex(txtDireccion.Text, ValidatorData.REGEX_DIRECCION);
            validator.ValidateTextWithRegex(txtNumPiso.Text, ValidatorData.REGEX_PISO);
            validator.ValidateTextWithRegex(txtDepartamento.Text, ValidatorData.REGEX_DEPARTAMENTO);
            validator.ValidateTextWithRegex(txtLocalidad.Text, ValidatorData.REGEX_LOCALIDAD);
            validator.ValidateTextWithRegex(txtCodigoPostal.Text, ValidatorData.REGEX_CODIGO_POSTAL);
            validator.ValidateTextWithRegex(txtTarjetaCredito.Text, ValidatorData.REGEX_TARJETA_CREDITO);
            return validator;
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
            if (String.IsNullOrEmpty(txtNumPiso.Text)) cliente.nroPiso = null; else cliente.nroPiso = Convert.ToDecimal(txtNumPiso.Text);       
            cliente.depto = txtDepartamento.Text;
            cliente.localidad = txtLocalidad.Text;
            cliente.codigoPostal = txtCodigoPostal.Text;
            cliente.fechaNacimiento = pickerFechaNacimiento.Value;
            cliente.tarjetaCredito = txtTarjetaCredito.Text;
            if (checkBoxBaja.Enabled)
            {
                cliente.baja = checkBoxBaja.Checked;
            }
            
        }

    }
}
