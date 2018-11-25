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
        private RepoRol repoRol = new RepoRol();

        public Funcionalidad Elegida
        {
            get { return elegida; }
        }

        public ListadoFuncionalidades()
        {
            InitializeComponent();
        }

        //Botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = (txtNombre.Text == null) ? "" : txtNombre.Text;
            funcionalidades = repoRol.GetFuncionalidades(filtro);
            listBoxFuncionalidades.DataSource = funcionalidades.Select<Funcionalidad, string>(x => x.Nombre).ToList();
        }

        //Botón Seleccionar
        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if (listBoxFuncionalidades.SelectedItem != null)
            {
                elegida = funcionalidades.Find(x => x.Nombre == (string)listBoxFuncionalidades.SelectedItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Elija una funcionalidad, por favor.");

        }
    }
}
