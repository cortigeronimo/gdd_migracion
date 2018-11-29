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
using PalcoNet.Abm_Cliente;
using PalcoNet.Modelo;
using PalcoNet.Registro_de_Usuario;
using PalcoNet.Config;


namespace PalcoNet
{
    public partial class Login : CustomForm
    {
        Usuario user = new Usuario();
        RepoUsuario repo = new RepoUsuario();

        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {                  
            if (IsRegistered())
            {
                if (user.CountRoles() > 1)
                {
                    FormManager.getInstance().OpenAndClose(new RolSelector(), this);
                }
                else
                {
                    Rol rol = new Rol();
                    TakeRolFromUser(user, rol);

                    UserSession.UserId = user.id;
                    UserSession.Username = user.username;
                    UserSession.RolId = rol.id;
                    
                    FormManager.getInstance().OpenAndClose(new HomeMenu(), this);
                }
                  
                  
                //FormManager.getInstance().open(new Menu());

                //FormManager.getInstance().OpenAndClose(new UserHome(), this);
            }
            else
            {
                ClearTextBox();

                user.ClearRolesList();
                user.username = "";
                user.SetPassword("");
                user.isAdmin = false;
                user.id = 0;
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


        private void ClearTextBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }


        private void TxtBoxes_TextChanged(object sender, EventArgs e)
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

        private void TakeRolFromUser(Usuario user, Rol rol)
        {
            if (user.isAdmin)
            {
                rol.id = 2;
                rol.nombre = "ADMINISTRATIVO";
            }
            else
            {
                List<Rol> rolList = user.GetRoles();
                rol.nombre = rolList[0].nombre;
                rol.id = rolList[0].id;
                rol.habilitado = rolList[0].habilitado;
            }
            
        }

        private void lblRegistroUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.getInstance().Open(new CreateUsuario());
        }

    }
}
