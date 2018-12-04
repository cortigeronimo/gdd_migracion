using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Registro_de_Usuario;
using PalcoNet.Modelo;
using PalcoNet.Repositorios;
using PalcoNet.Vistas;

namespace PalcoNet.Abm_Cliente
{
    public partial class ListCliente : CustomForm
    {
        RepoCliente repoCliente = new RepoCliente();

        public ListCliente()
        {
            InitializeComponent();
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.RowHeadersVisible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            List<Cliente> clientes = repoCliente.GetClientesByFilter(txtNombre.Text, txtApellido.Text, txtNroDocumento.Text, txtEmail.Text);
            BindingSource binding = new BindingSource(clientes, "");
            this.dataGridViewClientes.DataSource = binding;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNroDocumento.Clear();
            txtEmail.Clear();
        }


        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;

            if (e.ColumnIndex == dataGridViewClientes.Columns.IndexOf(this.columnEditar))
            {
                Form EditForm = new CreateOrUpdateCliente(cliente);
                EditForm.ShowDialog();
            }
            if (e.ColumnIndex == dataGridViewClientes.Columns.IndexOf(this.columnEliminar))
            {
                DialogResult dialogResult;

                if(cliente.baja)
                    dialogResult = MessageBox.Show("¿Desea dar de alta al cliente?", "Alta Cliente", MessageBoxButtons.YesNo);
                else
                    dialogResult = MessageBox.Show("¿Desea eliminar la fila?", "Eliminar Cliente", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    repoCliente.AltaBajaCliente(cliente.id, cliente.baja);
                    LoadDataGrid();
                    
                }
            }
        }
        

        
    }
}
