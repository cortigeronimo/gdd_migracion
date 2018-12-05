namespace PalcoNet.Comprar
{
    partial class FormAgregarTarjetaCredito
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxTarjetaCredito = new System.Windows.Forms.GroupBox();
            this.txtTarjetaCredito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxTarjetaCredito.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(253, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBoxTarjetaCredito
            // 
            this.groupBoxTarjetaCredito.Controls.Add(this.txtTarjetaCredito);
            this.groupBoxTarjetaCredito.Controls.Add(this.label1);
            this.groupBoxTarjetaCredito.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTarjetaCredito.Name = "groupBoxTarjetaCredito";
            this.groupBoxTarjetaCredito.Size = new System.Drawing.Size(316, 79);
            this.groupBoxTarjetaCredito.TabIndex = 0;
            this.groupBoxTarjetaCredito.TabStop = false;
            this.groupBoxTarjetaCredito.Text = "Registro Tarjeta de Crédito";
            // 
            // txtTarjetaCredito
            // 
            this.txtTarjetaCredito.Location = new System.Drawing.Point(9, 43);
            this.txtTarjetaCredito.Name = "txtTarjetaCredito";
            this.txtTarjetaCredito.Size = new System.Drawing.Size(180, 20);
            this.txtTarjetaCredito.TabIndex = 1;
            this.txtTarjetaCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaCredito_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Tarjeta de Crédito";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAgregarTarjetaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 136);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBoxTarjetaCredito);
            this.Name = "FormAgregarTarjetaCredito";
            this.Text = "Registrar Tarjeta de Crédito";
            this.groupBoxTarjetaCredito.ResumeLayout(false);
            this.groupBoxTarjetaCredito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTarjetaCredito;
        private System.Windows.Forms.TextBox txtTarjetaCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}