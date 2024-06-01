using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //1ro cargarmos los elementos para el datagridview
            cargarDataGridView();

            cargarImagen(listaArticulos[0].ImagenUrl);
            cargarDescripcion(listaArticulos[0].Descripcion);

            cargarComboBoxes();

        }

        private void cargarDataGridView() //cargamos el dgvArticulos
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;

                ocultarColumnas();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenArticulo.Load(imagen);
                pbImagenArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception) //preguntar si se puede usar un repositorio propio de imagenes...
            {
                pbImagenArticulo.Load("https://www.peacemakersnetwork.org/wp-content/uploads/2019/09/placeholder.jpg");
                pbImagenArticulo.SizeMode = PictureBoxSizeMode.CenterImage;
            }

        }

        private void cargarDescripcion(string descripcion) //cargar descripcion al textBox
        {
            try
            {
                tbDescripcion.Text = descripcion;
                //tbDescripcion.Text = listaArticulos[0].Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cargarComboBoxes()
        {
            cbCampo.Items.Add("Código");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoría");
            cbCampo.Items.Add("Precio");

        }

        private void ocultarColumnas()
        {
            try
            {
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    cargarImagen(seleccionado.ImagenUrl);
                    cargarDescripcion(seleccionado.Descripcion);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if (opcion == "Precio") //se va a seleccionar un numero
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
            }
            else //se va a seleccionar un string (nombre o descripcion)
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comenza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                //if (validarFiltro()) //retorna un bool segun si los desplegables de Campo y Criterio esten vacios o no
                //{
                //    return; //return para detener la ejecucion
                //}

                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = tbFiltro.Text;
                dgvArticulos.DataSource = negocio.filtroAvanzado(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void tbDescripcion_TextChanged(object sender, EventArgs e) 
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
