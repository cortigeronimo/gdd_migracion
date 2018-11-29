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
    public partial class CreateEmpresa : CustomForm
    {
        Usuario usuario;
        Empresa empresa;
        RepoEmpresa repoEmpresa = new RepoEmpresa();
        bool hasToUpdate = false;

        public CreateEmpresa(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        public CreateEmpresa(Usuario usuario, Empresa empresa)
        {
            this.usuario = usuario;
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
            Empresa empresaToInsert = new Empresa(usuario);
            empresaToInsert.razonSocial = txtRazonSocial.Text;
            empresaToInsert.cuit = txtCuit.Text;
            empresaToInsert.email = txtEmail.Text;
            empresaToInsert.telefono = (long)Convert.ToInt64(txtTelefono.Text);
            empresaToInsert.direccion = txtDireccion.Text;
            empresaToInsert.nroPiso = Convert.ToByte(txtNumeroPiso.Text);
            empresaToInsert.ciudad = txtCiudad.Text;
            empresaToInsert.depto = txtDepartamento.Text;
            empresaToInsert.localidad = txtLocalidad.Text;
            empresaToInsert.codigoPostal = txtCodigoPostal.Text;
            if (hasToUpdate)
            {
                MessageBox.Show("holis");
                repoEmpresa.UpdateEmpresa(empresaToInsert);
            }
            else {
                repoEmpresa.InsertEmpresa(empresaToInsert);
            }
            
        }
    }
}
