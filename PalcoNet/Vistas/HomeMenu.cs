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
using PalcoNet.Abm_Grado;
using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Rol;
using PalcoNet.Abm_Rubro;
using PalcoNet.Comprar;
using PalcoNet.Editar_Publicacion;
using PalcoNet.Generar_Publicacion;
using PalcoNet.Canje_Puntos;
using PalcoNet.Generar_Rendicion_Comisiones;
using PalcoNet.Historial_Cliente;
using PalcoNet.Listado_Estadistico;
using PalcoNet.Registro_de_Usuario;

using PalcoNet.Config;

namespace PalcoNet.Vistas
{
    public partial class HomeMenu : CustomForm
    {
        private RepoRol repo = new RepoRol();
        private RepoUsuario repoUsuario = new RepoUsuario();

        private Usuario user = new Usuario();
        private Rol rol = new Rol();


        public HomeMenu()
        {
            InitializeComponent();

            this.user.id = (int)UserSession.UserId;
            this.rol.id = (int)UserSession.RolId;
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private Boolean FirstLogin()
        {
            return repoUsuario.FirstLogin(UserSession.UserId, UserSession.RolId);
        }


        private void HomeMenu_Load(object sender, EventArgs e)
        {
            LoadFuncionalidades();

            if (FirstLogin())
            {
                using (FormChangePassword form = new FormChangePassword())
                {
                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        form.Close();
                    }
                }
            }
            

        }


        private void LoadFuncionalidades()
        {
            DataTable tableFuncionalidad = repo.GetFuncionalidades(this.rol);

            foreach (DataRow row in tableFuncionalidad.Rows)
            {
                
                String idFuncionalidad = row[0].ToString();
                String funcionalidad = row[1].ToString();

                if (funcionalidad != "REGISTRO_USUARIO")
                {
                    funcionalidad = funcionalidad.Replace('_', ' ');

                    ToolStripMenuItem itemFuncionalidad = new ToolStripMenuItem();
                    itemFuncionalidad.Text = funcionalidad;
                    itemFuncionalidad.Name = idFuncionalidad;

                    menúToolStripMenuItem.DropDownItems.Add(itemFuncionalidad);

                    AddSubItems(itemFuncionalidad);

                    AddClickEventsItems(itemFuncionalidad);
                }

            }

        }

        private void CreateAndAddSubItem(Dictionary<String, String> dictionary, ToolStripMenuItem itemFuncionalidad) 
        {
            foreach (KeyValuePair<String, String> entry in dictionary)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = entry.Key;
                item.Name = entry.Value;
                itemFuncionalidad.DropDownItems.Add(item);
            }
        }
        

        private void AddSubItems(ToolStripMenuItem itemFuncionalidad)
        {
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            switch (itemFuncionalidad.Text)
            {
                case "ABM ROL":
                    dictionary.Add("Crear Rol", "crearRol");
                    dictionary.Add("Consultar Roles", "listarRoles");
                    CreateAndAddSubItem(dictionary, itemFuncionalidad);
                    break;

                case "ABM CLIENTE":
                    dictionary.Add("Crear Cliente", "crearCliente");
                    dictionary.Add("Consultar Clientes", "listarClientes");
                    CreateAndAddSubItem(dictionary, itemFuncionalidad);
                    break;

                case "ABM EMPRESA ESPECTACULO":
                    dictionary.Add("Crear Empresa", "crearEmpresa");
                    dictionary.Add("Consultar Empresas", "listarEmpresas");
                    CreateAndAddSubItem(dictionary, itemFuncionalidad);
                    break;

                case "ABM GRADO PUBLICACION":
                    dictionary.Add("Crear Grado", "crearGrado");
                    dictionary.Add("Consultar Grados", "listarGrados");
                    CreateAndAddSubItem(dictionary, itemFuncionalidad);
                    break;

                case "CANJE ADMINISTRACION PUNTOS":
                    dictionary.Add("Canjear Puntos", "canjearPuntos");
                    dictionary.Add("Ver Premios", "verPremios");
                    CreateAndAddSubItem(dictionary, itemFuncionalidad);
                    break;

                default:
                    break;
            }


        }

