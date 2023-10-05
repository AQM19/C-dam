namespace Zoocan
{
    partial class AnimalesListFrm
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
            this.mnsAnimalesMenu = new System.Windows.Forms.MenuStrip();
            this.animalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrearAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorrarAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAnimalesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwListaAnimales = new System.Windows.Forms.ListView();
            this.chNombreRefugio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNacimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRaza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspacio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.informeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAnimalesMenu.SuspendLayout();
            this.cmsAnimalesContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAnimalesMenu
            // 
            this.mnsAnimalesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalesToolStripMenuItem});
            this.mnsAnimalesMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsAnimalesMenu.Name = "mnsAnimalesMenu";
            this.mnsAnimalesMenu.Size = new System.Drawing.Size(800, 24);
            this.mnsAnimalesMenu.TabIndex = 0;
            this.mnsAnimalesMenu.Text = "mnsAnimalesMenu";
            // 
            // animalesToolStripMenuItem
            // 
            this.animalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrearAnimal,
            this.tsmiEditarAnimal,
            this.tsmiBorrarAnimal,
            this.toolStripMenuItem1,
            this.informeToolStripMenuItem});
            this.animalesToolStripMenuItem.Name = "animalesToolStripMenuItem";
            this.animalesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.animalesToolStripMenuItem.Text = "Animales";
            // 
            // tsmiCrearAnimal
            // 
            this.tsmiCrearAnimal.Name = "tsmiCrearAnimal";
            this.tsmiCrearAnimal.Size = new System.Drawing.Size(180, 22);
            this.tsmiCrearAnimal.Text = "Crear";
            this.tsmiCrearAnimal.Click += new System.EventHandler(this.tsmiCrearAnimal_Click);
            // 
            // tsmiEditarAnimal
            // 
            this.tsmiEditarAnimal.Name = "tsmiEditarAnimal";
            this.tsmiEditarAnimal.Size = new System.Drawing.Size(180, 22);
            this.tsmiEditarAnimal.Text = "Editar";
            this.tsmiEditarAnimal.Click += new System.EventHandler(this.tsmiEditarAnimal_Click);
            // 
            // tsmiBorrarAnimal
            // 
            this.tsmiBorrarAnimal.Name = "tsmiBorrarAnimal";
            this.tsmiBorrarAnimal.Size = new System.Drawing.Size(180, 22);
            this.tsmiBorrarAnimal.Text = "Borrar";
            this.tsmiBorrarAnimal.Click += new System.EventHandler(this.tsmiBorrarAnimal_Click);
            // 
            // cmsAnimalesContext
            // 
            this.cmsAnimalesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.editarToolStripMenuItem1,
            this.borrarToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.informeToolStripMenuItem1});
            this.cmsAnimalesContext.Name = "cmsAnimalesContext";
            this.cmsAnimalesContext.Size = new System.Drawing.Size(117, 98);
            this.cmsAnimalesContext.Text = "cmsAnimalesContext";
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
            // lvwListaAnimales
            // 
            this.lvwListaAnimales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombreRefugio,
            this.chNombre,
            this.chNacimiento,
            this.chEntrada,
            this.chEspecie,
            this.chRaza,
            this.chPeso,
            this.chEspacio});
            this.lvwListaAnimales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwListaAnimales.FullRowSelect = true;
            this.lvwListaAnimales.GridLines = true;
            this.lvwListaAnimales.HideSelection = false;
            this.lvwListaAnimales.Location = new System.Drawing.Point(0, 24);
            this.lvwListaAnimales.MultiSelect = false;
            this.lvwListaAnimales.Name = "lvwListaAnimales";
            this.lvwListaAnimales.Size = new System.Drawing.Size(800, 426);
            this.lvwListaAnimales.TabIndex = 2;
            this.lvwListaAnimales.UseCompatibleStateImageBehavior = false;
            this.lvwListaAnimales.View = System.Windows.Forms.View.Details;
            // 
            // chNombreRefugio
            // 
            this.chNombreRefugio.Text = "Refugio";
            this.chNombreRefugio.Width = 99;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 130;
            // 
            // chNacimiento
            // 
            this.chNacimiento.Text = "Nacimiento";
            this.chNacimiento.Width = 148;
            // 
            // chEntrada
            // 
            this.chEntrada.Text = "Entrada";
            this.chEntrada.Width = 130;
            // 
            // chEspecie
            // 
            this.chEspecie.Text = "Especie";
            this.chEspecie.Width = 94;
            // 
            // chRaza
            // 
            this.chRaza.Text = "Raza";
            this.chRaza.Width = 71;
            // 
            // chPeso
            // 
            this.chPeso.Text = "Peso";
            this.chPeso.Width = 68;
            // 
            // chEspacio
            // 
            this.chEspacio.Text = "Espacio minimo";
            this.chEspacio.Width = 56;
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informeToolStripMenuItem.Text = "Informe";
            this.informeToolStripMenuItem.Click += new System.EventHandler(this.informeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // informeToolStripMenuItem1
            // 
            this.informeToolStripMenuItem1.Name = "informeToolStripMenuItem1";
            this.informeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.informeToolStripMenuItem1.Text = "Informe";
            this.informeToolStripMenuItem1.Click += new System.EventHandler(this.informeToolStripMenuItem1_Click);
            // 
            // AnimalesListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmsAnimalesContext;
            this.Controls.Add(this.lvwListaAnimales);
            this.Controls.Add(this.mnsAnimalesMenu);
            this.MainMenuStrip = this.mnsAnimalesMenu;
            this.Name = "AnimalesListFrm";
            this.Text = "AnimalesListFrm";
            this.Load += new System.EventHandler(this.AnimalesListFrm_Load);
            this.mnsAnimalesMenu.ResumeLayout(false);
            this.mnsAnimalesMenu.PerformLayout();
            this.cmsAnimalesContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAnimalesMenu;
        private System.Windows.Forms.ToolStripMenuItem animalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrearAnimal;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarAnimal;
        private System.Windows.Forms.ToolStripMenuItem tsmiBorrarAnimal;
        private System.Windows.Forms.ContextMenuStrip cmsAnimalesContext;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ListView lvwListaAnimales;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chNacimiento;
        private System.Windows.Forms.ColumnHeader chEntrada;
        private System.Windows.Forms.ColumnHeader chEspecie;
        private System.Windows.Forms.ColumnHeader chRaza;
        private System.Windows.Forms.ColumnHeader chPeso;
        private System.Windows.Forms.ColumnHeader chEspacio;
        private System.Windows.Forms.ColumnHeader chNombreRefugio;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem1;
    }
}