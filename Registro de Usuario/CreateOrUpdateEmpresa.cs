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
    public partial class CreateOrUpdateEmpresa : CustomForm
    {
        Empresa empresa;
        RepoEmpresa repoEmpresa = new RepoEmpresa();
        RepoRol repoRol = new RepoRol();
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

        //El usuario crea una empresa
        public CreateOrUpdateEmpresa(Usuario usuario)
        {
            InitializeComponent();
            empresa = new Empresa(usuario);
            this.checkBoxBaja.Visible = false;
        }

        //El admin modifica una empresa
        public CreateOrUpdateEmpresa(Empresa empresa)
        {
            InitializeComponent();
            hasToUpdate = true;
            this.empresa = empresa;
            InitializeEmpresa(empresa);
        }

        //El admin crea una empresa
        public CreateOrUpdateEmpresa() {
            //InitializeComponent();
            //this.checkBoxBaja.Visible = false;
            //Rol rol = repoRol.FindRolByName(RepoRol.ROL_CLIENTE);
            //Usuario usuario = new Usuario();
            //usuario.AddRol(rol);
            //usuario.isAdmin = false;
            //usuario.isClient = true;

            InitializeComponent();
            this.checkBoxBaja.Visible = false;
            Rol rol = repoRol.FindRolByName(RepoRol.ROL_EMPRESA);
            Usuario usuario = new Usuario();
            usuario.AddRol(rol);
            usuario.isAdmin = false;
            usuario.isClient = false;
            empresa = new Empresa(usuario);
            empresa.id = 0;
            empresa.primerLogin = true;
        }

        private void InitializeEmpresa(Empresa empresa) {
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
            this.checkBoxBaja.Checked = empresa.baja;
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
            if (ValidateForm().ShowIfThereAreErrors()) return;
            if (repoEmpresa.RepiteCUIT(txtCuit.Text, hasToUpdate, empresa.id))
            {
                MessageBox.Show("Ya existe un usuario con ese cuit.");
                return;
            }
            if (repoEmpresa.RepiteRazonSocial(txtRazonSocial.Text, hasToUpdate, empresa.id))
            {
                MessageBox.Show("Ya existe un usuario con esa Razon Social.");
                return;
            }
            empresa.razonSocial = txtRazonSocial.Text;
            empresa.cuit = txtCuit.Text;
            empresa.email = txtEmail.Text;
            empresa.telefono = (long)Convert.ToInt64(txtTelefono.Text);
            empresa.direccion = txtDireccion.Text;
            //empresa.nroPiso = Convert.ToDecimal(txtNumeroPiso.Text);  //error aca!!!!
            if (String.IsNullOrEmpty(txtNumeroPiso.Text)) empresa.nroPiso = null; else empresa.nroPiso = Convert.ToDecimal(txtNumeroPiso.Text);  
            empresa.ciudad = txtCiudad.Text;
            empresa.depto = txtDepartamento.Text;
            empresa.localidad = txtLocalidad.Text;
            empresa.codigoPostal = txtCodigoPostal.Text;

            if (hasToUpdate)
            {
                empresa.baja = this.checkBoxBaja.Checked;
                repoEmpresa.UpdateEmpresa(empresa);
                MessageBox.Show(Messages.DATOS_ACTUALIZADOS);
            }
            else {
                if(String.IsNullOrEmpty(empresa.username)){
                    empresa.username = "EMPRESA" + empresa.cuit.Replace("-","");
                    empresa.SetPassword(empresa.cuit.Replace("-",""));
                }
                repoEmpresa.InsertEmpresa(empresa);
                MessageBox.Show(Messages.OPERACION_EXITOSA);
            }
            
        }
    }
}
