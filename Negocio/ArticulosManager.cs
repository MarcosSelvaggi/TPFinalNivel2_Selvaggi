using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                aux.precioArticulo = (decimal)conexion.Lector["Precio"];
                listaArticulos.Add(aux);
            }
            conexion.cerrarConexion();
            return listaArticulos;
        }
    }
}
