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
        public UpdateGrado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RepoGradoPublicacion repo = new RepoGradoPublicacion();
            Grado grado = new Grado(
                (int)numIdGrado.Value,
                (int)numComisionGrado.Value,
                txtNombreGrado.Text);
            if(repo.UpdateGrado(grado) > 0){
                MessageBox.Show("Todo ok perro");
            }
            else{
                MessageBox.Show("Algo se rompio mono");   
            }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numComisionGrado.Value = 0;
            txtNombreGrado.Text = "";
        }


    }
}
