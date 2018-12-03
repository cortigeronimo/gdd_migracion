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
using PalcoNet.Utils;

namespace PalcoNet.Abm_Grado
{
    public partial class CreateGrado : CustomForm
    {
        public CreateGrado()
        {
            InitializeComponent();
        }

        private ValidatorData ValidateAllFields()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtNombreGrado.Text, ValidatorData.REGEX_DESCRIPCION_GRADO);
            validator.ValidateTextWithRegex(txtComision.Text, ValidatorData.REGEX_COMISION);
            return validator;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields().ShowIfThereAreErrors()) return;
            RepoGradoPublicacion repo = new RepoGradoPublicacion();
            Grado grado = new Grado(
                (int)Convert.ToInt32(txtComision.Text),
                txtNombreGrado.Text);
            try
            {
                repo.InsertGrado(grado);
                MessageBox.Show(Messages.OPERACION_EXITOSA);
            }
            catch {
                MessageBox.Show(Messages.ERROR_INESPERADO);
            }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtComision.Clear();
            txtNombreGrado.Clear();
        }

    }
}
