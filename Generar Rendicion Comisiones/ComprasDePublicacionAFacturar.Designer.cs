namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class ComprasDePublicacionAFacturar
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
            this.lblTituloPublicacion = new System.Windows.Forms.Label();
            this.dataGridCompras = new System.Windows.Forms.DataGridView();
            this.btnRendir = new System.Windows.Forms.Button();
            this.lblCantidadARendir = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoDePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numCantidadARendir = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadARendir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPublicacion
            // 
            this.lblTituloPublicacion.AutoSize = true;
            this.lblTituloPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPublicacion.Location = new System.Drawing.Point(7, 9);
            this.lblTituloPublicacion.Name = "lblTituloPublicacion";
            this.lblTituloPublicacion.Size = new System.Drawing.Size(141, 25);
            this.lblTituloPublicacion.TabIndex = 0;
            this.lblTituloPublicacion.Text = "Publicacion #";
            // 
            // dataGridCompras
            // 
            this.dataGridCompras.AllowUserToAddRows = false;
            this.dataGridCompras.AllowUserToDeleteRows = false;
            this.dataGridCompras.AutoGenerateColumns = false;
            this.dataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaCompraDataGridViewTextBoxColumn,
            this.metodoDePagoDataGridViewTextBoxColumn,
            this.filaDataGridViewTextBoxColumn,
            this.asientoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionUbicacionDataGridViewTextBoxColumn,
            this.descripcionPublicacionDataGridViewTextBoxColumn,
            this.fechaEventoDataGridViewTextBoxColumn});
            this.dataGridCompras.DataSource = this.detalleCompraBindingSource;
            this.dataGridCompras.Location = new System.Drawing.Point(12, 79);
            this.dataGridCompras.Name = "dataGridCompras";
            this.dataGridCompras.ReadOnly = true;
            this.dataGridCompras.Size = new System.Drawing.Size(815, 222);
            this.dataGridCompras.TabIndex = 1;
            // 
            // btnRendir
            // 
            this.btnRendir.Location = new System.Drawing.Point(752, 311);
            this.btnRendir.Name = "btnRendir";
            this.btnRendir.Size = new System.Drawing.Size(75, 20);
            this.btnRendir.TabIndex = 3;
            this.btnRendir.Text = "Rendir";
            this.btnRendir.UseVisualStyleBackColor = true;
            this.btnRendir.Click += new System.EventHandler(this.btnRendir_Click);
            // 
            // lblCantidadARendir
            // 
            this.lblCantidadARendir.AutoSize = true;
            this.lblCantidadARendir.Location = new System.Drawing.Point(517, 315);
            this.lblCantidadARendir.Name = "lblCantidadARendir";
            this.lblCantidadARendir.Size = new System.Drawing.Size(92, 13);
            this.lblCantidadARendir.TabIndex = 4;
            this.lblCantidadARendir.Text = "Cantidad a Rendir";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 47);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(295, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Las Rendiciones se Realizan a partir de la fecha más antigua";
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoDePagoDataGridViewTextBoxColumn
            // 
            this.metodoDePagoDataGridViewTextBoxColumn.DataPropertyName = "MetodoDePago";
            this.metodoDePagoDataGridViewTextBoxColumn.HeaderText = "MetodoDePago";
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
            this.descripcionUbicacionDataGridViewTextBoxColumn.HeaderText = "DescripcionUbicacion";
            this.descripcionUbicacionDataGridViewTextBoxColumn.Name = "descripcionUbicacionDataGridViewTextBoxColumn";
            this.descripcionUbicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionPublicacionDataGridViewTextBoxColumn
            // 
            this.descripcionPublicacionDataGridViewTextBoxColumn.DataPropertyName = "DescripcionPublicacion";
            this.descripcionPublicacionDataGridViewTextBoxColumn.HeaderText = "DescripcionPublicacion";
            this.descripcionPublicacionDataGridViewTextBoxColumn.Name = "descripcionPublicacionDataGridViewTextBoxColumn";
            this.descripcionPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEventoDataGridViewTextBoxColumn
            // 
            this.fechaEventoDataGridViewTextBoxColumn.DataPropertyName = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.HeaderText = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.Name = "fechaEventoDataGridViewTextBoxColumn";
            this.fechaEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataSource = typeof(PalcoNet.Modelo.DetalleCompra);
            // 
            // numericUpDown1
            // 
            this.numCantidadARendir.Location = new System.Drawing.Point(615, 311);
            this.numCantidadARendir.Name = "numericUpDown1";
            this.numCantidadARendir.Size = new System.Drawing.Size(120, 20);
            this.numCantidadARendir.TabIndex = 7;
            // 
            // ComprasDePublicacionAFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 347);
            this.Controls.Add(this.numCantidadARendir);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCantidadARendir);
            this.Controls.Add(this.btnRendir);
            this.Controls.Add(this.dataGridCompras);
            this.Controls.Add(this.lblTituloPublicacion);
            this.Name = "ComprasDePublicacionAFacturar";
            this.Text = "ComprasDePublicacionAFacturar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadARendir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPublicacion;
        private System.Windows.Forms.DataGridView dataGridCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoDePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private System.Windows.Forms.Button btnRendir;
        private System.Windows.Forms.Label lblCantidadARendir;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.NumericUpDown numCantidadARendir;
    }
}