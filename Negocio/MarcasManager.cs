using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class MarcasManager
    {
        public List<Marcas> listarMarcas()
        {
            List<Marcas> listaMarcas = new List<Marcas>();
            AccesoADatos conexion = new AccesoADatos();
            try
            {
                conexion.setearConsulta("Select Id, Descripcion from Marcas");
                conexion.ejecutarQuery();
                while (conexion.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.idMarca = (int)conexion.Lector["Id"];
                    aux.descripcionMarca = (string)conexion.Lector["Descripcion"];

                    listaMarcas.Add(aux);
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

            return listaMarcas;
        }
    }
}
