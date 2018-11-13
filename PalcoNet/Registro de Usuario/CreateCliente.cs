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
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoDocumento.Clear();
            numNumeroDocumento.Value = numNumeroDocumento.Minimum;
            numCuil.Value = numCuil.Minimum;
            txtEmail.Clear();
            numTelefono.Value = numTelefono.Minimum;
            txtDireccion.Clear();
            numPiso.Value = numTelefono.Minimum;
            txtDepartamento.Clear();
            txtLocalidad.Clear();
            txtCodigoPostal.Clear();
            txtTarjetaCredito.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(usuario);
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.tipoDocumento = txtTipoDocumento.Text;
            cliente.nroDocumento = (int)numNumeroDocumento.Value;
            cliente.cuil = (long)numCuil.Value;
            cliente.email = txtEmail.Text;
            cliente.telefono = (long)numTelefono.Value;
            cliente.direccion = txtDireccion.Text;
            cliente.nroPiso = Convert.ToByte(numPiso.Value);
            cliente.depto = txtDepartamento.Text;
            cliente.localidad = txtLocalidad.Text;
            cliente.codigoPostal = txtCodigoPostal.Text;
            cliente.fechaNacimiento = pickerFechaNacimiento.Value;
            cliente.SetFechaCreacion();
            cliente.tarjetaCredito = txtTarjetaCredito.Text;
            repoCliente.InsertCliente(cliente);
        }
    }
}
