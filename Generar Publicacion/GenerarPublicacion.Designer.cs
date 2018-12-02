namespace PalcoNet.Generar_Publicacion
{
    partial class FormGenerarPublicacion
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
            this.btnAgregarUbicaciones = new System.Windows.Forms.Button();
            this.dateTimePickerFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGrado = new System.Windows.Forms.ComboBox();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombrePublicacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProgramarFechas = new System.Windows.Forms.Button();
            this.checkBoxVariasFechas = new System.Windows.Forms.CheckBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxGenerarPublicacion = new System.Windows.Forms.GroupBox();
            this.groupBoxGenerarPublicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarUbicaciones
            // 
            this.btnAgregarUbicaciones.Location = new System.Drawing.Point(107, 206);
            this.btnAgregarUbicaciones.Name = "btnAgregarUbicaciones";
            this.btnAgregarUbicaciones.Size = new System.Drawing.Size(114, 23);
            this.btnAgregarUbicaciones.TabIndex = 12;
            this.btnAgregarUbicaciones.Text = "Agregar Ubicaciones";
            this.btnAgregarUbicaciones.UseVisualStyleBackColor = true;
            this.btnAgregarUbicaciones.Click += new System.EventHandler(this.btnAgregarUbicaciones_Click);
            // 
            // dateTimePickerFechaEvento
            // 
            this.dateTimePickerFechaEvento.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePickerFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaEvento.Location = new System.Drawing.Point(10, 151);
            this.dateTimePickerFechaEvento.Name = "dateTimePickerFechaEvento";
            this.dateTimePickerFechaEvento.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerFechaEvento.TabIndex = 11;
            // 
            // comboBoxGrado
            // 
            this.comboBoxGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrado.FormattingEnabled = true;
            this.comboBoxGrado.Location = new System.Drawing.Point(284, 93);
            this.comboBoxGrado.Name = "comboBoxGrado";
            this.comboBoxGrado.Size = new System.Drawing.Size(110, 21);
            this.comboBoxGrado.TabIndex = 9;
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(9, 93);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(114, 21);
            this.comboBoxRubro.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(284, 41);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(212, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombrePublicacion
            // 
            this.txtNombrePublicacion.Location = new System.Drawing.Point(9, 41);
            this.txtNombrePublicacion.MaxLength = 255;
            this.txtNombrePublicacion.Name = "txtNombrePublicacion";
            this.txtNombrePublicacion.Size = new System.Drawing.Size(213, 20);
            this.txtNombrePublicacion.TabIndex = 6;
            this.txtNombrePublicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePublicacion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Del Evento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnProgramarFechas
            // 
            this.btnProgramarFechas.Enabled = false;
            this.btnProgramarFechas.Location = new System.Drawing.Point(381, 148);
            this.btnProgramarFechas.Name = "btnProgramarFechas";
            this.btnProgramarFechas.Size = new System.Drawing.Size(114, 23);
            this.btnProgramarFechas.TabIndex = 15;
            this.btnProgramarFechas.Text = "Programar Fechas";
            this.btnProgramarFechas.UseVisualStyleBackColor = true;
            this.btnProgramarFechas.Click += new System.EventHandler(this.btnProgramarFechas_Click);
            // 
            // checkBoxVariasFechas
            // 
            this.checkBoxVariasFechas.AutoSize = true;
            this.checkBoxVariasFechas.Location = new System.Drawing.Point(283, 152);
            this.checkBoxVariasFechas.Name = "checkBoxVariasFechas";
            this.checkBoxVariasFechas.Size = new System.Drawing.Size(93, 17);
            this.checkBoxVariasFechas.TabIndex = 16;
            this.checkBoxVariasFechas.Text = "Varias Fechas";
            this.checkBoxVariasFechas.UseVisualStyleBackColor = true;
            this.checkBoxVariasFechas.CheckedChanged += new System.EventHandler(this.checkBoxVariasFechas_CheckedChanged);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(283, 208);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(10, 206);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(76, 20);
            this.txtStock.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(433, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(21, 278);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxGenerarPublicacion
            // 
            this.groupBoxGenerarPublicacion.Controls.Add(this.txtNombrePublicacion);
            this.groupBoxGenerarPublicacion.Controls.Add(this.label1);
            this.groupBoxGenerarPublicacion.Controls.Add(this.label2);
            this.groupBoxGenerarPublicacion.Controls.Add(this.txtStock);
            this.groupBoxGenerarPublicacion.Controls.Add(this.label3);
            this.groupBoxGenerarPublicacion.Controls.Add(this.label8);
            this.groupBoxGenerarPublicacion.Controls.Add(this.label4);
            this.groupBoxGenerarPublicacion.Controls.Add(this.label7);
            this.groupBoxGenerarPublicacion.Controls.Add(this.label6);
            this.groupBoxGenerarPublicacion.Controls.Add(this.comboBoxEstado);
            this.groupBoxGenerarPublicacion.Controls.Add(this.txtDireccion);
            this.groupBoxGenerarPublicacion.Controls.Add(this.checkBoxVariasFechas);
            this.groupBoxGenerarPublicacion.Controls.Add(this.comboBoxRubro);
            this.groupBoxGenerarPublicacion.Controls.Add(this.btnProgramarFechas);
            this.groupBoxGenerarPublicacion.Controls.Add(this.comboBoxGrado);
            this.groupBoxGenerarPublicacion.Controls.Add(this.dateTimePickerFechaEvento);
            this.groupBoxGenerarPublicacion.Controls.Add(this.btnAgregarUbicaciones);
            this.groupBoxGenerarPublicacion.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGenerarPublicacion.Name = "groupBoxGenerarPublicacion";
            this.groupBoxGenerarPublicacion.Size = new System.Drawing.Size(513, 247);
            this.groupBoxGenerarPublicacion.TabIndex = 23;
            this.groupBoxGenerarPublicacion.TabStop = false;
            this.groupBoxGenerarPublicacion.Text = "Generar Publicación";
            // 
            // FormGenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 315);
            this.Controls.Add(this.groupBoxGenerarPublicacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormGenerarPublicacion";
            this.Text = "Generar Publicación";
            this.groupBoxGenerarPublicacion.ResumeLayout(false);
            this.groupBoxGenerarPublicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombrePublicacion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.ComboBox comboBoxGrado;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEvento;
        private System.Windows.Forms.Button btnAgregarUbicaciones;
        private System.Windows.Forms.Button btnProgramarFechas;
        private System.Windows.Forms.CheckBox checkBoxVariasFechas;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxGenerarPublicacion;
    }
}