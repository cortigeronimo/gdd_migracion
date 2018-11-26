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
                (int)Convert.ToInt32(txtComision.Text),
                txtNombreGrado.Text);
            try
            {
                repo.InsertGrado(grado);
                MessageBox.Show("La operación ha sido exitosa");
            }
            catch {
                MessageBox.Show("Hubo un error al guardar la información, reintentelo");
            }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtComision.Clear();
            txtNombreGrado.Clear();
        }

    }
}
