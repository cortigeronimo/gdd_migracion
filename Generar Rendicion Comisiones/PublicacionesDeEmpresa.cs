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
using PalcoNet.DTO;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class PublicacionesDeEmpresa : Form
    {
        Empresa empresa = new Empresa();

        RepoEmpresa repoEmpresa = new RepoEmpresa();
        RepoPublicacion repoPublicacion = new RepoPublicacion();

        public PublicacionesDeEmpresa(int idEmpresa)
        {
            InitializeComponent();
            this.dataGridPublicacionesPorFacturar.RowHeadersVisible = false;
            this.dataGridPublicacionesPorFacturar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.empresa = repoEmpresa.FindEmpresaById(idEmpresa);
            btnActualizar_Click(null, null);
            lblEmpresa.Text = empresa.razonSocial;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PublicacionPorFacturarDTO publicacionPorFacturar 
                = (PublicacionPorFacturarDTO)dataGridPublicacionesPorFacturar.CurrentRow.DataBoundItem;

            if (e.ColumnIndex == dataGridPublicacionesPorFacturar.Columns.IndexOf(this.columnFacturar))
            {
                Form publicacionesEmpresa = new ComprasDePublicacionAFacturar(publicacionPorFacturar.Codigo);
                publicacionesEmpresa.ShowDialog();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<PublicacionPorFacturarDTO> publicacionesPorFacturar
                = repoPublicacion.FindPublicacionesAFacturar(empresa.id);
            dataGridPublicacionesPorFacturar.DataSource = new BindingSource(publicacionesPorFacturar, String.Empty);
        }

    }
}