        private void AddClickEventsItems(ToolStripMenuItem itemFuncionalidad)
        {
            switch (itemFuncionalidad.Text)
            {
                case "ABM ROL":
                    itemFuncionalidad.DropDownItems["crearRol"].Click += new EventHandler(crearRol_Click);
                    itemFuncionalidad.DropDownItems["listarRoles"].Click += new EventHandler(listarRoles_Click);
                    break;
                case "ABM CLIENTE":
                    itemFuncionalidad.DropDownItems["crearCliente"].Click += new EventHandler(crearCliente_Click);
                    itemFuncionalidad.DropDownItems["listarClientes"].Click += new EventHandler(listarClientes_Click);
                    break;
                case "ABM EMPRESA ESPECTACULO":
                    itemFuncionalidad.DropDownItems["crearEmpresa"].Click += new EventHandler(crearEmpresa_Click);
                    itemFuncionalidad.DropDownItems["listarEmpresas"].Click += new EventHandler(listarEmpresas_Click);
                    break;
                case "ABM GRADO PUBLICACION":
                    itemFuncionalidad.DropDownItems["crearGrado"].Click += new EventHandler(crearGrado_Click);
                    itemFuncionalidad.DropDownItems["listarGrados"].Click += new EventHandler(listarGrados_Click);
                    break;
                case "GENERAR PUBLICACION":
                    itemFuncionalidad.Click += new EventHandler(generarPublicacion_Click);
                    break;
                case "EDITAR PUBLICACION":
                    itemFuncionalidad.Click += new EventHandler(editarPublicacion_Click);
                    break;
                case "COMPRAR":
                    itemFuncionalidad.Click += new EventHandler(comprar_Click);
                    break;
                case "HISTORIAL CLIENTE":
                    itemFuncionalidad.Click += new EventHandler(historialCliente_Click);
                    break;
                case "CANJE ADMINISTRACION PUNTOS":
                    itemFuncionalidad.Click += new EventHandler(canjeAdministracionPuntos_Click);
                    itemFuncionalidad.DropDownItems["canjearPuntos"].Click += new EventHandler(canjearPuntos_Click);
                    itemFuncionalidad.DropDownItems["verPremios"].Click += new EventHandler(verPremios_Click);
                    break;
                case "GENERAR PAGOS COMISIONES":
                    itemFuncionalidad.Click += new EventHandler(generarPagosComisiones_Click);
                    break;
                case "LISTADO ESTADISTICO":
                    itemFuncionalidad.Click += new EventHandler(listadoEstadistico_Click);
                    break;
                default:
                    break;
            }
        }


        //Eventos para el menu de ABM Grado
        private void crearGrado_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new CreateGrado());
        }

        private void listarGrados_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new ListGrado());
        }


        //Eventos para el menu de ABM Empresa
        private void crearEmpresa_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new CreateEmpresa(), this);
            MessageBox.Show("soy el form crear empresa");
        }

        private void listarEmpresas_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new ListEmpresa(), this);
            MessageBox.Show("soy el form listar empresa");
        }


        //Eventos para el menu de ABM Cliente
        private void crearCliente_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new CreateCliente());       
        }

        private void listarClientes_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new ListCliente());
        }


        //Eventos para el menu de ABM Rol
        private void crearRol_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new AltaRol());
        }

        private void listarRoles_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new ListadoRol());
        }
       

        //Evento click para "generar publicacion"
        private void generarPublicacion_Click(object sender, EventArgs e)
        {
            //abrir el form de "generar publicacion"
            FormManager.getInstance().Open(new FormGenerarPublicacion());
        }


        //Evento click para "editar publicacion"
        private void editarPublicacion_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new FormEditarPublicacion());
        }


        //Evento click para "comprar"
        private void comprar_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new FormComprar());
        }


        //Evento click para "historial cliente"
        private void historialCliente_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new HistorialCliente());
        }


        //Evento click para "canje administracion puntos"
        private void canjeAdministracionPuntos_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new CanjeForm());
        }


        //Evento click para "generar comisiones"
        private void generarPagosComisiones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soy el form comisiones..");
        }


        //Evento click para "listado estadistico"
        private void listadoEstadistico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soy el form de lsitado estadistico");
        }

        private void verPremios_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new ViewPremios());
        }

        private void canjearPuntos_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().Open(new CanjeForm());
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormChangePassword form = new FormChangePassword())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    form.Close();
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().OpenAndClose(new Login(), this);
        }

        
    }
}
