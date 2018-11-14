using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PalcoNet.Modelo;
using PalcoNet.Repositorios;
using PalcoNet.Vistas;

namespace PalcoNet.Abm_Cliente
{
    public partial class ListCliente : CustomForm
    {
        RepoCliente repoCliente = new RepoCliente();
        Cliente cliente;

        public ListCliente()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text == String.Empty)
            {
                if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            }
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellido.Text == String.Empty)
            {
                if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmail.Text == String.Empty)
            {
                if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtNroDocumento.Text, txtEmail.Text);
            ShowResultsQuery(cliente);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().OpenAndClose(new UpdateCliente(cliente), this);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNroDocumento.Clear();
            txtEmail.Clear();
        }

        private void ShowResultsQuery(Cliente cliente)
        {
            dataGridViewClientes.DataSource = repoCliente.GetTable(cliente);
        }


        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewClientes.SelectedRows.Count == 1)
            {
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
                
        }

        private void SelectedRowsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewClientes.SelectedRows[0];
            cliente = BuildCliente(row);
            
        }

        private void ListCliente_Load(object sender, EventArgs e)
        {
            this.dataGridViewClientes.RowHeaderMouseClick += SelectedRowsButton_Click;
            this.dataGridViewClientes.SelectionChanged += OnSelectionChanged;
            this.dataGridViewClientes.MultiSelect = false;
        }

        private Cliente BuildCliente(DataGridViewRow row)
        {
            Cliente cliente = new Cliente();
            
            cliente.id = (int)row.Cells[columnID.Name].Value;
            cliente.nombre = row.Cells[columnNombre.Name].Value.ToString();
            cliente.apellido = row.Cells[columnApellido.Name].Value.ToString();
            cliente.tipoDocumento = row.Cells[columnTipoDocumento.Name].Value.ToString();
            cliente.nroDocumento = Convert.ToInt32(row.Cells[columnNroDocumento.Name].Value);    
            cliente.fechaNacimiento = (DateTime)row.Cells[columnFechaNacimiento.Name].Value;
            cliente.fechaCreacion = (DateTime)row.Cells[columnFechaCreacion.Name].Value;
            cliente.email = row.Cells[columnEmail.Name].Value.ToString();
            cliente.codigoPostal = row.Cells[columnCodigoPostal.Name].Value.ToString(); 
            
            cliente.direccion = row.Cells[columnDireccion.Name].Value.ToString();

            cliente.localidad = row.Cells[columnLocalidad.Name].Value.ToString();
            cliente.depto = row.Cells[columnDepto.Name].Value.ToString();
            cliente.tarjetaCredito = row.Cells[columnTarjetaCredito.Name].Value.ToString();
            //try
            //{
            //    cliente.telefono = Convert.ToInt64(row.Cells[columnTelefono.Name].Value);
            //    cliente.cuil = Convert.ToInt64(row.Cells[columnCuil.Name].Value);
            //    cliente.localidad = row.Cells[columnLocalidad.Name].Value.ToString();                       
            //    cliente.nroPiso = Convert.ToByte(row.Cells[columnNroPiso.Name].Value);
            //    cliente.depto = row.Cells[columnDepto.Name].Value.ToString();                
            //    cliente.tarjetaCredito = row.Cells[columnTarjetaCredito.Name].Value.ToString();
            //}
            //catch (Exception)
            //{
            //    cliente.telefono = 0;
            //    cliente.cuil = 0;
            //    cliente.localidad = String.Empty;
            //    cliente.nroPiso = 0;
            //    cliente.depto = String.Empty;
            //    cliente.tarjetaCredito = String.Empty;
            //}

            try { cliente.telefono = Convert.ToInt64(row.Cells[columnTelefono.Name].Value); }
            catch (Exception) { cliente.telefono = long.MinValue; }
            try { cliente.cuil = Convert.ToInt64(row.Cells[columnCuil.Name].Value); }
            catch (Exception) { cliente.cuil = long.MinValue; }
            try { cliente.nroPiso = Convert.ToByte(row.Cells[columnNroPiso.Name].Value); }
            catch (Exception) { cliente.nroPiso = byte.MinValue; }


            return cliente;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente clienteAltaBaja = new Cliente();
            Boolean isBaja;
            DataGridViewRow row = dataGridViewClientes.SelectedRows[0];
            isBaja = (Boolean)row.Cells[columnBaja.Name].Value;
            clienteAltaBaja.id = (int)row.Cells[columnID.Name].Value;

            if (!isBaja)
            {
                clienteAltaBaja.baja = false;

                DialogResult dialogResult = MessageBox.Show("¿Desea dar de BAJA al cliente seleccionado?", "Baja Cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (repoCliente.AltaBajaCliente(clienteAltaBaja) == 1)
                        MessageBox.Show("La operación se realizo correctamente.");
                    else
                        MessageBox.Show("Error inesperado, intente nuevamente.");
                    RefreshDataGridViewClientes();
                }

            }
            else
            {
                clienteAltaBaja.baja = true;

                DialogResult dialogResult = MessageBox.Show("El cliente seleccionado es encuentra es estado BAJA, ¿Desea dar de ALTA al cliente?", "Alta Cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (repoCliente.AltaBajaCliente(clienteAltaBaja) == 1)
                        MessageBox.Show("La operación se realizo correctamente.");
                    else
                        MessageBox.Show("Error inesperado, intente nuevamente.");
                    RefreshDataGridViewClientes();
                }
            }




        }


        private void RefreshDataGridViewClientes()
        {
            Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtNroDocumento.Text, txtEmail.Text);
            ShowResultsQuery(cliente);
        }
        

        
    }
}
