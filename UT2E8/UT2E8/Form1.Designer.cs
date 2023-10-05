<<<<<<< HEAD
﻿namespace UT2E8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lvwListaNombres = new System.Windows.Forms.ListView();
            this.lvwColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPersonas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwListaNombres
            // 
            this.lvwListaNombres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwColumnName});
            this.lvwListaNombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwListaNombres.GridLines = true;
            this.lvwListaNombres.HideSelection = false;
            this.lvwListaNombres.Location = new System.Drawing.Point(0, 0);
            this.lvwListaNombres.Name = "lvwListaNombres";
            this.lvwListaNombres.Size = new System.Drawing.Size(434, 450);
            this.lvwListaNombres.TabIndex = 0;
            this.lvwListaNombres.UseCompatibleStateImageBehavior = false;
            this.lvwListaNombres.View = System.Windows.Forms.View.Details;
            // 
            // lvwColumnName
            // 
            this.lvwColumnName.Text = "Nombre";
            this.lvwColumnName.Width = 387;
            // 
            // cmsPersonas
            // 
            this.cmsPersonas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.cmsPersonas.Name = "cmsPersonas";
            this.cmsPersonas.Size = new System.Drawing.Size(181, 92);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.lvwListaNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsPersonas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaNombres;
        private System.Windows.Forms.ColumnHeader lvwColumnName;
        private System.Windows.Forms.ContextMenuStrip cmsPersonas;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
    }
}

=======
﻿namespace UT2E8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lvwListaNombres = new System.Windows.Forms.ListView();
            this.lvwColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPersonas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwListaNombres
            // 
            this.lvwListaNombres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwColumnName});
            this.lvwListaNombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwListaNombres.GridLines = true;
            this.lvwListaNombres.HideSelection = false;
            this.lvwListaNombres.Location = new System.Drawing.Point(0, 0);
            this.lvwListaNombres.Name = "lvwListaNombres";
            this.lvwListaNombres.Size = new System.Drawing.Size(434, 450);
            this.lvwListaNombres.TabIndex = 0;
            this.lvwListaNombres.UseCompatibleStateImageBehavior = false;
            this.lvwListaNombres.View = System.Windows.Forms.View.Details;
            // 
            // lvwColumnName
            // 
            this.lvwColumnName.Text = "Nombre";
            this.lvwColumnName.Width = 387;
            // 
            // cmsPersonas
            // 
            this.cmsPersonas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.cmsPersonas.Name = "cmsPersonas";
            this.cmsPersonas.Size = new System.Drawing.Size(181, 92);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.lvwListaNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsPersonas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaNombres;
        private System.Windows.Forms.ColumnHeader lvwColumnName;
        private System.Windows.Forms.ContextMenuStrip cmsPersonas;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
    }
}

>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
