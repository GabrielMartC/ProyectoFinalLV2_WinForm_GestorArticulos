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
        public void setearDatosArticulo(SqlDataReader lector, List<Articulo>listaArticulos) 
            //toma los datos de la DB y los incluye en un objeto Articulo
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> listar() //mejorado
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos(); //Ya establace por defecto a la conexion
                                                   //db. Crea un comando. 

            try
            {
                string consulta = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, MARCAS M, CATEGORIAS C Where A.IdMarca = M.Id AND A.IdCategoria = C.Id";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                setearDatosArticulo(datos.Lector, listaArticulos);
                datos.cerrarConexion();

                return listaArticulos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> listarFiltroAvanzado(string campo, string criterio, string filtro)
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

                setearDatosArticulo(datos.Lector, listaArticulos);
                return listaArticulos; 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregarNuevo(Articulo articuloNuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert Into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) Values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                //datos.setearParametro();
                datos.setearParametro("@Codigo",articuloNuevo.Codigo);
                datos.setearParametro("@Nombre", articuloNuevo.Nombre);
                datos.setearParametro("@Descripcion", articuloNuevo.Descripcion);
                datos.setearParametro("@IdMarca", articuloNuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", articuloNuevo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", articuloNuevo.ImagenUrl);
                datos.setearParametro("@Precio", articuloNuevo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio Where Id = @id");
                datos.setearParametro("@codigo",articulo.Codigo);
                datos.setearParametro("@nombre",articulo.Nombre);
                datos.setearParametro("@descripcion",articulo.Descripcion);
                datos.setearParametro("@idMarca",articulo.Marca.Id);
                datos.setearParametro("@idCategoria",articulo.Categoria.Id);
                datos.setearParametro("@imagenUrl",articulo.ImagenUrl);
                datos.setearParametro("@precio",articulo.Precio);
                datos.setearParametro("@id",articulo.Id);

                datos.ejecutarAccion();
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void eliminar(int id) //eliminacion fisica
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = @id");
                datos.setearParametro("@id",id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
