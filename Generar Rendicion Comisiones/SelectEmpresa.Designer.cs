namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class SelectEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRendicionComisiones = new System.Windows.Forms.DataGridView();
            this.empresaPorFacturarDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPublicacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPorFacturarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFacturar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRendicionComisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPorFacturarDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la Empresa a la cual le quiere facturar";
            // 
            // dataGridRendicionComisiones
            // 
            this.dataGridRendicionComisiones.AllowUserToAddRows = false;
            this.dataGridRendicionComisiones.AllowUserToDeleteRows = false;
            this.dataGridRendicionComisiones.AutoGenerateColumns = false;
            this.dataGridRendicionComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRendicionComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.razonSocialDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.nroPisoDataGridViewTextBoxColumn,
            this.deptoDataGridViewTextBoxColumn,
            this.cantidadPublicacionesDataGridViewTextBoxColumn,
            this.montoPorFacturarDataGridViewTextBoxColumn,
            this.columnFacturar});
            this.dataGridRendicionComisiones.DataSource = this.empresaPorFacturarDTOBindingSource;
            this.dataGridRendicionComisiones.Location = new System.Drawing.Point(13, 45);
            this.dataGridRendicionComisiones.Name = "dataGridRendicionComisiones";
            this.dataGridRendicionComisiones.ReadOnly = true;
            this.dataGridRendicionComisiones.Size = new System.Drawing.Size(952, 260);
            this.dataGridRendicionComisiones.TabIndex = 1;
            this.dataGridRendicionComisiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRendicionComisiones_CellContentClick);
            // 
            // empresaPorFacturarDTOBindingSource
            // 
            this.empresaPorFacturarDTOBindingSource.DataSource = typeof(PalcoNet.DTO.EmpresaPorFacturarDTO);
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "Cuit";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            this.cuitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            this.localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nroPisoDataGridViewTextBoxColumn
            // 
            this.nroPisoDataGridViewTextBoxColumn.DataPropertyName = "NroPiso";
            this.nroPisoDataGridViewTextBoxColumn.HeaderText = "NroPiso";
            this.nroPisoDataGridViewTextBoxColumn.Name = "nroPisoDataGridViewTextBoxColumn";
            this.nroPisoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptoDataGridViewTextBoxColumn
            // 
            this.deptoDataGridViewTextBoxColumn.DataPropertyName = "Depto";
            this.deptoDataGridViewTextBoxColumn.HeaderText = "Depto";
            this.deptoDataGridViewTextBoxColumn.Name = "deptoDataGridViewTextBoxColumn";
            this.deptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadPublicacionesDataGridViewTextBoxColumn
            // 
            this.cantidadPublicacionesDataGridViewTextBoxColumn.DataPropertyName = "CantidadPublicaciones";
            this.cantidadPublicacionesDataGridViewTextBoxColumn.HeaderText = "Cantidad De Publicaciones";
            this.cantidadPublicacionesDataGridViewTextBoxColumn.Name = "cantidadPublicacionesDataGridViewTextBoxColumn";
            this.cantidadPublicacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoPorFacturarDataGridViewTextBoxColumn
            // 
            this.montoPorFacturarDataGridViewTextBoxColumn.DataPropertyName = "MontoPorFacturar";
            this.montoPorFacturarDataGridViewTextBoxColumn.HeaderText = "Monto Por Facturar";
            this.montoPorFacturarDataGridViewTextBoxColumn.Name = "montoPorFacturarDataGridViewTextBoxColumn";
            this.montoPorFacturarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnFacturar
            // 
            this.columnFacturar.HeaderText = "Facturar";
            this.columnFacturar.Name = "columnFacturar";
            this.columnFacturar.ReadOnly = true;
            // 
            // RendicionComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 317);
            this.Controls.Add(this.dataGridRendicionComisiones);
            this.Controls.Add(this.label1);
            this.Name = "RendicionComisiones";
            this.Text = "Rendición de Comisiones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRendicionComisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPorFacturarDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridRendicionComisiones;
        private System.Windows.Forms.BindingSource empresaPorFacturarDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPublicacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPorFacturarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn columnFacturar;
    }
}