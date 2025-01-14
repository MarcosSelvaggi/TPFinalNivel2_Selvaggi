using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace UI
{
    public partial class BuscarArticulo : Form
    {
        public List<Articulos> aux;
        private string busqueda = null;
        private int busquedaEnInt = -1;
        public BuscarArticulo(string busqueda)
        {
            InitializeComponent();
            Icon = new System.Drawing.Icon(@"..\..\..\Iconos\8675339_ic_fluent_search_regular_icon.ico");
            this.busqueda = busqueda;
            comboBoxBusqueda.Items.Add("Contiene");
            comboBoxBusqueda.Items.Add("Empieza con");
            comboBoxBusqueda.Items.Add("Termina con");
            comboBoxBusqueda.SelectedIndex = 0;
        }

        /// El entero I representa donde entra:
        /// El 0 representa las marcas 
        /// El 1 representa las categorias 
        /// El 2 representa el precio del artículo
        public BuscarArticulo(int i)
        {
            InitializeComponent();
            busquedaEnInt = i;
            switch (i)
            {
                case 0:
                    MarcasManager managerMarcas = new MarcasManager();
                    List<Marcas> listaMarcas = new List<Marcas>();
                    listaMarcas = managerMarcas.listarMarcas();
                    foreach (var item in listaMarcas)
                    {
                        comboBoxMarcaYCategoria.Items.Add(item.descripcionMarca);
                    }
                    comboBoxBusqueda.Visible = false;
                    comboBoxMarcaYCategoria.Visible = true;
                    textBoxBusqueda.Visible = false;
                    comboBoxMarcaYCategoria.SelectedIndex = 0;
                    break;
                case 1:
                    CategoriasManager managerCategorias = new CategoriasManager();
                    List<Categorias> listaCategorias = new List<Categorias>();
                    listaCategorias = managerCategorias.listarCategorias();
                    foreach (var item in listaCategorias)
                    {
                        comboBoxMarcaYCategoria.Items.Add(item.descripcionCategoria);
                    }
                    comboBoxBusqueda.Visible = false;
                    comboBoxMarcaYCategoria.Visible = true;
                    textBoxBusqueda.Visible = false;
                    comboBoxMarcaYCategoria.SelectedIndex = 0;
                    break;
                case 2:
                    comboBoxBusqueda.Items.Add("Igual que");
                    comboBoxBusqueda.Items.Add("Menor que");
                    comboBoxBusqueda.Items.Add("Mayor que");
                    comboBoxBusqueda.SelectedIndex = 0;
                    break;
                default:
                    MessageBox.Show("Algo salió mal");
                    break;
            }


        }

        private void botonBusqueda_Click(object sender, EventArgs e)
        {
            //If que busca por nombre o por código
            ArticulosManager manager = new ArticulosManager();
            if (busqueda != null)
            {
                switch (comboBoxBusqueda.SelectedIndex)
                {
                    case 0:
                        aux = manager.listarArticulos("select * from Articulos where " + busqueda + " like '%" + textBoxBusqueda.Text + "%' ");
                        break;
                    case 1:
                        aux = manager.listarArticulos("select * from Articulos where " + busqueda + " like '" + textBoxBusqueda.Text + "%' ");
                        break;
                    case 2:
                        aux = manager.listarArticulos("select * from Articulos where " + busqueda + " like '%" + textBoxBusqueda.Text + "' ");
                        break;
                    default:
                        MessageBox.Show("No sé como lo hiciste pero rompiste el switch");
                        break;
                }

            }
            else
            {
                switch (busquedaEnInt) //If que busca por marca, categoria o precio
                {
                    case 0:
                        aux = manager.listarArticulos("select * from Articulos where IdMarca = " + (comboBoxMarcaYCategoria.SelectedIndex + 1));
                        break;
                    case 1:
                        aux = manager.listarArticulos("select * from Articulos where IdCategoria = " + (comboBoxMarcaYCategoria.SelectedIndex + 1));
                        break;
                    case 2:
                        buscarPrecio(manager);
                        break;
                    default:
                        break;
                }
            }
        }

        private void buscarPrecio(ArticulosManager manager)
        {
            switch (comboBoxBusqueda.SelectedIndex)
            {
                case 0:
                    aux = manager.listarArticulos("Select * From Articulos where Precio = " + textBoxBusqueda.Text);
                    break;
                case 1:
                    aux = manager.listarArticulos("Select * From Articulos where Precio < " + textBoxBusqueda.Text);
                    break;
                case 2:
                    aux = manager.listarArticulos("Select * From Articulos where Precio > " + textBoxBusqueda.Text);
                    break;

            }
        }

        //El método comprueba que no se presione otra cosa que un número, un punto o el borrar 
        private void textBoxBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (busquedaEnInt == 2)
            {
                //Este if no permite que el usuario presiona otra cosa que no sea un número, un punto o el borrar
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
                {
                    e.Handled = true;

                }
                //Con este if nos aseguramos de que sólo haya un punto decimal
                if (e.KeyChar == '.' && textBoxBusqueda.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
