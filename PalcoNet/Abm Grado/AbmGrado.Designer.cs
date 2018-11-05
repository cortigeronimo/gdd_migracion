using System.Windows.Forms;
using PalcoNet.Utils;
using System;
using PalcoNet.Repositorios;

namespace PalcoNet.Abm_Grado
{
    partial class AbmGrado
    {
        private Label lblComision;
        private NumericUpDown numComision;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        protected override void InitializeElements()
        {
            lblComision = DefaultLabel();
            lblComision.Text = "Ingrese la comision a dar de alta";
            lblComision.Location = ElementManager.CenterWidthAndSetHeight(
                Width, 10, lblComision.Width, lblComision.Height);

            numComision = DefaultNumericUpDown();
            numComision.Location = ElementManager.CenterWidthAndSetHeight(
                Width, 30, numComision.Width, numComision.Height);


            lblDescripcion = DefaultLabel();
            lblDescripcion.Text = "Ingrese la descripcion a dar de alta";
            lblDescripcion.Location = ElementManager.CenterWidthAndSetHeight(
                Width, 50, lblDescripcion.Width, lblDescripcion.Height);

            txtDescripcion = DefaultTextBox();
            txtDescripcion.Location = ElementManager.CenterWidthAndSetHeight(
                Width, 70, txtDescripcion.Width, txtDescripcion.Height);

            btnGuardar = DefaultButton();
            btnGuardar.Location = ElementManager.CenterWidthAndSetHeight(
                Width, 90, btnGuardar.Width, btnGuardar.Height);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;

            Controls.Add(lblComision);
            Controls.Add(numComision);
            Controls.Add(btnGuardar);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RepoGradoPublicacion repo = new RepoGradoPublicacion();
            Grado grado = new Grado((int)numComision.Value, txtDescripcion.Text);
            repo.InsertGrado(grado);
            MessageBox.Show("Todo ok perro");
        }

        
    }
}