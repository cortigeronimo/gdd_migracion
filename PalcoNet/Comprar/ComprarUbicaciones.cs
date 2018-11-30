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
using PalcoNet.Utils;
using PalcoNet.Config;

namespace PalcoNet.Comprar
{
    public partial class FormComprarUbicaciones : CustomForm
    {
        private List<Ubicacion> ubicacionesDisponibles;
        private List<Ubicacion> ubicacionesAComprar = new List<Ubicacion>();
        private RepoCliente repoCliente = new RepoCliente();

        private RepoCompra repoCompra = new RepoCompra();

        private int importeTotal = 0;
        private String medioDePago;
        private String compraEmail;

        public FormComprarUbicaciones(List<Ubicacion> ubicaciones)
        {
            InitializeComponent();
            dataGridViewUbicacionesDisponibles.MultiSelect = false;
            dataGridViewUbicacionesDisponibles.AllowUserToResizeRows = false;
            
            dataGridViewUbicacionesDisponibles.RowHeadersVisible = false;
            dataGridViewUbicacionesAComprar.MultiSelect = false;
            dataGridViewUbicacionesAComprar.AllowUserToResizeRows = false;
            
            dataGridViewUbicacionesAComprar.RowHeadersVisible = false;

            this.ubicacionesDisponibles = ubicaciones;
        }

        private void FormComprarUbicaciones_Load(object sender, EventArgs e)
        {
            SetUbicacionesDisponibles(ubicacionesDisponibles);
            labelImporteTotal.Text += " $ " + importeTotal.ToString();
        }

        private void SetUbicacionesDisponibles(List<Ubicacion> ubicacionesList)
        {
            BindingSource binding = new BindingSource(ubicacionesList, null);
            dataGridViewUbicacionesDisponibles.DataSource = binding;
        }

        private void SetUbicacionesAComprar(List<Ubicacion> ubicacionesList)
        {
            BindingSource binding = new BindingSource(ubicacionesList, null);
            dataGridViewUbicacionesAComprar.DataSource = binding;
        }


        private void dataGridViewUbicacionesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUbicacionesDisponibles.Columns["columnAgregarItem"].Index)
            {
                Ubicacion ubicacion = (Ubicacion)dataGridViewUbicacionesDisponibles.CurrentRow.DataBoundItem;

                importeTotal += Convert.ToInt32(ubicacion.Precio);
                labelImporteTotal.Text = "IMPORTE TOTAL: $ " + importeTotal.ToString();

                ubicacionesDisponibles.Remove(ubicacion);
                ubicacionesAComprar.Add(ubicacion);
                SetUbicacionesDisponibles(ubicacionesDisponibles);
                SetUbicacionesAComprar(ubicacionesAComprar);        
            }
            
        }

        

        private void dataGridViewUbicacionesAComprar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUbicacionesAComprar.Columns["columnEliminarItem"].Index)
            {
                Ubicacion ubicacion = (Ubicacion)dataGridViewUbicacionesAComprar.CurrentRow.DataBoundItem;

                importeTotal -= Convert.ToInt32(ubicacion.Precio);
                labelImporteTotal.Text = "IMPORTE TOTAL: $ " + importeTotal.ToString(); 

                ubicacionesAComprar.Remove(ubicacion);
                ubicacionesDisponibles.Add(ubicacion);
                SetUbicacionesAComprar(ubicacionesAComprar);
                SetUbicacionesDisponibles(ubicacionesDisponibles);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ubicacionesAComprar.Count == 0)
            {
                MessageBox.Show("Agregue las ubicaciones que desee adquirir.", "Error");
                return;
            }
            
            using (FormMediosDePago form = new FormMediosDePago())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    medioDePago = form.medioDePago;
                    compraEmail = form.compraEmail;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (!HasCreditCard())
            {              
                using (FormAgregarTarjetaCredito form = new FormAgregarTarjetaCredito())
                {
                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.Cancel) return;
                }                       
            }

            ExecuteCompra();
           

        }

        private void ExecuteCompra()
        {
            var confirmResult = MessageBox.Show("¿Desea realizar la compra de las ubicaciones seleccionadas?", "Confirmar Compra", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    repoCompra.GenerateCompras(ubicacionesAComprar, UserSession.UserId, medioDePago, compraEmail);
                    MessageBox.Show("La compra se realizó correctamente.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error, inténtelo nuevamente.");
                }

            }
            else
            {
                return;
            }
        }


        private Boolean HasCreditCard()
        {
            return repoCliente.HasCreditCard(UserSession.UserId);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

       


    }
}
