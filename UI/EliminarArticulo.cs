using System;
using System.IO;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace UI
{
    public partial class EliminarArticulo : Form
    {
        Articulos aux;
        public EliminarArticulo(Articulos Articulo)
        {
            InitializeComponent();
            labelEliminado.Text = "¿Desea eliminar el artículo " + Articulo.nombreArticulo + "?";
            aux = Articulo;
            try
            {
                Icon = new System.Drawing.Icon(@"..\..\..\Imagenes\Iconos\8674741_ic_fluent_delete_regular_icon.ico");
            }
            catch (Exception)
            {
                Icon = new Form().Icon;
            }
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            ArticulosManager articulosManager = new ArticulosManager();
            try
            {
                MessageBox.Show("Se han eliminado " + articulosManager.eliminarArticulo(aux) + " artículos");
                if (File.Exists(aux.imagenUrl))
                {
                    File.Delete(aux.imagenUrl);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto");
            }
            finally
            {
                Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
