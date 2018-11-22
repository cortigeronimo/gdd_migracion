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
using PalcoNet.Abm_Grado;
using PalcoNet.Config;

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormGenerarPublicacion : CustomForm
    {
        RepoRubro repoRubro = new RepoRubro();
        RepoGradoPublicacion repoGrado = new RepoGradoPublicacion();
        RepoPublicacion repoPublicacion = new RepoPublicacion();
 
        //Lista de publicaciones para el boton "varias fechas"
        List<Publicacion> publicacionesList = new List<Publicacion>();

        Publicacion publicacion = new Publicacion();
        //public List<Ubicacion> Ubicaciones { get; set; }
        
        Usuario loginUser = new Usuario();

        String errorMessage = "Error:\n"; 

        //List<Ubicacion> ubicacionesList = new List<Ubicacion>();

        public FormGenerarPublicacion()
        {
            InitializeComponent();

            this.loginUser.id = (int)LoggedInUser.ID;
            this.loginUser.username = LoggedInUser.Username;

            publicacion.Ubicaciones = new List<Ubicacion>();

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            comboBoxRubro.DisplayMember = "Rubro_Descripcion";
            comboBoxRubro.ValueMember = "Rubro_Id";
            comboBoxRubro.DataSource = repoRubro.GetRubros();

            comboBoxGrado.DisplayMember = "Grado_Descripcion";
            comboBoxGrado.ValueMember = "Grado_Id";
            comboBoxGrado.DataSource = repoGrado.GetGradosDataTable();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if (checkBoxVariasFechas.Checked)
            {
                if (FormDataOK())
                {
                    //cargar datos del form (nombre, direccion, ubicaciones) a los objetos de la lista publicaciones a insertar en la DB
                    LoadDataForPublicacionesList(2);

                    repoPublicacion.InsertPublicacionesList(publicacionesList);
                    MessageBox.Show("Publicaciones insertadas correctamente.");
                    ClearAll();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                    errorMessage = "Error:\n";
                }
            }
            else
            {
                if (FormDataOK())
                {
                    LoadData(publicacion, 2);
                    repoPublicacion.InsertPublicacion(publicacion);
                    MessageBox.Show("Publicación insertada correctamente.");
                    ClearAll();
                    
                }
                else
                {
                    MessageBox.Show(errorMessage);
                    errorMessage = "Error:\n";
                }
            }        

        }


        private void btnGuardarBorrador_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SystemDate.GetDate().ToString());

            if (checkBoxVariasFechas.Checked)
            {
                if (FormDataOK())
                {
                    //cargar datos del form (nombre, direccion, ubicaciones) a los objetos de la lista publicaciones a insertar en la DB
                    LoadDataForPublicacionesList(1);

                    repoPublicacion.InsertPublicacionesList(publicacionesList);
                    MessageBox.Show("Las publicaciones se guardaron en el borrador, puede editarlas desde la opción EDITAR PUBLICACIÓN");
                    ClearAll();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                    errorMessage = "Error:\n";
                }
            }
            else
            {
                if (FormDataOK())
                {
                    LoadData(publicacion, 1);
                    repoPublicacion.InsertPublicacion(publicacion);
                    MessageBox.Show("La publicación se guardó en el borrador, puede editarla desde la opción EDITAR PUBLICACIÓN");
                    ClearAll();

                }
                else
                {
                    MessageBox.Show(errorMessage);
                    errorMessage = "Error:\n";
                }
            }

        }

        private void btnProgramarFechas_Click(object sender, EventArgs e)
        {
            using (FormAgregarFechas form = new FormAgregarFechas(this.publicacionesList))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.publicacionesList = form.publicacionList;
                }
            }
        }


        private void btnAgregarUbicaciones_Click(object sender, EventArgs e)
        {
            using (FormAgregarUbicaciones form = new FormAgregarUbicaciones(publicacion.Ubicaciones))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    publicacion.Ubicaciones = form.Ubicaciones;
                }
            }       


        }

        private void LoadDataForPublicacionesList(int estadoId)
        {
            foreach (Publicacion p in publicacionesList)
            {
                LoadData(p, estadoId);
                p.Ubicaciones = publicacion.Ubicaciones;
            }
        }

        private void ClearAll()
        {
            txtNombrePublicacion.Clear();
            txtDireccion.Clear();
            dateTimePickerFechaInicio.Value = DateTime.Today;
            dateTimePickerFechaEvento.Value = DateTime.Today;

            checkBoxVariasFechas.Checked = false;

            publicacionesList = new List<Publicacion>();

            publicacion.Ubicaciones = new List<Ubicacion>();

        }

        private void LoadData(Publicacion publicacion, int estadoId)
        {
            if (!checkBoxVariasFechas.Checked)
            {
                //Fecha Inicio 
                publicacion.FechaInicio = dateTimePickerFechaInicio.Value;

                //Fecha Evento
                publicacion.FechaEvento = dateTimePickerFechaEvento.Value;
            }

            //Descripcion
            publicacion.Descripcion = txtNombrePublicacion.Text.ToString();

            //Direccion
            publicacion.Direccion = txtDireccion.Text.ToString();

            //Rubro
            Rubro rubro = new Rubro();
            rubro.Id = (int)comboBoxRubro.SelectedValue;
            rubro.Descripcíon = comboBoxRubro.Text;

            publicacion.Rubro = rubro;

            //Grado
            Grado grado = new Grado();
            grado.Id = (int)comboBoxGrado.SelectedValue;
            grado.Descripcion = comboBoxGrado.Text;

            publicacion.Grado = grado;

            //Estado
            Estado estado = new Estado();
            estado.Id = estadoId;
            if (estadoId == 1)
                estado.Descripcion ="BORRADOR";
            else
                estado.Descripcion = "PUBLICADA";

            publicacion.Estado = estado;

            //Empresa
            Empresa empresa = new Empresa();
            empresa.id = this.loginUser.id;

            publicacion.Empresa = empresa;        
            
        }


        private Boolean FormDataOK()
        {
            int errorCount = 0;
            if (!checkBoxVariasFechas.Checked)
            {
                if (!(dateTimePickerFechaInicio.Value < dateTimePickerFechaEvento.Value)) { errorMessage += "La fecha de evento debe ser posterior a la fecha de inicio.\n"; errorCount++; }
            }
            else
            {
                if (publicacionesList.Count == 0) { errorMessage += "No hay fechas ingresadas para la publicación."; errorCount++; }
            }    
            if (String.IsNullOrEmpty(txtNombrePublicacion.Text.ToString())) { errorMessage += "El campo Nombre está vacio.\n"; errorCount++; }
            if (String.IsNullOrEmpty(txtDireccion.Text.ToString())) { errorMessage += "El campo Dirección está vacio.\n"; errorCount++; }
            if (publicacion.Ubicaciones.Count == 0) { errorMessage += "La publicacion no tiene Ubicaciones.\n"; errorCount++; }
            return errorCount == 0;
        }

        private void txtNombrePublicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar) && txtNombrePublicacion.Text == String.Empty) e.Handled = true;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar) && txtDireccion.Text == String.Empty) e.Handled = true;
        }

        

        private void checkBoxVariasFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVariasFechas.Checked)
            {
                dateTimePickerFechaInicio.Enabled = false;
                dateTimePickerFechaEvento.Enabled = false;
                btnProgramarFechas.Enabled = true;
            }
            else
            {
                dateTimePickerFechaInicio.Enabled = true;
                dateTimePickerFechaEvento.Enabled = true;
                btnProgramarFechas.Enabled = false;
            }
        }

        

        

    }
}
