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
                //comando.CommandText = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio From ARTICULOS";
                //consulta varias tablas...
                comando.CommandText = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, MARCAS M, CATEGORIAS C Where A.IdMarca = M.Id AND A.IdCategoria = C.Id";
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
                    articulo.Marca.Descripcion = (string)lector["Marca"];  

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)lector["Categoria"];

                    articulo.ImagenUrl = (string)lector["ImagenUrl"];
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
