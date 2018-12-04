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
            this.txtComisionGrado = new System.Windows.Forms.TextBox();
            this.lblComisionGrado = new System.Windows.Forms.Label();
            this.txtNombreGrado = new System.Windows.Forms.TextBox();
            this.lblNombreGrado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnGradoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGradoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGradoComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.txtComisionGrado);
            this.groupBox1.Controls.Add(this.lblComisionGrado);
            this.groupBox1.Controls.Add(this.txtNombreGrado);
            this.groupBox1.Controls.Add(this.lblNombreGrado);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // txtComisionGrado
            // 
            this.txtComisionGrado.Location = new System.Drawing.Point(271, 45);
            this.txtComisionGrado.Name = "txtComisionGrado";
            this.txtComisionGrado.Size = new System.Drawing.Size(139, 20);
            this.txtComisionGrado.TabIndex = 4;
            // 
            // lblComisionGrado
            // 
            this.lblComisionGrado.AutoSize = true;
            this.lblComisionGrado.Location = new System.Drawing.Point(268, 29);
            this.lblComisionGrado.Name = "lblComisionGrado";
            this.lblComisionGrado.Size = new System.Drawing.Size(115, 13);
            this.lblComisionGrado.TabIndex = 3;
            this.lblComisionGrado.Text = "Ingrese la Comisión (%)";
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
            this.columnGradoComision,
            this.columnEditar,
            this.columnEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(34, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(416, 215);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnGradoId
            // 
            this.columnGradoId.DataPropertyName = "Id";
            this.columnGradoId.HeaderText = "Id";
            this.columnGradoId.Name = "columnGradoId";
            this.columnGradoId.ReadOnly = true;
            this.columnGradoId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnGradoId.Visible = false;
            // 
            // columnGradoDescripcion
            // 
            this.columnGradoDescripcion.DataPropertyName = "Descripcion";
            this.columnGradoDescripcion.HeaderText = "Descripcion";
            this.columnGradoDescripcion.Name = "columnGradoDescripcion";
            this.columnGradoDescripcion.ReadOnly = true;
            this.columnGradoDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnGradoComision
            // 
            this.columnGradoComision.DataPropertyName = "Comision";
            this.columnGradoComision.HeaderText = "Comision";
            this.columnGradoComision.Name = "columnGradoComision";
            this.columnGradoComision.ReadOnly = true;
            this.columnGradoComision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnEditar
            // 
            this.columnEditar.HeaderText = "Editar";
            this.columnEditar.Image = global::PalcoNet.Properties.Resources.iconfinder_new_24_103173;
            this.columnEditar.Name = "columnEditar";
            this.columnEditar.ReadOnly = true;
            this.columnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnEliminar
            // 
            this.columnEliminar.HeaderText = "Eliminar";
            this.columnEliminar.Image = global::PalcoNet.Properties.Resources.iconfinder_ic_delete_forever_48px_3669360;
            this.columnEliminar.Name = "columnEliminar";
            this.columnEliminar.ReadOnly = true;
            this.columnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ListGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "ListGrado";
            this.Text = "Consulta de Grados";
            this.Load += new System.EventHandler(this.ListGrado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGrado;
        private System.Windows.Forms.TextBox txtNombreGrado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblComisionGrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtComisionGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGradoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGradoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGradoComision;
        private System.Windows.Forms.DataGridViewImageColumn columnEditar;
        private System.Windows.Forms.DataGridViewImageColumn columnEliminar;
    }
}