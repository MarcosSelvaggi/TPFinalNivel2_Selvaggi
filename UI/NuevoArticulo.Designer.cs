namespace UI
{
    partial class NuevoArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.label_IdMarca = new System.Windows.Forms.Label();
            this.label_IdCategoria = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.botonAgregarProducto = new System.Windows.Forms.Button();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.codigoVacioLabel = new System.Windows.Forms.Label();
            this.nombreVacioLabel = new System.Windows.Forms.Label();
            this.descripcionVacioLabel = new System.Windows.Forms.Label();
            this.urlVaciaLabel = new System.Windows.Forms.Label();
            this.precioVacioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(35, 38);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(35, 66);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(35, 92);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción";
            // 
            // label_IdMarca
            // 
            this.label_IdMarca.AutoSize = true;
            this.label_IdMarca.Location = new System.Drawing.Point(35, 124);
            this.label_IdMarca.Name = "label_IdMarca";
            this.label_IdMarca.Size = new System.Drawing.Size(37, 13);
            this.label_IdMarca.TabIndex = 3;
            this.label_IdMarca.Text = "Marca";
            // 
            // label_IdCategoria
            // 
            this.label_IdCategoria.AutoSize = true;
            this.label_IdCategoria.Location = new System.Drawing.Point(35, 152);
            this.label_IdCategoria.Name = "label_IdCategoria";
            this.label_IdCategoria.Size = new System.Drawing.Size(52, 13);
            this.label_IdCategoria.TabIndex = 4;
            this.label_IdCategoria.Text = "Categoria";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(35, 188);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(83, 13);
            this.labelUrl.TabIndex = 5;
            this.labelUrl.Text = "Url de la imagen";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(35, 218);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 6;
            this.labelPrecio.Text = "Precio";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(119, 121);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMarca.TabIndex = 7;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(119, 149);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCategoria.TabIndex = 8;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(119, 31);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(165, 20);
            this.codigoTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(119, 59);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(165, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(119, 89);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(165, 20);
            this.descripcionTextBox.TabIndex = 11;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(119, 185);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(165, 20);
            this.urlTextBox.TabIndex = 12;
            this.urlTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(119, 211);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(165, 20);
            this.precioTextBox.TabIndex = 13;
            this.precioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTextBox_KeyPress);
            // 
            // botonAgregarProducto
            // 
            this.botonAgregarProducto.Location = new System.Drawing.Point(209, 255);
            this.botonAgregarProducto.Name = "botonAgregarProducto";
            this.botonAgregarProducto.Size = new System.Drawing.Size(158, 23);
            this.botonAgregarProducto.TabIndex = 14;
            this.botonAgregarProducto.Text = "Agregar Artículo";
            this.botonAgregarProducto.UseVisualStyleBackColor = true;
            this.botonAgregarProducto.Click += new System.EventHandler(this.botonAgregarProducto_Click);
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.Location = new System.Drawing.Point(334, 31);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(233, 200);
            this.pictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducto.TabIndex = 15;
            this.pictureBoxProducto.TabStop = false;
            // 
            // codigoVacioLabel
            // 
            this.codigoVacioLabel.AutoSize = true;
            this.codigoVacioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoVacioLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.codigoVacioLabel.Location = new System.Drawing.Point(290, 34);
            this.codigoVacioLabel.Name = "codigoVacioLabel";
            this.codigoVacioLabel.Size = new System.Drawing.Size(16, 16);
            this.codigoVacioLabel.TabIndex = 17;
            this.codigoVacioLabel.Text = "X";
            this.codigoVacioLabel.Visible = false;
            this.codigoVacioLabel.MouseHover += new System.EventHandler(this.codigoVacioLabel_MouseHover);
            // 
            // nombreVacioLabel
            // 
            this.nombreVacioLabel.AutoSize = true;
            this.nombreVacioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreVacioLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nombreVacioLabel.Location = new System.Drawing.Point(290, 59);
            this.nombreVacioLabel.Name = "nombreVacioLabel";
            this.nombreVacioLabel.Size = new System.Drawing.Size(16, 16);
            this.nombreVacioLabel.TabIndex = 18;
            this.nombreVacioLabel.Text = "X";
            this.nombreVacioLabel.Visible = false;
            this.nombreVacioLabel.MouseHover += new System.EventHandler(this.nombreVacioLabel_MouseHover);
            // 
            // descripcionVacioLabel
            // 
            this.descripcionVacioLabel.AutoSize = true;
            this.descripcionVacioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionVacioLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.descripcionVacioLabel.Location = new System.Drawing.Point(290, 92);
            this.descripcionVacioLabel.Name = "descripcionVacioLabel";
            this.descripcionVacioLabel.Size = new System.Drawing.Size(16, 16);
            this.descripcionVacioLabel.TabIndex = 19;
            this.descripcionVacioLabel.Text = "X";
            this.descripcionVacioLabel.Visible = false;
            this.descripcionVacioLabel.MouseHover += new System.EventHandler(this.descripcionVacioLabel_MouseHover);
            // 
            // urlVaciaLabel
            // 
            this.urlVaciaLabel.AutoSize = true;
            this.urlVaciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlVaciaLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.urlVaciaLabel.Location = new System.Drawing.Point(290, 186);
            this.urlVaciaLabel.Name = "urlVaciaLabel";
            this.urlVaciaLabel.Size = new System.Drawing.Size(16, 16);
            this.urlVaciaLabel.TabIndex = 20;
            this.urlVaciaLabel.Text = "X";
            this.urlVaciaLabel.Visible = false;
            this.urlVaciaLabel.MouseHover += new System.EventHandler(this.urlVaciaLabel_MouseHover);
            // 
            // precioVacioLabel
            // 
            this.precioVacioLabel.AutoSize = true;
            this.precioVacioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioVacioLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.precioVacioLabel.Location = new System.Drawing.Point(290, 212);
            this.precioVacioLabel.Name = "precioVacioLabel";
            this.precioVacioLabel.Size = new System.Drawing.Size(16, 16);
            this.precioVacioLabel.TabIndex = 21;
            this.precioVacioLabel.Text = "X";
            this.precioVacioLabel.Visible = false;
            this.precioVacioLabel.MouseHover += new System.EventHandler(this.precioVacioLabel_MouseHover);
            // 
            // NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 291);
            this.Controls.Add(this.precioVacioLabel);
            this.Controls.Add(this.urlVaciaLabel);
            this.Controls.Add(this.descripcionVacioLabel);
            this.Controls.Add(this.nombreVacioLabel);
            this.Controls.Add(this.codigoVacioLabel);
            this.Controls.Add(this.pictureBoxProducto);
            this.Controls.Add(this.botonAgregarProducto);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.label_IdCategoria);
            this.Controls.Add(this.label_IdMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.MaximumSize = new System.Drawing.Size(620, 330);
            this.MinimumSize = new System.Drawing.Size(620, 330);
            this.Name = "NuevoArticulo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.NuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label label_IdMarca;
        private System.Windows.Forms.Label label_IdCategoria;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Button botonAgregarProducto;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private System.Windows.Forms.Label codigoVacioLabel;
        private System.Windows.Forms.Label nombreVacioLabel;
        private System.Windows.Forms.Label descripcionVacioLabel;
        private System.Windows.Forms.Label urlVaciaLabel;
        private System.Windows.Forms.Label precioVacioLabel;
    }
}