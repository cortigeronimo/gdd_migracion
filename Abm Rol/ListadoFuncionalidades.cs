﻿using System;
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
        private List<Funcionalidad> funcionalidades;
        private Rol rol;
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

        public ListadoFuncionalidades(Rol _rol)
        {
            InitializeComponent();
            rol = _rol;
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
                if (rol != null && rol.funcionalidades != null && rol.funcionalidades.Exists(funcionalidad => funcionalidad.Nombre == (string)listBoxFuncionalidades.SelectedItem))
                {
                    MessageBox.Show("El rol " + rol.Nombre + " ya tiene esa funcionalidad");
                    return;
                }
                elegida = funcionalidades.Find(x => x.Nombre == (string)listBoxFuncionalidades.SelectedItem);
                this.DialogResult = DialogResult.OK; this.DialogResult = DialogResult.OK;
                this.CloseThis();
            }
            else MessageBox.Show("Elija una funcionalidad, por favor.");

        }
    }
}
