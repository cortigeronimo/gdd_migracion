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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.empresa = repoEmpresa.FindEmpresaById(idEmpresa);
            List<PublicacionPorFacturarDTO> publicacionesPorFacturar
                = repoPublicacion.FindPublicacionesAFacturar(idEmpresa);
            dataGridView1.DataSource = new BindingSource();
            lblEmpresa.Text = empresa.razonSocial;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
