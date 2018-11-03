using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Vistas;


namespace PalcoNet
{
    public partial class Login : CustomForm
    {
        Usuario user = new Usuario();

        public Login()
        {
            InitializeComponent();
            //el login se encarga de ocultar al manager porque sino
            //hay que hacer algo rebuscado
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsRegistered())
            {
                FormManager.getInstance().OpenAndClose(new Home(), this);
                //FormManager.getInstance().open(new Menu());
            }
            
        }

        private Boolean IsRegistered()
        {
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            //esta hardcodeado para que podamos entrar directamente
            return true;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
