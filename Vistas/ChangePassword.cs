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
using PalcoNet.Utils;

namespace PalcoNet.Vistas
{
    public partial class FormChangePassword : CustomForm
    {

        RepoUsuario repoUsuario = new RepoUsuario();
        String password;
        Boolean firstLogin = false;

        public FormChangePassword()
        {
            InitializeComponent();
        }

        public FormChangePassword(Boolean firstLogin)
        {
            InitializeComponent();
            this.firstLogin = firstLogin;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!CheckPasswords())
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Error");
                return;   
            }
     
            password = txtConfirmarPassword.Text;

            try
            {
                ChangePassword();
                MessageBox.Show("Contraseña actualizada.", "Message");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.ERROR_INESPERADO, "Error");
            }            
        }

        private void ChangePassword()
        {
            if (firstLogin)
                repoUsuario.ChangePasswordFirstLogin(password);            
            else
                repoUsuario.ChangePassword(password);                 
        }



        private Boolean CheckPasswords()
        {
            return txtPassword.Text == txtConfirmarPassword.Text;
        }

        
        private void TxtBoxes_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty && txtConfirmarPassword.Text != string.Empty)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }


    }
}
