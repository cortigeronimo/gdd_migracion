using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Utils;

namespace PalcoNet.Historial_Cliente
{
    public partial class HistorialCliente : Form
    {
        private Page page;

        public HistorialCliente()
        {
            InitializeComponent();
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            this.dataGridHistorialCliente.AllowUserToResizeColumns = false;
            this.dataGridHistorialCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorialCliente.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridHistorialCliente.MultiSelect = false;
            this.dataGridHistorialCliente.RowHeadersVisible = false;
            this.dataGridHistorialCliente.AutoGenerateColumns = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            page.nextPage();
        }

    }
}
