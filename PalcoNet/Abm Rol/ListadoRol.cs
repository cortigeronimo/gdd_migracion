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
            dataGridRoles.AutoGenerateColumns = false;
            comboBoxHabilitado.Text = "Sí";
            Console.WriteLine(txtNombre.Text);
        }

        private void ListadoRol_Load(object sender, EventArgs e)
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
                    txtFuncionalidad.Text = val.Nombre;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txtNombre.Text);
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxHabilitado.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txtFuncionalidad.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Buscar
            bindingSource.Clear();
            rolesFiltrados = new RepoRol().GetRolesByFilter(txtNombre.Text, (comboBoxHabilitado.Text == "Sí" ? true : false), txtFuncionalidad.Text);
            rolesFiltrados.ForEach(rol => bindingSource.Add(rol));
            dataGridRoles.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridRoles.Columns["Seleccionar"].Index)
            {
                string nombre = (string)dataGridRoles.CurrentRow.Cells[1].Value;
                bool habilitado = (bool)dataGridRoles.CurrentRow.Cells[2].Value;
                using (ModificarRol form = new ModificarRol(nombre,habilitado ? "Sí" : "No"))
                {
                    DialogResult result = form.ShowDialog();
                }
            }
            if (e.ColumnIndex == dataGridRoles.Columns["Eliminar"].Index)
            {
                Console.WriteLine("Eliminaste el registro amiguero");
            }
        }
    }
}
