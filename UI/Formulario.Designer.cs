﻿namespace UI
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
            this.botonInformacionAdicional = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformaciónAdicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Location = new System.Drawing.Point(12, 44);
            this.dataGridDatos.MinimumSize = new System.Drawing.Size(740, 250);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            this.dataGridDatos.Size = new System.Drawing.Size(740, 250);
            this.dataGridDatos.TabIndex = 0;
            this.dataGridDatos.SelectionChanged += new System.EventHandler(this.dataGridDatos_SelectionChanged);
            // 
            // pictureBoxImagenes
            // 
            this.pictureBoxImagenes.Location = new System.Drawing.Point(758, 44);
            this.pictureBoxImagenes.MinimumSize = new System.Drawing.Size(230, 250);
            this.pictureBoxImagenes.Name = "pictureBoxImagenes";
            this.pictureBoxImagenes.Size = new System.Drawing.Size(230, 250);
            this.pictureBoxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenes.TabIndex = 1;
            this.pictureBoxImagenes.TabStop = false;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(12, 351);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(151, 351);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(133, 23);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArtículo
            // 
            this.btnEliminarArtículo.Location = new System.Drawing.Point(291, 351);
            this.btnEliminarArtículo.Name = "btnEliminarArtículo";
            this.btnEliminarArtículo.Size = new System.Drawing.Size(133, 23);
            this.btnEliminarArtículo.TabIndex = 4;
            this.btnEliminarArtículo.Text = "Eliminar Artículo";
            this.btnEliminarArtículo.UseVisualStyleBackColor = true;
            this.btnEliminarArtículo.Click += new System.EventHandler(this.btnEliminarArtículo_Click);
            // 
            // botonInformacionAdicional
            // 
            this.botonInformacionAdicional.Location = new System.Drawing.Point(430, 351);
            this.botonInformacionAdicional.Name = "botonInformacionAdicional";
            this.botonInformacionAdicional.Size = new System.Drawing.Size(155, 23);
            this.botonInformacionAdicional.TabIndex = 5;
            this.botonInformacionAdicional.Text = "Ver información adicional";
            this.botonInformacionAdicional.UseVisualStyleBackColor = true;
            this.botonInformacionAdicional.Click += new System.EventHandler(this.botonInformacionAdicional_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículoToolStripMenuItem,
            this.busquedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículoToolStripMenuItem
            // 
            this.artículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArtículoToolStripMenuItem,
            this.modificarArtículoToolStripMenuItem,
            this.eliminarArtículoToolStripMenuItem,
            this.verInformaciónAdicionalToolStripMenuItem});
            this.artículoToolStripMenuItem.Name = "artículoToolStripMenuItem";
            this.artículoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.artículoToolStripMenuItem.Text = "Artículo";
            // 
            // agregarArtículoToolStripMenuItem
            // 
            this.agregarArtículoToolStripMenuItem.Name = "agregarArtículoToolStripMenuItem";
            this.agregarArtículoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.agregarArtículoToolStripMenuItem.Text = "Agregar Artículo";
            this.agregarArtículoToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículoToolStripMenuItem_Click);
            // 
            // modificarArtículoToolStripMenuItem
            // 
            this.modificarArtículoToolStripMenuItem.Name = "modificarArtículoToolStripMenuItem";
            this.modificarArtículoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modificarArtículoToolStripMenuItem.Text = "Modificar Artículo";
            this.modificarArtículoToolStripMenuItem.Click += new System.EventHandler(this.modificarArtículoToolStripMenuItem_Click);
            // 
            // eliminarArtículoToolStripMenuItem
            // 
            this.eliminarArtículoToolStripMenuItem.Name = "eliminarArtículoToolStripMenuItem";
            this.eliminarArtículoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.eliminarArtículoToolStripMenuItem.Text = "Eliminar Artículo";
            this.eliminarArtículoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArtículoToolStripMenuItem_Click);
            // 
            // verInformaciónAdicionalToolStripMenuItem
            // 
            this.verInformaciónAdicionalToolStripMenuItem.Name = "verInformaciónAdicionalToolStripMenuItem";
            this.verInformaciónAdicionalToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verInformaciónAdicionalToolStripMenuItem.Text = "Ver Información adicional";
            this.verInformaciónAdicionalToolStripMenuItem.Click += new System.EventHandler(this.verInformaciónAdicionalToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem,
            this.porNombreToolStripMenuItem,
            this.porMarcaToolStripMenuItem,
            this.porCategoriaToolStripMenuItem,
            this.porPrecioToolStripMenuItem});
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // porCódigoToolStripMenuItem
            // 
            this.porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            this.porCódigoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porCódigoToolStripMenuItem.Text = "Por código";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            // 
            // porMarcaToolStripMenuItem
            // 
            this.porMarcaToolStripMenuItem.Name = "porMarcaToolStripMenuItem";
            this.porMarcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porMarcaToolStripMenuItem.Text = "Por marca";
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porCategoriaToolStripMenuItem.Text = "Por categoria ";
            // 
            // porPrecioToolStripMenuItem
            // 
            this.porPrecioToolStripMenuItem.Name = "porPrecioToolStripMenuItem";
            this.porPrecioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porPrecioToolStripMenuItem.Text = "Por precio";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 386);
            this.Controls.Add(this.botonInformacionAdicional);
            this.Controls.Add(this.btnEliminarArtículo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.pictureBoxImagenes);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1020, 425);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.PictureBox pictureBoxImagenes;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArtículo;
        private System.Windows.Forms.Button botonInformacionAdicional;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformaciónAdicionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrecioToolStripMenuItem;
    }
}

