using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;


namespace negocio
{
    public static class Helper
    {
        public static void CargarImagen(string imagen, PictureBox pictureBox)
        {
            try
            {
                pictureBox.Load(imagen);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception) //preguntar si se puede usar un repositorio propio de imagenes...
            {
                pictureBox.Load("https://www.peacemakersnetwork.org/wp-content/uploads/2019/09/placeholder.jpg");
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        //public static void ValidarCriterioFiltroAvanzado(DataGridView listadoArticulos)
        //{

        //}

        //public static bool SoloDecimal(string text) //validacion solo numeros
        //{
        //    foreach (char caracter in text)
        //    {
        //        if (!(char.IsNumber(caracter)) || !(caracter.Equals('.'))) //si NO es numero...
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}

        public static bool ValidacionAltaArticulo(TextBox codigo, TextBox nombre, TextBox precio)
        {
            if (string.IsNullOrEmpty(codigo.Text) || string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(precio.Text))
            {
                return true; //algunos de los textBox estan vacios
            }
            return false;
        }

        public static void permitirSoloDecimal(object sender, KeyPressEventArgs e)
        //evento que solo permite ingreso de numeros y un "." para separar decimal
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
