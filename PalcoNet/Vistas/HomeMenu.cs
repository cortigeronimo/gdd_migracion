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
using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.Abm_Rol;
using PalcoNet.Abm_Rubro;
using PalcoNet.Comprar;
using PalcoNet.Editar_Publicacion;
using PalcoNet.Generar_Publicacion;
using PalcoNet.Canje_Puntos;
using PalcoNet.Generar_Rendicion_Comisiones;
using PalcoNet.Historial_Cliente;
using PalcoNet.Listado_Estadistico;


namespace PalcoNet.Vistas
{
    public partial class HomeMenu : CustomForm
    {
        RepoRol repo = new RepoRol();

        public HomeMenu(Usuario _user, Rol _rol)
        {
            InitializeComponent(_user, _rol);
            
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            LoadFuncionalidades();
        }


        private void LoadFuncionalidades()
        {
            DataTable tableFuncionalidad = repo.GetFuncionalidades(this.rol);

            int i = 0;
            while (tableFuncionalidad.Rows.Count > i)
            {
                String idFuncionalidad = tableFuncionalidad.Rows[i][0].ToString();
                String funcionalidad = tableFuncionalidad.Rows[i][1].ToString();
                funcionalidad = funcionalidad.Replace('_', ' ');

                ToolStripMenuItem itemFuncionalidad = new ToolStripMenuItem();
                itemFuncionalidad.Text = funcionalidad;
                itemFuncionalidad.Name = idFuncionalidad;

                menúToolStripMenuItem.DropDownItems.Add(itemFuncionalidad);

                AddSubItems(itemFuncionalidad);

                AddClickEventsItems(itemFuncionalidad);

                i++;

            }

        }

        

        private void AddSubItems(ToolStripMenuItem itemFuncionalidad)
        {
            switch (itemFuncionalidad.Text)
            {
                case "ABM ROL":
                    ToolStripMenuItem itemCrearRol = new ToolStripMenuItem();
                    itemCrearRol.Text = "Crear Rol";
                    itemCrearRol.Name = "crearRol";
                    ToolStripMenuItem itemListarRoles = new ToolStripMenuItem();
                    itemListarRoles.Text = "Listar Roles";
                    itemListarRoles.Name = "listarRoles";
                    ToolStripMenuItem itemActualizarRol = new ToolStripMenuItem();
                    itemActualizarRol.Text = "Actualizar Rol";
                    itemActualizarRol.Name = "actualizarRol";

                    itemFuncionalidad.DropDownItems.Add(itemCrearRol);
                    itemFuncionalidad.DropDownItems.Add(itemListarRoles);
                    itemFuncionalidad.DropDownItems.Add(itemActualizarRol);

                    break;

                case "ABM CLIENTE":
                    ToolStripMenuItem itemCrearCliente = new ToolStripMenuItem();
                    itemCrearCliente.Text = "Crear Cliente";
                    itemCrearCliente.Name = "crearCliente";
                    ToolStripMenuItem itemListarClientes = new ToolStripMenuItem();
                    itemListarClientes.Text = "Listar Clientes";
                    itemListarClientes.Name = "listarClientes";
                    ToolStripMenuItem itemActualizarCliente = new ToolStripMenuItem();
                    itemActualizarCliente.Text = "Actualizar Cliente";
                    itemActualizarCliente.Name = "actualizarCliente";

                    itemFuncionalidad.DropDownItems.Add(itemCrearCliente);
                    itemFuncionalidad.DropDownItems.Add(itemListarClientes);
                    itemFuncionalidad.DropDownItems.Add(itemActualizarCliente);
                    break;

                case "ABM EMPRESA ESPECTACULO":
                    ToolStripMenuItem itemCrearEmpresa = new ToolStripMenuItem();
                    itemCrearEmpresa.Text = "Crear Empresa";
                    itemCrearEmpresa.Name = "crearEmpresa";
                    ToolStripMenuItem itemListarEmpresas = new ToolStripMenuItem();
                    itemListarEmpresas.Text = "Listar Empresas";
                    itemListarEmpresas.Name = "listarEmpresas";
                    ToolStripMenuItem itemActualizarEmpresa = new ToolStripMenuItem();
                    itemActualizarEmpresa.Text = "Actualizar Empresa";
                    itemActualizarEmpresa.Name = "actualizarEmpresa";

                    itemFuncionalidad.DropDownItems.Add(itemCrearEmpresa);
                    itemFuncionalidad.DropDownItems.Add(itemListarEmpresas);
                    itemFuncionalidad.DropDownItems.Add(itemActualizarEmpresa);
                    break;

                case "ABM GRADO PUBLICACION":
                    ToolStripMenuItem itemCrearGrado = new ToolStripMenuItem();
                    itemCrearGrado.Text = "Crear Grado";
                    itemCrearGrado.Name = "crearGrado";
                    ToolStripMenuItem itemListarGrados = new ToolStripMenuItem();
                    itemListarGrados.Text = "Listar Grados";
                    itemListarGrados.Name = "listarGrados";
                    ToolStripMenuItem itemActualizarGrado = new ToolStripMenuItem();
                    itemActualizarGrado.Text = "Actualizar Grado";
                    itemActualizarGrado.Name = "actualizarGrado";

                    itemFuncionalidad.DropDownItems.Add(itemCrearGrado);
                    itemFuncionalidad.DropDownItems.Add(itemListarGrados);
                    itemFuncionalidad.DropDownItems.Add(itemActualizarGrado);
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
                    itemFuncionalidad.DropDownItems["actualizarRol"].Click += new EventHandler(actualizarRol_Click);
                    break;
                case "ABM CLIENTE":
                    itemFuncionalidad.DropDownItems["crearCliente"].Click += new EventHandler(crearCliente_Click);
                    itemFuncionalidad.DropDownItems["listarClientes"].Click += new EventHandler(listarClientes_Click);
                    itemFuncionalidad.DropDownItems["actualizarCliente"].Click += new EventHandler(actualizarCliente_Click);
                    break;
                case "ABM EMPRESA ESPECTACULO":
                    itemFuncionalidad.DropDownItems["crearEmpresa"].Click += new EventHandler(crearEmpresa_Click);
                    itemFuncionalidad.DropDownItems["listarEmpresas"].Click += new EventHandler(listarEmpresas_Click);
                    itemFuncionalidad.DropDownItems["actualizarEmpresa"].Click += new EventHandler(actualizarEmpresa_Click);
                    break;
                case "ABM GRADO PUBLICACION":
                    itemFuncionalidad.DropDownItems["crearGrado"].Click += new EventHandler(crearGrado_Click);
                    itemFuncionalidad.DropDownItems["listarGrados"].Click += new EventHandler(listarGrados_Click);
                    itemFuncionalidad.DropDownItems["actualizarGrado"].Click += new EventHandler(actualizarGrado_Click);
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
            FormManager.getInstance().OpenAndClose(new CreateGrado(), this);
        }

        private void listarGrados_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().OpenAndClose(new ListGrado(), this);
        }

