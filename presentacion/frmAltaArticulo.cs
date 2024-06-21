﻿using dominio;
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
            btnAgregar.Text = "Modificar";
            btnLimpiar.Text = "Restablecer";

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                //al iniciar...
                cargarComboBoxes();

                if (articulo != null)
                {
                    cargarDatosArticuloSeleccionado();
                }

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
                tbPrecio.Text = articulo.Precio.ToString();
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

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente!");
                }
                else
                {
                    articuloNegocio.agregarNuevo(articulo);
                    MessageBox.Show("Agregado exitosamente!");
                    
                    limpiarTodo();
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

            Helper.CargarImagen(tbUrlImagen.Text, pbImagenAlta);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            if (btnLimpiar.Text == "Limpiar Todo")
            {
                limpiarTodo();    //para INSERT

            }
            else
            {
                cargarDatosArticuloSeleccionado(); //para UPDATE
            }
        }

        
    }
}
