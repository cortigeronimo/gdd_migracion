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
using PalcoNet.Modelo;
using PalcoNet.Repositorios;

namespace PalcoNet.Registro_de_Usuario
{
    public partial class CreateUsuario : CustomForm
    {

        public CreateUsuario()
        {
            InitializeComponent();
        }

        private void AllDataIsCompleted(object sender, EventArgs e)
        { 
            if(String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtPassword.Text) 
                || comboBoxRol.SelectedItem == null){
                    btnSiguiente.Enabled = false;
            }
            else {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            comboBoxRol.Items.Insert(0, "Cliente");
            comboBoxRol.Items.Insert(1, "Empresa");
        }

        private bool validateFields()
        {
            return txtPassword.Text != String.Empty &&
                txtUsuario.Text != String.Empty &&
                comboBoxRol.SelectedItem.ToString() != String.Empty;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!validateFields()) return;
            Form formToRedirect;
            Usuario usuario = new Usuario();
            RepoRol repoRol = new RepoRol();
            Rol rol = repoRol.FindRolByName(comboBoxRol.SelectedItem.ToString());
            usuario.username = txtUsuario.Text;
            usuario.SetPassword(txtPassword.Text);
            usuario.AddRol(rol);
            
            if(((String)comboBoxRol.SelectedItem).Equals("Cliente")){
                formToRedirect = new CreateOrUpdateCliente(usuario);
            }
            else{
                formToRedirect = new CreateOrUpdateEmpresa(usuario);
            }
            FormManager.GetInstance().OpenAndClose(formToRedirect, this);
        }

    }
}
