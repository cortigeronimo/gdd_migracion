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

namespace PalcoNet.Vistas
{
    public partial class FormChangePassword : CustomForm
    {

        RepoUsuario repoUsuario = new RepoUsuario();

        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CheckPasswords())
            {
                String password = txtConfirmarPassword.Text;
                repoUsuario.ChangePassword(password);
                MessageBox.Show("Contraseña actualizada.");

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error, las contraseñas ingresadas no coinciden");
            }
        }

        private Boolean CheckPasswords()
        {
            return txtPassword.Text == txtConfirmarPassword.Text;
        }

        private void CheckTextBox()
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void txtConfirmarPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }


    }
}
