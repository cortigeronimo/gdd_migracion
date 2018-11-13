namespace PalcoNet.Abm_Grado
{
    partial class ListGrado
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblComisionGrado = new System.Windows.Forms.Label();
            this.numComisionGrado = new System.Windows.Forms.NumericUpDown();
            this.txtNombreGrado = new System.Windows.Forms.TextBox();
            this.lblNombreGrado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnGradoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGradoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGradoComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(40, 104);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComisionGrado);
            this.groupBox1.Controls.Add(this.numComisionGrado);
            this.groupBox1.Controls.Add(this.txtNombreGrado);
            this.groupBox1.Controls.Add(this.lblNombreGrado);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // lblComisionGrado
            // 
            this.lblComisionGrado.AutoSize = true;
            this.lblComisionGrado.Location = new System.Drawing.Point(268, 29);
            this.lblComisionGrado.Name = "lblComisionGrado";
            this.lblComisionGrado.Size = new System.Drawing.Size(98, 13);
            this.lblComisionGrado.TabIndex = 3;
            this.lblComisionGrado.Text = "Ingrese la Comisión";
            // 
            // numComisionGrado
            // 
            this.numComisionGrado.Location = new System.Drawing.Point(271, 45);
            this.numComisionGrado.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numComisionGrado.Name = "numComisionGrado";
            this.numComisionGrado.Size = new System.Drawing.Size(139, 20);
            this.numComisionGrado.TabIndex = 4;
            // 
            // txtNombreGrado
            // 
            this.txtNombreGrado.Location = new System.Drawing.Point(6, 45);
            this.txtNombreGrado.Name = "txtNombreGrado";
            this.txtNombreGrado.Size = new System.Drawing.Size(139, 20);
            this.txtNombreGrado.TabIndex = 1;
            // 
            // lblNombreGrado
            // 
            this.lblNombreGrado.AutoSize = true;
            this.lblNombreGrado.Location = new System.Drawing.Point(6, 29);
            this.lblNombreGrado.Name = "lblNombreGrado";
            this.lblNombreGrado.Size = new System.Drawing.Size(91, 13);
            this.lblNombreGrado.TabIndex = 0;
            this.lblNombreGrado.Text = "Nombre de Grado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(375, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnGradoId,
            this.columnGradoDescripcion,
            this.columnGradoComision});
            this.dataGridView1.Location = new System.Drawing.Point(34, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(416, 169);
            this.dataGridView1.TabIndex = 7;
            // 
            // columnGradoId
            // 
            this.columnGradoId.DataPropertyName = "Grado_Id";
            this.columnGradoId.HeaderText = "Id";
            this.columnGradoId.Name = "columnGradoId";
            this.columnGradoId.ReadOnly = true;
            // 
            // columnGradoDescripcion
            // 
            this.columnGradoDescripcion.DataPropertyName = "Grado_Descripcion";
            this.columnGradoDescripcion.HeaderText = "Descripcion";
            this.columnGradoDescripcion.Name = "columnGradoDescripcion";
            this.columnGradoDescripcion.ReadOnly = true;
            // 
            // columnGradoComision
            // 
            this.columnGradoComision.DataPropertyName = "Grado_Comision";
            this.columnGradoComision.HeaderText = "Comision";
            this.columnGradoComision.Name = "columnGradoComision";
            this.columnGradoComision.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione una fila a editar o eliminar";
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(375, 365);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(294, 365);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // ListGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 400);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "ListGrado";
            this.Text = "Crear Grado";
            this.Load += new System.EventHandler(this.ListGrado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGrado;
        private System.Windows.Forms.TextBox txtNombreGrado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblComisionGrado;
        private System.Windows.Forms.NumericUpDown numComisionGrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGradoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGradoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGradoComision;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
    }
}