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
        private Usuario usuario;

        private RepoCliente repoCliente = new RepoCliente();

        public CreateCliente(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTipoDocumento.Text = "";
            numNumeroDocumento.Value = 0;
            numCuil.Value = 0;
            txtEmail.Text = "";
            numTelefono.Value = 0;
            txtDireccion.Text = "";
            numPiso.Value = 0;
            txtDepartamento.Text = "";
            txtLocalidad.Text = "";
            txtCodigoPostal.Text = "";
            txtTarjetaCredito.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(usuario);
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.tipoDocumento = txtTipoDocumento.Text;
            cliente.nroDocumento = (byte)numNumeroDocumento.Value;
            cliente.cuil = numCuil.Value.ToString();
            cliente.email = txtEmail.Text;
            cliente.telefono = (byte)numTelefono.Value;
            cliente.direccion = txtDireccion.Text;
            cliente.nroPiso = (byte)numPiso.Value;
            cliente.depto = txtDepartamento.Text;
            cliente.localidad = txtLocalidad.Text;
            cliente.codigoPostal = txtCodigoPostal.Text;
            cliente.tarjetaCredito = txtTarjetaCredito.Text;
            repoCliente.InsertClienteCreatedByUser(cliente);
        }
    }
}
