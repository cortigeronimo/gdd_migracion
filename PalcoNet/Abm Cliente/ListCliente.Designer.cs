namespace PalcoNet.Abm_Cliente
{
    partial class ListCliente
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNroPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTarjetaCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHabilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIntentosFallidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxFiltroBusqueda = new System.Windows.Forms.GroupBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBoxFiltroBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(500, 491);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnNombre,
            this.columnApellido,
            this.columnTipoDocumento,
            this.columnNroDocumento,
            this.columnCuil,
            this.columnEmail,
            this.columnTelefono,
            this.columnLocalidad,
            this.columnDireccion,
            this.columnNroPiso,
            this.columnDepto,
            this.columnCodigoPostal,
            this.columnFechaNacimiento,
            this.columnFechaCreacion,
            this.columnTarjetaCredito,
            this.columnHabilitado,
            this.columnIntentosFallidos,
            this.columnBaja});
            this.dataGridViewClientes.Location = new System.Drawing.Point(26, 249);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(549, 220);
            this.dataGridViewClientes.TabIndex = 3;
            // 
            // columnID
            // 
            this.columnID.DataPropertyName = "Cli_Usuario";
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            // 
            // columnNombre
            // 
            this.columnNombre.DataPropertyName = "Cli_Nombre";
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            // 
            // columnApellido
            // 
            this.columnApellido.DataPropertyName = "Cli_Apellido";
            this.columnApellido.HeaderText = "Apellido";
            this.columnApellido.Name = "columnApellido";
            this.columnApellido.ReadOnly = true;
            // 
            // columnTipoDocumento
            // 
            this.columnTipoDocumento.DataPropertyName = "Cli_Tipo_Documento";
            this.columnTipoDocumento.HeaderText = "Tipo De Documento";
            this.columnTipoDocumento.Name = "columnTipoDocumento";
            this.columnTipoDocumento.ReadOnly = true;
            // 
            // columnNroDocumento
            // 
            this.columnNroDocumento.DataPropertyName = "Cli_Nro_Documento";
            this.columnNroDocumento.HeaderText = "Nro De Documento";
            this.columnNroDocumento.Name = "columnNroDocumento";
            this.columnNroDocumento.ReadOnly = true;
            // 
            // columnCuil
            // 
            this.columnCuil.DataPropertyName = "Cli_Cuil";
            this.columnCuil.HeaderText = "CUIL";
            this.columnCuil.Name = "columnCuil";
            this.columnCuil.ReadOnly = true;
            // 
            // columnEmail
            // 
            this.columnEmail.DataPropertyName = "Cli_Email";
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            // 
            // columnTelefono
            // 
            this.columnTelefono.DataPropertyName = "Cli_Telefono";
            this.columnTelefono.HeaderText = "Teléfono";
            this.columnTelefono.Name = "columnTelefono";
            this.columnTelefono.ReadOnly = true;
            // 
            // columnLocalidad
            // 
            this.columnLocalidad.DataPropertyName = "Cli_Localidad";
            this.columnLocalidad.HeaderText = "Localidad";
            this.columnLocalidad.Name = "columnLocalidad";
            this.columnLocalidad.ReadOnly = true;
            // 
            // columnDireccion
            // 
            this.columnDireccion.DataPropertyName = "Cli_Direccion";
            this.columnDireccion.HeaderText = "Dirección";
            this.columnDireccion.Name = "columnDireccion";
            this.columnDireccion.ReadOnly = true;
            // 
            // columnNroPiso
            // 
            this.columnNroPiso.DataPropertyName = "Cli_Nro_Piso";
            this.columnNroPiso.HeaderText = "Nro De Piso";
            this.columnNroPiso.Name = "columnNroPiso";
            this.columnNroPiso.ReadOnly = true;
            // 
            // columnDepto
            // 
            this.columnDepto.DataPropertyName = "Cli_Depto";
            this.columnDepto.HeaderText = "Departamento";
            this.columnDepto.Name = "columnDepto";
            this.columnDepto.ReadOnly = true;
            // 
            // columnCodigoPostal
            // 
            this.columnCodigoPostal.DataPropertyName = "Cli_Cod_Postal";
            this.columnCodigoPostal.HeaderText = "Código Postal";
            this.columnCodigoPostal.Name = "columnCodigoPostal";
            this.columnCodigoPostal.ReadOnly = true;
            // 
            // columnFechaNacimiento
            // 
            this.columnFechaNacimiento.DataPropertyName = "Cli_Fecha_Nac";
            this.columnFechaNacimiento.HeaderText = "Fecha De Nacimiento";
            this.columnFechaNacimiento.Name = "columnFechaNacimiento";
            this.columnFechaNacimiento.ReadOnly = true;
            // 
            // columnFechaCreacion
            // 
            this.columnFechaCreacion.DataPropertyName = "Cli_Fecha_Creacion";
            this.columnFechaCreacion.HeaderText = "Fecha Creación";
            this.columnFechaCreacion.Name = "columnFechaCreacion";
            this.columnFechaCreacion.ReadOnly = true;
            // 
            // columnTarjetaCredito
            // 
            this.columnTarjetaCredito.DataPropertyName = "Cli_Tarjeta_Credito";
            this.columnTarjetaCredito.HeaderText = "Tarjeta De Crédito";
            this.columnTarjetaCredito.Name = "columnTarjetaCredito";
            this.columnTarjetaCredito.ReadOnly = true;
            // 
            // columnHabilitado
            // 
            this.columnHabilitado.DataPropertyName = "Cli_Habilitado";
            this.columnHabilitado.HeaderText = "Habilitado";
            this.columnHabilitado.Name = "columnHabilitado";
            this.columnHabilitado.ReadOnly = true;
            // 
            // columnIntentosFallidos
            // 
            this.columnIntentosFallidos.DataPropertyName = "Cli_Intentos_Fallidos";
            this.columnIntentosFallidos.HeaderText = "Intentos Fallidos";
            this.columnIntentosFallidos.Name = "columnIntentosFallidos";
            this.columnIntentosFallidos.ReadOnly = true;
            // 
            // columnBaja
            // 
            this.columnBaja.DataPropertyName = "Cli_Baja";
            this.columnBaja.HeaderText = "Baja";
            this.columnBaja.Name = "columnBaja";
            this.columnBaja.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(500, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(26, 179);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxFiltroBusqueda
            // 
            this.groupBoxFiltroBusqueda.Controls.Add(this.txtNroDocumento);
            this.groupBoxFiltroBusqueda.Controls.Add(this.lblEmail);
            this.groupBoxFiltroBusqueda.Controls.Add(this.lblApellido);
            this.groupBoxFiltroBusqueda.Controls.Add(this.lblNombre);
            this.groupBoxFiltroBusqueda.Controls.Add(this.lblNroDocumento);
            this.groupBoxFiltroBusqueda.Controls.Add(this.txtEmail);
            this.groupBoxFiltroBusqueda.Controls.Add(this.txtApellido);
            this.groupBoxFiltroBusqueda.Controls.Add(this.txtNombre);
            this.groupBoxFiltroBusqueda.Location = new System.Drawing.Point(26, 23);
            this.groupBoxFiltroBusqueda.Name = "groupBoxFiltroBusqueda";
            this.groupBoxFiltroBusqueda.Size = new System.Drawing.Size(549, 137);
            this.groupBoxFiltroBusqueda.TabIndex = 0;
            this.groupBoxFiltroBusqueda.TabStop = false;
            this.groupBoxFiltroBusqueda.Text = "Filtros de Búsqueda";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(21, 101);
            this.txtNroDocumento.MaxLength = 18;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(163, 20);
            this.txtNroDocumento.TabIndex = 9;
            this.txtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocumento_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(361, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(361, 28);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(18, 85);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(26, 13);
            this.lblNroDocumento.TabIndex = 5;
            this.lblNroDocumento.Text = "DNI";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(364, 101);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(364, 44);
            this.txtApellido.MaxLength = 255;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 44);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(390, 491);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Alta/Baja";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 547);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxFiltroBusqueda);
            this.Name = "ListCliente";
            this.Text = "ListCliente";
            this.Load += new System.EventHandler(this.ListCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBoxFiltroBusqueda.ResumeLayout(false);
            this.groupBoxFiltroBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltroBusqueda;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTarjetaCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHabilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIntentosFallidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBaja;
        private System.Windows.Forms.Button btnEliminar;
    }
}