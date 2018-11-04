using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PalcoNet.Utils;
using System.Windows;
using PalcoNet.Abm_Grado;

namespace PalcoNet.Vistas
{
    partial class UserHome
    {
        private Button btnGradoPublicacion;

        protected override void InitializeElements()
        {
            btnGradoPublicacion = this.DefaultButton();
            btnGradoPublicacion.Click += myButton_Click;

            Controls.Add(btnGradoPublicacion);
        }
        
        private void myButton_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new AbmGrado());
        }

        
    }
}
