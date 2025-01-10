namespace UI
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagenes = new System.Windows.Forms.PictureBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArtículo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Location = new System.Drawing.Point(13, 41);
            this.dataGridDatos.MinimumSize = new System.Drawing.Size(958, 250);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            this.dataGridDatos.Size = new System.Drawing.Size(958, 250);
            this.dataGridDatos.TabIndex = 0;
            this.dataGridDatos.SelectionChanged += new System.EventHandler(this.dataGridDatos_SelectionChanged);
            // 
            // pictureBoxImagenes
            // 
            this.pictureBoxImagenes.Location = new System.Drawing.Point(977, 41);
            this.pictureBoxImagenes.MinimumSize = new System.Drawing.Size(230, 250);
            this.pictureBoxImagenes.Name = "pictureBoxImagenes";
            this.pictureBoxImagenes.Size = new System.Drawing.Size(230, 250);
            this.pictureBoxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenes.TabIndex = 1;
            this.pictureBoxImagenes.TabStop = false;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(151, 12);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(133, 23);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArtículo
            // 
            this.btnEliminarArtículo.Location = new System.Drawing.Point(290, 12);
            this.btnEliminarArtículo.Name = "btnEliminarArtículo";
            this.btnEliminarArtículo.Size = new System.Drawing.Size(133, 23);
            this.btnEliminarArtículo.TabIndex = 4;
            this.btnEliminarArtículo.Text = "Eliminar Artículo";
            this.btnEliminarArtículo.UseVisualStyleBackColor = true;
            this.btnEliminarArtículo.Click += new System.EventHandler(this.btnEliminarArtículo_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 386);
            this.Controls.Add(this.btnEliminarArtículo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.pictureBoxImagenes);
            this.Controls.Add(this.dataGridDatos);
            this.MinimumSize = new System.Drawing.Size(1235, 425);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.PictureBox pictureBoxImagenes;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArtículo;
    }
}

