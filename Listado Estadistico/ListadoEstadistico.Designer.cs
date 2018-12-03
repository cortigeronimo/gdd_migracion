namespace PalcoNet.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEstadisticas = new System.Windows.Forms.DataGridView();
            this.btnListado1 = new System.Windows.Forms.Button();
            this.btnListado2 = new System.Windows.Forms.Button();
            this.btnListado3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTrimestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxAnio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxTrimestre.Location = new System.Drawing.Point(348, 31);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(58, 21);
            this.comboBoxTrimestre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(292, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trimestre";
            // 
            // txtBoxAnio
            // 
            this.txtBoxAnio.Location = new System.Drawing.Point(75, 31);
            this.txtBoxAnio.MaxLength = 4;
            this.txtBoxAnio.Name = "txtBoxAnio";
            this.txtBoxAnio.Size = new System.Drawing.Size(58, 20);
            this.txtBoxAnio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridEstadisticas
            // 
            this.dataGridEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadisticas.Location = new System.Drawing.Point(12, 270);
            this.dataGridEstadisticas.Name = "dataGridEstadisticas";
            this.dataGridEstadisticas.Size = new System.Drawing.Size(519, 295);
            this.dataGridEstadisticas.TabIndex = 1;
            // 
            // btnListado1
            // 
            this.btnListado1.Location = new System.Drawing.Point(26, 138);
            this.btnListado1.Name = "btnListado1";
            this.btnListado1.Size = new System.Drawing.Size(120, 100);
            this.btnListado1.TabIndex = 2;
            this.btnListado1.Text = "Empresas con mayor cantidad de localidades no vendidas";
            this.btnListado1.UseVisualStyleBackColor = true;
            this.btnListado1.Click += new System.EventHandler(this.btnListado1_Click);
            // 
            // btnListado2
            // 
            this.btnListado2.Location = new System.Drawing.Point(211, 138);
            this.btnListado2.Name = "btnListado2";
            this.btnListado2.Size = new System.Drawing.Size(120, 100);
            this.btnListado2.TabIndex = 3;
            this.btnListado2.Text = "Clientes con mayores puntos vencidos";
            this.btnListado2.UseVisualStyleBackColor = true;
            this.btnListado2.Click += new System.EventHandler(this.btnListado2_Click);
            // 
            // btnListado3
            // 
            this.btnListado3.Location = new System.Drawing.Point(388, 138);
            this.btnListado3.Name = "btnListado3";
            this.btnListado3.Size = new System.Drawing.Size(120, 100);
            this.btnListado3.TabIndex = 4;
            this.btnListado3.Text = "Clientes con mayor cantidad de compras";
            this.btnListado3.UseVisualStyleBackColor = true;
            this.btnListado3.Click += new System.EventHandler(this.btnListado3_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 619);
            this.Controls.Add(this.btnListado3);
            this.Controls.Add(this.btnListado2);
            this.Controls.Add(this.btnListado1);
            this.Controls.Add(this.dataGridEstadisticas);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoEstadistico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridEstadisticas;
        private System.Windows.Forms.Button btnListado1;
        private System.Windows.Forms.Button btnListado2;
        private System.Windows.Forms.Button btnListado3;

    }
}