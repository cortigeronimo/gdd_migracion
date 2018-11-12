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
using PalcoNet.Abm_Grado;
<<<<<<< HEAD
using PalcoNet.Abm_Rol;
=======
using PalcoNet.Registro_de_Usuario;
>>>>>>> 496d760215dc286e030a031e26985c104a37e7ec

namespace PalcoNet
{
    public partial class FormManager : Form
    {
        private List<Form> windows;
        private static FormManager principal;

        private FormManager()
        {
            InitializeComponent();
            windows = new List<Form>();

        }

        public void CloseForm(Form form)
        {
            windows.Remove(form);
            if(windows.Count < 1){
                Application.Exit();
            }
        }

        public static FormManager getInstance(){
            if(principal == null){
                principal = new FormManager();
            }
            return principal;
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            Hide();
            Open(new Login());
<<<<<<< HEAD
            //Open(new CreateGrado());
            //Open(new UpdateGrado());
            Open(new ListGrado());
            Open(new ListadoRol());
=======
            //Open(new CreateUsuario());
>>>>>>> 496d760215dc286e030a031e26985c104a37e7ec
        }

        public void Open(Form form)
        {
            windows.Add(form);
            form.Show();
        }

        private void Close(Form form) {
            windows.Remove(form);
            form.Close();
            if(windows.Count < 1){
                Application.Exit();
            }
        }

        public void OpenAndClose(Form formToOpen, Form formToClose)
        {
            Open(formToOpen);
            Close(formToClose);
           
        }
    }
}
