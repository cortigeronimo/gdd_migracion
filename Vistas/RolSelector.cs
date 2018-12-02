using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PalcoNet.Modelo;
using PalcoNet.Repositorios;
using PalcoNet.Config;

namespace PalcoNet.Vistas
{
    public partial class RolSelector : CustomForm
    {
        private List<Rol> roles;

        public RolSelector(List<Rol> loginRoles)
        {
            InitializeComponent();
            this.roles = loginRoles;

        }

        private void RolSelector_Load(object sender, EventArgs e)
        {
            comboBoxRol.DataSource = roles;
            comboBoxRol.ValueMember = "id";
            comboBoxRol.DisplayMember = "nombre";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            UserSession.RolId = (int)comboBoxRol.SelectedValue;
            FormManager.GetInstance().OpenAndClose(new HomeMenu(), this);
        }


    }
}
