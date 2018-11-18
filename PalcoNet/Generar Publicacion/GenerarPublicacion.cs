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

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormGenerarPublicacion : CustomForm
    {
        RepoRubro repoRubro = new RepoRubro();
        RepoGradoPublicacion repoGrado = new RepoGradoPublicacion();
        Publicacion publicacion = new Publicacion();
        public List<Ubicacion> Ubicaciones { get; set; }
        
        Usuario loginUser;

        //List<Ubicacion> ubicacionesList = new List<Ubicacion>();

        public FormGenerarPublicacion(Usuario loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;

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
            //publicacion = new Publicacion();     

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





    }
}
