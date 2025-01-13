namespace UI
{
    partial class BuscarArticulo
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
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.botonBusqueda = new System.Windows.Forms.Button();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.comboBoxMarcaYCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(159, 52);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(250, 20);
            this.textBoxBusqueda.TabIndex = 0;
            this.textBoxBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBusqueda_KeyPress);
            // 
            // botonBusqueda
            // 
            this.botonBusqueda.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonBusqueda.Location = new System.Drawing.Point(145, 78);
            this.botonBusqueda.Name = "botonBusqueda";
            this.botonBusqueda.Size = new System.Drawing.Size(117, 23);
            this.botonBusqueda.TabIndex = 2;
            this.botonBusqueda.Text = "Realizar busqueda";
            this.botonBusqueda.UseVisualStyleBackColor = true;
            this.botonBusqueda.Click += new System.EventHandler(this.botonBusqueda_Click);
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(45, 52);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(110, 21);
            this.comboBoxBusqueda.TabIndex = 3;
            // 
            // comboBoxMarcaYCategoria
            // 
            this.comboBoxMarcaYCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcaYCategoria.FormattingEnabled = true;
            this.comboBoxMarcaYCategoria.Location = new System.Drawing.Point(93, 25);
            this.comboBoxMarcaYCategoria.Name = "comboBoxMarcaYCategoria";
            this.comboBoxMarcaYCategoria.Size = new System.Drawing.Size(238, 21);
            this.comboBoxMarcaYCategoria.TabIndex = 4;
            this.comboBoxMarcaYCategoria.Visible = false;
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 131);
            this.Controls.Add(this.comboBoxMarcaYCategoria);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.botonBusqueda);
            this.Controls.Add(this.textBoxBusqueda);
            this.MaximumSize = new System.Drawing.Size(440, 170);
            this.MinimumSize = new System.Drawing.Size(440, 170);
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button botonBusqueda;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.ComboBox comboBoxMarcaYCategoria;
    }
}