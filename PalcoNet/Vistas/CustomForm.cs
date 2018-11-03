using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Vistas
{
    public class CustomForm : Form
    {
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            FormManager.getInstance().CloseForm(this);
        }
    }
}
