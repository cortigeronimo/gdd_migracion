using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Vistas;
using PalcoNet.Modelo;
using PalcoNet.Repositorios;

namespace PalcoNet.Listado_Estadistico
{
    public partial class ListadoEstadistico : CustomForm
    {

        private BindingSource bindingSource = new BindingSource();
        List<ResultadoEstadistico> top5 = new List<ResultadoEstadistico>();

        public ListadoEstadistico()
        {
            InitializeComponent();
            this.comboBoxTrimestre.Text = "1";
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnListado1_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            if (txtBoxAnio.Text == "")
            {
                MessageBox.Show("Por favor escriba el año a evaluar");
                return;
            }

            top5 = new RepoEstadistica().GetTop5Empresas(Convert.ToInt32(txtBoxAnio.Text), Convert.ToInt32(comboBoxTrimestre.Text));

        }

        private void btnListado2_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
        }

        private void btnListado3_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
        }
    }
}
