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
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewFechas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.columnFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(23, 34);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFechaInicio.TabIndex = 0;
            // 
            // dateTimePickerFechaEvento
            // 
            this.dateTimePickerFechaEvento.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaEvento.Location = new System.Drawing.Point(239, 34);
            this.dateTimePickerFechaEvento.Name = "dateTimePickerFechaEvento";
            this.dateTimePickerFechaEvento.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFechaEvento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Evento";
            // 
            // dataGridViewFechas
            // 
            this.dataGridViewFechas.AllowUserToAddRows = false;
            this.dataGridViewFechas.AllowUserToDeleteRows = false;
            this.dataGridViewFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFechaInicio,
            this.columnFechaEvento,
            this.columnEliminar});
            this.dataGridViewFechas.Location = new System.Drawing.Point(23, 74);
            this.dataGridViewFechas.Name = "dataGridViewFechas";
            this.dataGridViewFechas.ReadOnly = true;
            this.dataGridViewFechas.Size = new System.Drawing.Size(409, 176);
            this.dataGridViewFechas.TabIndex = 4;
            this.dataGridViewFechas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFechas_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(450, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Fecha";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(450, 130);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar Selección";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // columnFechaInicio
            // 
            this.columnFechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnFechaInicio.DataPropertyName = "FechaInicio";
            this.columnFechaInicio.HeaderText = "Fecha Inicio";
            this.columnFechaInicio.Name = "columnFechaInicio";
            this.columnFechaInicio.ReadOnly = true;
            this.columnFechaInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFechaInicio.Width = 71;
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
            this.columnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnEliminar.HeaderText = "Eliminar";
            this.columnEliminar.Name = "columnEliminar";
            this.columnEliminar.ReadOnly = true;
            this.columnEliminar.Width = 49;
            // 
            // FormAgregarFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 274);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewFechas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFechaEvento);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Name = "FormAgregarFechas";
            this.Text = "AgregarFechas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFechas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaEvento;
        private System.Windows.Forms.DataGridViewButtonColumn columnEliminar;
    }
}