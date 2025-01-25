using System;
using System.Collections.Generic;
using Datos;


namespace Negocio
{
    public class ArticulosManager
    {
        public List<Articulos> listarArticulos()
        {
            List<Articulos> listaArticulos = new List<Articulos>();
            List<Categorias> listaCategorias = new List<Categorias>();
            List<Marcas> listaMarcas = new List<Marcas>();

            AccesoADatos conexion = new AccesoADatos();
            CategoriasManager categorias = new CategoriasManager();
            MarcasManager marcas = new MarcasManager();

            listaMarcas = marcas.listarMarcas();
            listaCategorias = categorias.listarCategorias();
            try
            {
                string query = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from Articulos";
                conexion.setearConsulta(query);
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.idArticulo = (int)conexion.Lector["Id"];
                    aux.codigoArticulo = (string)conexion.Lector["Codigo"];
                    aux.nombreArticulo = (string)conexion.Lector["Nombre"];
                    aux.descripcionArticulo = (string)conexion.Lector["Descripcion"];
                    aux.idMarcaProducto = (int)conexion.Lector["IdMarca"] - 1;
                    aux.marcaProducto = listaMarcas[(int)conexion.Lector["IdMarca"] - 1].descripcionMarca;
                    aux.idCategoriaProducto = (int)conexion.Lector["IdCategoria"] - 1;
                    aux.categoriaProducto = listaCategorias[(int)conexion.Lector["IdCategoria"] - 1].descripcionCategoria;
                    aux.imagenUrl = (string)conexion.Lector["ImagenUrl"];
                    aux.precioEnDecimal = Decimal.Parse(conexion.Lector["Precio"].ToString());

                    //Actualmente lo que está acá ya no es necesario porque uso el CultureInfo para transformar el valor 
                    //A pesos Argentinos, así que no hace falta 

                    ////Pasamos el valor decimal a string para poder trabajar con el mismo 
                    //aux.precioEnString = "$" + aux.precioEnDecimal.ToString();
                    //
                    ////Acá verificamos si el if tiene un punto decimal, en caso de lo tenga nos quedamos con 2 valores 
                    ////Después del punto
                    //if (aux.precioEnString.Contains("."))
                    //{
                    //    aux.precioEnString = aux.precioEnString.Remove(aux.precioEnString.IndexOf(".") + 3);
                    //}

                    listaArticulos.Add(aux);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
            return listaArticulos;
        }

        public List<Articulos> listarArticulos(string query)
        {
            List<Articulos> listaArticulos = new List<Articulos>();
            List<Categorias> listaCategorias = new List<Categorias>();
            List<Marcas> listaMarcas = new List<Marcas>();

            AccesoADatos conexion = new AccesoADatos();
            CategoriasManager categorias = new CategoriasManager();
            MarcasManager marcas = new MarcasManager();

            listaMarcas = marcas.listarMarcas();
            listaCategorias = categorias.listarCategorias();
            try
            {
                conexion.setearConsulta(query);
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.idArticulo = (int)conexion.Lector["Id"];
                    aux.codigoArticulo = (string)conexion.Lector["Codigo"];
                    aux.nombreArticulo = (string)conexion.Lector["Nombre"];
                    aux.descripcionArticulo = (string)conexion.Lector["Descripcion"];
                    aux.idMarcaProducto = (int)conexion.Lector["IdMarca"] - 1;
                    aux.marcaProducto = listaMarcas[(int)conexion.Lector["IdMarca"] - 1].descripcionMarca;
                    aux.idCategoriaProducto = (int)conexion.Lector["IdCategoria"] - 1;
                    aux.categoriaProducto = listaCategorias[(int)conexion.Lector["IdCategoria"] - 1].descripcionCategoria;
                    aux.imagenUrl = (string)conexion.Lector["ImagenUrl"];
                    aux.precioEnDecimal = (decimal)conexion.Lector["Precio"];

                    listaArticulos.Add(aux);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
            return listaArticulos;
        }

    }
}
