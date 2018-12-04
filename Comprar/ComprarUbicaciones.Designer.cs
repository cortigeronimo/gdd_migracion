namespace PalcoNet.Comprar
{
    partial class FormComprarUbicaciones
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
            this.dataGridViewUbicacionesDisponibles = new System.Windows.Forms.DataGridView();
            this.filaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAgregarItem = new System.Windows.Forms.DataGridViewImageColumn();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelImporteTotal = new System.Windows.Forms.Label();
            this.dataGridViewUbicacionesAComprar = new System.Windows.Forms.DataGridView();
            this.filaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEliminarItem = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxComprarUbicaciones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacionesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacionesAComprar)).BeginInit();
            this.groupBoxComprarUbicaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUbicacionesDisponibles
            // 
            this.dataGridViewUbicacionesDisponibles.AllowUserToAddRows = false;
            this.dataGridViewUbicacionesDisponibles.AllowUserToDeleteRows = false;
            this.dataGridViewUbicacionesDisponibles.AutoGenerateColumns = false;
            this.dataGridViewUbicacionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUbicacionesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filaDataGridViewTextBoxColumn,
            this.asientoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.publicacionDataGridViewTextBoxColumn,
            this.columnAgregarItem});
            this.dataGridViewUbicacionesDisponibles.DataSource = this.ubicacionBindingSource;
            this.dataGridViewUbicacionesDisponibles.Location = new System.Drawing.Point(15, 54);
            this.dataGridViewUbicacionesDisponibles.Name = "dataGridViewUbicacionesDisponibles";
            this.dataGridViewUbicacionesDisponibles.ReadOnly = true;
            this.dataGridViewUbicacionesDisponibles.Size = new System.Drawing.Size(370, 254);
            this.dataGridViewUbicacionesDisponibles.TabIndex = 0;
            this.dataGridViewUbicacionesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUbicacionesDisponibles_CellContentClick);
            // 
            // filaDataGridViewTextBoxColumn
            // 
            this.filaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.filaDataGridViewTextBoxColumn.DataPropertyName = "Fila";
            this.filaDataGridViewTextBoxColumn.HeaderText = "Fila";
            this.filaDataGridViewTextBoxColumn.Name = "filaDataGridViewTextBoxColumn";
            this.filaDataGridViewTextBoxColumn.ReadOnly = true;
            this.filaDataGridViewTextBoxColumn.Width = 48;
            // 
            // asientoDataGridViewTextBoxColumn
            // 
            this.asientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asientoDataGridViewTextBoxColumn.DataPropertyName = "Asiento";
            this.asientoDataGridViewTextBoxColumn.HeaderText = "Asiento";
            this.asientoDataGridViewTextBoxColumn.Name = "asientoDataGridViewTextBoxColumn";
            this.asientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.asientoDataGridViewTextBoxColumn.Width = 67;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 62;
            // 
            // publicacionDataGridViewTextBoxColumn
            // 
            this.publicacionDataGridViewTextBoxColumn.DataPropertyName = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.HeaderText = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.Name = "publicacionDataGridViewTextBoxColumn";
            this.publicacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // columnAgregarItem
            // 
            this.columnAgregarItem.HeaderText = "Agegar Item Compra";
            this.columnAgregarItem.Image = global::PalcoNet.Properties.Resources.iconfinder_circle_add_226591;
            this.columnAgregarItem.Name = "columnAgregarItem";
            this.columnAgregarItem.ReadOnly = true;
            this.columnAgregarItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnAgregarItem.Width = 50;
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(PalcoNet.Modelo.Ubicacion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicaciones Disponibles";
            // 
            // labelImporteTotal
            // 
            this.labelImporteTotal.AutoSize = true;
            this.labelImporteTotal.Location = new System.Drawing.Point(420, 360);
            this.labelImporteTotal.Name = "labelImporteTotal";
            this.labelImporteTotal.Size = new System.Drawing.Size(97, 13);
            this.labelImporteTotal.TabIndex = 2;
            this.labelImporteTotal.Text = "IMPORTE TOTAL:";
            // 
            // dataGridViewUbicacionesAComprar
            // 
            this.dataGridViewUbicacionesAComprar.AllowUserToAddRows = false;
            this.dataGridViewUbicacionesAComprar.AllowUserToDeleteRows = false;
            this.dataGridViewUbicacionesAComprar.AutoGenerateColumns = false;
            this.dataGridViewUbicacionesAComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUbicacionesAComprar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filaDataGridViewTextBoxColumn1,
            this.asientoDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1,
            this.publicacionDataGridViewTextBoxColumn1,
            this.columnEliminarItem});
            this.dataGridViewUbicacionesAComprar.DataSource = this.ubicacionBindingSource;
            this.dataGridViewUbicacionesAComprar.Location = new System.Drawing.Point(411, 54);
            this.dataGridViewUbicacionesAComprar.Name = "dataGridViewUbicacionesAComprar";
            this.dataGridViewUbicacionesAComprar.ReadOnly = true;
            this.dataGridViewUbicacionesAComprar.Size = new System.Drawing.Size(365, 254);
            this.dataGridViewUbicacionesAComprar.TabIndex = 4;
            this.dataGridViewUbicacionesAComprar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUbicacionesAComprar_CellContentClick);
            // 
            // filaDataGridViewTextBoxColumn1
            // 
            this.filaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.filaDataGridViewTextBoxColumn1.DataPropertyName = "Fila";
            this.filaDataGridViewTextBoxColumn1.HeaderText = "Fila";
            this.filaDataGridViewTextBoxColumn1.Name = "filaDataGridViewTextBoxColumn1";
            this.filaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.filaDataGridViewTextBoxColumn1.Width = 48;
            // 
            // asientoDataGridViewTextBoxColumn1
            // 
            this.asientoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asientoDataGridViewTextBoxColumn1.DataPropertyName = "Asiento";
            this.asientoDataGridViewTextBoxColumn1.HeaderText = "Asiento";
            this.asientoDataGridViewTextBoxColumn1.Name = "asientoDataGridViewTextBoxColumn1";
            this.asientoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.asientoDataGridViewTextBoxColumn1.Width = 67;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn1.Width = 88;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn1.Width = 62;
            // 
            // publicacionDataGridViewTextBoxColumn1
            // 
            this.publicacionDataGridViewTextBoxColumn1.DataPropertyName = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn1.HeaderText = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn1.Name = "publicacionDataGridViewTextBoxColumn1";
            this.publicacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.publicacionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // columnEliminarItem
            // 
            this.columnEliminarItem.HeaderText = "Eliminar Item Compra";
            this.columnEliminarItem.Image = global::PalcoNet.Properties.Resources.iconfinder_ic_highlight_remove_48px_352425;
            this.columnEliminarItem.Name = "columnEliminarItem";
            this.columnEliminarItem.ReadOnly = true;
            this.columnEliminarItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnEliminarItem.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ubicaciones a Comprar";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(713, 355);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(27, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBoxComprarUbicaciones
            // 
            this.groupBoxComprarUbicaciones.Controls.Add(this.dataGridViewUbicacionesDisponibles);
            this.groupBoxComprarUbicaciones.Controls.Add(this.label1);
            this.groupBoxComprarUbicaciones.Controls.Add(this.dataGridViewUbicacionesAComprar);
            this.groupBoxComprarUbicaciones.Controls.Add(this.label3);
            this.groupBoxComprarUbicaciones.Location = new System.Drawing.Point(12, 12);
            this.groupBoxComprarUbicaciones.Name = "groupBoxComprarUbicaciones";
            this.groupBoxComprarUbicaciones.Size = new System.Drawing.Size(789, 330);
            this.groupBoxComprarUbicaciones.TabIndex = 8;
            this.groupBoxComprarUbicaciones.TabStop = false;
            this.groupBoxComprarUbicaciones.Text = "Compra Ubicaciones";
            // 
            // FormComprarUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 394);
            this.Controls.Add(this.groupBoxComprarUbicaciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.labelImporteTotal);
            this.Name = "FormComprarUbicaciones";
            this.Text = "Comprar Ubicaciones";
            this.Load += new System.EventHandler(this.FormComprarUbicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacionesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacionesAComprar)).EndInit();
            this.groupBoxComprarUbicaciones.ResumeLayout(false);
            this.groupBoxComprarUbicaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUbicacionesDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelImporteTotal;
        private System.Windows.Forms.DataGridView dataGridViewUbicacionesAComprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBoxComprarUbicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn filaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn columnAgregarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn filaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn columnEliminarItem;
    }
}