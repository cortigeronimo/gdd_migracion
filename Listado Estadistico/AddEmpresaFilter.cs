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

namespace PalcoNet.Listado_Estadistico
{
    public partial class AddEmpresaFilter : CustomForm
    {
        RepoEmpresa repoEmpresa = new RepoEmpresa();

        public Empresa empresa { get; set; }

        public AddEmpresaFilter()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxEmpresa.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una Empresa");
                return;
            }
            this.empresa = (Empresa)comboBoxEmpresa.SelectedItem;
            DialogResult = DialogResult.OK;
            this.CloseThis();
        }

        private void AddEmpresaFilter_Load(object sender, EventArgs e)
        {
            List<Empresa> empresas = repoEmpresa.GetEmpresasHabilite();
            comboBoxEmpresa.DataSource = empresas;
        }
    }
}
