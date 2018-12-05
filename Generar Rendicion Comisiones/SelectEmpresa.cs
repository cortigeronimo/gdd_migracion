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
using PalcoNet.Vistas;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class SelectEmpresa : CustomForm
    {
        private RepoEmpresa repoEmpresa = new RepoEmpresa();

        public SelectEmpresa()
        {
            InitializeComponent();
            dataGridRendicionComisiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRendicionComisiones.RowHeadersVisible = false;
            btnActualizar_Click(null, null);
        }

        private void dataGridRendicionComisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpresaPorFacturarDTO empresaPorFacturar = (EmpresaPorFacturarDTO)dataGridRendicionComisiones.CurrentRow.DataBoundItem;

            if (empresaPorFacturar.CantidadPublicaciones == 0)
            {
                MessageBox.Show("La Empresa elegida, no tiene publicaciones con compras sin rendir.");
                return;
            }

            if (e.ColumnIndex == dataGridRendicionComisiones.Columns.IndexOf(this.columnFacturar))
            {
                Form publicacionesEmpresa = new PublicacionesDeEmpresa(empresaPorFacturar.Id);
                publicacionesEmpresa.ShowDialog();
                btnActualizar_Click(null, null);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<EmpresaPorFacturarDTO> empresasToCheckIn = repoEmpresa.FindAllEmpresasToCheckIn();
            dataGridRendicionComisiones.DataSource = new BindingSource(empresasToCheckIn, String.Empty);
        }

    }
}
