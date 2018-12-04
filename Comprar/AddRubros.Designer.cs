namespace PalcoNet.Comprar
{
    partial class FormAddRubros
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
            this.listBoxRubros = new System.Windows.Forms.ListBox();
            this.btnAgregarRubro = new System.Windows.Forms.Button();
            this.groupBoxAddRubro = new System.Windows.Forms.GroupBox();
            this.groupBoxAddRubro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRubros
            // 
            this.listBoxRubros.FormattingEnabled = true;
            this.listBoxRubros.Location = new System.Drawing.Point(6, 19);
            this.listBoxRubros.Name = "listBoxRubros";
            this.listBoxRubros.Size = new System.Drawing.Size(120, 121);
            this.listBoxRubros.TabIndex = 0;
            // 
            // btnAgregarRubro
            // 
            this.btnAgregarRubro.Location = new System.Drawing.Point(143, 19);
            this.btnAgregarRubro.Name = "btnAgregarRubro";
            this.btnAgregarRubro.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRubro.TabIndex = 1;
            this.btnAgregarRubro.Text = "Agregar";
            this.btnAgregarRubro.UseVisualStyleBackColor = true;
            this.btnAgregarRubro.Click += new System.EventHandler(this.btnAgregarRubro_Click);
            // 
            // groupBoxAddRubro
            // 
            this.groupBoxAddRubro.Controls.Add(this.listBoxRubros);
            this.groupBoxAddRubro.Controls.Add(this.btnAgregarRubro);
            this.groupBoxAddRubro.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddRubro.Name = "groupBoxAddRubro";
            this.groupBoxAddRubro.Size = new System.Drawing.Size(237, 162);
            this.groupBoxAddRubro.TabIndex = 2;
            this.groupBoxAddRubro.TabStop = false;
            this.groupBoxAddRubro.Text = "Agregar Rubro";
            // 
            // FormAddRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 195);
            this.Controls.Add(this.groupBoxAddRubro);
            this.Name = "FormAddRubros";
            this.Text = "Agregar Rubros";
            this.groupBoxAddRubro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRubros;
        private System.Windows.Forms.Button btnAgregarRubro;
        private System.Windows.Forms.GroupBox groupBoxAddRubro;

    }
}