using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Vistas
{
    public partial class Home : CustomForm
    {

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.InitializeComponent();
        }
    }
}
