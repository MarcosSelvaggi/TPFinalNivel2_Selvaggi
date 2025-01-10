using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CategoriasManager
    {
        public List<Categorias> listarCategorias()
        {
            List<Categorias> listaCategorias = new List<Categorias>();

            AccesoADatos conexion = new AccesoADatos();
            try
            {
                conexion.setearConsulta("Select Id, Descripcion from Categorias");
                conexion.ejecutarQuery();
                while (conexion.Lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.idCategoria = (int)conexion.Lector["Id"];
                    aux.descripcionCategoria = (string)conexion.Lector["Descripcion"];

                    listaCategorias.Add(aux);
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
            return listaCategorias;
        }
    }
}
