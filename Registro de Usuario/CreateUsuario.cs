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
        private RepoRol repoRol = new RepoRol();

        private List<Rol> roles = new List<Rol>();

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
            txtUsuario.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            roles = repoRol.FindClienteAndEmpresaRolOnlyEnableEnable();
            int i = 0;
            foreach(Rol rol in roles){
                comboBoxRol.Items.Insert(i, rol.nombre);
                i++;
            }
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
            Rol rol = roles.Find((x) => x.nombre.Equals((String)comboBoxRol.SelectedItem));
            usuario.username = txtUsuario.Text;
            usuario.SetPassword(txtPassword.Text);
            usuario.AddRol(rol);
            
            if(rol.nombre.Equals("CLIENTE")){
                formToRedirect = new CreateOrUpdateCliente(usuario);
            }
            else{
                formToRedirect = new CreateOrUpdateEmpresa(usuario);
            }
            FormManager.GetInstance().OpenAndClose(formToRedirect, this);
        }

    }
}
