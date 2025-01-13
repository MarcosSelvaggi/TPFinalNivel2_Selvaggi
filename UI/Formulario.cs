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
        }

        private void ocultarArticulos()
        {
            dataGridDatos.AutoResizeColumns();
            dataGridDatos.Columns["idArticulo"].Visible = false;
            dataGridDatos.Columns["imagenUrl"].Visible = false;
            dataGridDatos.Columns["idCategoriaProducto"].Visible = false;
            dataGridDatos.Columns["idMarcaProducto"].Visible = false;
            dataGridDatos.Columns["codigoArticulo"].Visible = false;
            dataGridDatos.Columns["descripcionArticulo"].Visible = false;
            dataGridDatos.Columns["categoriaProducto"].Visible = false;
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


        //Botones
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
        //Botones

        //Métodos de los botones 
        private void agregarArticulo()
        {
            NuevoArticulo ventana = new NuevoArticulo();
            ventana.ShowDialog();
            cargarArticulos();
        }

        private void modificarArticulo()
        {
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
        //Métodos de los botones 
    }
}
