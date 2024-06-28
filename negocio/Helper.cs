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
                //pictureBox.Load("https://www.peacemakersnetwork.org/wp-content/uploads/2019/09/placeholder.jpg");
                pictureBox.Load("https://raw.githubusercontent.com/GabrielMartC/ProyectoFinalLV2_WinForm_GestorArticulos/main/images/placeholder.png");
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

        //public static void RemoverTexto(TextBox textBox)
        //{
        //    if (textBox.Text == "Enter text here...")
        //    {
        //        textBox.Text = "";
        //    }
        //}

        //public static void AgregarTexto(TextBox textBox)
        //{
        //    if (string.IsNullOrWhiteSpace(textBox.Text))
        //        textBox.Text = "Enter text here...";
        //}
    }

    //public static void configurarTimer(Timer timer)
    //{
    //    timer.Interval = 10000; // 10000 milisegundos = 10 segundos
    //    timer.Tick += timer_tick; ////el problema es esto, habria que habilitar el evento desde aca
    //    timer.Start();
    //}


    //private static void timer_tick(object sender, EventArgs e, ToolStripStatusLabel label, Timer timer)
    //{
    //    label.Text = string.Empty;
    //    timer.Stop();
    //}

    //public static void ConfigurarTimer(Timer timer, ToolStripStatusLabel label)
    //{
    //    timer.Interval = 10000; // 10000 milisegundos = 10 segundos
    //    timer.Tag = (label, timer); // Almacena los parámetros adicionales en el Tag
    //    timer.Tick += Timer_Tick;
    //    timer.Start();
    //}

    //private static void Timer_Tick(object sender, EventArgs e)
    //{
    //    if (sender is Timer timer && timer.Tag is (ToolStripStatusLabel label, Timer _))
    //    {
    //        label.Text = string.Empty;
    //        timer.Stop();
    //    }
    //}


    //public static bool validarFiltro(ComboBox campo, ComboBox criterio, ToolStripStatusLabel label, TextBox filtro)
    //{
    //    if (campo.SelectedIndex < 0) //si no hay seleccionado nada en el desplegable campo...
    //    {
    //        label.Text = "Por favor, seleccione el campo para filtrar";
    //        return true;
    //    }

    //    if (criterio.SelectedIndex < 0) // si no hay seleccionado nada en el desplegable criterio
    //    {
    //        label.Text = "Por favor, seleccione el criterio para filtrar";
    //        return true;
    //    }

    //    if(campo.SelectedItem.ToString() == "Código") { }
    //    if (campo.SelectedItem.ToString() == "Nombre") { }
    //    if (campo.SelectedItem.ToString() == "Marca") { }
    //    if (campo.SelectedItem.ToString() == "Categoría") { }
    //    if (campo.SelectedItem.ToString() == "Precio") //filtro para Precio
    //    {
    //        if (string.IsNullOrEmpty(filtro.Text))
    //        //si el text box del filtro avanzado esta vacio o es nulo...                                        
    //        {
    //            //MessageBox.Show("Debes cargar el filtro para numericos...");
    //            label.Text = "Debes cargar el filtro para numericos...";
    //            return true;
    //        }


    //    }
    //    return false; //todo ok
    //}
}
