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

namespace PalcoNet.Abm_Rol
{
    public partial class ModificarRol : Form
    {
        Rol rolNoModificado;
        Rol rol;
        public ModificarRol(Rol rol)
        {
            rolNoModificado = new Rol(rol.Id, rol.Nombre, rol.Habilitado);
            this.rol = new Rol(rol.Id, rol.Nombre, rol.Habilitado);
            //Negrada hecha porque la lista sino no se clona
            rol.funcionalidades.ForEach(_rolF => {
                rolNoModificado.funcionalidades.Add(_rolF);
                this.rol.funcionalidades.Add(_rolF);
            });
            InitializeComponent();
            textBoxNombre.Text = rol.Nombre;
            comboBoxHabilitado.Text = this.rol.Habilitado ? "Sí" : "No";
            CargarListFuncionalidades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (ListadoFuncionalidades form = new ListadoFuncionalidades(rol))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Funcionalidad func = form.Elegida;
                    rol.funcionalidades.Add(func);
                    CargarListFuncionalidades();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Funcionalidad selected = rol.funcionalidades.Find(r => r.Nombre == (string)listBoxFuncionalidades.SelectedItem);
            rol.funcionalidades.Remove(selected);
            CargarListFuncionalidades();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarListFuncionalidades()
        {
            listBoxFuncionalidades.DataSource = rol.funcionalidades.Select<Funcionalidad, string>(funcionalidad => funcionalidad.Nombre).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rol = new Rol(rolNoModificado.Id, rolNoModificado.Nombre, rolNoModificado.Habilitado);
            rolNoModificado.funcionalidades.ForEach(rolF => rol.funcionalidades.Add(rolF));
            textBoxNombre.Text = rol.Nombre;
            comboBoxHabilitado.Text = rol.Habilitado ? "Sí" : "No";
            CargarListFuncionalidades();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            new RepoRol().UpdateRol(rol);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Rol Modificado");
            this.Close();
        }

        private void comboBoxHabilitado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHabilitado.SelectedText == "Sí")
            {
                rol.habilitado = true;
            }
            else
            {
                rol.habilitado = false;
            }
        }

    }
}