        private void actualizarGrado_Click(object sender, EventArgs e)
        {
            FormManager.getInstance().OpenAndClose(new UpdateGrado(), this);
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

        private void actualizarEmpresa_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new UpdateEmpresa(), this);
            MessageBox.Show("soy el form actualizar empresa");
        }


        //Eventos para el menu de ABM Cliente
        private void crearCliente_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new CreateCliente(), this);
            MessageBox.Show("soy el form crear cliente");
        }

        private void listarClientes_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new ListClientes(), this);
            MessageBox.Show("soy el form listar clientes");
        }

        private void actualizarCliente_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new UpdateCliente(), this);
            MessageBox.Show("soy el form actualizar cliente");
        }


        //Eventos para el menu de ABM Rol
        private void crearRol_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new CreateRol(), this);
            MessageBox.Show("soy el form crear rol");
        }

        private void listarRoles_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new ListRoles(), this);
            MessageBox.Show("soy el form listar roles");
        }

        private void actualizarRol_Click(object sender, EventArgs e)
        {
            //FormManager.getInstance().OpenAndClose(new UpdateRol(), this);
            MessageBox.Show("soy el form actualizar rol");
        }
       

        //Evento click para "generar publicacion"
        private void generarPublicacion_Click(object sender, EventArgs e)
        {
            //abrir el form de "generar publicacion"
            MessageBox.Show("soy el form generar publkicacion");
        }


        //Evento click para "editar publicacion"
        private void editarPublicacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soy el form editar publicacion...");
        }


        //Evento click para "comprar"
        private void comprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soy el form comprar");
        }


        //Evento click para "historial cliente"
        private void historialCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soy el form historial de cliente");
        }


        //Evento click para "canje administracion puntos"
        private void canjeAdministracionPuntos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soy el form canje de ptos..");
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

        
    }
}
