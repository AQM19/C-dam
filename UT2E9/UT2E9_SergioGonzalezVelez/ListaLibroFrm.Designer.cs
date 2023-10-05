namespace UT2E9_SergioGonzalezVelez
{
    partial class ListaLibroFrm
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
            this.lvwLibros = new System.Windows.Forms.ListView();
            this.chTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsLibros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msLibros = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLibros.SuspendLayout();
            this.msLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwLibros
            // 
            this.lvwLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitulo,
            this.chAnno,
            this.chAutor});
            this.lvwLibros.GridLines = true;
            this.lvwLibros.HideSelection = false;
            this.lvwLibros.Location = new System.Drawing.Point(0, 27);
            this.lvwLibros.MultiSelect = false;
            this.lvwLibros.Name = "lvwLibros";
            this.lvwLibros.Size = new System.Drawing.Size(784, 423);
            this.lvwLibros.TabIndex = 0;
            this.lvwLibros.UseCompatibleStateImageBehavior = false;
            this.lvwLibros.View = System.Windows.Forms.View.Details;
            this.lvwLibros.DoubleClick += new System.EventHandler(this.cmsiVer_Click);
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
            // chAutor
            // 
            this.chAutor.Text = "Autor";
            this.chAutor.Width = 385;
            // 
            // cmsLibros
            // 
            this.cmsLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiVer,
            this.cmsiCrear,
            this.cmsiBorrar});
            this.cmsLibros.Name = "cmsLibros";
            this.cmsLibros.Size = new System.Drawing.Size(107, 70);
            this.cmsLibros.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLibros_Opening);
            // 
            // cmsiVer
            // 
            this.cmsiVer.Image = global::UT2E9_SergioGonzalezVelez.Properties.Resources.folder_Open_16xLG;
            this.cmsiVer.Name = "cmsiVer";
            this.cmsiVer.Size = new System.Drawing.Size(106, 22);
            this.cmsiVer.Text = "Ver";
            this.cmsiVer.Click += new System.EventHandler(this.cmsiVer_Click);
            // 
            // cmsiCrear
            // 
            this.cmsiCrear.Image = global::UT2E9_SergioGonzalezVelez.Properties.Resources.action_add_16xMD;
            this.cmsiCrear.Name = "cmsiCrear";
            this.cmsiCrear.Size = new System.Drawing.Size(106, 22);
            this.cmsiCrear.Text = "Crear";
            this.cmsiCrear.Click += new System.EventHandler(this.cmsiCrear_Click);
            // 
            // cmsiBorrar
            // 
            this.cmsiBorrar.Image = global::UT2E9_SergioGonzalezVelez.Properties.Resources.action_Cancel_16xMD;
            this.cmsiBorrar.Name = "cmsiBorrar";
            this.cmsiBorrar.Size = new System.Drawing.Size(106, 22);
            this.cmsiBorrar.Text = "Borrar";
            this.cmsiBorrar.Click += new System.EventHandler(this.cmsiBorrar_Click);
            // 
            // msLibros
            // 
            this.msLibros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msLibros.Dock = System.Windows.Forms.DockStyle.None;
            this.msLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem});
            this.msLibros.Location = new System.Drawing.Point(0, 0);
            this.msLibros.Name = "msLibros";
            this.msLibros.Size = new System.Drawing.Size(179, 24);
            this.msLibros.TabIndex = 1;
            this.msLibros.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.cmsiCrear_Click);
            // 
            // ListaLibroFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.ContextMenuStrip = this.cmsLibros;
            this.Controls.Add(this.msLibros);
            this.Controls.Add(this.lvwLibros);
            this.MainMenuStrip = this.msLibros;
            this.Name = "ListaLibroFrm";
            this.Text = "Mantenimiento de Libros";
            this.cmsLibros.ResumeLayout(false);
            this.msLibros.ResumeLayout(false);
            this.msLibros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwLibros;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.ColumnHeader chAutor;
        private System.Windows.Forms.ContextMenuStrip cmsLibros;
        private System.Windows.Forms.ToolStripMenuItem cmsiVer;
        private System.Windows.Forms.ToolStripMenuItem cmsiCrear;
        private System.Windows.Forms.ToolStripMenuItem cmsiBorrar;
        private System.Windows.Forms.MenuStrip msLibros;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
    }
}