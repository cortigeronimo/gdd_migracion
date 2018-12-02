using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PalcoNet.Vistas
{
    public class CustomForm : Form
    {

        //public CustomForm()
        //{
        //    InitializeComponent();
        //    InitializeElements();
        //}

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            FormManager.GetInstance().CloseForm(this);
        }

        //protected abstract void InitializeElements();

        //protected virtual void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    this.ClientSize = new System.Drawing.Size(300, 400);
        //    this.Name = "CustomForm";
        //    this.Load += new System.EventHandler(this.CustomForm_Load);
        //    this.ResumeLayout(false);

        //}

        //protected Button DefaultButton()
        //{
        //    Button button = new Button();
        //    button.Font = new Font("Microsoft Sant Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //    button.ImageAlign = ContentAlignment.TopCenter;
        //    button.Location = new Point(0, 0);
        //    button.Name = "Default Name, Change Please";
        //    button.Size = new Size(84, 27);
        //    button.TabIndex = 0;
        //    button.Text = "Default Text, Change Please";
        //    //button.UseVisualStyleBackColor = true;
        //    return button;
        //}

        //protected Label DefaultLabel()
        //{
        //    Label label = new Label();
        //    label.AutoSize = true;
        //    label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //    label.Location = new Point(0, 0);
        //    label.Name = "Default Name, Change Please";
        //    label.Size = new Size(100, 17);
        //    label.Text = "Default Text";
        //    return label;
        //}

        //protected TextBox DefaultTextBox()
        //{
        //    TextBox textBox = new TextBox();
        //    textBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //    textBox.Location = new Point(0, 0);
        //    textBox.Name = "Default Name, Change Please";
        //    textBox.Size = new Size(73, 17);
        //    return textBox;
        //}

        //protected LinkLabel DefaultLinkLabel()
        //{
        //    LinkLabel linkLabel = new LinkLabel();
        //    linkLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //    linkLabel.Location = new Point(0, 0);
        //    linkLabel.Name = "Default Name, Change Please";
        //    linkLabel.Size = new Size(133, 23);
        //    linkLabel.Text = "Default Text, Change Please";
        //    return linkLabel;
        //}

        //protected NumericUpDown DefaultNumericUpDown()
        //{
        //    NumericUpDown number = new NumericUpDown();
        //    number.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //    number.Location = new Point(0, 0);
        //    number.Name = "Default Name, Change Please";
        //    number.Size = new Size(133, 23);
        //    return number;
        //}

        //private void CustomForm_Load(object sender, EventArgs e)
        //{

        //}
    }
}
