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
using PalcoNet.Utils;

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            roles = repoRol.FindAllRolesOnlyEnable();
            int i = 0;
            foreach(Rol rol in roles){
                comboBoxRol.Items.Insert(i, rol.nombre);
                i++;
            }
        }

        private ValidatorData ValidateAllFields()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtUsuario.Text, ValidatorData.REGEX_USUARIO);
            validator.ValidateTextWithRegex(txtPassword.Text, ValidatorData.REGEX_PASSWORD);
            return validator;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (ValidateAllFields().ShowIfThereAreErrors()) return;
            if (comboBoxRol.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol", "Error");
                return;
            }
            Form formToRedirect;
            Usuario usuario = new Usuario();
            RepoRol repoRol = new RepoRol();
            Rol rol = roles.Find((x) => x.nombre.Equals((String)comboBoxRol.SelectedItem));
            usuario.username = txtUsuario.Text;
            usuario.SetPassword(txtPassword.Text);
            usuario.AddRol(rol);
            
            if(rol.nombre.Equals("CLIENTE")){
                formToRedirect = new CreateOrUpdateCliente(usuario);
                this.OpenAndClose(formToRedirect);
            }
            else if (rol.nombre.Equals("EMPRESA"))
            {
                formToRedirect = new CreateOrUpdateEmpresa(usuario);
                this.OpenAndClose(formToRedirect);
            }
            else
            {
                MessageBox.Show("Usuario creado.");
                this.CloseThis();
            }
            
        }

    }
}
