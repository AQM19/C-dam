using System.Windows.Forms;

namespace ZoocanV2
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvsVistaArbol = new System.Windows.Forms.TreeView();
            this.cmsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListaIconos = new System.Windows.Forms.ImageList(this.components);
            this.pPanel = new System.Windows.Forms.Panel();
            this.lblEspecieRefugio = new System.Windows.Forms.Label();
            this.lvwListaAnimales = new System.Windows.Forms.ListView();
            this.chNombreAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecieAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRazaAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwListaCuidadores = new System.Windows.Forms.ListView();
            this.chNombreCuidador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecieCuidador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResponsableCuidador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMaxAnimalesRefugio = new System.Windows.Forms.Label();
            this.lblTelefonoRefugio = new System.Windows.Forms.Label();
            this.lblDireccionRefugio = new System.Windows.Forms.Label();
            this.lblMaxAnimales = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRefugio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoRefugio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoCuidador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refugiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuidadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsContextMenu.SuspendLayout();
            this.pPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvsVistaArbol);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pPanel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvsVistaArbol
            // 
            this.tvsVistaArbol.ContextMenuStrip = this.cmsContextMenu;
            this.tvsVistaArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvsVistaArbol.ImageIndex = 0;
            this.tvsVistaArbol.ImageList = this.imgListaIconos;
            this.tvsVistaArbol.Location = new System.Drawing.Point(0, 0);
            this.tvsVistaArbol.Name = "tvsVistaArbol";
            this.tvsVistaArbol.SelectedImageIndex = 0;
            this.tvsVistaArbol.Size = new System.Drawing.Size(266, 426);
            this.tvsVistaArbol.TabIndex = 0;
            this.tvsVistaArbol.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvsVistaArbol_BeforeExpand);
            this.tvsVistaArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvsVistaArbol_AfterSelect);
            // 
            // cmsContextMenu
            // 
            this.cmsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiNuevo,
            this.cmsiEditar,
            this.cmsiBorrar,
            this.toolStripMenuItem2,
            this.informeToolStripMenuItem,
            this.informeGeneralToolStripMenuItem});
            this.cmsContextMenu.Name = "contextMenuStrip1";
            this.cmsContextMenu.Size = new System.Drawing.Size(190, 120);
            this.cmsContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsContextMenu_Opening);
            // 
            // cmsiNuevo
            // 
            this.cmsiNuevo.Name = "cmsiNuevo";
            this.cmsiNuevo.Size = new System.Drawing.Size(189, 22);
            this.cmsiNuevo.Text = "Nuevo";
            this.cmsiNuevo.Click += new System.EventHandler(this.cmsiNuevo_Click);
            // 
            // cmsiEditar
            // 
            this.cmsiEditar.Name = "cmsiEditar";
            this.cmsiEditar.Size = new System.Drawing.Size(189, 22);
            this.cmsiEditar.Text = "Editar";
            this.cmsiEditar.Click += new System.EventHandler(this.cmsiEditar_Click);
            // 
            // cmsiBorrar
            // 
            this.cmsiBorrar.Name = "cmsiBorrar";
            this.cmsiBorrar.Size = new System.Drawing.Size(189, 22);
            this.cmsiBorrar.Text = "Borrar";
            this.cmsiBorrar.Click += new System.EventHandler(this.cmsiBorrar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.informeToolStripMenuItem.Text = "Listado de cuidadores";
            this.informeToolStripMenuItem.Click += new System.EventHandler(this.informeToolStripMenuItem_Click);
            // 
            // informeGeneralToolStripMenuItem
            // 
            this.informeGeneralToolStripMenuItem.Name = "informeGeneralToolStripMenuItem";
            this.informeGeneralToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.informeGeneralToolStripMenuItem.Text = "Informe del refugio";
            this.informeGeneralToolStripMenuItem.Click += new System.EventHandler(this.informeGeneralToolStripMenuItem_Click);
            // 
            // imgListaIconos
            // 
            this.imgListaIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListaIconos.ImageStream")));
            this.imgListaIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListaIconos.Images.SetKeyName(0, "folder_Closed_16xLG.png");
            this.imgListaIconos.Images.SetKeyName(1, "folder_Open_16xLG.png");
            this.imgListaIconos.Images.SetKeyName(2, "document_16xLG.png");
            // 
            // pPanel
            // 
            this.pPanel.Controls.Add(this.lblEspecieRefugio);
            this.pPanel.Controls.Add(this.lvwListaAnimales);
            this.pPanel.Controls.Add(this.lvwListaCuidadores);
            this.pPanel.Controls.Add(this.lblMaxAnimalesRefugio);
            this.pPanel.Controls.Add(this.lblTelefonoRefugio);
            this.pPanel.Controls.Add(this.lblDireccionRefugio);
            this.pPanel.Controls.Add(this.lblMaxAnimales);
            this.pPanel.Controls.Add(this.lblEspecie);
            this.pPanel.Controls.Add(this.lblTelefono);
            this.pPanel.Controls.Add(this.lblDireccion);
            this.pPanel.Controls.Add(this.lblRefugio);
            this.pPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPanel.Location = new System.Drawing.Point(0, 0);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(530, 426);
            this.pPanel.TabIndex = 0;
            // 
            // lblEspecieRefugio
            // 
            this.lblEspecieRefugio.AutoSize = true;
            this.lblEspecieRefugio.Location = new System.Drawing.Point(326, 80);
            this.lblEspecieRefugio.Name = "lblEspecieRefugio";
            this.lblEspecieRefugio.Size = new System.Drawing.Size(45, 13);
            this.lblEspecieRefugio.TabIndex = 11;
            this.lblEspecieRefugio.Text = "Especie";
            // 
            // lvwListaAnimales
            // 
            this.lvwListaAnimales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombreAnimal,
            this.chEspecieAnimal,
            this.chRazaAnimal});
            this.lvwListaAnimales.ContextMenuStrip = this.cmsContextMenu;
            this.lvwListaAnimales.FullRowSelect = true;
            this.lvwListaAnimales.GridLines = true;
            this.lvwListaAnimales.HideSelection = false;
            this.lvwListaAnimales.Location = new System.Drawing.Point(278, 164);
            this.lvwListaAnimales.MultiSelect = false;
            this.lvwListaAnimales.Name = "lvwListaAnimales";
            this.lvwListaAnimales.Size = new System.Drawing.Size(240, 250);
            this.lvwListaAnimales.TabIndex = 10;
            this.lvwListaAnimales.UseCompatibleStateImageBehavior = false;
            this.lvwListaAnimales.View = System.Windows.Forms.View.Details;
            // 
            // chNombreAnimal
            // 
            this.chNombreAnimal.Text = "Nombre";
            this.chNombreAnimal.Width = 86;
            // 
            // chEspecieAnimal
            // 
            this.chEspecieAnimal.Text = "Especie";
            this.chEspecieAnimal.Width = 70;
            // 
            // chRazaAnimal
            // 
            this.chRazaAnimal.Text = "Raza";
            this.chRazaAnimal.Width = 78;
            // 
            // lvwListaCuidadores
            // 
            this.lvwListaCuidadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombreCuidador,
            this.chEspecieCuidador,
            this.chResponsableCuidador});
            this.lvwListaCuidadores.ContextMenuStrip = this.cmsContextMenu;
            this.lvwListaCuidadores.FullRowSelect = true;
            this.lvwListaCuidadores.GridLines = true;
            this.lvwListaCuidadores.HideSelection = false;
            this.lvwListaCuidadores.Location = new System.Drawing.Point(4, 164);
            this.lvwListaCuidadores.MultiSelect = false;
            this.lvwListaCuidadores.Name = "lvwListaCuidadores";
            this.lvwListaCuidadores.Size = new System.Drawing.Size(240, 250);
            this.lvwListaCuidadores.TabIndex = 9;
            this.lvwListaCuidadores.UseCompatibleStateImageBehavior = false;
            this.lvwListaCuidadores.View = System.Windows.Forms.View.Details;
            // 
            // chNombreCuidador
            // 
            this.chNombreCuidador.Text = "Nombre";
            this.chNombreCuidador.Width = 76;
            // 
            // chEspecieCuidador
            // 
            this.chEspecieCuidador.Text = "Especie";
            this.chEspecieCuidador.Width = 75;
            // 
            // chResponsableCuidador
            // 
            this.chResponsableCuidador.Text = "Responsable";
            this.chResponsableCuidador.Width = 84;
            // 
            // lblMaxAnimalesRefugio
            // 
            this.lblMaxAnimalesRefugio.AutoSize = true;
            this.lblMaxAnimalesRefugio.Location = new System.Drawing.Point(135, 120);
            this.lblMaxAnimalesRefugio.Name = "lblMaxAnimalesRefugio";
            this.lblMaxAnimalesRefugio.Size = new System.Drawing.Size(13, 13);
            this.lblMaxAnimalesRefugio.TabIndex = 7;
            this.lblMaxAnimalesRefugio.Text = "0";
            // 
            // lblTelefonoRefugio
            // 
            this.lblTelefonoRefugio.AutoSize = true;
            this.lblTelefonoRefugio.Location = new System.Drawing.Point(135, 80);
            this.lblTelefonoRefugio.Name = "lblTelefonoRefugio";
            this.lblTelefonoRefugio.Size = new System.Drawing.Size(61, 13);
            this.lblTelefonoRefugio.TabIndex = 6;
            this.lblTelefonoRefugio.Text = "123456789";
            // 
            // lblDireccionRefugio
            // 
            this.lblDireccionRefugio.AutoSize = true;
            this.lblDireccionRefugio.Location = new System.Drawing.Point(135, 44);
            this.lblDireccionRefugio.Name = "lblDireccionRefugio";
            this.lblDireccionRefugio.Size = new System.Drawing.Size(76, 13);
            this.lblDireccionRefugio.TabIndex = 5;
            this.lblDireccionRefugio.Text = "Calle falsa 123";
            // 
            // lblMaxAnimales
            // 
            this.lblMaxAnimales.AutoSize = true;
            this.lblMaxAnimales.Location = new System.Drawing.Point(30, 120);
            this.lblMaxAnimales.Name = "lblMaxAnimales";
            this.lblMaxAnimales.Size = new System.Drawing.Size(102, 13);
            this.lblMaxAnimales.TabIndex = 4;
            this.lblMaxAnimales.Text = "Máximo de animales";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(326, 44);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 3;
            this.lblEspecie.Text = "Especie:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(30, 80);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(30, 44);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblRefugio
            // 
            this.lblRefugio.AutoSize = true;
            this.lblRefugio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRefugio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefugio.Location = new System.Drawing.Point(0, 0);
            this.lblRefugio.Name = "lblRefugio";
            this.lblRefugio.Size = new System.Drawing.Size(72, 20);
            this.lblRefugio.TabIndex = 0;
            this.lblRefugio.Text = "Refugio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevo,
            this.tsmiEditar,
            this.tsmiBorrar,
            this.toolStripMenuItem1,
            this.tsmiSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoRefugio,
            this.tsmiNuevoCuidador,
            this.tsmiNuevoAnimal});
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(138, 22);
            this.tsmiNuevo.Text = "Nuevo";
            // 
            // tsmiNuevoRefugio
            // 
            this.tsmiNuevoRefugio.Name = "tsmiNuevoRefugio";
            this.tsmiNuevoRefugio.Size = new System.Drawing.Size(123, 22);
            this.tsmiNuevoRefugio.Text = "Refugio";
            this.tsmiNuevoRefugio.Click += new System.EventHandler(this.tsmiNuevoRefugio_Click);
            // 
            // tsmiNuevoCuidador
            // 
            this.tsmiNuevoCuidador.Name = "tsmiNuevoCuidador";
            this.tsmiNuevoCuidador.Size = new System.Drawing.Size(123, 22);
            this.tsmiNuevoCuidador.Text = "Cuidador";
            this.tsmiNuevoCuidador.Click += new System.EventHandler(this.tsmiNuevoCuidador_Click);
            // 
            // tsmiNuevoAnimal
            // 
            this.tsmiNuevoAnimal.Name = "tsmiNuevoAnimal";
            this.tsmiNuevoAnimal.Size = new System.Drawing.Size(123, 22);
            this.tsmiNuevoAnimal.Text = "Animal";
            this.tsmiNuevoAnimal.Click += new System.EventHandler(this.tsmiNuevoAnimal_Click);
            // 
            // tsmiEditar
            // 
            this.tsmiEditar.Name = "tsmiEditar";
            this.tsmiEditar.Size = new System.Drawing.Size(138, 22);
            this.tsmiEditar.Text = "Editar";
            this.tsmiEditar.Click += new System.EventHandler(this.tsmiEditar_Click);
            // 
            // tsmiBorrar
            // 
            this.tsmiBorrar.Name = "tsmiBorrar";
            this.tsmiBorrar.Size = new System.Drawing.Size(138, 22);
            this.tsmiBorrar.Text = "Borrar";
            this.tsmiBorrar.Click += new System.EventHandler(this.tsmiBorrar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiSalir.Size = new System.Drawing.Size(138, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refugiosToolStripMenuItem,
            this.cuidadoresToolStripMenuItem,
            this.animalesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // refugiosToolStripMenuItem
            // 
            this.refugiosToolStripMenuItem.Name = "refugiosToolStripMenuItem";
            this.refugiosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.refugiosToolStripMenuItem.Text = "Refugios";
            // 
            // cuidadoresToolStripMenuItem
            // 
            this.cuidadoresToolStripMenuItem.Name = "cuidadoresToolStripMenuItem";
            this.cuidadoresToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cuidadoresToolStripMenuItem.Text = "Cuidadores";
            // 
            // animalesToolStripMenuItem
            // 
            this.animalesToolStripMenuItem.Name = "animalesToolStripMenuItem";
            this.animalesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.animalesToolStripMenuItem.Text = "Animales";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsContextMenu.ResumeLayout(false);
            this.pPanel.ResumeLayout(false);
            this.pPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem tsmiNuevo;
        private ToolStripMenuItem tsmiNuevoRefugio;
        private ToolStripMenuItem tsmiNuevoCuidador;
        private ToolStripMenuItem tsmiNuevoAnimal;
        private ToolStripMenuItem tsmiEditar;
        private ToolStripMenuItem tsmiBorrar;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiSalir;
        private TreeView tvsVistaArbol;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem refugiosToolStripMenuItem;
        private ToolStripMenuItem cuidadoresToolStripMenuItem;
        private ToolStripMenuItem animalesToolStripMenuItem;
        private Panel pPanel;
        private ListView lvwListaAnimales;
        private ListView lvwListaCuidadores;
        private Label lblMaxAnimalesRefugio;
        private Label lblTelefonoRefugio;
        private Label lblDireccionRefugio;
        private Label lblMaxAnimales;
        private Label lblEspecie;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblRefugio;
        private ContextMenuStrip cmsContextMenu;
        private ToolStripMenuItem cmsiNuevo;
        private ToolStripMenuItem cmsiEditar;
        private ToolStripMenuItem cmsiBorrar;
        private ImageList imgListaIconos;
        private ColumnHeader chNombreAnimal;
        private ColumnHeader chEspecieAnimal;
        private ColumnHeader chRazaAnimal;
        private ColumnHeader chNombreCuidador;
        private ColumnHeader chEspecieCuidador;
        private ColumnHeader chResponsableCuidador;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem informeToolStripMenuItem;
        private Label lblEspecieRefugio;
        private ToolStripMenuItem informeGeneralToolStripMenuItem;
    }
}

