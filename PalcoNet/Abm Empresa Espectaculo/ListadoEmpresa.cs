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
using PalcoNet.Vistas;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class ListadoEmpresa : CustomForm
    {
        private BindingSource bindingSource = new BindingSource();
        List<Empresa> empresasFiltradas = new List<Empresa>(); 

        public ListadoEmpresa()
        {
            InitializeComponent();
            dataGridEmpresas.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Empresa> empresas = new RepoEmpresa().GetEmpresasByFilter(txtBoxRazonSocial.Text, txtBoxCUIT.Text, txtBoxEmail.Text);
            bindingSource.Clear();
            empresas.ForEach(emp => bindingSource.Add(emp));
            dataGridEmpresas.DataSource = bindingSource;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridEmpresas.DataSource = null;
        }

    }
}
