namespace Zoocan
{
    partial class RefugiosListFrm
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
            this.lvwListRefugios = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaxAnimales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsStripRefugios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuRefugios = new System.Windows.Forms.MenuStrip();
            this.refugioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStripRefugios.SuspendLayout();
            this.mnsMenuRefugios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwListRefugios
            // 
            this.lvwListRefugios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwListRefugios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chDireccion,
            this.chEspecie,
            this.chTelefono,
            this.chMaxAnimales});
            this.lvwListRefugios.ContextMenuStrip = this.cmsStripRefugios;
            this.lvwListRefugios.GridLines = true;
            this.lvwListRefugios.HideSelection = false;
            this.lvwListRefugios.Location = new System.Drawing.Point(1, 27);
            this.lvwListRefugios.Name = "lvwListRefugios";
            this.lvwListRefugios.Size = new System.Drawing.Size(800, 424);
            this.lvwListRefugios.TabIndex = 0;
            this.lvwListRefugios.UseCompatibleStateImageBehavior = false;
            this.lvwListRefugios.View = System.Windows.Forms.View.Details;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 191;
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Direccion";
            this.chDireccion.Width = 258;
            // 
            // chEspecie
            // 
            this.chEspecie.Text = "Especie";
            this.chEspecie.Width = 132;
            // 
            // chTelefono
            // 
            this.chTelefono.Text = "Telefono";
            this.chTelefono.Width = 97;
            // 
            // chMaxAnimales
            // 
            this.chMaxAnimales.Text = "Maximo de animales";
            this.chMaxAnimales.Width = 117;
            // 
            // cmsStripRefugios
            // 
            this.cmsStripRefugios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.editarToolStripMenuItem1,
            this.borrarToolStripMenuItem1});
            this.cmsStripRefugios.Name = "cmsStripRefugios";
            this.cmsStripRefugios.Size = new System.Drawing.Size(181, 92);
            this.cmsStripRefugios.Text = "cmsStripRefugios";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // mnsMenuRefugios
            // 
            this.mnsMenuRefugios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refugioToolStripMenuItem});
            this.mnsMenuRefugios.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuRefugios.Name = "mnsMenuRefugios";
            this.mnsMenuRefugios.Size = new System.Drawing.Size(800, 24);
            this.mnsMenuRefugios.TabIndex = 1;
            this.mnsMenuRefugios.Text = "mnsMenuRefugios";
            // 
            // refugioToolStripMenuItem
            // 
            this.refugioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.refugioToolStripMenuItem.Name = "refugioToolStripMenuItem";
            this.refugioToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.refugioToolStripMenuItem.Text = "Refugios";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // RefugiosListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwListRefugios);
            this.Controls.Add(this.mnsMenuRefugios);
            this.MainMenuStrip = this.mnsMenuRefugios;
            this.Name = "RefugiosListFrm";
            this.Text = "RefugiosListFrm";
            this.cmsStripRefugios.ResumeLayout(false);
            this.mnsMenuRefugios.ResumeLayout(false);
            this.mnsMenuRefugios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwListRefugios;
        private System.Windows.Forms.MenuStrip mnsMenuRefugios;
        private System.Windows.Forms.ContextMenuStrip cmsStripRefugios;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refugioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chDireccion;
        private System.Windows.Forms.ColumnHeader chEspecie;
        private System.Windows.Forms.ColumnHeader chTelefono;
        private System.Windows.Forms.ColumnHeader chMaxAnimales;
    }
}