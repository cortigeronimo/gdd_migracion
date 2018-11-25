using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Repositorios;
using PalcoNet.Modelo;
using PalcoNet.Config;

namespace PalcoNet.Canje_Puntos
{
    public partial class CanjeForm : Form
    {
        private int puntosClientes;
        private RepoCanjePuntos repoCanjePuntos = new RepoCanjePuntos();
        private RepoCliente repoCliente = new RepoCliente();

        public CanjeForm()
        {
            //puntos harcodeados
            InitializeComponent();
            puntosClientes = repoCliente.GetPuntosClienteById(LoggedInUser.ID);
            this.txtPuntosDisponibles.Text = puntosClientes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtBusquedaPuntos.Clear();
            this.txtPuntosDisponibles.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Premio> premios = repoCanjePuntos.GetPremiosBy(txtBusquedaPuntos.Text);
            listBoxPremios.DataSource = premios;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Premio selectedPremio = (Premio)listBoxPremios.SelectedItem;
            if (selectedPremio != null && selectedPremio.puntos <= puntosClientes)
            {
                
            }
        }
    }
}
