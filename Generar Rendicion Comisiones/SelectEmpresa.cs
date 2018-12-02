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
using PalcoNet.DTO;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class SelectEmpresa : Form
    {
        private RepoEmpresa repoEmpresa = new RepoEmpresa();

        public SelectEmpresa()
        {
            InitializeComponent();
            dataGridRendicionComisiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRendicionComisiones.RowHeadersVisible = false;
            List<EmpresaPorFacturarDTO> empresasToCheckIn = repoEmpresa.FindAllEmpresasToCheckIn();
            dataGridRendicionComisiones.DataSource = new BindingSource(empresasToCheckIn, String.Empty);
        }

        private void dataGridRendicionComisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpresaPorFacturarDTO empresaPorFacturar = (EmpresaPorFacturarDTO)dataGridRendicionComisiones.CurrentRow.DataBoundItem;

            if (e.ColumnIndex == dataGridRendicionComisiones.Columns.IndexOf(this.columnFacturar))
            {
                Form publicacionesEmpresa = new PublicacionesDeEmpresa(empresaPorFacturar.Id);
                publicacionesEmpresa.ShowDialog();
            }
        }

    }
}
