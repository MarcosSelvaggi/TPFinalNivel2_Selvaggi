using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Negocio
{
    public class Articulos
    {
        public Articulos() { }
        [DisplayName("Id del Artículo")]
        public int idArticulo { get; set; }
        [DisplayName("Código del artículo")]
        public string codigoArticulo { get; set; }
        [DisplayName("Nombre del Artículo")]
        public string nombreArticulo { get; set; }
        [DisplayName("Descripción del Artículo")]
        public string descripcionArticulo { get; set; }
        [DisplayName("Marca")]
        public int idMarcaProducto {  get; set; }
        public string marcaProducto { get; set; }
        [DisplayName("Categoría")]
        public int idCategoriaProducto { get; set; }
        public string categoriaProducto { get; set; }
        public string imagenUrl { get; set; }
        [DisplayName("Precio")]
        public decimal precioArticulo { get; set; }

    }
}
