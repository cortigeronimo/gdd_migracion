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

namespace PalcoNet.Registro_de_Usuario
{
    public partial class CreateEmpresa : CustomForm
    {
        Empresa empresa;
        RepoEmpresa repoEmpresa = new RepoEmpresa();
        bool hasToUpdate = false;

        private ValidatorData ValidateForm()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtRazonSocial.Text, ValidatorData.REGEX_RAZON_SOCIAL);
            validator.ValidateTextWithRegex(txtCuit.Text, ValidatorData.REGEX_CUIT);
            validator.ValidateTextWithRegex(txtTelefono.Text, ValidatorData.REGEX_TELEFONO);
            validator.ValidateTextWithRegex(txtEmail.Text, ValidatorData.REGEX_EMAIL);
            validator.ValidateTextWithRegex(txtLocalidad.Text, ValidatorData.REGEX_LOCALIDAD);
            validator.ValidateTextWithRegex(txtDireccion.Text, ValidatorData.REGEX_DIRECCION);
            validator.ValidateTextWithRegex(txtNumeroPiso.Text, ValidatorData.REGEX_PISO);
            validator.ValidateTextWithRegex(txtCodigoPostal.Text, ValidatorData.REGEX_CODIGO_POSTAL);
            validator.ValidateTextWithRegex(txtCiudad.Text, ValidatorData.REGEX_CIUDAD);
            return validator;
        }

        public CreateEmpresa(Usuario usuario)
        {
            empresa = new Empresa(usuario);
            InitializeComponent();
        }

        public CreateEmpresa(Empresa empresa)
        {
            hasToUpdate = true;
            this.empresa = empresa;
            InitializeComponent();
            InitializeEmpresa();
        }

        private void InitializeEmpresa() {
            this.txtRazonSocial.Text = empresa.razonSocial;
            this.txtCuit.Text = empresa.cuit;
            this.txtTelefono.Text = empresa.telefono.ToString();
            this.txtEmail.Text = empresa.email;
            this.txtLocalidad.Text = empresa.localidad;
            this.txtDireccion.Text = empresa.direccion;
            this.txtNumeroPiso.Text = empresa.nroPiso.ToString();
            this.txtDepartamento.Text = empresa.depto;
            this.txtCodigoPostal.Text = empresa.codigoPostal;
            this.txtCiudad.Text = empresa.ciudad;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Clear();
            txtCuit.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtLocalidad.Clear();
            txtDireccion.Clear();
            txtNumeroPiso.Clear();
            txtDepartamento.Clear();
            txtCodigoPostal.Clear();
            txtCiudad.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidatorData.validateEmptyFields(this.groupBoxCliente)) return;
            if (ValidateForm().ShowIfThereAreErrors()) return;

            empresa.razonSocial = txtRazonSocial.Text;
            empresa.cuit = txtCuit.Text;
            empresa.email = txtEmail.Text;
            empresa.telefono = (long)Convert.ToInt64(txtTelefono.Text);
            empresa.direccion = txtDireccion.Text;
            empresa.nroPiso = Convert.ToByte(txtNumeroPiso.Text);
            empresa.ciudad = txtCiudad.Text;
            empresa.depto = txtDepartamento.Text;
            empresa.localidad = txtLocalidad.Text;
            empresa.codigoPostal = txtCodigoPostal.Text;
            if (hasToUpdate)
            {
                repoEmpresa.UpdateEmpresa(empresa);
                MessageBox.Show(Messagges.DATOS_ACTUALIZADOS);
            }
            else {
                repoEmpresa.InsertEmpresa(empresa);
            }
            
        }
    }
}
