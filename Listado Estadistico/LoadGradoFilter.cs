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
using PalcoNet.Abm_Grado;
using PalcoNet.Vistas;

namespace PalcoNet.Listado_Estadistico
{
    public partial class LoadGradoFilter : CustomForm
    {
        private RepoGradoPublicacion repoGrado = new RepoGradoPublicacion();

        public Grado grado { get; set; }

        public LoadGradoFilter()
        {
            InitializeComponent();
        }

        private void LoadGradoFilter_Load(object sender, EventArgs e)
        {
            comboBoxGrado.DataSource = this.repoGrado.GetGradosBy("", "");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxGrado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un grado");
                return;
            }
            this.grado = (Grado)comboBoxGrado.SelectedItem;
            DialogResult = DialogResult.OK;
            this.CloseThis();
        }

        private void groupBoxFiltroGrado_Enter(object sender, EventArgs e)
        {

        }
    }
}
