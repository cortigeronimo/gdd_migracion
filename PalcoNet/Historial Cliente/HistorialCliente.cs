using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Utils;
using PalcoNet.Repositorios;
using PalcoNet.Modelo;
using PalcoNet.Config;

namespace PalcoNet.Historial_Cliente
{
    public partial class HistorialCliente : Form
    {
        private Page page;
        private RepoCompra repoCompra = new RepoCompra();

        public HistorialCliente()
        {
            InitializeComponent();
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            this.dataGridHistorialCliente.AllowUserToResizeColumns = false;
            this.dataGridHistorialCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorialCliente.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridHistorialCliente.MultiSelect = false;
            this.dataGridHistorialCliente.RowHeadersVisible = false;
            this.dataGridHistorialCliente.AutoGenerateColumns = false;

            InitPagination();

            LoadDataGridViewCompras();  

        }

        private void InitPagination()
        {
            List<DetalleCompra> compras = repoCompra.GetComprasUsuario(LoggedInUser.ID);

            int totalCompras = compras.Count;
            decimal totalPage = Math.Ceiling((decimal)totalCompras / 10);

            txtActualPage.Text = "1";
            txtTotalPage.Text = totalPage.ToString();


            page = new Page((int)totalPage, 1, compras);
        }

        private void LoadDataGridViewCompras()
        {
            dataGridHistorialCliente.Rows.Clear();

            List<DetalleCompra> comprasPage = page.GetComprasPage();
            foreach (DetalleCompra compra in comprasPage)
            {
                dataGridHistorialCliente.Rows.Add(compra.fechaCompra, compra.precio, compra.metodoDePago, compra.descripcionUbicacion, compra.fila, compra.asiento, compra.fechaEvento, compra.descripcionPublicacion);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            txtActualPage.Text = page.nextPage().ToString();

            LoadDataGridViewCompras();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtActualPage.Text = page.backPage().ToString();

            LoadDataGridViewCompras();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            page.ActualPage = 1;
            txtActualPage.Text = page.ActualPage.ToString();

            LoadDataGridViewCompras();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            page.ActualPage = page.TotalPage;
            txtActualPage.Text = page.ActualPage.ToString();

            LoadDataGridViewCompras();
        }

    }
}
