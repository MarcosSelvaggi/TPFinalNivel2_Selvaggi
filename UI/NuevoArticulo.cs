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
        public NuevoArticulo()
        {
            InitializeComponent();
        }

        public NuevoArticulo(Articulos articulos)
        {
            InitializeComponent();
            botonAgregarProducto.Text = "Modificar Artículo";
            Text = "Modificar Artículo";
            aux = articulos;
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

            if (aux != null)
            {
                codigoTextBox.Text = aux.codigoArticulo;
                nombreTextBox.Text = aux.nombreArticulo;
                descripcionTextBox.Text = aux.descripcionArticulo;
                urlTextBox.Text = aux.imagenUrl;
                precioTextBox.Text = aux.precioArticulo.ToString();
                comboBoxCategoria.SelectedIndex = aux.idCategoriaProducto;
                comboBoxMarca.SelectedIndex = aux.idMarcaProducto;
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

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este if no permite que el usuario ingrese otra cosa que no sea un número, un punto o el borrar
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
                ingresadoValorNoNumLabel.Visible = true;
                ingresadoValorNoNumLabel.ForeColor = Color.Red;
                ingresadoValorNoNumLabel.BackColor = Color.Black;
                precioTextBox.BackColor = Color.Black;

            }
            //Con este if nos aseguramos de que sólo haya un punto decimal
            if (e.KeyChar == '.' && precioTextBox.Text.Contains('.'))
            {
                e.Handled = true;
            }

        }

        //Eso desactiva la label cuando el usuario ingresa un valor no númerico 
        private void ingresadoValorNoNumLabel_Click(object sender, EventArgs e)
        {
            ingresadoValorNoNumLabel.Visible = false;
            precioTextBox.BackColor = Color.White;
            precioTextBox.SelectionStart = precioTextBox.Text.Length;
            
        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {

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

                if (precioTextBox.Text == "")
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

