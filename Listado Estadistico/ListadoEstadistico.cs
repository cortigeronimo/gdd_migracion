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
        List<ResultadoEstadistico2> top5ClientesPuntos = new List<ResultadoEstadistico2>();
        List<ResultadoEstadistico3> top5ClientesCompras = new List<ResultadoEstadistico3>();
        RepoEstadistica repo = new RepoEstadistica();

        public ListadoEstadistico()
        {
            InitializeComponent();
            this.comboBoxTrimestre.Text = "1";
            this.dataGridEstadisticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEstadisticas.RowHeadersVisible = false;
        }

        private void btnListado1_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            dataGridEstadisticas.Columns.Clear();
            bindingSource = new BindingSource();
            if (String.IsNullOrEmpty(txtBoxAnio.Text))
            {
                MessageBox.Show("Por favor escriba el año a evaluar.");
                return;
            }
            LoadGradoFilter form = new LoadGradoFilter();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //aca tenes el grado id, usalo en la funcion que busca
                int gradoid = form.grado.Id;
                top5 = repo.GetTop5Empresas(Convert.ToInt32(txtBoxAnio.Text), Convert.ToInt32(comboBoxTrimestre.Text));
                bindingSource = new BindingSource(top5, String.Empty);
                dataGridEstadisticas.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("Debe completar el filtro para buscar el top 5");
                return;
            }
            

        }

        private void btnListado2_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            dataGridEstadisticas.Columns.Clear();
            bindingSource = new BindingSource();
            if (txtBoxAnio.Text == "")
            {
                MessageBox.Show("Por favor escriba el año a evaluar.");
                return;
            }

            top5ClientesPuntos = repo.GetTop5ClientesPuntos(Convert.ToInt32(txtBoxAnio.Text), Convert.ToInt32(comboBoxTrimestre.Text));
            bindingSource = new BindingSource(top5ClientesPuntos, String.Empty);
            dataGridEstadisticas.DataSource = bindingSource;
        }

        private void btnListado3_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            dataGridEstadisticas.Columns.Clear();
            bindingSource = new BindingSource();
            if (txtBoxAnio.Text == "")
            {
                MessageBox.Show("Por favor escriba el año a evaluar.");
                return;
            }

            AddEmpresaFilter form = new AddEmpresaFilter();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //aca tenes  el empresa id, usalo en la funcion que busca
                int? empresaId = form.empresa.id;
                top5ClientesCompras = repo.GetTop5ClientesCompras(Convert.ToInt32(txtBoxAnio.Text), Convert.ToInt32(comboBoxTrimestre.Text));
                bindingSource = new BindingSource(top5ClientesCompras, String.Empty);
                dataGridEstadisticas.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("Debe completar el filtro para buscar el top 5");
                return;
            }

            
        }
    }
}
