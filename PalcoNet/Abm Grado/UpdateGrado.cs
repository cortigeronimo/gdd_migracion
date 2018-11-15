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
using PalcoNet.Repositorios;

namespace PalcoNet.Abm_Grado
{
    public partial class UpdateGrado : CustomForm
    {
        Grado grado;

        public UpdateGrado(Grado grado)
        {
            this.grado = grado;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RepoGradoPublicacion repo = new RepoGradoPublicacion();
            Grado grado = new Grado(
                (int)this.grado.Id,
                (int)numComisionGrado.Value,
                txtNombreGrado.Text);
            if(repo.UpdateGrado(grado) > 0){
                MessageBox.Show("Los Cambios se realizaron con Éxito");
            }
            else{
                MessageBox.Show("Hubo un error al realizar la operación, reintentelo");   
            }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numComisionGrado.Value = 0;
            txtNombreGrado.Text = "";
        }

        private void UpdateGrado_Load(object sender, EventArgs e)
        {
            txtNombreGrado.Text = this.grado.Descripcion;
            numComisionGrado.Value = this.grado.Comision;
        }


    }
}
