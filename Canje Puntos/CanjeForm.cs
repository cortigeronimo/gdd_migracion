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
using PalcoNet.Vistas;
using PalcoNet.Utils;

namespace PalcoNet.Canje_Puntos
{
    public partial class CanjeForm : CustomForm
    {
        private int puntosClientes;
        private RepoPuntos repoPuntos = new RepoPuntos();
        private RepoCanjePuntos repoCanjePuntos = new RepoCanjePuntos();
        private RepoCliente repoCliente = new RepoCliente();

        public CanjeForm()
        {
            InitializeComponent();
            puntosClientes = repoPuntos.GetPuntosClienteById(UserSession.UserId);
            this.txtPuntosDisponibles.Text = puntosClientes.ToString();
            this.btnComprar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusquedaPuntos.Value = 0;
            this.listBoxPremios.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Premio> premios = repoCanjePuntos.GetPremiosBy(txtBusquedaPuntos.Text);
            premios.Sort((p1, p2) => p1.puntos.CompareTo(p2.puntos));
            listBoxPremios.DataSource = premios;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Premio selectedPremio = (Premio)listBoxPremios.SelectedItem;
            if (selectedPremio != null && selectedPremio.puntos <= puntosClientes)
            {
                try
                {
                    repoCanjePuntos.ChangePointsToPremio(UserSession.UserId, selectedPremio.id);
                    puntosClientes -= selectedPremio.puntos;
                    txtPuntosDisponibles.Text = puntosClientes.ToString();
                    MessageBox.Show("Puntos canjeados correctamente.");
                }
                catch(Exception){
                    MessageBox.Show(Messages.ERROR_INESPERADO);
                }
                 
            }
            else
            {
                MessageBox.Show("No le alcanzan los puntos para comprar el premio que eligió");
            }
        }

        private void listBoxPremios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnComprar.Enabled = (listBoxPremios.SelectedItem != null) ? true : false;
        }
    }
}
