using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PalcoNet.Utils;

namespace PalcoNet.Vistas
{
    partial class Home
    {
        private Button btnHolaMundo;
        private Label lblHolaMundo;
        private TextBox txtHolaMundo;

        private void InitializeElements()
        {
            btnHolaMundo = this.DefaultButton();
            btnHolaMundo.Click += new EventHandler(this.btnHolaMundo_Click);
            btnHolaMundo.Location = ElementManager.CenterPosition(new Point(60, 60), btnHolaMundo.Width, btnHolaMundo.Height);
            lblHolaMundo = this.DefaultLabel();
            txtHolaMundo = this.DefaultTextBox();
            Controls.Add(this.btnHolaMundo);
            Controls.Add(this.lblHolaMundo);
            Controls.Add(this.txtHolaMundo);
        }

        private void btnHolaMundo_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().OpenAndClose(new Home(), this);
        }
    }
}
