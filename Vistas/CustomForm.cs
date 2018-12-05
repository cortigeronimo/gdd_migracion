using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PalcoNet.Vistas
{
    public class CustomForm : Form
    {
        protected List<Form> formularios = new List<Form>();
        private bool killChildForms = true;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (killChildForms)
            {
                foreach (Form form in formularios)
                {
                    FormManager.GetInstance().CloseForm(form);
                }
            }
            FormManager.GetInstance().CloseForm(this);
        }

        protected void Open(Form form)
        {
            formularios.Add(form);
            FormManager.GetInstance().Open(form);
        }

        protected void OpenAndClose(Form form)
        {
            killChildForms = false;
            FormManager.GetInstance().OpenAndClose(form, this);
        }
    }
}
