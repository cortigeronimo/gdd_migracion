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
using PalcoNet.Modelo;
using PalcoNet.Registro_de_Usuario;
using PalcoNet.Config;
using PalcoNet.Utils;

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

        private ValidatorData ValidateAllFields()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtUsername.Text, ValidatorData.REGEX_USUARIO);
            validator.ValidateTextWithRegex(txtPassword.Text, ValidatorData.REGEX_PASSWORD);
            return validator;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {      
            if (ValidateAllFields().ShowIfThereAreErrors())
            {
                user = new Usuario();
                return;
            }

            if (IsRegistered())
            {
                UserSession.UserId = user.id;
                UserSession.Username = user.username;
                UserSession.IsAdmin = user.isAdmin;

                if (user.CountRoles() > 1)
                {
                    FormManager.GetInstance().OpenAndClose(new RolSelector(user.GetRoles()), this);
                }
                else
                {
                    Rol rol = new Rol();
                    TakeRolFromUser(rol);
                    UserSession.RolId = rol.id;
                    FormManager.GetInstance().OpenAndClose(new HomeMenu(), this);
                }
            }
            else
            {
                user = new Usuario();
            }
            
        }


        private Boolean IsRegistered()
        {
            user.username = txtUsername.Text;
            user.SetPassword(txtPassword.Text);
            user.isAdmin = false;

            if (!repo.ExistsUser(user))
            {
                MessageBox.Show("Usuario Inexistente.", "Error");
                return false;
            }

            if (repo.GetRolesUsuario(user).Count == 0)
            {
                MessageBox.Show("No tiene roles asignados para ingresar al sistema.\nContáctese con el ADMINISTRADOR.", "Error");
                return false;
            }

            if (!repo.EnabledUser(user))
            {
                MessageBox.Show("Usuario Inhabilitado.", "Error");
                return false;
            }

            if (repo.ValidPassword(user))
            {
                if (!user.isAdmin)
                    repo.CleanFailedAttemps(user);
                return true;
            }
            else
            {
                if (!user.isAdmin)
                    repo.AddFailedAttempt(user);
                MessageBox.Show("Username y/o Password Incorrecto.", "Error");
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

        private void TakeRolFromUser(Rol rol)
        {
            if (user.isAdmin)
            {
                rol.id = user.GetRoles()[0].id;
                rol.nombre = user.GetRoles()[0].nombre;
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
            FormManager.GetInstance().Open(new CreateUsuario());
        }

    }
}
