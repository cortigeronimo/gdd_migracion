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

namespace PalcoNet.Abm_Rol
{
    public partial class ListadoFuncionalidades : CustomForm
    {
        List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
        private Funcionalidad elegida;

        public Funcionalidad Elegida
        {
            get { return elegida; }
        }

        public ListadoFuncionalidades()
        {
            InitializeComponent();
        }

        private void ListadoFuncionalidades_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Botón Buscar
        private void button2_Click(object sender, EventArgs e)
        {
            RepoRol repoRol = new RepoRol();
            string filtro = (textBox1.Text == null) ? "" : textBox1.Text;
            funcionalidades = repoRol.GetFuncionalidades(filtro);
            listBox1.DataSource = funcionalidades.Select<Funcionalidad, string>(x => x.Nombre).ToList();
        }

        //Botón Seleccionar
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                elegida = funcionalidades.Find(x => x.Nombre == (string)listBox1.SelectedItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Elegí una funcionalidad amiguero");

        }
    }
}
