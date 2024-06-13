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
        public frmPrincipal2()
        {
            InitializeComponent();
        }

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {
            loadForms(new frmListadoArticulo());

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            loadForms(new frmAltaArticulo());
            //cargarDataGridView();
            


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            loadForms(new frmListadoArticulo());
        }
    }
}
