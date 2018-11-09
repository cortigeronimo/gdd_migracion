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
    public partial class ListGrado : CustomForm
    {
        public ListGrado()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreGrado.Text = "";
            numComisionGrado.Value = 0;
        }

    }
}

