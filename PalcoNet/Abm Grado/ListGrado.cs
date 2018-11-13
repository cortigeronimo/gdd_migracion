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
        Grado grado;
        RepoGradoPublicacion repoGrado = new RepoGradoPublicacion();

        public ListGrado()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreGrado.Text = "";
            numComisionGrado.Value = 0;
        }

        private void ListGrado_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            this.dataGridView1.RowHeaderMouseClick += selectedRowsButton_Click;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionChanged += OnSelectionChanged;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Grado grado = new Grado(
                (int)numComisionGrado.Value, 
                txtNombreGrado.Text);
            DataTable table = repoGrado.GetGradosBy(grado);
            dataGridView1.DataSource = table.DefaultView;
        }

        private void selectedRowsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            grado = buildGrado(row);
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                this.btnBorrar.Enabled = true;
                this.btnEditar.Enabled = true;
            }
            else
            {
                this.btnBorrar.Enabled = false;
                this.btnEditar.Enabled = false;
            }

        }


        private Grado buildGrado(DataGridViewRow row)
        {
            Grado grado = new Grado();
            grado.setId((int)row.Cells[columnGradoId.Name].Value);
            grado.SetDescripcion((String)row.Cells[columnGradoDescripcion.Name].Value);
            grado.SetComision((int)row.Cells[columnGradoComision.Name].Value);
            return grado;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new UpdateGrado(grado));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la fila?", "Eliminar Grado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                repoGrado.DeleteGrado(buildGrado(row));
                this.dataGridView1.Rows.Remove(row);
            }            
        }

    }
}

