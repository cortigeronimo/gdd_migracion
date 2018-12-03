namespace PalcoNet.Canje_Puntos
{
    partial class CanjeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntosDisponibles = new System.Windows.Forms.Label();
            this.txtPuntosDisponibles = new System.Windows.Forms.TextBox();
            this.listBoxPremios = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtBusquedaPuntos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusquedaPuntos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos con puntos menores a";
            // 
            // lblPuntosDisponibles
            // 
            this.lblPuntosDisponibles.AutoSize = true;
            this.lblPuntosDisponibles.Location = new System.Drawing.Point(9, 143);
            this.lblPuntosDisponibles.Name = "lblPuntosDisponibles";
            this.lblPuntosDisponibles.Size = new System.Drawing.Size(97, 13);
            this.lblPuntosDisponibles.TabIndex = 1;
            this.lblPuntosDisponibles.Text = "Puntos Disponibles";
            // 
            // txtPuntosDisponibles
            // 
            this.txtPuntosDisponibles.Location = new System.Drawing.Point(12, 159);
            this.txtPuntosDisponibles.Name = "txtPuntosDisponibles";
            this.txtPuntosDisponibles.ReadOnly = true;
            this.txtPuntosDisponibles.Size = new System.Drawing.Size(151, 20);
            this.txtPuntosDisponibles.TabIndex = 2;
            // 
            // listBoxPremios
            // 
            this.listBoxPremios.FormattingEnabled = true;
            this.listBoxPremios.Location = new System.Drawing.Point(12, 197);
            this.listBoxPremios.Name = "listBoxPremios";
            this.listBoxPremios.Size = new System.Drawing.Size(228, 121);
            this.listBoxPremios.TabIndex = 3;
            this.listBoxPremios.SelectedIndexChanged += new System.EventHandler(this.listBoxPremios_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(165, 101);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 101);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(165, 324);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // numericUpDown1
            // 
            this.txtBusquedaPuntos.Location = new System.Drawing.Point(7, 46);
            this.txtBusquedaPuntos.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtBusquedaPuntos.Name = "numericUpDown1";
            this.txtBusquedaPuntos.Size = new System.Drawing.Size(159, 20);
            this.txtBusquedaPuntos.TabIndex = 3;
            // 
            // CanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 360);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.listBoxPremios);
            this.Controls.Add(this.txtPuntosDisponibles);
            this.Controls.Add(this.lblPuntosDisponibles);
            this.Controls.Add(this.groupBox1);
            this.Name = "CanjeForm";
            this.Text = "Canje de Puntos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntosDisponibles;
        private System.Windows.Forms.TextBox txtPuntosDisponibles;
        private System.Windows.Forms.ListBox listBoxPremios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.NumericUpDown txtBusquedaPuntos;
    }
}