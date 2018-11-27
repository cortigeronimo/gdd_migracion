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
using PalcoNet.Config;

namespace PalcoNet.Canje_Puntos
{
    public partial class ViewPremios : Form
    {
        RepoPremio repoPremio = new RepoPremio();

        public ViewPremios()
        {
            InitializeComponent();
            btnActualizar_Click(null, null);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = repoPremio.GetPremios(UserSession.UserId);
        }

        private void ViewPremios_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowHeadersVisible = false;
        }
    }
}
