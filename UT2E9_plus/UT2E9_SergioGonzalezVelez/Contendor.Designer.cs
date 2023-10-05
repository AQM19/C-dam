namespace UT2E9_SergioGonzalezVelez
{
    partial class Contendor
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
            this.msContenedor = new System.Windows.Forms.MenuStrip();
            this.msiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPelículas = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.msiVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.msiVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.msContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // msContenedor
            // 
            this.msContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiArchivo,
            this.msiMantenimiento,
            this.msiVentanas});
            this.msContenedor.Location = new System.Drawing.Point(0, 0);
            this.msContenedor.Name = "msContenedor";
            this.msContenedor.Size = new System.Drawing.Size(994, 24);
            this.msContenedor.TabIndex = 0;
            this.msContenedor.Text = "menuStrip1";
            // 
            // msiArchivo
            // 
            this.msiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiSalir});
            this.msiArchivo.Name = "msiArchivo";
            this.msiArchivo.Size = new System.Drawing.Size(60, 20);
            this.msiArchivo.Text = "Archivo";
            // 
            // msiSalir
            // 
            this.msiSalir.Name = "msiSalir";
            this.msiSalir.Size = new System.Drawing.Size(180, 22);
            this.msiSalir.Text = "Salir";
            this.msiSalir.Click += new System.EventHandler(this.msiSalir_Click);
            // 
            // msiMantenimiento
            // 
            this.msiMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiPelículas,
            this.msiLibros});
            this.msiMantenimiento.Name = "msiMantenimiento";
            this.msiMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.msiMantenimiento.Text = "Mantenimiento";
            // 
            // msiPelículas
            // 
            this.msiPelículas.Name = "msiPelículas";
            this.msiPelículas.Size = new System.Drawing.Size(120, 22);
            this.msiPelículas.Text = "Películas";
            this.msiPelículas.Click += new System.EventHandler(this.msiPelículas_Click);
            // 
            // msiLibros
            // 
            this.msiLibros.Name = "msiLibros";
            this.msiLibros.Size = new System.Drawing.Size(120, 22);
            this.msiLibros.Text = "Libros";
            this.msiLibros.Click += new System.EventHandler(this.msiLibros_Click);
            // 
            // msiVentanas
            // 
            this.msiVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCascada,
            this.msiHorizontal,
            this.msiVertical});
            this.msiVentanas.Name = "msiVentanas";
            this.msiVentanas.Size = new System.Drawing.Size(66, 20);
            this.msiVentanas.Text = "Ventanas";
            // 
            // msiCascada
            // 
            this.msiCascada.Name = "msiCascada";
            this.msiCascada.Size = new System.Drawing.Size(129, 22);
            this.msiCascada.Text = "Cascada";
            this.msiCascada.Click += new System.EventHandler(this.msiCascada_Click);
            // 
            // msiHorizontal
            // 
            this.msiHorizontal.Name = "msiHorizontal";
            this.msiHorizontal.Size = new System.Drawing.Size(129, 22);
            this.msiHorizontal.Text = "Horizontal";
            this.msiHorizontal.Click += new System.EventHandler(this.msiHorizontal_Click);
            // 
            // msiVertical
            // 
            this.msiVertical.Name = "msiVertical";
            this.msiVertical.Size = new System.Drawing.Size(129, 22);
            this.msiVertical.Text = "Vertical";
            this.msiVertical.Click += new System.EventHandler(this.msiVertical_Click);
            // 
            // Contendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 567);
            this.Controls.Add(this.msContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msContenedor;
            this.Name = "Contendor";
            this.Text = "Contador";
            this.msContenedor.ResumeLayout(false);
            this.msContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msContenedor;
        private System.Windows.Forms.ToolStripMenuItem msiArchivo;
        private System.Windows.Forms.ToolStripMenuItem msiSalir;
        private System.Windows.Forms.ToolStripMenuItem msiMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem msiPelículas;
        private System.Windows.Forms.ToolStripMenuItem msiLibros;
        private System.Windows.Forms.ToolStripMenuItem msiVentanas;
        private System.Windows.Forms.ToolStripMenuItem msiCascada;
        private System.Windows.Forms.ToolStripMenuItem msiHorizontal;
        private System.Windows.Forms.ToolStripMenuItem msiVertical;
    }
}

