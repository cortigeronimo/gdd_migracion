using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Repositorios;
using PalcoNet.Modelo;
using PalcoNet.Vistas;
using PalcoNet.Utils;

namespace PalcoNet.Abm_Grado
{
    public partial class ListGrado : CustomForm
    {
        RepoGradoPublicacion repoGrado = new RepoGradoPublicacion();
        private BindingSource bindingSource = new BindingSource();

        public ListGrado()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreGrado.Clear();
            txtComisionGrado.Clear();
        }

        private void ListGrado_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.columnEliminar.DisplayIndex = this.dataGridView1.Columns.Count - 1;
            this.columnEditar.DisplayIndex = this.dataGridView1.Columns.Count - 2;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            List<Grado> grados = repoGrado.GetGradosBy(txtNombreGrado.Text, txtComisionGrado.Text);
            grados.ForEach((g) => bindingSource.Add(g));
            this.dataGridView1.DataSource = bindingSource;
        }

        private Grado buildGrado(DataGridViewRow row)
        {
            Grado grado = new Grado();
            grado.Id = (int)row.Cells[columnGradoId.Name].Value;
            grado.Descripcion = (String)row.Cells[columnGradoDescripcion.Name].Value;
            grado.Comision = (int)row.Cells[columnGradoComision.Name].Value;
            return grado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            Grado grado = buildGrado(row);

            if (e.ColumnIndex == dataGridView1.Columns.IndexOf(this.columnEditar))
            {
                Form EditForm = new UpdateGrado(grado);
                EditForm.ShowDialog();
            }
            if (e.ColumnIndex == dataGridView1.Columns.IndexOf(this.columnEliminar))
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la fila?", "Eliminar Grado", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repoGrado.DeleteGrado(buildGrado(row));
                    this.dataGridView1.Rows.Remove(row);
                }    
            }
        }

    }
}

