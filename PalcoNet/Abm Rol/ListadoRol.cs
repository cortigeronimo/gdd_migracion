using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Vistas;
using PalcoNet.Modelo;
using PalcoNet.Repositorios;

namespace PalcoNet.Abm_Rol
{
    public partial class ListadoRol : CustomForm
    {
        private BindingSource bindingSource = new BindingSource();
        List<Rol> rolesFiltrados = new List<Rol>();
        Rol elegido;

        public ListadoRol()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            comboBox1.Text = "Sí";
            Console.WriteLine(textBox1.Text);
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Seleccionar
            using (ListadoFuncionalidades form = new ListadoFuncionalidades())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Funcionalidad val = form.Elegida;
                    textBox2.Text = val.Nombre;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Buscar
            bindingSource.Clear();
            rolesFiltrados = new RepoRol().GetRolesByFilter(textBox1.Text, (comboBox1.Text == "Sí" ? true : false), textBox2.Text);
            rolesFiltrados.ForEach(rol => bindingSource.Add(rol));
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Seleccionar"].Index)
            {
                string nombre = (string)dataGridView1.CurrentRow.Cells[1].Value;
                bool habilitado = (bool)dataGridView1.CurrentRow.Cells[2].Value;
                using (ModificarRol form = new ModificarRol(nombre,habilitado ? "Sí" : "No"))
                {
                    DialogResult result = form.ShowDialog();
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                Console.WriteLine("Eliminaste el registro amiguero");
            }
        }
    }
}
