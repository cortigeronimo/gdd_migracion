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

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class ComprasDePublicacionAFacturar : Form
    {
        RepoPublicacion repoPublicacion = new RepoPublicacion();

        RepoCompra repoCompra = new RepoCompra();

        List<DetalleCompra> compras = new List<DetalleCompra>();

        public ComprasDePublicacionAFacturar(decimal id)
        {
            InitializeComponent();
            dataGridCompras.RowHeadersVisible = false;
            dataGridCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Publicacion publicacion = repoPublicacion.FindById(id);
            lblTituloPublicacion.Text = "#" + publicacion.Codigo + ": " + publicacion.Descripcion;
            compras = repoCompra.FindComprasToCheckIn(publicacion.Codigo);
            dataGridCompras.DataSource = new BindingSource(compras, String.Empty);
            this.numCantidadARendir.Minimum = 1;
            this.numCantidadARendir.Maximum = compras.Count;
        }

        private void btnRendir_Click(object sender, EventArgs e)
        {
            
        }

    }
}
