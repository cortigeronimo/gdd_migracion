using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PalcoNet.Modelo;

using PalcoNet.Vistas;

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormAgregarFechas : CustomForm
    {
        public List<Publicacion> publicacionList;

        private Publicacion newPublicacion = new Publicacion();

        String errorMessage = "Error:\n";

        public FormAgregarFechas(List<Publicacion> list)
        {
            InitializeComponent();

            newPublicacion.FechaInicio = DateTime.MinValue;
            newPublicacion.FechaEvento = DateTime.MinValue;

            this.publicacionList = list;

            foreach (Publicacion p in publicacionList)
            {
                dataGridViewFechas.Rows.Add(p.FechaInicio, p.FechaEvento);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CheckDatesOK())
            {
                newPublicacion = new Publicacion();
                newPublicacion.FechaInicio = dateTimePickerFechaInicio.Value;
                newPublicacion.FechaEvento = dateTimePickerFechaEvento.Value;

                publicacionList.Add(newPublicacion);

                dataGridViewFechas.Rows.Add(newPublicacion.FechaInicio, newPublicacion.FechaEvento);
            }
            else
            {
                MessageBox.Show(errorMessage);
                errorMessage = "Error:\n";
            }
                             

        }

        private Boolean CheckDatesOK()
        {
            int errorCount = 0;

            if (dateTimePickerFechaEvento.Value == dateTimePickerFechaInicio.Value) { errorMessage += "La fecha evento debe ser posterior a la fecha inicio.\n"; errorCount++; };
            if (dateTimePickerFechaInicio.Value <= newPublicacion.FechaInicio || dateTimePickerFechaEvento.Value <= newPublicacion.FechaEvento) { errorMessage += "Las fechas a ingresar deben ser posteriores a las ultimas ingresadas.\n"; errorCount++; };

            return errorCount == 0;       
        }


        private void dataGridViewFechas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFechas.Columns["columnEliminar"].Index && dataGridViewFechas.Rows.Count != 0)
            {
                dataGridViewFechas.Rows.RemoveAt(dataGridViewFechas.CurrentRow.Index);


                publicacionList = new List<Publicacion>();

                foreach (DataGridViewRow row in dataGridViewFechas.Rows)
                {
                    Publicacion publicacion = new Publicacion();
                    publicacion.FechaInicio = Convert.ToDateTime(row.Cells["columnFechaInicio"].Value);
                    publicacion.FechaEvento = Convert.ToDateTime(row.Cells["columnFechaEvento"].Value);

                    publicacionList.Add(publicacion);
                }


                //setear el ultimo par de fechas de la lista para compararlos con el proximo ingreso
                int lastIndex = publicacionList.Count - 1;

                if (lastIndex == -1)
                {
                    newPublicacion.FechaInicio = DateTime.MinValue;
                    newPublicacion.FechaEvento = DateTime.MinValue;
                }
                else
                {
                    newPublicacion = publicacionList[lastIndex];
                }


            }
            else
            {
                MessageBox.Show("No hay filas a eliminar");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }





    }
}
