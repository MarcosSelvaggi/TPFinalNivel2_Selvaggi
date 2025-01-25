using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio;

namespace UI
{
    public partial class Formulario : Form
    {
        private List<Articulos> listaArticulos;
        public Formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }
        //Métodos de carga y muestra de artículos
        private void cargarArticulos()
        {
            ArticulosManager articulosManager = new ArticulosManager();
            listaArticulos = articulosManager.listarArticulos();
            dataGridDatos.DataSource = listaArticulos;
            ocultarArticulos();
            dataGridDatos.Columns["codigoArticulo"].Width = 120;
            dataGridDatos.Columns["precioEnString"].Width = 100;
        }

        //Carga la lista de artículos buscados
        private void cargarArticulos(List<Articulos> listaArticulos)
        {
            if (listaArticulos != null)
            {
                dataGridDatos.DataSource = listaArticulos;
                ocultarArticulos();
            }
            else
            {
                cargarArticulos();
            }
        }

        private void ocultarArticulos()
        {
            dataGridDatos.Columns["idArticulo"].Visible = false;
            dataGridDatos.Columns["imagenUrl"].Visible = false;
            dataGridDatos.Columns["idCategoriaProducto"].Visible = false;
            dataGridDatos.Columns["idMarcaProducto"].Visible = false;
            dataGridDatos.Columns["descripcionArticulo"].Visible = false;
            dataGridDatos.Columns["precioEnDecimal"].Visible = false;
        }
        private void cargarImagen(string ubicacionImagen)
        {
            try
            {
                pictureBoxImagenes.Load(ubicacionImagen);
            }
            catch (Exception)
            {
                pictureBoxImagenes.Load("https://static.thenounproject.com/png/2932881-200.png");
            }
        }

        private void dataGridDatos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos articuloActual = (Articulos)dataGridDatos.CurrentRow.DataBoundItem;
            cargarImagen(articuloActual.imagenUrl);
        }
        //Métodos de carga y muestra de artículos

        //Métodos de los botones 
        private void agregarArticulo()
        {
            NuevoArticulo ventana = new NuevoArticulo();
            ventana.ShowDialog();
            cargarArticulos();
        }

        private void modificarArticulo()
        {
            cargarImagen(null);
            NuevoArticulo ventana = new NuevoArticulo((Articulos)dataGridDatos.CurrentRow.DataBoundItem);
            ventana.ShowDialog();
            cargarArticulos();
        }

        private void eliminarArticulo()
        {
            EliminarArticulo aux = new EliminarArticulo((Articulos)dataGridDatos.CurrentRow.DataBoundItem);
            aux.ShowDialog();
            cargarArticulos();
        }

        private void verInfoAdicionalArticulo()
        {
            Articulos articuloAux = (Articulos)dataGridDatos.CurrentRow.DataBoundItem;
            NuevoArticulo aux = new NuevoArticulo(articuloAux, true);
            aux.ShowDialog();
        }

        //Comprueba el DialogResult de los botones de busqueda
        private void respuestaOk(BuscarArticulo busqueda)
        {
            DialogResult respuesta = busqueda.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                listaArticulos = busqueda.aux;
            }
            cargarArticulos(listaArticulos);
        }

        //Métodos de los botones 

        //Botones
        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarArticulo busqueda = new BuscarArticulo("Codigo");
            respuestaOk(busqueda);
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarArticulo busqueda = new BuscarArticulo("Nombre");
            respuestaOk(busqueda);
        }

        /// El entero I representa donde entra:
        /// El 0 representa las marcas 
        /// El 1 representa las categorias 
        /// El 2 representa el precio del artículo

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarArticulo busqueda = new BuscarArticulo(0);
            respuestaOk(busqueda);
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarArticulo busqueda = new BuscarArticulo(1);
            respuestaOk(busqueda);
        }

        private void porPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarArticulo busqueda = new BuscarArticulo(2);
            respuestaOk(busqueda); 
        }

        

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            agregarArticulo();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            modificarArticulo();
        }

        private void btnEliminarArtículo_Click(object sender, EventArgs e)
        {
            eliminarArticulo();
        }

        private void botonInformacionAdicional_Click(object sender, EventArgs e)
        {
            verInfoAdicionalArticulo();
        }

        private void agregarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarArticulo();
        }

        private void modificarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarArticulo();
        }

        private void eliminarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarArticulo();
        }

        private void verInformaciónAdicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verInfoAdicionalArticulo();

        }

        private void botonRecargarArticulos_Click(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void reiniciarBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarArticulos();
        }


        //Botones
    }
}
