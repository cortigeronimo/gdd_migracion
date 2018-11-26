namespace PalcoNet.Generar_Publicacion
{
    partial class FormEditarPublicacion
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
            this.dataGridViewPublicaciones = new System.Windows.Forms.DataGridView();
            this.columnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPublicaciones
            // 
            this.dataGridViewPublicaciones.AllowUserToAddRows = false;
            this.dataGridViewPublicaciones.AllowUserToDeleteRows = false;
            this.dataGridViewPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCodigo,
            this.columnFechaInicio,
            this.columnFechaEvento,
            this.columnDescripcion,
            this.columnDireccion,
            this.columnRubro,
            this.columnGrado,
            this.columnEmpresa,
            this.columnEstado});
            this.dataGridViewPublicaciones.Location = new System.Drawing.Point(26, 162);
            this.dataGridViewPublicaciones.MultiSelect = false;
            this.dataGridViewPublicaciones.Name = "dataGridViewPublicaciones";
            this.dataGridViewPublicaciones.ReadOnly = true;
            this.dataGridViewPublicaciones.Size = new System.Drawing.Size(501, 200);
            this.dataGridViewPublicaciones.TabIndex = 6;
            // 
            // columnCodigo
            // 
            this.columnCodigo.DataPropertyName = "Pub_Codigo";
            this.columnCodigo.HeaderText = "Código";
            this.columnCodigo.Name = "columnCodigo";
            this.columnCodigo.ReadOnly = true;
            // 
            // columnFechaInicio
            // 
            this.columnFechaInicio.DataPropertyName = "Pub_Fecha_Inicio";
            this.columnFechaInicio.HeaderText = "Fecha Inicio";
            this.columnFechaInicio.Name = "columnFechaInicio";
            this.columnFechaInicio.ReadOnly = true;
            // 
            // columnFechaEvento
            // 
            this.columnFechaEvento.DataPropertyName = "Pub_Fecha_Evento";
            this.columnFechaEvento.HeaderText = "Fecha Evento";
            this.columnFechaEvento.Name = "columnFechaEvento";
            this.columnFechaEvento.ReadOnly = true;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.DataPropertyName = "Pub_Descripcion";
            this.columnDescripcion.HeaderText = "Descripción";
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.ReadOnly = true;
            // 
            // columnDireccion
            // 
            this.columnDireccion.DataPropertyName = "Pub_Direccion";
            this.columnDireccion.HeaderText = "Dirección";
            this.columnDireccion.Name = "columnDireccion";
            this.columnDireccion.ReadOnly = true;
            // 
            // columnRubro
            // 
            this.columnRubro.DataPropertyName = "Pub_Rubro";
            this.columnRubro.HeaderText = "Rubro";
            this.columnRubro.Name = "columnRubro";
            this.columnRubro.ReadOnly = true;
            // 
            // columnGrado
            // 
            this.columnGrado.DataPropertyName = "Pub_Grado";
            this.columnGrado.HeaderText = "Grado";
            this.columnGrado.Name = "columnGrado";
            this.columnGrado.ReadOnly = true;
            // 
            // columnEmpresa
            // 
            this.columnEmpresa.DataPropertyName = "Pub_Empresa";
            this.columnEmpresa.HeaderText = "ID Empresa";
            this.columnEmpresa.Name = "columnEmpresa";
            this.columnEmpresa.ReadOnly = true;
            // 
            // columnEstado
            // 
            this.columnEstado.DataPropertyName = "Pub_Estado";
            this.columnEstado.HeaderText = "Estado";
            this.columnEstado.Name = "columnEstado";
            this.columnEstado.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(371, 368);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Enabled = false;
            this.btnPublicar.Location = new System.Drawing.Point(290, 368);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(75, 23);
            this.btnPublicar.TabIndex = 4;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(452, 368);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(408, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Publicación";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(203, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione una publicación a editar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Publicación";
            // 
            // FormEditarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPublicaciones);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FormEditarPublicacion";
            this.Text = "Editar Publicación";
            this.Load += new System.EventHandler(this.FormEditarPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridViewPublicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}