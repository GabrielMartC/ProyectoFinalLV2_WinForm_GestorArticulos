using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }// para hacer las relaciones entre tablas
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public Marca MarcaArticulo { get; set; }
        public Categoria CategoriaArticulo { get; set; }
        public string UrlImagen { get; set; }
        public double Precio { get; set; } //fijarse el equivalente en tipo money

        public Articulo() { }


    }

}
