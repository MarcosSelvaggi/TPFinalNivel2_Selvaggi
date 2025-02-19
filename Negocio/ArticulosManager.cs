using System;
using System.Collections.Generic;
using Datos;


namespace Negocio
{
    public class ArticulosManager
    {
        private List<Categorias> listaCategorias;
        private List<Marcas> listaMarcas;

        public ArticulosManager()
        {
            CategoriasManager categoriasManager = new CategoriasManager();
            MarcasManager marcasManager = new MarcasManager();

            listaCategorias = categoriasManager.listarCategorias();
            listaMarcas = marcasManager.listarMarcas();
        }

        public List<Articulos> listarArticulos()
        {
            List<Articulos> listaArticulos = new List<Articulos>();
            AccesoADatos conexion = new AccesoADatos();         
            
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

        public List<Articulos> buscarPorNombre_O_Codigo(string busqueda, string informacionBuscada, int valorSwitch)
        {
            string query = "";

            switch (valorSwitch)
            {
                case 0:
                    query = $"SELECT * FROM Articulos WHERE {busqueda} LIKE '%{informacionBuscada}%'";
                    break;
                case 1:
                    query = $"SELECT * FROM Articulos WHERE {busqueda} LIKE '{informacionBuscada}%'";
                    break;
                case 2:
                    query = $"SELECT * FROM Articulos WHERE {busqueda} LIKE '%{informacionBuscada}'";
                    break;
                default:
                    query = "SELECT * FROM Articulos";
                    break;
            }

            return ejecutarBusqueda(query);
        }

        public List<Articulos> buscarPorMarca_O_Categoria(string informacionBuscada, int valorSwitch)
        {
            string query = valorSwitch == 0
                ? $"SELECT * FROM Articulos WHERE IdMarca = {informacionBuscada}"
                : $"SELECT * FROM Articulos WHERE IdCategoria = {informacionBuscada}";

            return ejecutarBusqueda(query);
        }

        public List<Articulos> buscarPorPrecio(int valorSwitch, string valorDelProducto)
        {
            string query = valorSwitch switch
            {
                0 => $"SELECT * FROM Articulos WHERE Precio = {valorDelProducto}",
                1 => $"SELECT * FROM Articulos WHERE Precio < {valorDelProducto}",
                2 => $"SELECT * FROM Articulos WHERE Precio > {valorDelProducto}",
                _ => ""
            };

            return ejecutarBusqueda(query);
        }


        private List<Articulos> ejecutarBusqueda(string query)
        {
            List<Articulos> listaArticulos = new List<Articulos>();
            AccesoADatos conexion = new AccesoADatos();

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


        public int agregarArticulo(Articulos nuevoArticulo)
        {
            AccesoADatos conexion = new AccesoADatos();

            conexion.setearConsulta("INSERT INTO Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
            conexion.agregarParametros("@Codigo", nuevoArticulo.codigoArticulo);
            conexion.agregarParametros("@Nombre", nuevoArticulo.nombreArticulo);
            conexion.agregarParametros("@Descripcion", nuevoArticulo.descripcionArticulo);
            conexion.agregarParametros("@IdMarca", nuevoArticulo.idMarcaProducto + 1);
            conexion.agregarParametros("@IdCategoria", nuevoArticulo.idCategoriaProducto + 1);
            conexion.agregarParametros("@Precio", nuevoArticulo.precioEnDecimal);
            conexion.agregarParametros("@ImagenUrl", nuevoArticulo.imagenUrl);

            return conexion.ejecutarNonQuery();

        }
        public int modificarArticulo(Articulos articuloModificado)
        {
            AccesoADatos conexion = new AccesoADatos();
            conexion.setearConsulta("UPDATE Articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
            conexion.agregarParametros("@Id", articuloModificado.idArticulo);
            conexion.agregarParametros("@Codigo", articuloModificado.codigoArticulo);
            conexion.agregarParametros("@Nombre", articuloModificado.nombreArticulo);
            conexion.agregarParametros("@Descripcion", articuloModificado.descripcionArticulo);
            conexion.agregarParametros("@ImagenUrl", articuloModificado.imagenUrl);
            conexion.agregarParametros("@IdMarca", articuloModificado.idMarcaProducto + 1);
            conexion.agregarParametros("@IdCategoria", articuloModificado.idCategoriaProducto + 1);
            conexion.agregarParametros("@Precio", articuloModificado.precioEnDecimal);
            return conexion.ejecutarNonQuery();
        }

        public int eliminarArticulo(Articulos articuloEliminado)
        {
            AccesoADatos conexion = new AccesoADatos();
            conexion.setearConsulta("Delete from Articulos where Id = @Id");
            conexion.agregarParametros("@Id", articuloEliminado.idArticulo);
            return conexion.ejecutarNonQuery();
        }
    }
}
