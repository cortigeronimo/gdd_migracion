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
using PalcoNet.Utils;

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormGenerarPublicacion : CustomForm
    {
        RepoRubro repoRubro = new RepoRubro();
        RepoGradoPublicacion repoGrado = new RepoGradoPublicacion();
        RepoEstado repoEstado = new RepoEstado();
        RepoPublicacion repoPublicacion = new RepoPublicacion();
 
        //Lista de publicaciones para varias fechas (mismo espectaculo)
        List<Publicacion> publicacionesList = new List<Publicacion>();

        Publicacion publicacion = new Publicacion();
              
        Usuario loginUser = new Usuario();

        String errorMessage; 

        

        public FormGenerarPublicacion()
        {
            InitializeComponent();

            this.loginUser.id = (int)UserSession.UserId;
            this.loginUser.username = UserSession.Username;

            publicacion.Ubicaciones = new List<Ubicacion>();

            LoadComboBox();

            dateTimePickerFechaEvento.Value = SystemDate.GetDate();
        }


        public FormGenerarPublicacion(Publicacion publicacionFromEditForm)
        {
            InitializeComponent();

            Publicacion publicacionToEdit = publicacionFromEditForm;
            publicacion.Codigo = publicacionFromEditForm.Codigo;

            this.loginUser.id = (int)UserSession.UserId;
            this.loginUser.username = UserSession.Username;

            publicacion.Ubicaciones = new List<Ubicacion>();

            checkBoxVariasFechas.Enabled = false;
            btnProgramarFechas.Enabled = false;

            LoadComboBox();

            LoadPublicacionDataToForm(publicacionToEdit);

            this.Text = "Editar Publicación";
            this.groupBoxGenerarPublicacion.Text = "Editar Publicación";
        }


        //Carga los datos de publicacion a editar al form
        private void LoadPublicacionDataToForm(Publicacion publicacionToLoad)
        {
            txtNombrePublicacion.Text = publicacionToLoad.Descripcion;
            txtDireccion.Text = publicacionToLoad.Direccion;
            comboBoxRubro.SelectedValue = publicacionToLoad.Rubro.Id;
            comboBoxRubro.Text = publicacionToLoad.Rubro.Descripcíon;
            comboBoxGrado.SelectedValue = publicacionToLoad.Grado.Id;
            comboBoxGrado.Text = publicacionToLoad.Grado.Descripcion;

            comboBoxEstado.Text = publicacionToLoad.Estado.Descripcion;

            dateTimePickerFechaEvento.Value = publicacionToLoad.FechaEvento;

            publicacion.Ubicaciones = publicacionToLoad.Ubicaciones;
            txtStock.Text = publicacionToLoad.Ubicaciones.Count.ToString();
        }


        private void LoadComboBox()
        {
            comboBoxRubro.DisplayMember = "Rubro_Descripcion";
            comboBoxRubro.ValueMember = "Rubro_Id";
            comboBoxRubro.DataSource = repoRubro.GetRubros();

            comboBoxGrado.DisplayMember = "Grado_Descripcion";
            comboBoxGrado.ValueMember = "Grado_Id";
            comboBoxGrado.DataSource = repoGrado.GetGradosDataTable();

            comboBoxEstado.DisplayMember = "Estado_Descripcion";
            comboBoxEstado.ValueMember = "Estado_Id";
            comboBoxEstado.DataSource = repoEstado.GetEstadosToGenerarPubForm();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!FormDataOK())
            {
                MessageBox.Show(errorMessage, "Error");
                errorMessage = String.Empty;
                return;
            }
          

            if (checkBoxVariasFechas.Checked)
            {
                LoadDataForPublicacionesList();

                if (ExistsPublicacionMismaHora(publicacionesList))
                {
                    MessageBox.Show(errorMessage, "Error");
                    errorMessage = String.Empty;
                    return;
                }

                try
                {
                    repoPublicacion.InsertPublicacionesList(publicacionesList);
                    MessageBox.Show(Messages.OPERACION_EXITOSA, "Message");
                    ClearAll();
                }
                catch (Exception)
                {
                    MessageBox.Show(Messages.ERROR_INESPERADO, "Message");
                }
                
            }
            else
            {
                LoadData(publicacion);

                if (ExistsPublicacionMismaHora(publicacion.Codigo, publicacion.Descripcion, publicacion.FechaEvento))
                {
                    MessageBox.Show(errorMessage, "Error");
                    errorMessage = String.Empty;
                    return;
                }

                try
                {
                    repoPublicacion.InsertOrUpdatePublicacion(publicacion);
                    MessageBox.Show(Messages.OPERACION_EXITOSA, "Message");
                    ClearAll();
                }
                catch (Exception)
                {
                    MessageBox.Show(Messages.ERROR_INESPERADO, "Message");
                }

                this.DialogResult = DialogResult.OK;
            }

        }


        //Verifica si existen publicaciones del mismo nombre y con la misma fecha de evento (Para una publicación)
        private Boolean ExistsPublicacionMismaHora(decimal publicacionCodigo, String descripcionPublicacion, DateTime fechaHoraEvento)
        {
            if (repoPublicacion.ExistsPublicacionMismaHora(publicacionCodigo, descripcionPublicacion, fechaHoraEvento))
            {
                errorMessage += "Ya existe un Espectáculo del mismo nombre en la Fecha de Evento ingresada.\n";
                return true;
            }
            else
            {
                return false;
            }
        }

        //Verifica si existen publicaciones del mismo nombre y con las mismas fechas de evento ingresadas (Para una publicación con varias fechas)
        private Boolean ExistsPublicacionMismaHora(List<Publicacion> publicaciones)
        {
            int countPublicacionesMismaFechaHora = 0;
            String repeatDates = String.Empty;
            foreach (Publicacion p in publicaciones)
            {
                if (repoPublicacion.ExistsPublicacionMismaHora(p.Codigo, p.Descripcion, p.FechaEvento))
                {
                    countPublicacionesMismaFechaHora++;
                    repeatDates += p.FechaEvento.ToString() + "\n";
                } 
            }

            if (countPublicacionesMismaFechaHora != 0)
            {
                errorMessage = "Ya existen Espectáculos del mismo Nombre en la/s siguiente/s Fecha/s de Evento ingresada/s: \n" + repeatDates;
                return true;
            }
            else
            {
                return false;
            }     
        }


        //Agrega varias fechas a un mismo evento
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

        //Agerga ubicaciones disponibles para el evento (Stock)
        private void btnAgregarUbicaciones_Click(object sender, EventArgs e)
        {
            using (FormAgregarUbicaciones form = new FormAgregarUbicaciones(publicacion.Ubicaciones))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    publicacion.Ubicaciones = form.Ubicaciones;
                    txtStock.Text = publicacion.Ubicaciones.Count.ToString();
                }
            }       

        }

        //Cargar datos para lista publicaciones del mismo espectaculo con varias fechas
        private void LoadDataForPublicacionesList()
        {
            foreach (Publicacion p in publicacionesList)
            {
                LoadData(p);
                p.Ubicaciones = publicacion.Ubicaciones;
            }
        }

        private void ClearAll()
        {
            txtNombrePublicacion.Clear();
            txtDireccion.Clear();

            dateTimePickerFechaEvento.Value = SystemDate.GetDate().AddDays(7);
            
            checkBoxVariasFechas.Checked = false;

            publicacionesList = new List<Publicacion>();

            publicacion.Ubicaciones = new List<Ubicacion>();

            txtStock.Clear();

        }

        //Cargar datos de una publicación
        private void LoadData(Publicacion publicacion)
        {
            if (!checkBoxVariasFechas.Checked)
            {
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
            estado.Id = (int)comboBoxEstado.SelectedValue;
            estado.Descripcion = comboBoxEstado.Text;

            publicacion.Estado = estado;

            //Empresa
            Empresa empresa = new Empresa();
            empresa.id = this.loginUser.id;

            publicacion.Empresa = empresa;        
            
        }

        //Validaciones
        private Boolean FormDataOK()
        {
            int errorCount = 0;
      
            if (!checkBoxVariasFechas.Checked)
            {
                if (!(SystemDate.GetDate() < dateTimePickerFechaEvento.Value)) { errorMessage += "La Fecha de Evento debe ser posterior a la fecha actual.\n"; errorCount++; }
            }
            else
            {
                if (publicacionesList.Count == 0) { errorMessage += "No hay Fechas de Evento ingresadas para la Publicación.\n"; errorCount++; }
            }

            if (String.IsNullOrEmpty(txtNombrePublicacion.Text.ToString())) { errorMessage += "El campo Nombre está vacio.\n"; errorCount++; }
            if (String.IsNullOrEmpty(txtDireccion.Text.ToString())) { errorMessage += "El campo Dirección está vacio.\n"; errorCount++; }
            if (publicacion.Ubicaciones.Count == 0) { errorMessage += "La Publicación no tiene Ubicaciones.\n"; errorCount++; }

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
                dateTimePickerFechaEvento.Enabled = false;
                btnProgramarFechas.Enabled = true;
            }
            else
            {
                dateTimePickerFechaEvento.Enabled = true;
                btnProgramarFechas.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePublicacion.Clear();
            txtDireccion.Clear();
        }

        

    }
}
