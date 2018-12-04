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
using PalcoNet.Registro_de_Usuario;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class ListadoEmpresa : CustomForm
    {
        private BindingSource bindingSource = new BindingSource();
        private RepoEmpresa repoEmpresa = new RepoEmpresa();

        public ListadoEmpresa()
        {
            InitializeComponent();
            dataGridEmpresas.AutoGenerateColumns = false;
            dataGridEmpresas.RowHeadersVisible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Empresa> empresas = repoEmpresa.GetEmpresasByFilter(txtBoxRazonSocial.Text, txtBoxCUIT.Text, txtBoxEmail.Text);
            empresas.Sort((e1, e2) => e1.razonSocial.CompareTo(e1.razonSocial));
            bindingSource = new BindingSource(empresas, String.Empty);
            dataGridEmpresas.DataSource = bindingSource;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridEmpresas.DataSource = null;
        }

        private void dataGridEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empresa empresa = (Empresa)dataGridEmpresas.CurrentRow.DataBoundItem;

            if (e.ColumnIndex == dataGridEmpresas.Columns.IndexOf(this.Seleccionar))
            {
                Form EditForm = new CreateOrUpdateEmpresa(empresa);
                EditForm.ShowDialog();
            }
            if (e.ColumnIndex == dataGridEmpresas.Columns.IndexOf(this.Eliminar))
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la fila?", "Eliminar Empresa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repoEmpresa.DeleteEmpresa(empresa);
                    this.dataGridEmpresas.Rows.Remove(this.dataGridEmpresas.CurrentRow);
                }
            }
        }

    }
}
