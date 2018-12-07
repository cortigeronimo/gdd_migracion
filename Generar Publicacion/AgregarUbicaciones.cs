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
        String errorMessage = String.Empty;
        BindingSource bindingSource = new BindingSource();
        public List<Ubicacion> Ubicaciones { get; set; }
        
        public FormGenerarPublicacion form;
        

        //Recibe como parámetro las ubicaciones del espectáculo a editar
        public FormAgregarUbicaciones(List<Ubicacion> _ubicaciones)
        {
            InitializeComponent();
            dataGridViewUbicaciones.AutoGenerateColumns = false;
            dataGridViewUbicaciones.RowHeadersVisible = false;
            dataGridViewUbicaciones.AllowUserToResizeRows = false;

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

                    UpAsientoNumber();
                }
                else{
                    MessageBox.Show("La Ubicación ya existe en la lista.", "Error");
                }


            }
            else{
                MessageBox.Show(errorMessage, "Error");
                errorMessage = String.Empty;        
            }
        }

        private void UpAsientoNumber()
        {
            if(numericUpDownAsiento.Value < numericUpDownAsiento.Maximum)
                numericUpDownAsiento.Value++;            
        }

        private void btnConfirmarSeleccion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.CloseThis();
            
        }


        private Boolean FormDataOK()
        {
            int errorCount = 0;
            
            if (numericUpDownPrecio.Value == 0) { errorMessage += "Complete el campo Precio, debe ser distinto de 0.\n"; errorCount++; } 
                   
            return errorCount == 0;
        }

        //Verifica las filas y asientos ingresados
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
                try
                {
                    dataGridViewUbicaciones.Rows.RemoveAt(dataGridViewUbicaciones.CurrentRow.Index);
                }
                catch (Exception)
                {
                    return;
                }

                FromDataGridToList();        

            }
           
        }

        private void comboBoxFila_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownAsiento.Value = 1;
        }


        //Cargar la lista con datos del datagrid
        private void FromDataGridToList()
        {
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


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Desea eliminar las Ubicaciones actuales del evento?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                dataGridViewUbicaciones.Rows.Clear();
                FromDataGridToList();
            }
                
        }

        

        

        

    }
}
