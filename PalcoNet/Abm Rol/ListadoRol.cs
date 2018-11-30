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
    public partial class ListadoRol : CustomForm
    {
        private BindingSource bindingSource = new BindingSource();
        List<Rol> rolesFiltrados = new List<Rol>();
        RepoRol repoRol = new RepoRol();

        public ListadoRol()
        {
            InitializeComponent();
            dataGridRoles.AutoGenerateColumns = false;
            comboBoxHabilitado.Text = "Sí";
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Seleccionar
            using (ListadoFuncionalidades form = new ListadoFuncionalidades())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Funcionalidad val = form.Elegida;
                    txtFuncionalidad.Text = val.Nombre;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void comboBoxHabiliitado_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtFuncionalidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscar
            bindingSource.Clear();
            rolesFiltrados = new RepoRol().GetRolesByFilter(txtNombre.Text, (comboBoxHabilitado.Text == "Sí" ? true : false), txtFuncionalidad.Text);
            rolesFiltrados.ForEach(rol => bindingSource.Add(rol));
            dataGridRoles.DataSource = bindingSource;
        }

        private void dataGridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridRoles.Columns["Seleccionar"].Index)
            {
                Rol rol = (Rol)dataGridRoles.CurrentRow.DataBoundItem;
                rol.funcionalidades = repoRol.GetFuncionalidades(rol.Id);
                using (ModificarRol form = new ModificarRol(rol))
                {
                    DialogResult result = form.ShowDialog();
                }
            }
            if (e.ColumnIndex == dataGridRoles.Columns["Eliminar"].Index)
            {
                Rol rol = (Rol)dataGridRoles.CurrentRow.DataBoundItem;
                rol.funcionalidades = repoRol.GetFuncionalidades(rol.Id);
                
                var confirmResult = MessageBox.Show("Eliminar el rol " + rol.Nombre + " ??",
                                     "Confirmar eliminación",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show("Rol "+ rol.Nombre + " eliminado");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
