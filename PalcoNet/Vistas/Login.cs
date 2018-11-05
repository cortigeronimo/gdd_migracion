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
using PalcoNet.Repositorios;


namespace PalcoNet
{
    public partial class Login : CustomForm
    {

        Usuario user = new Usuario();

        public Login() : base()
        {
            
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {                  
            if (IsRegistered())
            {                  
                //FormManager.getInstance().open(new Menu());

                FormManager.getInstance().OpenAndClose(new UserHome(), this);
            }
            else
            {
                ClearTextBox();
            }
            
        }

        private Boolean IsRegistered()
        {
            Usuario user = new Usuario();
            RepoUsuario repo = new RepoUsuario();

            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.IsAdmin = false;

            if (repo.ExistsUser(user))
            {
                if (repo.EnabledUser(user))
                {
                    if (repo.ValidPassword(user))
                    {
                        MessageBox.Show("Login Correcto");
                        return true;
                    }
                    else
                    {           
                        if(!user.IsAdmin)
                            repo.AddFailedAttempt(user);
                        MessageBox.Show("Username y/o Password Incorrecto");
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Usuario Inhabilitado");
                    return false;
                }
            }
            else
            {          
                MessageBox.Show("Usuario inexistente");
                return false;
            }

        }


        private void CheckTextBox()
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }


        private void ClearTextBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

    }
}
