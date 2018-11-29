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
using PalcoNet.Utils;
using PalcoNet.Modelo;
using PalcoNet.Repositorios;
using PalcoNet.DTO;
using PalcoNet.Config;

namespace PalcoNet.Comprar
{
    public partial class FormComprar : CustomForm
    {
        private Page<PublicacionDTO> page;
        private const int sizePage = 20;

        private RepoPublicacion repoPublicacion = new RepoPublicacion();
        private RepoRubro repoRubro = new RepoRubro();

        private List<String> allRubros;
        public List<String> selectedRubros = new List<String>();

        public FormComprar()
        {
            InitializeComponent();
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            dataGridViewPublicaciones.RowHeadersVisible = false;
            dataGridViewPublicaciones.AllowUserToResizeRows = false;

            InitDateTimePickers();
            SetRubros();

            InitPagination();
            LoadDataGridViewPublicaciones();
        }

        private void InitDateTimePickers()
        {
            checkBoxRangoFecha.Checked = false;
            dateTimePickerFechaDesde.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaDesde.CustomFormat = " ";
            dateTimePickerFechaDesde.Value = DateTime.Parse("1890-01-01 00:00");
            dateTimePickerFechaHasta.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaHasta.CustomFormat = " ";
            dateTimePickerFechaHasta.Value = DateTime.Parse("2500-01-01 00:00");
        }

        private void InitPagination()
        {          
            List<PublicacionDTO> publicaciones = repoPublicacion.GetPublicacionesActivas();
            BuildPagination(publicaciones); 
        }


        private void BuildPagination(List<PublicacionDTO> publicaciones)
        {
            int totalPublicaciones = publicaciones.Count;
            decimal totalPage = Math.Ceiling((decimal)totalPublicaciones / sizePage);

            txtActualPage.Text = "1";
            txtTotalPage.Text = totalPage.ToString();


            page = new Page<PublicacionDTO>((int)totalPage, 1, publicaciones, sizePage);
        }

        private void LoadDataGridViewPublicaciones()
        {
            
            dataGridViewPublicaciones.Rows.Clear();

            List<PublicacionDTO> publicacionesPage = page.GetDataPage();
            BindingSource binding = new BindingSource(publicacionesPage, null);
            dataGridViewPublicaciones.DataSource = binding;
            
            
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            page.ActualPage = 1;
            txtActualPage.Text = page.ActualPage.ToString();

            LoadDataGridViewPublicaciones();
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            txtActualPage.Text = page.backPage().ToString();

            LoadDataGridViewPublicaciones();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            txtActualPage.Text = page.nextPage().ToString();

            LoadDataGridViewPublicaciones();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            page.ActualPage = page.TotalPage;
            txtActualPage.Text = page.ActualPage.ToString();

            LoadDataGridViewPublicaciones();
        }

        private void SetRubros()
        {
            allRubros = repoRubro.GetRubrosDescripcion();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {

            using(FormAddRubros form = new FormAddRubros(allRubros))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (!selectedRubros.Contains(form.selectedRubro))
                    {
                        selectedRubros.Add(form.selectedRubro);
                        txtCategorias.Text += form.selectedRubro + ", ";
                    }
                    
                }

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            selectedRubros = new List<String>();
            txtCategorias.Clear();
            txtDescripcion.Clear();

            InitDateTimePickers();

            InitPagination();
            LoadDataGridViewPublicaciones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
            List<PublicacionDTO> publicaciones = new List<PublicacionDTO>();

            publicaciones = repoPublicacion.GetPublicacionesByFilter(selectedRubros, dateTimePickerFechaDesde.Value, dateTimePickerFechaHasta.Value, txtDescripcion.Text);

            BuildPagination(publicaciones);

            LoadDataGridViewPublicaciones();

        }


        private void checkBoxRangoFecha_CheckedChanged(object sender, EventArgs e)
        {         
            if (checkBoxRangoFecha.Checked)
            {
                dateTimePickerFechaDesde.Enabled = true;
                dateTimePickerFechaHasta.Enabled = true;
                dateTimePickerFechaDesde.Format = DateTimePickerFormat.Custom;
                dateTimePickerFechaDesde.CustomFormat = "yyyy-MM-dd HH:mm";
                dateTimePickerFechaDesde.Value = SystemDate.GetDate();
                dateTimePickerFechaHasta.Format = DateTimePickerFormat.Custom;
                dateTimePickerFechaHasta.CustomFormat = "yyyy-MM-dd HH:mm";
                dateTimePickerFechaHasta.Value = SystemDate.GetDate().AddDays(7);
            }
            else
            {
                dateTimePickerFechaDesde.Enabled = false;
                dateTimePickerFechaHasta.Enabled = false;
                dateTimePickerFechaDesde.Format = DateTimePickerFormat.Custom;
                dateTimePickerFechaDesde.CustomFormat = " ";
                dateTimePickerFechaDesde.Value = DateTime.Parse("1890-01-01 00:00");
                dateTimePickerFechaHasta.Format = DateTimePickerFormat.Custom;
                dateTimePickerFechaHasta.CustomFormat = " ";
                dateTimePickerFechaHasta.Value = DateTime.Parse("2500-01-01 00:00");
                
            }
        }


        private void dataGridViewPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPublicaciones.Columns["columnComprar"].Index)
            {
                PublicacionDTO publicacion = (PublicacionDTO)dataGridViewPublicaciones.CurrentRow.DataBoundItem;

                List<Ubicacion> ubicacionesDisponibles = new RepoUbicacion().GetUbicacionesDisponibles(publicacion.Codigo);

                using (FormComprarUbicaciones form = new FormComprarUbicaciones(ubicacionesDisponibles))
                {
                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        InitPagination();
                        LoadDataGridViewPublicaciones();
                    }
                }

            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDescripcion.Text == String.Empty && Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }
    }
}
