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

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class AltaEmpresa : Form
    {
        public AltaEmpresa()
        {
            InitializeComponent();
        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxRazonSocial.Clear();
            txtBoxMail1.Clear();
            txtBoxMail2.Clear();
            txtBoxTelefono.Clear();
            txtBoxCalle.Clear();
            txtBoxPiso.Clear();
            txtBoxDepto.Clear();
            txtBoxLocalidad.Clear();
            txtBoxCodPostal.Clear();
            txtBoxCiudad.Clear();
            txtBoxCuit1.Clear();
            txtBoxCuit2.Clear();
            txtBoxCuit3.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtBoxRazonSocial.Text == "" || txtBoxMail1.Text == "" || txtBoxMail2.Text == "" || txtBoxTelefono.Text == "" || txtBoxCalle.Text == "" ||
                txtBoxLocalidad.Text == "" || txtBoxCodPostal.Text == "" || txtBoxCiudad.Text == "" || txtBoxCuit1.Text == "" || txtBoxCuit2.Text == "" ||
                txtBoxCuit3.Text == "")
            {
                MessageBox.Show("Falta completar campos.");
                return;
            }

            var repoEmpresa = new RepoEmpresa();
            string cuit = txtBoxCuit1 + "-" + txtBoxCuit2 + "-" + txtBoxCuit3;
            //if (repoEmpresa.RepiteCUIT(cuit))
            //{
            //    MessageBox.Show("Ya existe una empresa con ese CUIT");
            //    return;
            //}
            //if (repoEmpresa.RepiteRazonSocial(txtBoxRazonSocial.Text))
            //{
            //    MessageBox.Show("Ya existe una empresa con esa Razón Social");
            //    return;
            //}

            //COMENTO PARA QUE NO ROMPA....


        }
    }
}
