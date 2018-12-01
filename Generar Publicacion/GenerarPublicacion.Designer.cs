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
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnGuardarBorrador = new System.Windows.Forms.Button();
            this.btnAgregarUbicaciones = new System.Windows.Forms.Button();
            this.dateTimePickerFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGrado = new System.Windows.Forms.ComboBox();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombrePublicacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProgramarFechas = new System.Windows.Forms.Button();
            this.checkBoxVariasFechas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(300, 247);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(114, 23);
            this.btnPublicar.TabIndex = 14;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // btnGuardarBorrador
            // 
            this.btnGuardarBorrador.Location = new System.Drawing.Point(24, 247);
            this.btnGuardarBorrador.Name = "btnGuardarBorrador";
            this.btnGuardarBorrador.Size = new System.Drawing.Size(114, 23);
            this.btnGuardarBorrador.TabIndex = 13;
            this.btnGuardarBorrador.Text = "Guardar Borrador";
            this.btnGuardarBorrador.UseVisualStyleBackColor = true;
            this.btnGuardarBorrador.Click += new System.EventHandler(this.btnGuardarBorrador_Click);
            // 
            // btnAgregarUbicaciones
            // 
            this.btnAgregarUbicaciones.Location = new System.Drawing.Point(299, 195);
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
            this.dateTimePickerFechaEvento.Location = new System.Drawing.Point(300, 151);
            this.dateTimePickerFechaEvento.Name = "dateTimePickerFechaEvento";
            this.dateTimePickerFechaEvento.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerFechaEvento.TabIndex = 11;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(24, 151);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerFechaInicio.TabIndex = 10;
            this.dateTimePickerFechaInicio.Value = new System.DateTime(2018, 11, 17, 20, 15, 4, 0);
            // 
            // comboBoxGrado
            // 
            this.comboBoxGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrado.FormattingEnabled = true;
            this.comboBoxGrado.Location = new System.Drawing.Point(299, 93);
            this.comboBoxGrado.Name = "comboBoxGrado";
            this.comboBoxGrado.Size = new System.Drawing.Size(110, 21);
            this.comboBoxGrado.TabIndex = 9;
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(24, 93);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(114, 21);
            this.comboBoxRubro.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(299, 35);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(212, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombrePublicacion
            // 
            this.txtNombrePublicacion.Location = new System.Drawing.Point(24, 35);
            this.txtNombrePublicacion.MaxLength = 255;
            this.txtNombrePublicacion.Name = "txtNombrePublicacion";
            this.txtNombrePublicacion.Size = new System.Drawing.Size(213, 20);
            this.txtNombrePublicacion.TabIndex = 6;
            this.txtNombrePublicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePublicacion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Del Evento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha De Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnProgramarFechas
            // 
            this.btnProgramarFechas.Enabled = false;
            this.btnProgramarFechas.Location = new System.Drawing.Point(123, 195);
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
            this.checkBoxVariasFechas.Location = new System.Drawing.Point(24, 199);
            this.checkBoxVariasFechas.Name = "checkBoxVariasFechas";
            this.checkBoxVariasFechas.Size = new System.Drawing.Size(93, 17);
            this.checkBoxVariasFechas.TabIndex = 16;
            this.checkBoxVariasFechas.Text = "Varias Fechas";
            this.checkBoxVariasFechas.UseVisualStyleBackColor = true;
            this.checkBoxVariasFechas.CheckedChanged += new System.EventHandler(this.checkBoxVariasFechas_CheckedChanged);
            // 
            // FormGenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 294);
            this.Controls.Add(this.checkBoxVariasFechas);
            this.Controls.Add(this.btnProgramarFechas);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnGuardarBorrador);
            this.Controls.Add(this.btnAgregarUbicaciones);
            this.Controls.Add(this.dateTimePickerFechaEvento);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.comboBoxGrado);
            this.Controls.Add(this.comboBoxRubro);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombrePublicacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGenerarPublicacion";
            this.Text = "Generar Publicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombrePublicacion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.ComboBox comboBoxGrado;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEvento;
        private System.Windows.Forms.Button btnAgregarUbicaciones;
        private System.Windows.Forms.Button btnGuardarBorrador;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnProgramarFechas;
        private System.Windows.Forms.CheckBox checkBoxVariasFechas;
    }
}