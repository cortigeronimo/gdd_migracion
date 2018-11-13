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

        public CreateCliente()
        {
            this.usuario = new Usuario();
            this.usuario.username = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoDocumento.Clear();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (usuario.username != "")
            {
                Cliente cliente = new Cliente(usuario);
                ReadAllTextBox(cliente);
                repoCliente.InsertCliente(cliente);
                MessageBox.Show("Cliente registrado correctamente.");
                ClearAllTextBox();
            }
            else
            {
                Cliente cliente = new Cliente();
                try
                {
                    ReadAllTextBox(cliente);
                    cliente.username = "USUARIO" + cliente.nroDocumento.ToString();
                    cliente.SetPassword(cliente.nroDocumento.ToString());
                    repoCliente.InsertCliente(cliente);
                    MessageBox.Show("Cliente registrado correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese todos los datos solicitados.");
                    ClearAllTextBox();

                }
            }
            
        }

        private void ReadAllTextBox(Cliente cliente)
        {
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.tipoDocumento = txtTipoDocumento.Text;
            cliente.nroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
            cliente.cuil = Convert.ToInt64(txtCuil.Text);
            cliente.email = txtEmail.Text;
            cliente.telefono = Convert.ToInt64(txtTelefono.Text);
            cliente.direccion = txtDireccion.Text;
            cliente.nroPiso = Convert.ToByte(txtNumPiso.Text);
            cliente.depto = txtDepartamento.Text;
            cliente.localidad = txtLocalidad.Text;
            cliente.codigoPostal = txtCodigoPostal.Text;
            cliente.fechaNacimiento = pickerFechaNacimiento.Value;
            cliente.SetFechaCreacion();
            cliente.tarjetaCredito = txtTarjetaCredito.Text;
            
        }

        private void ClearAllTextBox()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoDocumento.Clear();
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
    }
}
