using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

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
            Icon = new System.Drawing.Icon(@"..\..\..\Iconos\8674741_ic_fluent_delete_regular_icon.ico");
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
