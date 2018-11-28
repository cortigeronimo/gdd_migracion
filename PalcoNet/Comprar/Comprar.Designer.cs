namespace PalcoNet.Comprar
{
    partial class FormComprar
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
            this.dataGridViewPublicaciones = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnComprar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.publicacionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxFiltroEventos = new System.Windows.Forms.GroupBox();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.dateTimePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtCategorias = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.txtActualPage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRangoFecha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionDTOBindingSource)).BeginInit();
            this.groupBoxFiltroEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPublicaciones
            // 
            this.dataGridViewPublicaciones.AllowUserToAddRows = false;
            this.dataGridViewPublicaciones.AllowUserToDeleteRows = false;
            this.dataGridViewPublicaciones.AutoGenerateColumns = false;
            this.dataGridViewPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaEventoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.columnComprar});
            this.dataGridViewPublicaciones.DataSource = this.publicacionDTOBindingSource;
            this.dataGridViewPublicaciones.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewPublicaciones.Name = "dataGridViewPublicaciones";
            this.dataGridViewPublicaciones.ReadOnly = true;
            this.dataGridViewPublicaciones.Size = new System.Drawing.Size(549, 238);
            this.dataGridViewPublicaciones.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEventoDataGridViewTextBoxColumn
            // 
            this.fechaEventoDataGridViewTextBoxColumn.DataPropertyName = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.HeaderText = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.Name = "fechaEventoDataGridViewTextBoxColumn";
            this.fechaEventoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.gradoDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnComprar
            // 
            this.columnComprar.HeaderText = "Comprar";
            this.columnComprar.Name = "columnComprar";
            this.columnComprar.ReadOnly = true;
            // 
            // publicacionDTOBindingSource
            // 
            this.publicacionDTOBindingSource.DataSource = typeof(PalcoNet.DTO.PublicacionDTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorías";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // groupBoxFiltroEventos
            // 
            this.groupBoxFiltroEventos.Controls.Add(this.checkBoxRangoFecha);
            this.groupBoxFiltroEventos.Controls.Add(this.btnAddCategoria);
            this.groupBoxFiltroEventos.Controls.Add(this.dateTimePickerFechaHasta);
            this.groupBoxFiltroEventos.Controls.Add(this.dateTimePickerFechaDesde);
            this.groupBoxFiltroEventos.Controls.Add(this.txtCategorias);
            this.groupBoxFiltroEventos.Controls.Add(this.txtDescripcion);
            this.groupBoxFiltroEventos.Controls.Add(this.label2);
            this.groupBoxFiltroEventos.Controls.Add(this.label1);
            this.groupBoxFiltroEventos.Location = new System.Drawing.Point(12, 21);
            this.groupBoxFiltroEventos.Name = "groupBoxFiltroEventos";
            this.groupBoxFiltroEventos.Size = new System.Drawing.Size(549, 131);
            this.groupBoxFiltroEventos.TabIndex = 4;
            this.groupBoxFiltroEventos.TabStop = false;
            this.groupBoxFiltroEventos.Text = "Filtros de Búsqueda";
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(200, 43);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(51, 23);
            this.btnAddCategoria.TabIndex = 8;
            this.btnAddCategoria.Text = "Add";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerFechaHasta.Enabled = false;
            this.dateTimePickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(221, 91);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(185, 20);
            this.dateTimePickerFechaHasta.TabIndex = 7;
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerFechaDesde.Enabled = false;
            this.dateTimePickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(9, 91);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(185, 20);
            this.dateTimePickerFechaDesde.TabIndex = 6;
            // 
            // txtCategorias
            // 
            this.txtCategorias.Enabled = false;
            this.txtCategorias.Location = new System.Drawing.Point(9, 45);
            this.txtCategorias.Name = "txtCategorias";
            this.txtCategorias.Size = new System.Drawing.Size(185, 20);
            this.txtCategorias.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(351, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 171);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(486, 171);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(381, 478);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(37, 23);
            this.btnLastPage.TabIndex = 7;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(338, 478);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(37, 23);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(147, 478);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(37, 23);
            this.btnFirstPage.TabIndex = 9;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.Location = new System.Drawing.Point(190, 478);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(37, 23);
            this.btnBackPage.TabIndex = 10;
            this.btnBackPage.Text = "<";
            this.btnBackPage.UseVisualStyleBackColor = true;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Enabled = false;
            this.txtTotalPage.Location = new System.Drawing.Point(299, 480);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(33, 20);
            this.txtTotalPage.TabIndex = 11;
            // 
            // txtActualPage
            // 
            this.txtActualPage.Enabled = false;
            this.txtActualPage.Location = new System.Drawing.Point(233, 480);
            this.txtActualPage.Name = "txtActualPage";
            this.txtActualPage.Size = new System.Drawing.Size(33, 20);
            this.txtActualPage.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "de";
            // 
            // checkBoxRangoFecha
            // 
            this.checkBoxRangoFecha.AutoSize = true;
            this.checkBoxRangoFecha.Location = new System.Drawing.Point(430, 91);
            this.checkBoxRangoFecha.Name = "checkBoxRangoFecha";
            this.checkBoxRangoFecha.Size = new System.Drawing.Size(106, 17);
            this.checkBoxRangoFecha.TabIndex = 9;
            this.checkBoxRangoFecha.Text = "Rango de Fecha";
            this.checkBoxRangoFecha.UseVisualStyleBackColor = true;
            this.checkBoxRangoFecha.CheckedChanged += new System.EventHandler(this.checkBoxRangoFecha_CheckedChanged);
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtActualPage);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxFiltroEventos);
            this.Controls.Add(this.dataGridViewPublicaciones);
            this.Name = "FormComprar";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.FormComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionDTOBindingSource)).EndInit();
            this.groupBoxFiltroEventos.ResumeLayout(false);
            this.groupBoxFiltroEventos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPublicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxFiltroEventos;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.TextBox txtCategorias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.TextBox txtActualPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource publicacionDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn columnComprar;
        private System.Windows.Forms.CheckBox checkBoxRangoFecha;
    }
}