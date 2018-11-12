﻿using System;
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
using PalcoNet.Abm_Cliente;


namespace PalcoNet
{
    public partial class Login : CustomForm
    {
        Usuario user = new Usuario();
        RepoUsuario repo = new RepoUsuario();
        

        //public Login() : base()
        //{
            
        //}

        public Login()
        {
            InitializeComponent();
            

        }




        private void btnLogin_Click(object sender, EventArgs e)
        {                  
            if (IsRegistered())
            {
                if (user.CountRoles() > 1)
                    FormManager.getInstance().OpenAndClose(new RolSelector(), this);
                else
                    FormManager.getInstance().OpenAndClose(new CreateCliente(), this);
                    //MessageBox.Show("Abrir el menu de funcionalidades....");
                    //por el momento message box, la idea es abrir directamnte el menu de funcionalidades, abm..etc..
                  
                //FormManager.getInstance().open(new Menu());

                //FormManager.getInstance().OpenAndClose(new UserHome(), this);
            }
            else
            {
                ClearTextBox();

                user.ClearRolesList();
                user.username = "";
                user.SetPassword("");
            }
            
        }


        private Boolean IsRegistered()
        {
            //Usuario user = new Usuario();
            //RepoUsuario repo = new RepoUsuario();

            user.username = txtUsername.Text;
            user.SetPassword(txtPassword.Text);
            user.isAdmin = false;

            if (repo.ExistsUser(user))
            {
                if (repo.EnabledUser(user))
                {
                    if (repo.ValidPassword(user))
                    {
                        MessageBox.Show("Login Correcto");
                        if (!user.isAdmin)
                            repo.CleanFailedAttemps(user);
                        return true;
                    }
                    else
                    {           
                        if(!user.isAdmin)
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
