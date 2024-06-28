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
            catch (Exception) 
            {
                pictureBox.Load("https://raw.githubusercontent.com/GabrielMartC/ProyectoFinalLV2_WinForm_GestorArticulos/main/images/placeholder.png");
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

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
