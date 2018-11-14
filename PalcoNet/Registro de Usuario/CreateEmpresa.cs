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
        RepoEmpresa repoEmpresa = new RepoEmpresa();

        public CreateEmpresa(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Clear();
            numCuit.Value = numCuit.Minimum;
            numTelefono.Value = numTelefono.Minimum;
            txtEmail.Clear();
            txtLocalidad.Clear();
            txtDireccion.Clear();
            numPiso.Value = numTelefono.Minimum;
            txtDepartamento.Clear();
            txtCodigoPostal.Clear();
            txtCiudad.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(usuario);
            empresa.razonSocial = txtRazonSocial.Text;
            empresa.cuit = (long)numCuit.Value;
            empresa.email = txtEmail.Text;
            empresa.telefono = (long)numTelefono.Value;
            empresa.direccion = txtDireccion.Text;
            empresa.nroPiso = Convert.ToByte(numPiso.Value);
            empresa.ciudad = txtCiudad.Text;
            empresa.depto = txtDepartamento.Text;
            empresa.localidad = txtLocalidad.Text;
            empresa.codigoPostal = txtCodigoPostal.Text;
            repoEmpresa.InsertEmpresa(empresa);
        }
    }
}
