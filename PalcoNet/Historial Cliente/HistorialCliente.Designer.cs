namespace PalcoNet.Historial_Cliente
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
            this.components = new System.ComponentModel.Container();
            this.dataGridHistorialCliente = new System.Windows.Forms.DataGridView();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoDePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHistorialCliente = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtActualPage = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorialCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistorialCliente
            // 
            this.dataGridHistorialCliente.AllowUserToAddRows = false;
            this.dataGridHistorialCliente.AllowUserToDeleteRows = false;
            this.dataGridHistorialCliente.AutoGenerateColumns = false;
            this.dataGridHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorialCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaCompraDataGridViewTextBoxColumn,
            this.metodoDePagoDataGridViewTextBoxColumn,
            this.filaDataGridViewTextBoxColumn,
            this.asientoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionUbicacionDataGridViewTextBoxColumn,
            this.descripcionPublicacionDataGridViewTextBoxColumn,
            this.fechaEventoDataGridViewTextBoxColumn});
            this.dataGridHistorialCliente.DataSource = this.detalleCompraBindingSource;
            this.dataGridHistorialCliente.Location = new System.Drawing.Point(25, 43);
            this.dataGridHistorialCliente.Name = "dataGridHistorialCliente";
            this.dataGridHistorialCliente.ReadOnly = true;
            this.dataGridHistorialCliente.Size = new System.Drawing.Size(889, 233);
            this.dataGridHistorialCliente.TabIndex = 1;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha De Compra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoDePagoDataGridViewTextBoxColumn
            // 
            this.metodoDePagoDataGridViewTextBoxColumn.DataPropertyName = "MetodoDePago";
            this.metodoDePagoDataGridViewTextBoxColumn.HeaderText = "Metodo De Pago";
            this.metodoDePagoDataGridViewTextBoxColumn.Name = "metodoDePagoDataGridViewTextBoxColumn";
            this.metodoDePagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filaDataGridViewTextBoxColumn
            // 
            this.filaDataGridViewTextBoxColumn.DataPropertyName = "Fila";
            this.filaDataGridViewTextBoxColumn.HeaderText = "Fila";
            this.filaDataGridViewTextBoxColumn.Name = "filaDataGridViewTextBoxColumn";
            this.filaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asientoDataGridViewTextBoxColumn
            // 
            this.asientoDataGridViewTextBoxColumn.DataPropertyName = "Asiento";
            this.asientoDataGridViewTextBoxColumn.HeaderText = "Asiento";
            this.asientoDataGridViewTextBoxColumn.Name = "asientoDataGridViewTextBoxColumn";
            this.asientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionUbicacionDataGridViewTextBoxColumn
            // 
            this.descripcionUbicacionDataGridViewTextBoxColumn.DataPropertyName = "DescripcionUbicacion";
            this.descripcionUbicacionDataGridViewTextBoxColumn.HeaderText = "Descripción Ubicacion";
            this.descripcionUbicacionDataGridViewTextBoxColumn.Name = "descripcionUbicacionDataGridViewTextBoxColumn";
            this.descripcionUbicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionPublicacionDataGridViewTextBoxColumn
            // 
            this.descripcionPublicacionDataGridViewTextBoxColumn.DataPropertyName = "DescripcionPublicacion";
            this.descripcionPublicacionDataGridViewTextBoxColumn.HeaderText = "Descripción Publicación";
            this.descripcionPublicacionDataGridViewTextBoxColumn.Name = "descripcionPublicacionDataGridViewTextBoxColumn";
            this.descripcionPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEventoDataGridViewTextBoxColumn
            // 
            this.fechaEventoDataGridViewTextBoxColumn.DataPropertyName = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.HeaderText = "Fecha Evento";
            this.fechaEventoDataGridViewTextBoxColumn.Name = "fechaEventoDataGridViewTextBoxColumn";
            this.fechaEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataSource = typeof(PalcoNet.Modelo.DetalleCompra);
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
            this.btnBack.Location = new System.Drawing.Point(392, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(513, 296);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtActualPage
            // 
            this.txtActualPage.Location = new System.Drawing.Point(424, 297);
            this.txtActualPage.Name = "txtActualPage";
            this.txtActualPage.Size = new System.Drawing.Size(26, 20);
            this.txtActualPage.TabIndex = 6;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(456, 300);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(19, 13);
            this.lblDe.TabIndex = 7;
            this.lblDe.Text = "de";
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Enabled = false;
            this.txtTotalPage.Location = new System.Drawing.Point(481, 297);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(26, 20);
            this.txtTotalPage.TabIndex = 8;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(358, 295);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(28, 23);
            this.btnFirstPage.TabIndex = 9;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(545, 296);
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
            this.ClientSize = new System.Drawing.Size(937, 332);
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
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistorialCliente;
        private System.Windows.Forms.Label lblHistorialCliente;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtActualPage;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoDePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEventoDataGridViewTextBoxColumn;

    }
}