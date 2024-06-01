using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Xml.Linq;

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

        public List<Articulo> filtroAvanzado(string campo, string criterio, string filtro)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, MARCAS M, CATEGORIAS C Where A.IdMarca = M.Id AND A.IdCategoria = C.Id AND ";
                //dejamos espacion para concatenar posibles filtros...

                switch (campo)
                {
                    case "Código":
                        switch (criterio)
                        {
                            case "Comenza con":
                                consulta += "Codigo LIKE '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "Codigo LIKE '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "Codigo LIKE '%" + filtro + "%'";
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comenza con":
                                consulta += "Nombre LIKE '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "Nombre LIKE '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "Nombre LIKE '%" + filtro + "%'";
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Marca":
                        switch (criterio)
                        {
                            case "Comenza con":
                                consulta += "M.Descripcion LIKE '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "M.Descripcion LIKE '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "M.Descripcion LIKE '%" + filtro + "%'";
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Categoria":
                        switch (criterio)
                        {
                            case "Comenza con":
                                consulta += "C.Descripcion LIKE '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "C.Descripcion LIKE '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "C.Descripcion LIKE '%" + filtro + "%'";
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + filtro;
                                break;

                            case "Menor a":
                                consulta += "Precio < " + filtro;
                                break;

                            case "Igual a":
                                consulta += "Precio = " + filtro;
                                break;

                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read()) //esto esta repetido, podria mejorarse...
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    articulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];

                    listaArticulos.Add(articulo);
                    
                }

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
