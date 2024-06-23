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

        public static bool SoloNumeros(string text) //validacion solo numeros
        {
            foreach (char caracter in text)
            {
                if (!(char.IsNumber(caracter))) //si NO es numero...
                {
                    return false;
                }

            }
            return true;
        }

        public static bool ValidacionAltaArticulo(TextBox codigo, TextBox nombre, TextBox precio)
        {
            if (string.IsNullOrEmpty(codigo.Text) || string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(precio.Text))
            {
                return true; //algunos de los textBox estan vacios
            }
            return false;
        }
    }
}
