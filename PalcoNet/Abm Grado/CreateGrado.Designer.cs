namespace PalcoNet.Abm_Grado
{
    partial class CreateGrado
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
            this.lblNombreGrado = new System.Windows.Forms.Label();
            this.txtNombreGrado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblComisionGrado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreGrado
            // 
            this.lblNombreGrado.AutoSize = true;
            this.lblNombreGrado.Location = new System.Drawing.Point(6, 29);
            this.lblNombreGrado.Name = "lblNombreGrado";
            this.lblNombreGrado.Size = new System.Drawing.Size(142, 13);
            this.lblNombreGrado.TabIndex = 0;
            this.lblNombreGrado.Text = "Ingrese un nombre de Grado";
            // 
            // txtNombreGrado
            // 
            this.txtNombreGrado.Location = new System.Drawing.Point(6, 45);
            this.txtNombreGrado.Name = "txtNombreGrado";
            this.txtNombreGrado.Size = new System.Drawing.Size(139, 20);
            this.txtNombreGrado.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(214, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblComisionGrado
            // 
            this.lblComisionGrado.AutoSize = true;
            this.lblComisionGrado.Location = new System.Drawing.Point(6, 85);
            this.lblComisionGrado.Name = "lblComisionGrado";
            this.lblComisionGrado.Size = new System.Drawing.Size(98, 13);
            this.lblComisionGrado.TabIndex = 3;
            this.lblComisionGrado.Text = "Ingrese la Comisión";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComision);
            this.groupBox1.Controls.Add(this.lblComisionGrado);
            this.groupBox1.Controls.Add(this.txtNombreGrado);
            this.groupBox1.Controls.Add(this.lblNombreGrado);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Grado";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(6, 102);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(139, 20);
            this.txtComision.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(34, 163);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // CreateGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 208);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CreateGrado";
            this.Text = "Crear Grado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGrado;
        private System.Windows.Forms.TextBox txtNombreGrado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblComisionGrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtComision;
    }
}