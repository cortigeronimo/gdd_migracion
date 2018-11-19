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

namespace PalcoNet.Canje_Puntos
{
    public partial class CanjeForm : Form
    {
        

        public CanjeForm()
        {
            //puntos harcodeados
            InitializeComponent();
            this.txtPuntosDisponibles.Text = "605";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtDescripcion.Clear();
            this.txtPuntosDisponibles.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
