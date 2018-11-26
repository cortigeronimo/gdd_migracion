namespace PalcoNet.Abm_Grado
{
    partial class UpdateGrado
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
            this.groupGrado = new System.Windows.Forms.GroupBox();
            this.lblComisionGrado = new System.Windows.Forms.Label();
            this.txtNombreGrado = new System.Windows.Forms.TextBox();
            this.lblNombreGrado = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.groupGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(34, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupGrado
            // 
            this.groupGrado.Controls.Add(this.txtComision);
            this.groupGrado.Controls.Add(this.lblComisionGrado);
            this.groupGrado.Controls.Add(this.txtNombreGrado);
            this.groupGrado.Controls.Add(this.lblNombreGrado);
            this.groupGrado.Location = new System.Drawing.Point(34, 12);
            this.groupGrado.Name = "groupGrado";
            this.groupGrado.Size = new System.Drawing.Size(340, 135);
            this.groupGrado.TabIndex = 5;
            this.groupGrado.TabStop = false;
            this.groupGrado.Text = "Editar Grado";
            // 
            // lblComisionGrado
            // 
            this.lblComisionGrado.AutoSize = true;
            this.lblComisionGrado.Location = new System.Drawing.Point(3, 82);
            this.lblComisionGrado.Name = "lblComisionGrado";
            this.lblComisionGrado.Size = new System.Drawing.Size(98, 13);
            this.lblComisionGrado.TabIndex = 3;
            this.lblComisionGrado.Text = "Ingrese la Comisión";
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
            this.lblNombreGrado.Location = new System.Drawing.Point(3, 29);
            this.lblNombreGrado.Name = "lblNombreGrado";
            this.lblNombreGrado.Size = new System.Drawing.Size(142, 13);
            this.lblNombreGrado.TabIndex = 0;
            this.lblNombreGrado.Text = "Ingrese un nombre de Grado";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(299, 153);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(6, 99);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(139, 20);
            this.txtComision.TabIndex = 4;
            // 
            // UpdateGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 201);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupGrado);
            this.Controls.Add(this.btnModificar);
            this.Name = "UpdateGrado";
            this.Text = "Editar Grado";
            this.Load += new System.EventHandler(this.UpdateGrado_Load);
            this.groupGrado.ResumeLayout(false);
            this.groupGrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGrado;
        private System.Windows.Forms.TextBox txtNombreGrado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblComisionGrado;
        private System.Windows.Forms.GroupBox groupGrado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtComision;
    }
}