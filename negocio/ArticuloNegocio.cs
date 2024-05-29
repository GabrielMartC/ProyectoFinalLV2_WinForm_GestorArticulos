using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        //aca vamos a tener la logica... el agregarNuevo, modificar, eliminar, listar

        public List<Articulo> listar()
        {
            List<Articulo> listaArticulos = new List<Articulo> ();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio From ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo articulo = new Articulo();
                    //hacermos con setearConsulta / setearParametro... aunque eso vale mas para INSERT ,UPDATE, DELETE
                    articulo.Id = (int)lector["Id"];
                    articulo.Codigo = (string)lector["Codigo"];
                    articulo.Nombre = (string)lector["Nombre"];
                    articulo.Descripcion = (string)lector["Descripcion"];

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)lector["IdMarca"];
                    //articulo.Marca.Descripcion = (string)lector["..."];  cuando relacione la otro tabla...

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)lector["IdCategoria"];
                    //articulo.Categoria.Descripcion = (string)lector["..."];  cuando relacione la otro tabla...

                    articulo.UrlImagen = (string)lector["ImagenUrl"];
                    articulo.Precio = (decimal)lector["Precio"];

                    listaArticulos.Add(articulo);
                }

                conexion.Close();
                return listaArticulos;

            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }




        public void agregarNuevo(Articulo articuloNuevo)
        {

        }
        public void modificar(Articulo articulo)
        {

        }
        public void eliminar(Articulo articulo)
        {

        } //eliminacion logica: desabilita un pokemon
    }
}
