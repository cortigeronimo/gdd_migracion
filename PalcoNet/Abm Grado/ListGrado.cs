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

namespace PalcoNet.Abm_Grado
{
    public partial class ListGrado : CustomForm
    {
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
            this.dataGridView1.RowHeadersVisible = false;
            float widthForm = this.dataGridView1.Width;
            int columnCount = dataGridView1.ColumnCount;
            float widthColumn = widthForm / columnCount;
            this.columnNombre.Width = (int)widthColumn;
            this.columnComision.Width = (int)widthColumn;
            this.columnDelete.Width = (int)widthColumn;
            this.columnUpdate.Width = (int)widthColumn;
            this.columnId.Width = (int)widthColumn;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepoGradoPublicacion repoGrado = new RepoGradoPublicacion();
            Grado grado = new Grado(
                (int)numComisionGrado.Value, 
                txtNombreGrado.Text);
            DataTable table = repoGrado.GetGradosBy(grado);
            dataGridView1.DataSource = table.DefaultView;
        }

    }
}

