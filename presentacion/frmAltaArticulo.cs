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

        public frmAltaArticulo() //AGREGAR
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo) //MODIFICAR
        {
            InitializeComponent();
            this.articulo = articulo; //articulo no es null
            lblTitulo.Text = "Modificar Articulo";

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            //al iniciar...

            cargarComboBoxes();
        }

        private void cargarComboBoxes()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            //para cargar los cbMarca / cbCategoria
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

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

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente!");
                }
                else
                {
                    negocio.agregarNuevo(articulo);
                    MessageBox.Show("Agregado exitosamente!");

                }

                //this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            //cargarImagen(); //si lo vuelvo a copiar, el metodo va a estar repetido...
            //intentar reutilizar el ya creado, o una clase helper
            Helper.CargarImagen(tbUrlImagen.Text, pbImagenAlta);
        }
    }
}
