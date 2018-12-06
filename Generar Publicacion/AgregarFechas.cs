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
using PalcoNet.Config;

using PalcoNet.Vistas;

namespace PalcoNet.Generar_Publicacion
{
    public partial class FormAgregarFechas : CustomForm
    {
        public List<Publicacion> publicacionList;

        private Publicacion newPublicacion = new Publicacion();

        String errorMessage;


        public FormAgregarFechas(List<Publicacion> list)
        {
            InitializeComponent();
            dataGridViewFechas.AllowUserToResizeRows = false;
            dataGridViewFechas.RowHeadersVisible = false;

            newPublicacion.FechaEvento = DateTime.MinValue;

            dateTimePickerFechaEvento.Value = SystemDate.GetDate().AddDays(7);

            this.publicacionList = list;

            foreach (Publicacion p in publicacionList)
            {
                dataGridViewFechas.Rows.Add(p.FechaEvento);
            }


        }

        //Agregar fecha al datagrid
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CheckDatesOK())
            {
                newPublicacion = new Publicacion();
                newPublicacion.FechaEvento = dateTimePickerFechaEvento.Value;

                publicacionList.Add(newPublicacion);

                dataGridViewFechas.Rows.Add(newPublicacion.FechaEvento);
            }
            else
            {
                MessageBox.Show(errorMessage, "Error");
                errorMessage = String.Empty;
            }
                             

        }

        private Boolean CheckDatesOK()
        {
            int errorCount = 0;

            if (dateTimePickerFechaEvento.Value <= SystemDate.GetDate()) { errorMessage += "La Fecha de Evento no puede igual o menor a la fecha actual.\n"; errorCount++; }
            if (dateTimePickerFechaEvento.Value <= newPublicacion.FechaEvento) { errorMessage += "Las Fechas de Evento a ingresar deben ser posteriores a las últimas ingresadas.\n"; errorCount++; };

            return errorCount == 0;       
        }


        private void dataGridViewFechas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Elimina una fecha cargada al datagrid
            if (e.ColumnIndex == dataGridViewFechas.Columns.IndexOf(this.columnEliminar))
            {             
                try
                {
                    dataGridViewFechas.Rows.Remove(this.dataGridViewFechas.CurrentRow);
                }
                catch (Exception)
                {
                    return;
                }
                
                publicacionList = new List<Publicacion>();

                foreach (DataGridViewRow row in dataGridViewFechas.Rows)
                {
                    Publicacion publicacion = new Publicacion();
                    publicacion.FechaEvento = Convert.ToDateTime(row.Cells["columnFechaEvento"].Value);

                    publicacionList.Add(publicacion);
                }


                //Setear la ultima fecha de la lista para compararla con el proximo ingreso
                int lastIndex = publicacionList.Count - 1;

                if (lastIndex == -1)
                    newPublicacion.FechaEvento = DateTime.MinValue;
                else
                    newPublicacion = publicacionList[lastIndex];

            }
            
            
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.CloseThis();
        }





    }
}
