﻿namespace PalcoNet.Historial_Cliente
{
    partial class HistorialCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridHistorialCliente = new System.Windows.Forms.DataGridView();
            this.FechaDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodoDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorialCliente = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtActualPage = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorialCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistorialCliente
            // 
            this.dataGridHistorialCliente.AllowUserToAddRows = false;
            this.dataGridHistorialCliente.AllowUserToDeleteRows = false;
            this.dataGridHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorialCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaDeCompra,
            this.Precio,
            this.MetodoDePago,
            this.DescripcionUbicacion,
            this.Fila,
            this.Asiento,
            this.FechaEvento,
            this.DescripcionEvento});
            this.dataGridHistorialCliente.Location = new System.Drawing.Point(25, 43);
            this.dataGridHistorialCliente.Name = "dataGridHistorialCliente";
            this.dataGridHistorialCliente.ReadOnly = true;
            this.dataGridHistorialCliente.Size = new System.Drawing.Size(889, 273);
            this.dataGridHistorialCliente.TabIndex = 1;
            // 
            // FechaDeCompra
            // 
            this.FechaDeCompra.HeaderText = "Fecha de Compra";
            this.FechaDeCompra.Name = "FechaDeCompra";
            this.FechaDeCompra.ReadOnly = true;
            this.FechaDeCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MetodoDePago
            // 
            this.MetodoDePago.HeaderText = "Metodo de Pago";
            this.MetodoDePago.Name = "MetodoDePago";
            this.MetodoDePago.ReadOnly = true;
            this.MetodoDePago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DescripcionUbicacion
            // 
            this.DescripcionUbicacion.HeaderText = "Descripcion Ubicación";
            this.DescripcionUbicacion.Name = "DescripcionUbicacion";
            this.DescripcionUbicacion.ReadOnly = true;
            this.DescripcionUbicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fila
            // 
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            this.Fila.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Asiento
            // 
            this.Asiento.HeaderText = "Asiento";
            this.Asiento.Name = "Asiento";
            this.Asiento.ReadOnly = true;
            this.Asiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaEvento
            // 
            this.FechaEvento.HeaderText = "Fecha Evento";
            this.FechaEvento.Name = "FechaEvento";
            this.FechaEvento.ReadOnly = true;
            this.FechaEvento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DescripcionEvento
            // 
            this.DescripcionEvento.HeaderText = "Descripción Evento";
            this.DescripcionEvento.Name = "DescripcionEvento";
            this.DescripcionEvento.ReadOnly = true;
            this.DescripcionEvento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblHistorialCliente
            // 
            this.lblHistorialCliente.AutoSize = true;
            this.lblHistorialCliente.Location = new System.Drawing.Point(22, 18);
            this.lblHistorialCliente.Name = "lblHistorialCliente";
            this.lblHistorialCliente.Size = new System.Drawing.Size(103, 13);
            this.lblHistorialCliente.TabIndex = 2;
            this.lblHistorialCliente.Text = "Historial de Compras";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(393, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(514, 334);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtActualPage
            // 
            this.txtActualPage.Location = new System.Drawing.Point(425, 335);
            this.txtActualPage.Name = "txtActualPage";
            this.txtActualPage.Size = new System.Drawing.Size(26, 20);
            this.txtActualPage.TabIndex = 6;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(457, 338);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(19, 13);
            this.lblDe.TabIndex = 7;
            this.lblDe.Text = "de";
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Enabled = false;
            this.txtTotalPage.Location = new System.Drawing.Point(482, 335);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(26, 20);
            this.txtTotalPage.TabIndex = 8;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(359, 333);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(28, 23);
            this.btnFirstPage.TabIndex = 9;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(546, 334);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(28, 23);
            this.btnLastPage.TabIndex = 11;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 381);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.txtActualPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHistorialCliente);
            this.Controls.Add(this.dataGridHistorialCliente);
            this.Name = "HistorialCliente";
            this.Text = "Historial Cliente";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorialCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistorialCliente;
        private System.Windows.Forms.Label lblHistorialCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodoDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEvento;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtActualPage;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;

    }
}