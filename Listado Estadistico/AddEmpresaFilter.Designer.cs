﻿namespace PalcoNet.Listado_Estadistico
{
    partial class AddEmpresaFilter
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBoxFiltroGrado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.groupBoxFiltroGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(197, 103);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBoxFiltroGrado
            // 
            this.groupBoxFiltroGrado.Controls.Add(this.label1);
            this.groupBoxFiltroGrado.Controls.Add(this.comboBoxEmpresa);
            this.groupBoxFiltroGrado.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltroGrado.Name = "groupBoxFiltroGrado";
            this.groupBoxFiltroGrado.Size = new System.Drawing.Size(260, 85);
            this.groupBoxFiltroGrado.TabIndex = 2;
            this.groupBoxFiltroGrado.TabStop = false;
            this.groupBoxFiltroGrado.Text = "Agregar filtro empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la empresa";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(6, 43);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(163, 21);
            this.comboBoxEmpresa.TabIndex = 0;
            // 
            // AddEmpresaFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBoxFiltroGrado);
            this.Name = "AddEmpresaFilter";
            this.Text = "Filtro Empresa";
            this.Load += new System.EventHandler(this.AddEmpresaFilter_Load);
            this.groupBoxFiltroGrado.ResumeLayout(false);
            this.groupBoxFiltroGrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBoxFiltroGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
    }
}