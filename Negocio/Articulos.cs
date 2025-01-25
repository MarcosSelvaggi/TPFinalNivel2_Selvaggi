using System.ComponentModel;
using System.Globalization;


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
        public int idMarcaProducto { get; set; }
        [DisplayName("Marca")]
        public string marcaProducto { get; set; }
        public int idCategoriaProducto { get; set; }
        [DisplayName("Categoría")]
        public string categoriaProducto { get; set; }
        public string imagenUrl { get; set; }
        public decimal precioEnDecimal { get; set; }
        [DisplayName("Precio")]
        public string precioEnString
        {
            get
            {
                return precioEnDecimal.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
            }
        }
    }
}
