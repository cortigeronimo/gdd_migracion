namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class PublicacionesDeEmpresa
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
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.dataGridPublicacionesPorFacturar = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFacturar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.publicacionPorFacturarDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicacionesPorFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionPorFacturarDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(17, 50);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(190, 13);
            this.lblIndicacion.TabIndex = 0;
            this.lblIndicacion.Text = "Seleccione una Publicación a Facturar";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(15, 13);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(97, 25);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa";
            // 
            // dataGridPublicacionesPorFacturar
            // 
            this.dataGridPublicacionesPorFacturar.AllowUserToAddRows = false;
            this.dataGridPublicacionesPorFacturar.AllowUserToDeleteRows = false;
            this.dataGridPublicacionesPorFacturar.AutoGenerateColumns = false;
            this.dataGridPublicacionesPorFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublicacionesPorFacturar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaEventoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn,
            this.comisionDataGridViewTextBoxColumn,
            this.columnFacturar});
            this.dataGridPublicacionesPorFacturar.DataSource = this.publicacionPorFacturarDTOBindingSource;
            this.dataGridPublicacionesPorFacturar.Location = new System.Drawing.Point(20, 81);
            this.dataGridPublicacionesPorFacturar.Name = "dataGridPublicacionesPorFacturar";
            this.dataGridPublicacionesPorFacturar.ReadOnly = true;
            this.dataGridPublicacionesPorFacturar.Size = new System.Drawing.Size(858, 273);
            this.dataGridPublicacionesPorFacturar.TabIndex = 2;
            this.dataGridPublicacionesPorFacturar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEventoDataGridViewTextBoxColumn
            // 
            this.fechaEventoDataGridViewTextBoxColumn.DataPropertyName = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.HeaderText = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.Name = "fechaEventoDataGridViewTextBoxColumn";
            this.fechaEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubroDataGridViewTextBoxColumn
            // 
            this.rubroDataGridViewTextBoxColumn.DataPropertyName = "Rubro";
            this.rubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.rubroDataGridViewTextBoxColumn.Name = "rubroDataGridViewTextBoxColumn";
            this.rubroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "Grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "Grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            this.gradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comisionDataGridViewTextBoxColumn
            // 
            this.comisionDataGridViewTextBoxColumn.DataPropertyName = "Comision";
            this.comisionDataGridViewTextBoxColumn.HeaderText = "Comision";
            this.comisionDataGridViewTextBoxColumn.Name = "comisionDataGridViewTextBoxColumn";
            this.comisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnFacturar
            // 
            this.columnFacturar.HeaderText = "Facturar";
            this.columnFacturar.Name = "columnFacturar";
            this.columnFacturar.ReadOnly = true;
            this.columnFacturar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnFacturar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // publicacionPorFacturarDTOBindingSource
            // 
            this.publicacionPorFacturarDTOBindingSource.DataSource = typeof(PalcoNet.DTO.PublicacionPorFacturarDTO);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(803, 360);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // PublicacionesDeEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 391);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridPublicacionesPorFacturar);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblIndicacion);
            this.Name = "PublicacionesDeEmpresa";
            this.Text = "PublicacionesDeEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicacionesPorFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionPorFacturarDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.DataGridView dataGridPublicacionesPorFacturar;
        private System.Windows.Forms.BindingSource publicacionPorFacturarDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn columnFacturar;
        private System.Windows.Forms.Button btnActualizar;
    }
}