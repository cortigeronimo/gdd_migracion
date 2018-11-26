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
        BindingSource bindingSource = new BindingSource();
        public List<Ubicacion> Ubicaciones { get; set; }
        
        public FormGenerarPublicacion form;
        

        public FormAgregarUbicaciones(List<Ubicacion> _ubicaciones)
        {
            InitializeComponent();
            dataGridViewUbicaciones.AutoGenerateColumns = false;
            this.Ubicaciones = _ubicaciones;
            
            comboBoxTipoUbicacion.SelectedIndex = 0;
            comboBoxFila.SelectedIndex = 0;

            this.Ubicaciones.ForEach(u => bindingSource.Add(u));

            dataGridViewUbicaciones.DataSource = bindingSource;
        }
     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (FormDataOK()){
                if (NoRepeatedUbication()){

                    Ubicacion ubicacion = new Ubicacion();
                    
                    ubicacion.Fila = Convert.ToChar(comboBoxFila.SelectedItem);
                    ubicacion.Asiento = (int)numericUpDownAsiento.Value;                                      
                    ubicacion.Precio = (int)numericUpDownPrecio.Value;
                    ubicacion.Descripcion = comboBoxTipoUbicacion.SelectedItem.ToString();

                    Ubicaciones.Add(ubicacion);

                    

                    bindingSource.Add(ubicacion);
                    
                    dataGridViewUbicaciones.DataSource = bindingSource;
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
            
            if (numericUpDownPrecio.Value == 0) { errorMessage += "Complete el campo precio, debe ser distinto de 0.\n"; errorCount++; } 
                   
            return errorCount == 0;
        }

        private Boolean NoRepeatedUbication()
        {           
            Char fila = Convert.ToChar(comboBoxFila.SelectedItem);
            int asiento = (int)numericUpDownAsiento.Value;
            List<Ubicacion> list = Ubicaciones.Where(u => u.Fila == fila && u.Asiento == asiento).ToList();
            return list.Count == 0;             
        }

        private void comboBoxFila_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            
        }

        private void comboBoxTipoUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        private void dataGridViewUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUbicaciones.Columns["columnDelete"].Index && dataGridViewUbicaciones.Rows.Count != 0)
            {
                dataGridViewUbicaciones.Rows.RemoveAt(dataGridViewUbicaciones.CurrentRow.Index);


                Ubicaciones = new List<Ubicacion>();

                foreach (DataGridViewRow row in dataGridViewUbicaciones.Rows)
                {
                    Ubicacion ubicacion = new Ubicacion();
                    ubicacion.Asiento = Convert.ToInt32(row.Cells["columnAsiento"].Value);
                    ubicacion.Fila = Convert.ToChar(row.Cells["columnFila"].Value);
                    ubicacion.Precio = Convert.ToInt32(row.Cells["columnPrecio"].Value);
                    ubicacion.Descripcion = Convert.ToString(row.Cells["columnDescripcion"].Value);


                    Ubicaciones.Add(ubicacion);
                }



                bindingSource = new BindingSource();
                Ubicaciones.ForEach(u => bindingSource.Add(u));

            }
            else
            {
                MessageBox.Show("No hay ubicaciones a eliminar");
            }
        }

        

        

        

    }
}
