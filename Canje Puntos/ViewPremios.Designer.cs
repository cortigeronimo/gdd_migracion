namespace PalcoNet.Canje_Puntos
{
    partial class ViewPremios
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
            this.lblPremios = new System.Windows.Forms.Label();
            this.dataGridPremios = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premioDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premioDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPremios
            // 
            this.lblPremios.AutoSize = true;
            this.lblPremios.Location = new System.Drawing.Point(12, 9);
            this.lblPremios.Name = "lblPremios";
            this.lblPremios.Size = new System.Drawing.Size(96, 13);
            this.lblPremios.TabIndex = 0;
            this.lblPremios.Text = "Premios Adquiridos";
            // 
            // dataGridPremios
            // 
            this.dataGridPremios.AllowUserToAddRows = false;
            this.dataGridPremios.AllowUserToDeleteRows = false;
            this.dataGridPremios.AutoGenerateColumns = false;
            this.dataGridPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPremios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.Puntos,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridPremios.DataSource = this.premioDTOBindingSource;
            this.dataGridPremios.Location = new System.Drawing.Point(13, 26);
            this.dataGridPremios.Name = "dataGridPremios";
            this.dataGridPremios.ReadOnly = true;
            this.dataGridPremios.Size = new System.Drawing.Size(240, 150);
            this.dataGridPremios.TabIndex = 1;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion Premio";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Puntos
            // 
            this.Puntos.DataPropertyName = "Puntos";
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Cantidad Canjeada";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // premioDTOBindingSource
            // 
            this.premioDTOBindingSource.DataSource = typeof(PalcoNet.DTO.PremioDTO);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(178, 182);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ViewPremios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 224);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridPremios);
            this.Controls.Add(this.lblPremios);
            this.Name = "ViewPremios";
            this.Text = "Visualización De Premios";
            this.Load += new System.EventHandler(this.ViewPremios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premioDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPremios;
        private System.Windows.Forms.DataGridView dataGridPremios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.BindingSource premioDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}