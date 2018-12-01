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
using PalcoNet.Utils;

namespace PalcoNet.Abm_Rol
{
    public partial class AltaRol : Form
    {
        Rol rol = new Rol();
        RepoRol repoRol = new RepoRol();

        public AltaRol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (ListadoFuncionalidades form = new ListadoFuncionalidades(rol))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Funcionalidad val = form.Elegida;
                    rol.funcionalidades.Add(val);
                    CargarListFuncionalidades();
                    AllDataIsCompleted(sender, e);
                }
            }
        }

        private void AllDataIsCompleted(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxNombre.Text) || rol.funcionalidades.Count == 0)
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Funcionalidad selected = rol.funcionalidades.Find(r => r.Nombre == (string)listBoxFuncionalidades.SelectedItem);
            rol.funcionalidades.Remove(selected);
            CargarListFuncionalidades();
            AllDataIsCompleted(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rol = new Rol();
            txtBoxNombre.Clear();
            listBoxFuncionalidades.DataSource = null;
            AllDataIsCompleted(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Rol nuevoRol = new Rol(txtBoxNombre.Text, true);
            nuevoRol.funcionalidades = rol.funcionalidades;
            if (repoRol.ExisteRol(nuevoRol.Nombre))
            {
                MessageBox.Show("Ya existe un rol con ese nombre");
                return;
            }
            try
            {
                repoRol.CreateRol(nuevoRol);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show(Messagges.OPERACION_EXITOSA);
            }
            catch (Exception) {
                MessageBox.Show(Messagges.ERROR_INESPERADO);
            }
            
            this.Close();
        }

        private void CargarListFuncionalidades()
        {
            listBoxFuncionalidades.DataSource = rol.funcionalidades.Select<Funcionalidad, string>(funcionalidad => funcionalidad.Nombre).ToList();
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
