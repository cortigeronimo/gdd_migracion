namespace PalcoNet.Generar_Publicacion
{
    partial class FormAgregarUbicaciones
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
            this.btnConfirmarSeleccion = new System.Windows.Forms.Button();
            this.dataGridViewUbicaciones = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipoUbicacion = new System.Windows.Forms.ComboBox();
            this.numericUpDownAsiento = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFila = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarSeleccion
            // 
            this.btnConfirmarSeleccion.Location = new System.Drawing.Point(442, 274);
            this.btnConfirmarSeleccion.Name = "btnConfirmarSeleccion";
            this.btnConfirmarSeleccion.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmarSeleccion.TabIndex = 10;
            this.btnConfirmarSeleccion.Text = "Confirmar Selección";
            this.btnConfirmarSeleccion.UseVisualStyleBackColor = true;
            this.btnConfirmarSeleccion.Click += new System.EventHandler(this.btnConfirmarSeleccion_Click);
            // 
            // dataGridViewUbicaciones
            // 
            this.dataGridViewUbicaciones.AllowUserToAddRows = false;
            this.dataGridViewUbicaciones.AllowUserToDeleteRows = false;
            this.dataGridViewUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFila,
            this.columnAsiento,
            this.columnPrecio,
            this.columnDescripcion,
            this.columnDelete});
            this.dataGridViewUbicaciones.Location = new System.Drawing.Point(18, 92);
            this.dataGridViewUbicaciones.Name = "dataGridViewUbicaciones";
            this.dataGridViewUbicaciones.ReadOnly = true;
            this.dataGridViewUbicaciones.Size = new System.Drawing.Size(545, 166);
            this.dataGridViewUbicaciones.TabIndex = 9;
            this.dataGridViewUbicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUbicaciones_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(219, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numericUpDownPrecio
            // 
            this.numericUpDownPrecio.Location = new System.Drawing.Point(57, 55);
            this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrecio.Name = "numericUpDownPrecio";
            this.numericUpDownPrecio.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownPrecio.TabIndex = 7;
            // 
            // comboBoxTipoUbicacion
            // 
            this.comboBoxTipoUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoUbicacion.FormattingEnabled = true;
            this.comboBoxTipoUbicacion.Items.AddRange(new object[] {
            "Platea Baja",
            "Platea Alta",
            "Cabecera",
            "Vip",
            "Campo",
            "Super PullMan",
            "PullMan",
            "Campo Vip"});
            this.comboBoxTipoUbicacion.Location = new System.Drawing.Point(393, 11);
            this.comboBoxTipoUbicacion.Name = "comboBoxTipoUbicacion";
            this.comboBoxTipoUbicacion.Size = new System.Drawing.Size(77, 21);
            this.comboBoxTipoUbicacion.TabIndex = 6;
            this.comboBoxTipoUbicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTipoUbicacion_KeyPress);
            // 
            // numericUpDownAsiento
            // 
            this.numericUpDownAsiento.Location = new System.Drawing.Point(219, 12);
            this.numericUpDownAsiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAsiento.Name = "numericUpDownAsiento";
            this.numericUpDownAsiento.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownAsiento.TabIndex = 5;
            this.numericUpDownAsiento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxFila
            // 
            this.comboBoxFila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFila.FormattingEnabled = true;
            this.comboBoxFila.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxFila.Location = new System.Drawing.Point(57, 12);
            this.comboBoxFila.Name = "comboBoxFila";
            this.comboBoxFila.Size = new System.Drawing.Size(78, 21);
            this.comboBoxFila.TabIndex = 4;
            this.comboBoxFila.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFila_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fila";
            // 
            // columnFila
            // 
            this.columnFila.DataPropertyName = "Fila";
            this.columnFila.HeaderText = "Fila";
            this.columnFila.Name = "columnFila";
            this.columnFila.ReadOnly = true;
            // 
            // columnAsiento
            // 
            this.columnAsiento.DataPropertyName = "Asiento";
            this.columnAsiento.HeaderText = "Asiento";
            this.columnAsiento.Name = "columnAsiento";
            this.columnAsiento.ReadOnly = true;
            // 
            // columnPrecio
            // 
            this.columnPrecio.DataPropertyName = "Precio";
            this.columnPrecio.HeaderText = "Precio";
            this.columnPrecio.Name = "columnPrecio";
            this.columnPrecio.ReadOnly = true;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.DataPropertyName = "Descripcion";
            this.columnDescripcion.HeaderText = "Descripción";
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.ReadOnly = true;
            // 
            // columnDelete
            // 
            this.columnDelete.DataPropertyName = "Eliminar";
            this.columnDelete.HeaderText = "Eliminar";
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.ReadOnly = true;
            // 
            // FormAgregarUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 309);
            this.Controls.Add(this.btnConfirmarSeleccion);
            this.Controls.Add(this.dataGridViewUbicaciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numericUpDownPrecio);
            this.Controls.Add(this.comboBoxTipoUbicacion);
            this.Controls.Add(this.numericUpDownAsiento);
            this.Controls.Add(this.comboBoxFila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarUbicaciones";
            this.Text = "Agregar Ubicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFila;
        private System.Windows.Forms.NumericUpDown numericUpDownAsiento;
        private System.Windows.Forms.ComboBox comboBoxTipoUbicacion;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridViewUbicaciones;
        private System.Windows.Forms.Button btnConfirmarSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewButtonColumn columnDelete;
    }
}