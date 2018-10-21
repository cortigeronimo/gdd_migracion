using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PalcoNet
{
    public partial class Login : Form
    {
        Usuario user = new Usuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        void verificarLogin()
        {
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;




        }
    }
}
