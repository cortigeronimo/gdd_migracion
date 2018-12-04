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
using PalcoNet.Utils;

namespace PalcoNet.Abm_Grado
{
    public partial class UpdateGrado : CustomForm
    {
        Grado grado;
        RepoGradoPublicacion repo = new RepoGradoPublicacion();


        public UpdateGrado(Grado grado)
        {
            this.grado = grado;
            InitializeComponent();
        }

        private ValidatorData ValidateAllFields()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtNombreGrado.Text, ValidatorData.REGEX_DESCRIPCION_GRADO);
            return validator;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields().ShowIfThereAreErrors()) return;
            if (repo.ExistsGrado(txtNombreGrado.Text))
            {
                MessageBox.Show("Ya existe el grado " + this.txtNombreGrado.Text + ".");
                return;
            }
            
            Grado grado = new Grado(
                (int)this.grado.Id,
                Convert.ToInt32(txtComision.Text),
                txtNombreGrado.Text);
            if(repo.UpdateGrado(grado) > 0){
                MessageBox.Show(Messages.OPERACION_EXITOSA);
            }
            else{
                MessageBox.Show(Messages.ERROR_INESPERADO);   
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtComision.Clear();
            txtNombreGrado.Clear();
        }

        private void UpdateGrado_Load(object sender, EventArgs e)
        {
            txtNombreGrado.Text = this.grado.Descripcion;
            txtComision.Text = this.grado.Comision.ToString();
        }


    }
}
