using System;
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
            AccesoADatos conexion = new AccesoADatos();
            conexion.setearConsulta("Delete from Articulos where Id = @Id");
            conexion.agregarParametros("@Id", aux.idArticulo);
            try
            {
                conexion.ejecutarQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto");
            }
            finally
            {
                MessageBox.Show("Se ha eliminado el artículo");
                conexion.cerrarConexion();
                Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
