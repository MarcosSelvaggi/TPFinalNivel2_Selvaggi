using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;



namespace UI
{
    public partial class NuevoArticulo : Form
    {

        Articulos aux;
        bool verInformacionAdicional;
        public NuevoArticulo()
        {
            InitializeComponent();
            Text = "Agregar Artículo";
        }
        //Ventana que se muestra cuando se quiere modificar un artículo
        public NuevoArticulo(Articulos articulo)
        {
            InitializeComponent();
            botonAgregarProducto.Text = "Modificar Artículo";
            Text = "Modificar Artículo";
            aux = articulo;
        }
        //Ventana que se muestra cuando se desea ver la info completa del producto
        //Se deshabilita todo para que el usuario no pueda modificar nada
        public NuevoArticulo(Articulos articulo, bool verArticulo)
        {
            InitializeComponent();
            botonAgregarProducto.Visible = false;
            Text = articulo.nombreArticulo;
            aux = articulo;
            codigoTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
            descripcionTextBox.ReadOnly = true;
            urlTextBox.ReadOnly = true;
            precioTextBox.ReadOnly = true;
            comboBoxCategoria.Enabled = false;
            comboBoxMarca.Enabled = false;
            verInformacionAdicional = verArticulo;
        }

        private void NuevoArticulo_Load(object sender, EventArgs e)
        {
            CategoriasManager categoriasManager = new CategoriasManager();
            List<Categorias> listaCategorias = categoriasManager.listarCategorias();

            MarcasManager marcasManager = new MarcasManager();
            List<Marcas> listaMarcas = marcasManager.listarMarcas();

            foreach (Categorias item in listaCategorias)
            {
                comboBoxCategoria.Items.Add(item.descripcionCategoria);
            }

            foreach (var item in listaMarcas)
            {
                comboBoxMarca.Items.Add(item.descripcionMarca);
            }

            comboBoxCategoria.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;

            //Este if verifica que aux si es null, si se pasó un producto como parametro, este if carga los datos
           
            if (aux != null)
            {
                codigoTextBox.Text = aux.codigoArticulo;
                nombreTextBox.Text = aux.nombreArticulo;
                descripcionTextBox.Text = aux.descripcionArticulo;
                urlTextBox.Text = aux.imagenUrl;
                precioTextBox.Text = aux.precioEnDecimal.ToString();
                comboBoxCategoria.SelectedIndex = aux.idCategoriaProducto;
                comboBoxMarca.SelectedIndex = aux.idMarcaProducto;

                //Si se pasó el bool para ver la información adional, este if agrega el $ al texto precio
                if (verInformacionAdicional)
                {
                    
                    precioTextBox.Text = aux.precioEnString;
                }
            }

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBoxProducto.Load(urlTextBox.Text);
            }
            catch (Exception)
            {
                pictureBoxProducto.Load("https://static.thenounproject.com/png/2932881-200.png");
            }
        }

        //Esto verifica que el valor ingresado sea un número o un punto
        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este if no permite que el usuario ingrese otra cosa que no sea un número, un punto o el borrar
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;

            }
            //Con este if nos aseguramos de que sólo haya un punto decimal
            if (e.KeyChar == '.' && precioTextBox.Text.Contains('.'))
            {
                e.Handled = true;
            }

        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            //Si algún campo tiene longitud menor a 3, da error 
            if (codigoTextBox.Text.Length < 3 || nombreTextBox.Text.Length < 3 || descripcionTextBox.Text.Length < 3 || urlTextBox.Text.Length < 3 || precioTextBox.Text == "")
            {
                MessageBox.Show("Hay campos sin completar, revise los campos marcados con rojo");
                if (codigoTextBox.Text.Length < 3)
                {
                    codigoVacioLabel.Visible = true;
                    codigoVacioLabel.ForeColor = Color.Red;
                }
                else
                {
                    codigoVacioLabel.Visible = false;
                }

                if (nombreTextBox.Text.Length < 3)
                {
                    nombreVacioLabel.Visible = true;
                    nombreVacioLabel.ForeColor = Color.Red;
                }
                else
                {
                    nombreVacioLabel.Visible = false;
                }

                if (descripcionTextBox.Text.Length < 3)
                {
                    descripcionVacioLabel.Visible = true;
                    descripcionVacioLabel.ForeColor = Color.Red;
                }
                else
                {
                    descripcionVacioLabel.Visible = false;
                }

                if (urlTextBox.Text.Length < 3)
                {
                    urlVaciaLabel.Visible = true;
                    urlVaciaLabel.ForeColor = Color.Red;
                }
                else
                {
                    urlVaciaLabel.Visible = false;
                }

                if (precioTextBox.Text == "" || Int32.Parse(precioTextBox.Text) == 0)
                {
                    precioVacioLabel.Visible = true;
                    precioVacioLabel.ForeColor = Color.Red;
                }
                else
                {
                    precioVacioLabel.Visible = false;
                }
            }
            else
            {
                AccesoADatos conexion = new AccesoADatos();
                string query = "";

                //Si el articulo auxiliar está en null, significa que va a agregar un producto
                //Caso contrario, está modificando el mismo
                if (aux == null)
                {
                    query = "INSERT INTO Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)";
                    conexion.setearConsulta(query);
                }
                else
                {
                    query = "UPDATE Articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id";
                    conexion.setearConsulta(query);
                    conexion.agregarParametros("@Id", aux.idArticulo);
                }
                try
                {
                    conexion.agregarParametros("@Codigo", codigoTextBox.Text);
                    conexion.agregarParametros("@Nombre", nombreTextBox.Text);
                    conexion.agregarParametros("@Descripcion", descripcionTextBox.Text);
                    conexion.agregarParametros("@IdMarca", (comboBoxMarca.SelectedIndex + 1));
                    conexion.agregarParametros("@IdCategoria", (comboBoxCategoria.SelectedIndex + 1));
                    conexion.agregarParametros("@Precio", Decimal.Parse(precioTextBox.Text));
                    conexion.agregarParametros("@ImagenUrl", urlTextBox.Text);


                    conexion.ejecutarQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.cerrarConexion();
                }
                Close();
            }
        }

    }
}

