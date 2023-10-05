namespace UT2E9_SergioGonzalezVelez
{
    partial class ListaPeliculaFrm
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
            this.components = new System.ComponentModel.Container();
            this.lvwPeliculas = new System.Windows.Forms.ListView();
            this.chTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPelicula = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiVerPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiCrearPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiBorrarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPelicula.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPeliculas
            // 
            this.lvwPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitulo,
            this.chAnno,
            this.chGenero});
            this.lvwPeliculas.GridLines = true;
            this.lvwPeliculas.HideSelection = false;
            this.lvwPeliculas.Location = new System.Drawing.Point(-2, 25);
            this.lvwPeliculas.MultiSelect = false;
            this.lvwPeliculas.Name = "lvwPeliculas";
            this.lvwPeliculas.Size = new System.Drawing.Size(811, 425);
            this.lvwPeliculas.TabIndex = 3;
            this.lvwPeliculas.UseCompatibleStateImageBehavior = false;
            this.lvwPeliculas.View = System.Windows.Forms.View.Details;
            this.lvwPeliculas.DoubleClick += new System.EventHandler(this.cmsiVerPelicula_Click);
            // 
            // chTitulo
            // 
            this.chTitulo.Text = "Título";
            this.chTitulo.Width = 328;
            // 
            // chAnno
            // 
            this.chAnno.Text = "Año";
            this.chAnno.Width = 67;
            // 
            // chGenero
            // 
            this.chGenero.Text = "Género";
            this.chGenero.Width = 385;
            // 
            // cmsPelicula
            // 
            this.cmsPelicula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiVerPelicula,
            this.cmsiCrearPelicula,
            this.cmsiBorrarPelicula});
            this.cmsPelicula.Name = "cmsPelicula";
            this.cmsPelicula.Size = new System.Drawing.Size(107, 70);
            this.cmsPelicula.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPelicula_Opening);
            // 
            // cmsiVerPelicula
            // 
            this.cmsiVerPelicula.Image = global::UT2E9_SergioGonzalezVelez.Properties.Resources.folder_Open_16xLG;
            this.cmsiVerPelicula.Name = "cmsiVerPelicula";
            this.cmsiVerPelicula.Size = new System.Drawing.Size(106, 22);
            this.cmsiVerPelicula.Text = "Ver";
            this.cmsiVerPelicula.Click += new System.EventHandler(this.cmsiVerPelicula_Click);
            // 
            // cmsiCrearPelicula
            // 
            this.cmsiCrearPelicula.Image = global::UT2E9_SergioGonzalezVelez.Properties.Resources.action_add_16xMD;
            this.cmsiCrearPelicula.Name = "cmsiCrearPelicula";
            this.cmsiCrearPelicula.Size = new System.Drawing.Size(106, 22);
            this.cmsiCrearPelicula.Text = "Crear";
            this.cmsiCrearPelicula.Click += new System.EventHandler(this.cmsiCrearPelicula_Click);
            // 
            // cmsiBorrarPelicula
            // 
            this.cmsiBorrarPelicula.Image = global::UT2E9_SergioGonzalezVelez.Properties.Resources.action_Cancel_16xMD;
            this.cmsiBorrarPelicula.Name = "cmsiBorrarPelicula";
            this.cmsiBorrarPelicula.Size = new System.Drawing.Size(106, 22);
            this.cmsiBorrarPelicula.Text = "Borrar";
            this.cmsiBorrarPelicula.Click += new System.EventHandler(this.cmsiBorrarPelicula_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.cmsiCrearPelicula_Click);
            // 
            // ListaPeliculaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.ContextMenuStrip = this.cmsPelicula;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lvwPeliculas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaPeliculaFrm";
            this.Text = "Mantenimiento de Películas";
            this.cmsPelicula.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwPeliculas;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ContextMenuStrip cmsPelicula;
        private System.Windows.Forms.ToolStripMenuItem cmsiVerPelicula;
        private System.Windows.Forms.ToolStripMenuItem cmsiCrearPelicula;
        private System.Windows.Forms.ToolStripMenuItem cmsiBorrarPelicula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
    }
}