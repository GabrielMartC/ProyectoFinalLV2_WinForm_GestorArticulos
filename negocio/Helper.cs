using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

    }
}
