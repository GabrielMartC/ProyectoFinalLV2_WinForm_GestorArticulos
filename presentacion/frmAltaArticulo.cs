using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private Timer timer;

        public frmAltaArticulo() //AGREGAR
        {
            InitializeComponent();

        }

        public frmAltaArticulo(Articulo articulo) //MODIFICAR
        {
            InitializeComponent();

            this.articulo = articulo; //articulo no es null
            lblTitulo.Text = "Modificar Articulo";
            btnAgregar.Text = "Modificar";
            btnLimpiar.Text = "Restablecer";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                // Configurar el Timer para sstrlabelPrincipal
                timer = new Timer();
                timer.Interval = 10000; // 10000 milisegundos = 10 segundos
                timer.Tick += Timer_Tick;

                cargarComboBoxes();

                if (articulo != null)
                {
                    cargarDatosArticuloSeleccionado();
                }

                //permitir solo nro decimal en tbPrecio
                tbPrecio.KeyPress += new KeyPressEventHandler(Helper.permitirSoloDecimal);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void cargarDatosArticuloSeleccionado()
        {
            try
            {
                tbCodigo.Text = articulo.Codigo;
                tbNombre.Text = articulo.Nombre;
                tbUrlImagen.Text = articulo.ImagenUrl;
                cbMarca.SelectedValue = articulo.Marca.Id;
                cbCategoria.SelectedValue = articulo.Categoria.Id;
                tbPrecio.Text = articulo.Precio.ToString("0.00"); //limita decimales
                tbDescripcion.Text = articulo.Descripcion;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void limpiarTodo()
        {
            tbCodigo.ResetText();
            tbNombre.ResetText();
            tbUrlImagen.ResetText();
            cbMarca.ResetText();
            cbCategoria.ResetText();
            tbPrecio.ResetText();
            tbDescripcion.ResetText();

        }

        private void cargarComboBoxes()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // ----------------------------- eventos ------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                {
                    this.articulo = new Articulo();
                }

                articulo.Codigo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.ImagenUrl = tbUrlImagen.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(tbPrecio.Text);
                articulo.Descripcion = tbDescripcion.Text;

                //valida que el Art cuente con: Codigo, Marca y Precio
                if(Helper.ValidacionAltaArticulo(tbCodigo, tbNombre, tbPrecio))
                {
                    timer.Start(); //muestra texto por 10 seg
                    sstrlabelPrincipal.Text = "No se puede agregar o modificar un articulo sin: Codigo, Nombre o Precio";
                    return; 
                }

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    timer.Start();
                    sstrlabelPrincipal.Text = "Modificado exitosamente!";
                }
                else
                {
                    articuloNegocio.agregarNuevo(articulo);
                    timer.Start();
                    sstrlabelPrincipal.Text = "Agregado exitosamente!";

                    limpiarTodo();
                }
            }
            catch (Exception ex)
            {
                if (ex is System.FormatException) //si Precio esta vacio o no es un nro
                {
                    timer.Start();
                    sstrlabelPrincipal.Text = "No se puede agregar o modificar un articulo sin: Codigo, Nombre o Precio";
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            Helper.CargarImagen(tbUrlImagen.Text, pbImagenAlta);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {           
            if (btnLimpiar.Text == "Limpiar Todo")
            {
                limpiarTodo();  //para INSERT
            }
            else
            {
                cargarDatosArticuloSeleccionado();  //para UPDATE
            }
        }

        private void Timer_Tick(object sender, EventArgs e) // limpar el texto del sstrlabelPrincipal después de 10 segundos
        {
            sstrlabelPrincipal.Text = string.Empty;
            timer.Stop();
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = System.Drawing.Color.Black;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = System.Drawing.Color.Orange;
        }

        private void btnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = System.Drawing.Color.Black;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = System.Drawing.Color.White;
        }
    }
}
