namespace PalcoNet.Registro_de_Usuario
{
    partial class CreateEmpresa
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
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.numPiso = new System.Windows.Forms.NumericUpDown();
            this.numTelefono = new System.Windows.Forms.NumericUpDown();
            this.numCuit = new System.Windows.Forms.NumericUpDown();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCuit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.numPiso);
            this.groupBoxCliente.Controls.Add(this.numTelefono);
            this.groupBoxCliente.Controls.Add(this.numCuit);
            this.groupBoxCliente.Controls.Add(this.txtCiudad);
            this.groupBoxCliente.Controls.Add(this.lblCiudad);
            this.groupBoxCliente.Controls.Add(this.txtCodigoPostal);
            this.groupBoxCliente.Controls.Add(this.lblCodigoPostal);
            this.groupBoxCliente.Controls.Add(this.txtLocalidad);
            this.groupBoxCliente.Controls.Add(this.lblLocalidad);
            this.groupBoxCliente.Controls.Add(this.lblDepartamento);
            this.groupBoxCliente.Controls.Add(this.txtDepartamento);
            this.groupBoxCliente.Controls.Add(this.lblPiso);
            this.groupBoxCliente.Controls.Add(this.txtDireccion);
            this.groupBoxCliente.Controls.Add(this.lblDireccion);
            this.groupBoxCliente.Controls.Add(this.lblTelefono);
            this.groupBoxCliente.Controls.Add(this.txtEmail);
            this.groupBoxCliente.Controls.Add(this.lblEmail);
            this.groupBoxCliente.Controls.Add(this.lblCuit);
            this.groupBoxCliente.Controls.Add(this.txtRazonSocial);
            this.groupBoxCliente.Controls.Add(this.lblRazonSocial);
            this.groupBoxCliente.Location = new System.Drawing.Point(36, 22);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(354, 301);
            this.groupBoxCliente.TabIndex = 0;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Alta De Cliente";
            // 
            // numPiso
            // 
            this.numPiso.Location = new System.Drawing.Point(6, 204);
            this.numPiso.Name = "numPiso";
            this.numPiso.Size = new System.Drawing.Size(131, 20);
            this.numPiso.TabIndex = 30;
            // 
            // numTelefono
            // 
            this.numTelefono.Location = new System.Drawing.Point(6, 99);
            this.numTelefono.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTelefono.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Size = new System.Drawing.Size(131, 20);
            this.numTelefono.TabIndex = 29;
            this.numTelefono.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // numCuit
            // 
            this.numCuit.Location = new System.Drawing.Point(217, 48);
            this.numCuit.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numCuit.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numCuit.Name = "numCuit";
            this.numCuit.Size = new System.Drawing.Size(131, 20);
            this.numCuit.TabIndex = 28;
            this.numCuit.Value = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(215, 254);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(131, 20);
            this.txtCiudad.TabIndex = 26;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(214, 238);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 25;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(6, 254);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(131, 20);
            this.txtCodigoPostal.TabIndex = 22;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(6, 238);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPostal.TabIndex = 21;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(6, 155);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(131, 20);
            this.txtLocalidad.TabIndex = 20;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(3, 139);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 19;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(212, 188);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 18;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(215, 204);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(131, 20);
            this.txtDepartamento.TabIndex = 17;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(6, 188);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(67, 13);
            this.lblPiso.TabIndex = 15;
            this.lblPiso.Text = "Número Piso";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(217, 155);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(131, 20);
            this.txtDireccion.TabIndex = 14;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(214, 139);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 13);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Calle y Número";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(3, 83);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(217, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(214, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(214, 32);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 7;
            this.lblCuit.Text = "Cuit";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(6, 48);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(131, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(3, 32);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(36, 329);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(315, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CreateEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 363);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxCliente);
            this.Name = "CreateEmpresa";
            this.Text = "CreateCliente";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCuit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown numPiso;
        private System.Windows.Forms.NumericUpDown numTelefono;
        private System.Windows.Forms.NumericUpDown numCuit;
    }
}