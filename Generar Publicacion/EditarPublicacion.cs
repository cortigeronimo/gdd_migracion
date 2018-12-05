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
using PalcoNet.Config;
using PalcoNet.Repositorios;
using PalcoNet.Abm_Grado;
using PalcoNet.Utils;

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormEditarPublicacion : CustomForm

    {
        RepoPublicacion repoPublicacion = new RepoPublicacion();
        RepoUbicacion repoUbicacion = new RepoUbicacion();
        RepoEstado repoEstado = new RepoEstado();

        //Ubicaciones de las publicaciones del usuario
        List<Ubicacion> pubUbicaciones = new List<Ubicacion>();

        Publicacion publicacionToEdit;

        public FormEditarPublicacion()
        {
            InitializeComponent();
            

            dataGridViewPublicaciones.DataSource = repoPublicacion.GetPublicacionesToEditForm(String.Empty, Convert.ToInt32(comboBoxEstado.SelectedValue));

            pubUbicaciones = repoUbicacion.GetUbicacionesByUser();

            comboBoxEstado.ValueMember = "Estado_Id";
            comboBoxEstado.DisplayMember = "Estado_Descripcion";
            comboBoxEstado.DataSource = repoEstado.GetAllEstados();

            comboBoxEstado.SelectedValue = 0;
        }

        //Buscar publicación por filtro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewPublicaciones.DataSource = repoPublicacion.GetPublicacionesToEditForm(txtDescripcion.Text, Convert.ToInt32(comboBoxEstado.SelectedValue));
        }


        //Dar por finalizada una publicación
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea dar por finalizada la publicación?", "Finalizar Publicación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    repoPublicacion.CambiarEstadoPublicacion(publicacionToEdit, "FINALIZADA");
                    MessageBox.Show("La publicación ha finalizado.", "Message");
                    RefreshDataGridViewPublicacion();
                }
                catch (Exception)
                {
                    MessageBox.Show(Messages.ERROR_INESPERADO, "Error");
                }

            }
        }

        //Publicar un espectáculo
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            //Verifica que la fecha de evento sea anterior a la fecha actual
            if (publicacionToEdit.FechaEvento <= SystemDate.GetDate())
            {
                MessageBox.Show("La Fecha del Evento a publicar es anterior a la fecha actual.", "Error");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Desea publicar el evento seleccionado?", "Publicar Evento", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    repoPublicacion.CambiarEstadoPublicacion(publicacionToEdit, "PUBLICADA");
                    MessageBox.Show("El Evento ha sido publicado.", "Message");
                    RefreshDataGridViewPublicacion();
                }
                catch (Exception)
                {
                    MessageBox.Show(Messages.ERROR_INESPERADO, "Error");
                }
                

            }
        }

        //Abre el form para editar la publicación seleccionada
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
            dataGridViewPublicaciones.DataSource = repoPublicacion.GetPublicacionesToEditForm(txtDescripcion.Text, Convert.ToInt32(comboBoxEstado.SelectedValue));
            pubUbicaciones = repoUbicacion.GetUbicacionesByUser();
        }

        private void SelectedRowsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewPublicaciones.SelectedRows[0];
            publicacionToEdit = BuildPublicacion(row);

        }


        //Botonera dinámica, activa y desactiva botones segun el estado del espectáculo
        private void OnSelectionChanged(object sender, EventArgs e)
        {           
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

        //Cargar las ubicaciones del espectáculo seleccionado
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

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstado.Checked)
            {
                comboBoxEstado.Enabled = true;
                comboBoxEstado.SelectedIndex = 0;
            }
            else
            {
                comboBoxEstado.Enabled = false;
                comboBoxEstado.SelectedValue = 0;
            }
        }

        

        



    }
}
