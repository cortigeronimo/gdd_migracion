using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class ModificarEmpresa : Form
    {
        public ModificarEmpresa()
        {
            InitializeComponent();
        }

        private void ModificarEmpresa_Load(object sender, EventArgs e)
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

        }
    }
}
