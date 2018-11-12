using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Repositorios;
using PalcoNet.Modelo;
using PalcoNet.Vistas;

namespace PalcoNet.Abm_Grado
{
    public partial class CreateGrado : CustomForm
    {
        public CreateGrado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RepoGradoPublicacion repo = new RepoGradoPublicacion();
            Grado grado = new Grado(
                (int)numComisionGrado.Value,
                txtNombreGrado.Text);
            repo.InsertGrado(grado);
            MessageBox.Show("Todo ok perro");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numComisionGrado.Value = 0;
            txtNombreGrado.Text = "";
        }

    }
}
