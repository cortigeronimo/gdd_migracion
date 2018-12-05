namespace PalcoNet.Generar_Publicacion
{
    partial class FormAgregarFechas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewFechas = new System.Windows.Forms.DataGridView();
            this.columnFechaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaEvento);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Evento";
            // 
            // dateTimePickerFechaEvento
            // 
            this.dateTimePickerFechaEvento.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaEvento.Location = new System.Drawing.Point(6, 37);
            this.dateTimePickerFechaEvento.Name = "dateTimePickerFechaEvento";
            this.dateTimePickerFechaEvento.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFechaEvento.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(95, 354);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar Selección";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(95, 91);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Fecha";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewFechas
            // 
            this.dataGridViewFechas.AllowUserToAddRows = false;
            this.dataGridViewFechas.AllowUserToDeleteRows = false;
            this.dataGridViewFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFechaEvento,
            this.columnEliminar});
            this.dataGridViewFechas.Location = new System.Drawing.Point(23, 136);
            this.dataGridViewFechas.Name = "dataGridViewFechas";
            this.dataGridViewFechas.ReadOnly = true;
            this.dataGridViewFechas.Size = new System.Drawing.Size(191, 197);
            this.dataGridViewFechas.TabIndex = 4;
            this.dataGridViewFechas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFechas_CellContentClick);
            // 
            // columnFechaEvento
            // 
            this.columnFechaEvento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnFechaEvento.DataPropertyName = "FechaEvento";
            this.columnFechaEvento.HeaderText = "Fecha Evento";
            this.columnFechaEvento.Name = "columnFechaEvento";
            this.columnFechaEvento.ReadOnly = true;
            this.columnFechaEvento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFechaEvento.Width = 80;
            // 
            // columnEliminar
            // 
            this.columnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEliminar.HeaderText = "Eliminar";
            this.columnEliminar.Image = global::PalcoNet.Properties.Resources.iconfinder_ic_delete_forever_48px_3669360;
            this.columnEliminar.Name = "columnEliminar";
            this.columnEliminar.ReadOnly = true;
            this.columnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormAgregarFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewFechas);
            this.MaximumSize = new System.Drawing.Size(251, 432);
            this.MinimumSize = new System.Drawing.Size(251, 432);
            this.Name = "FormAgregarFechas";
            this.Text = "Agregar Fechas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFechas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaEvento;
        private System.Windows.Forms.DataGridViewImageColumn columnEliminar;
    }
}