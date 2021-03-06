﻿using System;
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
using PalcoNet.Vistas;

namespace PalcoNet.Historial_Cliente
{
    public partial class HistorialCliente : CustomForm
    {
        private Page<DetalleCompra> page;
        private const int sizePage = 10;
        private RepoCompra repoCompra = new RepoCompra();

        public HistorialCliente()
        {
            InitializeComponent();
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            this.dataGridHistorialCliente.AllowUserToResizeColumns = false;
            this.dataGridHistorialCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorialCliente.RowHeadersVisible = false;
            this.dataGridHistorialCliente.MultiSelect = false;
            this.dataGridHistorialCliente.RowHeadersVisible = false;
            this.dataGridHistorialCliente.AutoGenerateColumns = false;

            InitPagination();

            LoadDataGridViewCompras();  

        }

        private void InitPagination()
        {
            List<DetalleCompra> compras = repoCompra.GetComprasUsuario(UserSession.UserId);

            int totalCompras = compras.Count;
            decimal totalPage = Math.Ceiling((decimal)totalCompras / sizePage);

            if (totalPage == 0) totalPage = 1;

            txtActualPage.Text = "1";
            txtTotalPage.Text = totalPage.ToString();


            page = new Page<DetalleCompra>((int)totalPage, 1, compras, sizePage);
        }

        private void LoadDataGridViewCompras()
        {
            dataGridHistorialCliente.Rows.Clear();

            List<DetalleCompra> comprasPage = page.GetDataPage();
            BindingSource binding = new BindingSource(comprasPage, null);
            dataGridHistorialCliente.DataSource = binding;
            /*foreach (DetalleCompra compra in comprasPage)
            {
                dataGridHistorialCliente.Rows.Add(compra.fechaCompra, compra.precio, compra.metodoDePago, compra.descripcionUbicacion, compra.fila, compra.asiento, compra.fechaEvento, compra.descripcionPublicacion);
            }*/
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
