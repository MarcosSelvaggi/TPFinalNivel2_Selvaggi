using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace UI
{
    public partial class NuevoArticulo : Form
    {
        private OpenFileDialog archivo;
        Articulos aux;
        bool verInformacionAdicional;
        public NuevoArticulo()
        {
            InitializeComponent();
            Text = "Agregar Artículo";
            urlTextBox.Text = "Ingrese la URL o cargue una imagen";
            //Bloque try-catch para la carga del ícono, si algo sale mal, se carga el icono por defecto 
            try
            {
                Icon = new System.Drawing.Icon(@"..\..\..\Imagenes\Iconos\8675578_ic_fluent_text_bullet_list_icon.ico");
            }
            catch (Exception)
            {
                Icon = new Form().Icon;
            }
        }
        //Ventana que se muestra cuando se quiere modificar un artículo
        public NuevoArticulo(Articulos articulo)
        {
            InitializeComponent();
            botonAgregarProducto.Text = "Modificar Artículo";
            Text = "Modificar Artículo";
            aux = articulo;
            try
            {
                Icon = new System.Drawing.Icon(@"..\..\..\Imagenes\Iconos\8675578_ic_fluent_text_bullet_list_icon.ico");
            }
            catch (Exception)
            {
                Icon = new Form().Icon;
            }
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
            botonCargarImagen.Enabled = false;
            try
            {
                Icon = new System.Drawing.Icon(@"..\..\..\Imagenes\Iconos\8675339_ic_fluent_search_regular_icon.ico");
            }
            catch (Exception)
            {
                Icon = new Form().Icon;
            }
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

            //Cargar los datos del articulo que se pasó por parametro
            if (aux != null)
            {
                codigoTextBox.Text = aux.codigoArticulo;
                nombreTextBox.Text = aux.nombreArticulo;
                descripcionTextBox.Text = aux.descripcionArticulo;
                urlTextBox.Text = aux.imagenUrl;
                precioTextBox.Text = aux.precioEnDecimal.ToString();
                comboBoxCategoria.SelectedIndex = aux.idCategoriaProducto;
                comboBoxMarca.SelectedIndex = aux.idMarcaProducto;

                //Agrega el $ al texto precio
                if (verInformacionAdicional)
                {
                    precioTextBox.Text = aux.precioEnString;
                }
            }

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
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
            //If muy largo que revisa las longitudes de los Text Box, y del precio
            if ((codigoTextBox.Text.Length < 3 || codigoTextBox.Text.Length > 50) || (nombreTextBox.Text.Length < 3 || nombreTextBox.Text.Length > 50) || (descripcionTextBox.Text.Length < 3 || descripcionTextBox.Text.Length > 150) || urlTextBox.Text.Length < 3 || precioTextBox.Text == "" || Decimal.Parse(precioTextBox.Text) == 0)
            {
                MessageBox.Show("Hay campos sin completar, revise las cruces rojas para ver el error");
                if (codigoTextBox.Text.Length < 3 || codigoTextBox.Text.Length > 50)
                {
                    codigoVacioLabel.Visible = true;
                }
                else
                {
                    codigoVacioLabel.Visible = false;
                }

                if (nombreTextBox.Text.Length < 3 || nombreTextBox.Text.Length > 50)
                {
                    nombreVacioLabel.Visible = true;
                }
                else
                {
                    nombreVacioLabel.Visible = false;
                }

                if (descripcionTextBox.Text.Length < 3 || descripcionTextBox.Text.Length > 150)
                {
                    descripcionVacioLabel.Visible = true;
                }
                else
                {
                    descripcionVacioLabel.Visible = false;
                }

                if (urlTextBox.Text.Length < 3)
                {
                    urlVaciaLabel.Visible = true;
                }
                else
                {
                    urlVaciaLabel.Visible = false;
                }

                if (precioTextBox.Text == "" || Decimal.Parse(precioTextBox.Text) == 0)
                {
                    precioVacioLabel.Visible = true;
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
                    if (archivo != null && !(urlTextBox.Text.Contains("https")))

                        //Verifica que exista la carpeta donde van las imagenes de los productos, si no existe la crea 
                        if (!Directory.Exists(ConfigurationManager.AppSettings["images-folder"]))
                        {
                            DirectoryInfo directorio = new DirectoryInfo(ConfigurationManager.AppSettings["images-folder"]);
                            directorio.Create();
                        }

                    //Cualquiera de las 2 funcionan, la dejo para que se vea y se pueda probar 
                    //string ubicacionImagen = @"..\..\..\Imagenes\Articulos\" + codigoTextBox.Text + " - " + nombreTextBox.Text + "-" + DateTime.Now.Year + DateTime.Now.Month+ DateTime.Now.Day;
                    string ubicacionImagen = ConfigurationManager.AppSettings["images-folder"] + codigoTextBox.Text + " - " + nombreTextBox.Text + "-" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;

                    //Este dispose evita el IOException generado por tener la imagen cargada
                    pictureBoxProducto.Dispose();

                    //Si ya existe un archivo con el nombre del producto, la remplaza
                    if (File.Exists(aux.imagenUrl))
                        File.Delete(aux.imagenUrl);

                    File.Copy(archivo.FileName, ubicacionImagen);
                    urlTextBox.Text = ubicacionImagen;

                    conexion.agregarParametros("@ImagenUrl", urlTextBox.Text);
                    conexion.ejecutarQuery();
                }
                catch (IOException)
                {
                    MessageBox.Show("Error al copiar el archivo");
                    throw;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("No hay permisos para copiar el archivo");
                    throw;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error en la carga o modificación del artículo");
                }
                finally
                {
                    conexion.cerrarConexion();
                }
                Close();
            }
        }

        private void precioVacioLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 100;
            toolTip.SetToolTip(precioVacioLabel, "Debe ingresar un valor númerico mayor a 0");
        }

        //Manejo del tooltip para que el usuario sepa que está mal
        private void mostrarToolTip(Label label)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(label, "Debe ingresar entre 3 y 50 carácteres");
        }
        private void urlVaciaLabel_MouseHover(object sender, EventArgs e)
        {
            mostrarToolTip(urlVaciaLabel);
        }

        private void descripcionVacioLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 100;
            toolTip.SetToolTip(precioVacioLabel, "Debe ingresar entre 3 y 150 carácteres");
        }

        private void nombreVacioLabel_MouseHover(object sender, EventArgs e)
        {
            mostrarToolTip(nombreVacioLabel);
        }

        private void codigoVacioLabel_MouseHover(object sender, EventArgs e)
        {
            mostrarToolTip(codigoVacioLabel);
        }

        private void botonCargarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Imágenes(*.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                urlTextBox.Text = archivo.SafeFileName;
                try
                {
                    pictureBoxProducto.Load(archivo.FileName);
                }
                catch (Exception)
                {
                    pictureBoxProducto.Load("https://static.thenounproject.com/png/2932881-200.png");
                }
            }
        }

        private void urlTextBox_Click(object sender, EventArgs e)
        {
            //If que limpia el textbox de la ruta de la imagen la primera vez que se hace click
            if (aux == null && urlTextBox.Text == "Ingrese la URL o cargue una imagen")
            {
                urlTextBox.Text = "";
            }
        }

    }
}

