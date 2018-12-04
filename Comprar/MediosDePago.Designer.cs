namespace PalcoNet.Comprar
{
    partial class FormMediosDePago
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
            this.groupBoxMedioPago = new System.Windows.Forms.GroupBox();
            this.txtEmailFacturacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedioPago = new System.Windows.Forms.ComboBox();
            this.btnAceptarMedioDePago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxMedioPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMedioPago
            // 
            this.groupBoxMedioPago.Controls.Add(this.txtEmailFacturacion);
            this.groupBoxMedioPago.Controls.Add(this.label2);
            this.groupBoxMedioPago.Controls.Add(this.label1);
            this.groupBoxMedioPago.Controls.Add(this.comboBoxMedioPago);
            this.groupBoxMedioPago.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMedioPago.Name = "groupBoxMedioPago";
            this.groupBoxMedioPago.Size = new System.Drawing.Size(303, 113);
            this.groupBoxMedioPago.TabIndex = 0;
            this.groupBoxMedioPago.TabStop = false;
            this.groupBoxMedioPago.Text = "Medio De Pago";
            // 
            // txtEmailFacturacion
            // 
            this.txtEmailFacturacion.Location = new System.Drawing.Point(109, 71);
            this.txtEmailFacturacion.Name = "txtEmailFacturacion";
            this.txtEmailFacturacion.Size = new System.Drawing.Size(188, 20);
            this.txtEmailFacturacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email(Facturación):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el medio de pago:";
            // 
            // comboBoxMedioPago
            // 
            this.comboBoxMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedioPago.FormattingEnabled = true;
            this.comboBoxMedioPago.Items.AddRange(new object[] {
            "Tarjeta De Credito"});
            this.comboBoxMedioPago.Location = new System.Drawing.Point(162, 30);
            this.comboBoxMedioPago.Name = "comboBoxMedioPago";
            this.comboBoxMedioPago.Size = new System.Drawing.Size(135, 21);
            this.comboBoxMedioPago.TabIndex = 0;
            // 
            // btnAceptarMedioDePago
            // 
            this.btnAceptarMedioDePago.Location = new System.Drawing.Point(240, 131);
            this.btnAceptarMedioDePago.Name = "btnAceptarMedioDePago";
            this.btnAceptarMedioDePago.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMedioDePago.TabIndex = 1;
            this.btnAceptarMedioDePago.Text = "Siguiente";
            this.btnAceptarMedioDePago.UseVisualStyleBackColor = true;
            this.btnAceptarMedioDePago.Click += new System.EventHandler(this.btnAceptarMedioDePago_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormMediosDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 167);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarMedioDePago);
            this.Controls.Add(this.groupBoxMedioPago);
            this.Name = "FormMediosDePago";
            this.Text = "Datos de Compra";
            this.groupBoxMedioPago.ResumeLayout(false);
            this.groupBoxMedioPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMedioPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedioPago;
        private System.Windows.Forms.Button btnAceptarMedioDePago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEmailFacturacion;
        private System.Windows.Forms.Label label2;
    }
}