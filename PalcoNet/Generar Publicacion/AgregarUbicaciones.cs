using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PalcoNet.Repositorios;
using PalcoNet.Vistas;
using PalcoNet.Modelo;

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormAgregarUbicaciones : CustomForm
    {
        String errorMessage = "Error:\n";
        //BindingSource bindingSource = new BindingSource();
        public List<Ubicacion> Ubicaciones { get; set; }
        public FormGenerarPublicacion form;
        

        public FormAgregarUbicaciones(List<Ubicacion> _ubicaciones)
        {
            InitializeComponent();
            dataGridViewUbicaciones.AutoGenerateColumns = false;
            this.Ubicaciones = _ubicaciones;
            
            comboBoxTipoUbicacion.SelectedIndex = 0;
            dataGridViewUbicaciones.DataSource = this.Ubicaciones;
        }
     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (FormDataOK()){
                if (NoRepeatedUbication()){
                    Ubicacion ubicacion = new Ubicacion();
                    if (checkBoxUbicacionSinNumerar.Checked){
                        ubicacion.Fila = char.MinValue;
                        ubicacion.Asiento = 0;
                        ubicacion.SinNumerar = true;
                    }
                    else{
                        ubicacion.Fila = Convert.ToChar(comboBoxFila.SelectedItem);
                        ubicacion.Asiento = (int)numericUpDownAsiento.Value;
                        ubicacion.SinNumerar = false;
                    }

                    ubicacion.Precio = (int)numericUpDownPrecio.Value;
                    ubicacion.Descripcion = comboBoxTipoUbicacion.SelectedItem.ToString();

                    Ubicaciones.Add(ubicacion);

                    //bindingSource.DataSource = Ubicaciones;

                    dataGridViewUbicaciones.DataSource = null;
                    dataGridViewUbicaciones.DataSource = Ubicaciones;
                }
                else{
                    MessageBox.Show("Error, la ubicación ya existe en la lista.");
                }


            }
            else{
                MessageBox.Show(errorMessage);
                errorMessage = "Error:\n";        
            }
        }

        private void btnConfirmarSeleccion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }


        private Boolean FormDataOK()
        {
            int errorCount = 0;
            if (checkBoxUbicacionSinNumerar.Checked)
            {
                if (comboBoxTipoUbicacion.SelectedItem == null) { errorMessage += "Complete el campo tipo ubicacion.\n"; errorCount++; }
                if (numericUpDownPrecio.Value == 0) { errorMessage += "Complete el campo precio, debe ser distinto de 0.\n"; errorCount++; }
            }
            else
            {
                if (comboBoxFila.SelectedItem == null) { errorMessage += "Complete el campo fila.\n"; errorCount++; }
                if (numericUpDownAsiento.Value == 0) { errorMessage += "Complete el campo asiento, debe ser distinto de 0.\n"; errorCount++; }
                if (comboBoxTipoUbicacion.SelectedItem == null) { errorMessage += "Complete el campo tipo ubicacion.\n"; errorCount++; }
                if (numericUpDownPrecio.Value == 0) { errorMessage += "Complete el campo precio, debe ser distinto de 0.\n"; errorCount++; }
            }
                   
            return errorCount == 0;
        }

        private Boolean NoRepeatedUbication()
        {
            if (checkBoxUbicacionSinNumerar.Checked)
            {
                return true;
            }
            else
            {
                Char fila = Convert.ToChar(comboBoxFila.SelectedItem);
                int asiento = (int)numericUpDownAsiento.Value;
                List<Ubicacion> list = Ubicaciones.Where(u => u.Fila == fila && u.Asiento == asiento).ToList();
                return list.Count == 0;
            }
            
        }

        private void comboBoxFila_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            
        }

        private void comboBoxTipoUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void checkBoxUbicacionSinNumerar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUbicacionSinNumerar.Checked)
            {
                comboBoxFila.Enabled = false;
                numericUpDownAsiento.Enabled = false;
            }
            else
            {
                comboBoxFila.Enabled = true;
                numericUpDownAsiento.Enabled = true;
            }
            
        }

        private void dataGridViewUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUbicaciones.Columns["columnDelete"].Index)
            {             
                dataGridViewUbicaciones.Rows.RemoveAt(dataGridViewUbicaciones.CurrentRow.Index);

                Ubicaciones = new List<Ubicacion>();

                foreach (DataGridViewRow row in dataGridViewUbicaciones.Rows)
                {
                    Ubicacion ubicacion = new Ubicacion();
                    ubicacion.Asiento = (int)row.Cells["columnAsiento"].Value;
                    ubicacion.Fila = Convert.ToChar(row.Cells["columnFila"].Value);
                    ubicacion.Precio = (float)row.Cells["columnPrecio"].Value;
                    ubicacion.Descripcion = row.Cells["columnDescripcion"].Value.ToString();
                    ubicacion.SinNumerar = (Boolean)row.Cells["columnSinNumerar"].Value;

                    Ubicaciones.Add(ubicacion);                 
                }

            }
        }

        

        

        

    }
}
