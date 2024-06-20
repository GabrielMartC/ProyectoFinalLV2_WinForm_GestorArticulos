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
    public partial class frmPrincipal2 : Form
    {
        private List<Articulo> listaArticulos;
        public frmPrincipal2()
        {
            InitializeComponent();
        }

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {

            //al iniciar, se oculta el panel para cargar formAltaArticulo
            panelPrincipal.Visible = false; 
            

            //1ro cargarmos los elementos para el datagridview
            cargarDataGridView();

            cargarComboBoxes();

            ocultarSeccionFiltrar();

        }

        private void ocultarSeccionFiltrar()
        {
            try
            {
                btnFiltrar.Visible = false;
                btnLimpiarFiltro.Visible = false;

                lblCampo.Visible = false;
                lblCriterio.Visible = false;
                lblFiltro.Visible = false;
                lblFiltroBR.Visible = false;

                cbCampo.Visible = false;
                cbCriterio.Visible = false;
                tbFiltro.Visible = false;
                tbFiltroBR.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarComboBoxes()
        {
            try
            {
                cbCampo.Items.Add("Código");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Marca");
                cbCampo.Items.Add("Categoría");
                cbCampo.Items.Add("Precio");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarDescripcion(string descripcion)
        {
            try
            {
                tbDescripcion.Text = descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarDataGridView()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;

                Helper.CargarImagen(listaArticulos[0].ImagenUrl, pbImagenArticulo);
                cargarDescripcion(listaArticulos[0].Descripcion);

                ocultarColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        public void loadForms(object Form) //metodo para cargar form dentro de panelPrincipal
        {
            try
            {
                if (panelPrincipal.Controls.Count > 0)
                {
                    panelPrincipal.Controls.RemoveAt(0);
                }
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(f);
                panelPrincipal.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        // ----------------------------- eventos ------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                panelPrincipal.Visible = true;
                loadForms(new frmAltaArticulo());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                //loadForms(new frmListadoArticulo());
                panelPrincipal.Visible = false;

                //volver a cargar el datagridview
                cargarDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articuloSeleccionado;
                articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                panelPrincipal.Visible = true;
                loadForms(new frmAltaArticulo(articuloSeleccionado));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    Helper.CargarImagen(seleccionado.ImagenUrl, pbImagenArticulo);
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                dgvArticulos.DataSource = negocio.listarFiltroAvanzado(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbFiltroBR_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string criterio = cbCampo.SelectedItem.ToString();
            string filtro = tbFiltroBR.Text;

            try
            {
                if (filtro.Length > 1 && criterio.Equals("Código"))
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()));
                }

                else if (filtro.Length > 1 && criterio.Equals("Nombre"))
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                }

                else if (filtro.Length > 1 && criterio.Equals("Marca"))
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Marca.ToString().ToUpper().Contains(filtro.ToUpper()));
                }

                else if (filtro.Length > 1 && criterio.Equals("Precio"))
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Precio.ToString().ToUpper().Contains(filtro.ToUpper()));
                }

                else
                {
                    listaFiltrada = listaArticulos;
                }

                dgvArticulos.DataSource = null; //primero limpiamos
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                tbFiltro.Text = "";
                tbFiltroBR.Text = "";
                cbCampo.ResetText();
                cbCriterio.ResetText();

                cargarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbFiltroRapido_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnFiltrar.Visible = false;
                btnLimpiarFiltro.Visible = false;

                lblCampo.Visible = true;
                cbCampo.Visible = true;

                lblFiltroBR.Visible = true;
                tbFiltroBR.Visible = true;

                lblCriterio.Visible = false;
                cbCriterio.Visible = false;

                lblFiltro.Visible = false;
                tbFiltro.Visible = false;

                gbFiltros.Location = new System.Drawing.Point(161, 30);
                lblCampo.Location = new System.Drawing.Point(162, 80);
                cbCampo.Location = new System.Drawing.Point(204, 75);
                lblFiltroBR.Location = new System.Drawing.Point(356, 80);
                tbFiltroBR.Location = new System.Drawing.Point(387, 75);
                //agregar el resto de movimientos, ocultamiento.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnFiltrar.Visible = true;
                btnLimpiarFiltro.Visible = true;

                lblCampo.Visible = true;
                cbCampo.Visible = true;

                lblFiltroBR.Visible = false;
                tbFiltroBR.Visible = false;

                lblCriterio.Visible = true;
                cbCriterio.Visible = true;

                lblFiltro.Visible = true;
                tbFiltro.Visible = true;

                gbFiltros.Location = new System.Drawing.Point(161, 30);

                lblCampo.Location = new System.Drawing.Point(162, 80);
                cbCampo.Location = new System.Drawing.Point(204, 75);

                lblCriterio.Location = new System.Drawing.Point(350, 80);
                cbCriterio.Location = new System.Drawing.Point(387, 75);

                lblFiltro.Location = new System.Drawing.Point(524, 80);
                tbFiltro.Location = new System.Drawing.Point(555, 75);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
