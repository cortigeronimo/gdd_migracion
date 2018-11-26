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
using PalcoNet.Config;
using PalcoNet.Repositorios;
using PalcoNet.Abm_Grado;

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormEditarPublicacion : CustomForm

    {
        RepoPublicacion repoPublicacion = new RepoPublicacion();
        RepoUbicacion repoUbicacion = new RepoUbicacion();

        //Ubicaciones de las publicaciones del usuario
        List<Ubicacion> pubUbicaciones = new List<Ubicacion>();

        Publicacion publicacionToEdit;

        public FormEditarPublicacion()
        {
            InitializeComponent();

            dataGridViewPublicaciones.DataSource = repoPublicacion.GetPublicacionesToEditForm(String.Empty);

            pubUbicaciones = repoUbicacion.GetUbicacionesByUser();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewPublicaciones.DataSource = repoPublicacion.GetPublicacionesToEditForm(txtDescripcion.Text);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea dar por finalizada la publicación?", "Finalizar Publicación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                repoPublicacion.CambiarEstadoPublicacion(publicacionToEdit, "FINALIZADA");
                MessageBox.Show("La publicación ha finalizado.");
                RefreshDataGridViewPublicacion();

            }
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea publicar el evento seleccionado?", "Publicar Evento", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                repoPublicacion.CambiarEstadoPublicacion(publicacionToEdit, "PUBLICADA");
                MessageBox.Show("El evento ha sido publicado.");
                RefreshDataGridViewPublicacion();

            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoadUbicaciones();

            using(FormGenerarPublicacion form = new FormGenerarPublicacion(publicacionToEdit))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    form.Close();
                    RefreshDataGridViewPublicacion();
                    
                }

            }
        }

        private void RefreshDataGridViewPublicacion()
        {
            dataGridViewPublicaciones.DataSource = repoPublicacion.GetPublicacionesToEditForm(txtDescripcion.Text);
            pubUbicaciones = repoUbicacion.GetUbicacionesByUser();
        }

        private void SelectedRowsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewPublicaciones.SelectedRows[0];
            publicacionToEdit = BuildPublicacion(row);

        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            //hacer case para habilitar los botones, segun los estados de las publicaciones.....
            if (this.dataGridViewPublicaciones.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridViewPublicaciones.SelectedRows[0];

                String estadoPublicacion = row.Cells[columnEstado.Name].Value.ToString();

                switch (estadoPublicacion)
                {
                    case "BORRADOR":
                        this.btnEditar.Enabled = true;
                        this.btnFinalizar.Enabled = false;
                        this.btnPublicar.Enabled = true;
                        break;
                    case "PUBLICADA":
                        this.btnEditar.Enabled = false;
                        this.btnFinalizar.Enabled = true;
                        this.btnPublicar.Enabled = false;
                        break;
                    case "FINALIZADA":
                        this.btnEditar.Enabled = false;
                        this.btnFinalizar.Enabled = false;
                        this.btnPublicar.Enabled = false;
                        break;
                }
            }
            else
            {
                this.btnEditar.Enabled = false;
                this.btnFinalizar.Enabled = false;
                this.btnPublicar.Enabled = false;
            }

        }

        private void LoadUbicaciones()
        {
            List<Ubicacion> filteredUbicaciones = new List<Ubicacion>();

            foreach (Ubicacion u in pubUbicaciones)
            {
                if (u.Publicacion == publicacionToEdit.Codigo)
                    filteredUbicaciones.Add(u);
            }

            publicacionToEdit.Ubicaciones = filteredUbicaciones;
        }

        private Publicacion BuildPublicacion(DataGridViewRow row)
        {
            Publicacion publicacion = new Publicacion();

            publicacion.Codigo = Convert.ToInt64(row.Cells[columnCodigo.Name].Value);
            publicacion.Descripcion = row.Cells[columnDescripcion.Name].Value.ToString();
            publicacion.FechaInicio = Convert.ToDateTime(row.Cells[columnFechaInicio.Name].Value);
            publicacion.FechaEvento = Convert.ToDateTime(row.Cells[columnFechaEvento.Name].Value);
            publicacion.Direccion = row.Cells[columnDireccion.Name].Value.ToString();
            
            Rubro rubro = new Rubro();
            rubro.Descripcíon = row.Cells[columnRubro.Name].Value.ToString();
            publicacion.Rubro = rubro;

            Grado grado = new Grado();
            grado.Descripcion = row.Cells[columnGrado.Name].Value.ToString();
            publicacion.Grado = grado;

            Empresa emp = new Empresa();
            emp.id = (int)row.Cells[columnEmpresa.Name].Value;
            publicacion.Empresa = emp;

            Estado estado = new Estado();
            estado.Descripcion = row.Cells[columnEstado.Name].Value.ToString();
            publicacion.Estado = estado;



            return publicacion;

        }

        private void FormEditarPublicacion_Load(object sender, EventArgs e)
        {
            this.dataGridViewPublicaciones.RowHeaderMouseClick += SelectedRowsButton_Click;
            this.dataGridViewPublicaciones.SelectionChanged += OnSelectionChanged;
        }

        

        



    }
}