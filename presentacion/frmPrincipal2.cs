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
        private Articulo articuloSeleccionado;
        private Timer timer;
        public frmPrincipal2()
        {
            InitializeComponent();

            // Configurar el Timer sstrlabelPrincipal
            timer = new Timer();
            timer.Interval = 10000; // 10000 milisegundos = 10 segundos
            timer.Tick += Timer_Tick;
        }

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {
            try
            {
                //al iniciar, se oculta el panel para cargar formAltaArticulo
                panelPrincipal.Visible = false;

                cargarDataGridView();
                cargarComboBoxes();
                ocultarSeccionFiltrar();

                articuloSeleccionado = listaArticulos[0]; //articulo seleccionado por defecto
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

                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";    //limitar decimales

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

        private bool validarFiltroAvanzado()
        {
            if (cbCampo.SelectedIndex < 0)
            {
                timer.Start();
                sstrlabelPrincipal.Text = "Por favor, seleccione un campo para filtrar";
                return true;
            }

            if (cbCriterio.SelectedIndex < 0)
            {
                timer.Start();
                sstrlabelPrincipal.Text = "Por favor, seleccione un criterio para filtrar";
                return true;
            }

            if (cbCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(tbFiltro.Text))
                {
                    timer.Start();
                    sstrlabelPrincipal.Text = "Por favor, cargue el filtro para numericos";
                    return true;
                }
            }
            return false;
        }

        private void resetearRadioButtons()
        {
            if (rbFiltroRapido.Checked == true || rbFiltroAvanzado.Checked == true)
            {
                rbFiltroRapido.Checked = false;
                rbFiltroAvanzado.Checked = false;
                gbFiltros.Location = new System.Drawing.Point(55, 52);
                ocultarSeccionFiltrar();
            }
        }

        // ----------------------------- eventos ------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                gbFiltros.Visible = false;
                ocultarSeccionFiltrar();

                panelPrincipal.Visible = true;
                loadForms(new frmAltaArticulo());

                //deshabilitar botones
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;

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
                gbFiltros.Visible = true;
                resetearRadioButtons();

                panelPrincipal.Visible = false;

                //habilitar botones
                btnAgregar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

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
                gbFiltros.Visible = false;
                ocultarSeccionFiltrar();
       
                panelPrincipal.Visible = true;
                loadForms(new frmAltaArticulo(articuloSeleccionado));

                //deshabilitar botones
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad desea eliminar "+ articuloSeleccionado.Nombre + "?","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    articuloNegocio.eliminar(articuloSeleccionado.Id);
                }

                btnEliminar.ForeColor = System.Drawing.Color.Red;
                cargarDataGridView();
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
                    articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    Helper.CargarImagen(articuloSeleccionado.ImagenUrl, pbImagenArticulo);
                    cargarDescripcion(articuloSeleccionado.Descripcion);
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
                if (opcion == "Precio") //se va a seleccionar un numero decimal
                {
                    cbCriterio.Items.Clear();
                    cbCriterio.Items.Add("Mayor a");
                    cbCriterio.Items.Add("Menor a");
                    cbCriterio.Items.Add("Igual a");

                    //habilita evento solo nro decimal
                    tbFiltro.KeyPress += new KeyPressEventHandler(Helper.permitirSoloDecimal);

                }
                else //se va a seleccionar un string (nombre o descripcion)
                {
                    cbCriterio.Items.Clear();
                    cbCriterio.Items.Add("Comenza con");
                    cbCriterio.Items.Add("Termina con");
                    cbCriterio.Items.Add("Contiene");

                    //deshabilita evento solo nro decimal
                    tbFiltro.KeyPress -= new KeyPressEventHandler(Helper.permitirSoloDecimal);
                }
                tbFiltro.Clear();

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
                if (validarFiltroAvanzado()) //retorna true si los desplegables de Campo/Criterio o tbPrecio estan vacios 
                {
                    return; 
                }

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
            string filtro = tbFiltroBR.Text;

            try
            {
                if (filtro.Length > 1)
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
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
                tbFiltro.ResetText();
                tbFiltroBR.ResetText();
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

                lblCampo.Visible = false;
                cbCampo.Visible = false;

                lblFiltroBR.Visible = true;
                tbFiltroBR.Visible = true;

                lblCriterio.Visible = false;
                cbCriterio.Visible = false;

                lblFiltro.Visible = false;
                tbFiltro.Visible = false;

                gbFiltros.Location = new System.Drawing.Point(55, 30);
                lblFiltroBR.Location = new System.Drawing.Point(55, 80);
                tbFiltroBR.Location = new System.Drawing.Point(160, 75);
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

                gbFiltros.Location = new System.Drawing.Point(55, 30);

                lblCampo.Location = new System.Drawing.Point(52, 80);
                cbCampo.Location = new System.Drawing.Point(94, 75);

                lblCriterio.Location = new System.Drawing.Point(235, 80);
                cbCriterio.Location = new System.Drawing.Point(277, 75);

                lblFiltro.Location = new System.Drawing.Point(415, 80);
                tbFiltro.Location = new System.Drawing.Point(446, 75);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Timer_Tick(object sender, EventArgs e) // limpar el texto del sstrlabelPrincipal después de 10 segundos
        {
            sstrlabelPrincipal.Text = string.Empty;
            timer.Stop();
        }

        private void btnListar_MouseEnter(object sender, EventArgs e)
        {
            btnListar.ForeColor = System.Drawing.Color.Black;
            btnListar.Image = presentacion.Properties.Resources.list_B_32;
        }

        private void btnListar_MouseLeave(object sender, EventArgs e)
        {
            btnListar.ForeColor = System.Drawing.Color.White;
            btnListar.Image = presentacion.Properties.Resources.list_W;
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = System.Drawing.Color.Black;
            btnAgregar.Image = presentacion.Properties.Resources.add_B;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = System.Drawing.Color.White;
            btnAgregar.Image = presentacion.Properties.Resources.add_W;
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.ForeColor = System.Drawing.Color.Black;
            btnModificar.Image = presentacion.Properties.Resources.edit_B;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.ForeColor = System.Drawing.Color.White;
            btnModificar.Image = presentacion.Properties.Resources.edit_W;
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 48, 49);
            btnEliminar.Image = presentacion.Properties.Resources.delete_R;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Image = presentacion.Properties.Resources.delete_W__1_;
        }

        private void btnLimpiarFiltro_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiarFiltro.ForeColor = System.Drawing.Color.Black;
        }

        private void btnLimpiarFiltro_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiarFiltro.ForeColor = System.Drawing.Color.White;
        }

        private void btnFiltrar_MouseEnter(object sender, EventArgs e)
        {
            btnFiltrar.ForeColor = System.Drawing.Color.Black;
        }

        private void btnFiltrar_MouseLeave(object sender, EventArgs e)
        {
            btnFiltrar.ForeColor = System.Drawing.Color.White;
        }
    }
}
