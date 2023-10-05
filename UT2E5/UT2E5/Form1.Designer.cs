<<<<<<< HEAD
﻿namespace UT2E5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrBuscarSiguiente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrAjusteLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNotepad = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrNuevo,
            this.tsrAbrir,
            this.tsrGuardar,
            this.tsrGuardarComo,
            this.toolStripSeparator3,
            this.tsrSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsrNuevo
            // 
            this.tsrNuevo.Name = "tsrNuevo";
            this.tsrNuevo.Size = new System.Drawing.Size(161, 22);
            this.tsrNuevo.Text = "Nuevo";
            this.tsrNuevo.Click += new System.EventHandler(this.tsrNuevo_Click);
            // 
            // tsrAbrir
            // 
            this.tsrAbrir.Name = "tsrAbrir";
            this.tsrAbrir.Size = new System.Drawing.Size(161, 22);
            this.tsrAbrir.Text = "Abrir";
            this.tsrAbrir.Click += new System.EventHandler(this.tsrAbrir_Click);
            // 
            // tsrGuardar
            // 
            this.tsrGuardar.Image = global::UT2E5.Properties.Resources.Save_6530;
            this.tsrGuardar.Name = "tsrGuardar";
            this.tsrGuardar.Size = new System.Drawing.Size(161, 22);
            this.tsrGuardar.Text = "Guardar";
            this.tsrGuardar.Click += new System.EventHandler(this.tsrGuardar_Click);
            // 
            // tsrGuardarComo
            // 
            this.tsrGuardarComo.Name = "tsrGuardarComo";
            this.tsrGuardarComo.Size = new System.Drawing.Size(161, 22);
            this.tsrGuardarComo.Text = "Guardar Como...";
            this.tsrGuardarComo.Click += new System.EventHandler(this.tsrGuardarComo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // tsrSalir
            // 
            this.tsrSalir.Name = "tsrSalir";
            this.tsrSalir.Size = new System.Drawing.Size(161, 22);
            this.tsrSalir.Text = "Salir";
            this.tsrSalir.Click += new System.EventHandler(this.tsrSalir_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrDeshacer,
            this.toolStripSeparator1,
            this.tsrCortar,
            this.tsrCopiar,
            this.tsrPegar,
            this.tsrEliminar,
            this.toolStripSeparator2,
            this.tsrBuscar,
            this.tsrBuscarSiguiente,
            this.toolStripSeparator4,
            this.tsrSeleccionarTodo});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.editarToolStripMenuItem.Text = "Edición";
            // 
            // tsrDeshacer
            // 
            this.tsrDeshacer.Image = global::UT2E5.Properties.Resources.Undo_16x;
            this.tsrDeshacer.Name = "tsrDeshacer";
            this.tsrDeshacer.Size = new System.Drawing.Size(180, 22);
            this.tsrDeshacer.Text = "Deshacer";
            this.tsrDeshacer.Click += new System.EventHandler(this.tsrDeshacer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsrCortar
            // 
            this.tsrCortar.Image = global::UT2E5.Properties.Resources.Cut_6523;
            this.tsrCortar.Name = "tsrCortar";
            this.tsrCortar.Size = new System.Drawing.Size(180, 22);
            this.tsrCortar.Text = "Cortar";
            this.tsrCortar.Click += new System.EventHandler(this.tsrCortar_Click);
            // 
            // tsrCopiar
            // 
            this.tsrCopiar.Image = global::UT2E5.Properties.Resources.Copy_6524;
            this.tsrCopiar.Name = "tsrCopiar";
            this.tsrCopiar.Size = new System.Drawing.Size(180, 22);
            this.tsrCopiar.Text = "Copiar";
            this.tsrCopiar.Click += new System.EventHandler(this.tsrCopiar_Click);
            // 
            // tsrPegar
            // 
            this.tsrPegar.Image = global::UT2E5.Properties.Resources.Paste_6520;
            this.tsrPegar.Name = "tsrPegar";
            this.tsrPegar.Size = new System.Drawing.Size(180, 22);
            this.tsrPegar.Text = "Pegar";
            this.tsrPegar.Click += new System.EventHandler(this.tsrPegar_Click);
            // 
            // tsrEliminar
            // 
            this.tsrEliminar.Name = "tsrEliminar";
            this.tsrEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsrEliminar.Text = "Eliminar";
            this.tsrEliminar.Click += new System.EventHandler(this.tsrEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsrBuscar
            // 
            this.tsrBuscar.Name = "tsrBuscar";
            this.tsrBuscar.Size = new System.Drawing.Size(180, 22);
            this.tsrBuscar.Text = "Buscar";
            this.tsrBuscar.Click += new System.EventHandler(this.tsrBuscar_Click);
            // 
            // tsrBuscarSiguiente
            // 
            this.tsrBuscarSiguiente.Name = "tsrBuscarSiguiente";
            this.tsrBuscarSiguiente.Size = new System.Drawing.Size(180, 22);
            this.tsrBuscarSiguiente.Text = "Buscar siguiente";
            this.tsrBuscarSiguiente.Click += new System.EventHandler(this.tsrBuscarSiguiente_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsrSeleccionarTodo
            // 
            this.tsrSeleccionarTodo.Name = "tsrSeleccionarTodo";
            this.tsrSeleccionarTodo.Size = new System.Drawing.Size(180, 22);
            this.tsrSeleccionarTodo.Text = "Seleccionar todo";
            this.tsrSeleccionarTodo.Click += new System.EventHandler(this.tsrSeleccionarTodo_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrAjusteLinea,
            this.tsrFuente});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // tsrAjusteLinea
            // 
            this.tsrAjusteLinea.Name = "tsrAjusteLinea";
            this.tsrAjusteLinea.Size = new System.Drawing.Size(151, 22);
            this.tsrAjusteLinea.Text = "Ajuste de línea";
            this.tsrAjusteLinea.Click += new System.EventHandler(this.tsrAjusteLinea_Click);
            // 
            // tsrFuente
            // 
            this.tsrFuente.Name = "tsrFuente";
            this.tsrFuente.Size = new System.Drawing.Size(151, 22);
            this.tsrFuente.Text = "Fuente";
            this.tsrFuente.Click += new System.EventHandler(this.tsrFuente_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tsrAcercaDe
            // 
            this.tsrAcercaDe.Name = "tsrAcercaDe";
            this.tsrAcercaDe.Size = new System.Drawing.Size(135, 22);
            this.tsrAcercaDe.Text = "Acerca de...";
            this.tsrAcercaDe.Click += new System.EventHandler(this.tsrAcercaDe_Click);
            // 
            // txtNotepad
            // 
            this.txtNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotepad.Location = new System.Drawing.Point(0, 24);
            this.txtNotepad.Multiline = true;
            this.txtNotepad.Name = "txtNotepad";
            this.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotepad.Size = new System.Drawing.Size(800, 426);
            this.txtNotepad.TabIndex = 1;
            this.txtNotepad.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNotepad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioCerrandose);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsrAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsrGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsrGuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsrSalir;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsrCortar;
        private System.Windows.Forms.ToolStripMenuItem tsrCopiar;
        private System.Windows.Forms.ToolStripMenuItem tsrPegar;
        private System.Windows.Forms.ToolStripMenuItem tsrEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsrBuscar;
        private System.Windows.Forms.ToolStripMenuItem tsrBuscarSiguiente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsrSeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrAjusteLinea;
        private System.Windows.Forms.ToolStripMenuItem tsrFuente;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrAcercaDe;
        private System.Windows.Forms.TextBox txtNotepad;
    }
}

=======
﻿namespace UT2E5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrBuscarSiguiente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrAjusteLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNotepad = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrNuevo,
            this.tsrAbrir,
            this.tsrGuardar,
            this.tsrGuardarComo,
            this.toolStripSeparator3,
            this.tsrSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsrNuevo
            // 
            this.tsrNuevo.Name = "tsrNuevo";
            this.tsrNuevo.Size = new System.Drawing.Size(161, 22);
            this.tsrNuevo.Text = "Nuevo";
            this.tsrNuevo.Click += new System.EventHandler(this.tsrNuevo_Click);
            // 
            // tsrAbrir
            // 
            this.tsrAbrir.Name = "tsrAbrir";
            this.tsrAbrir.Size = new System.Drawing.Size(161, 22);
            this.tsrAbrir.Text = "Abrir";
            this.tsrAbrir.Click += new System.EventHandler(this.tsrAbrir_Click);
            // 
            // tsrGuardar
            // 
            this.tsrGuardar.Image = global::UT2E5.Properties.Resources.Save_6530;
            this.tsrGuardar.Name = "tsrGuardar";
            this.tsrGuardar.Size = new System.Drawing.Size(161, 22);
            this.tsrGuardar.Text = "Guardar";
            this.tsrGuardar.Click += new System.EventHandler(this.tsrGuardar_Click);
            // 
            // tsrGuardarComo
            // 
            this.tsrGuardarComo.Name = "tsrGuardarComo";
            this.tsrGuardarComo.Size = new System.Drawing.Size(161, 22);
            this.tsrGuardarComo.Text = "Guardar Como...";
            this.tsrGuardarComo.Click += new System.EventHandler(this.tsrGuardarComo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // tsrSalir
            // 
            this.tsrSalir.Name = "tsrSalir";
            this.tsrSalir.Size = new System.Drawing.Size(161, 22);
            this.tsrSalir.Text = "Salir";
            this.tsrSalir.Click += new System.EventHandler(this.tsrSalir_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrDeshacer,
            this.toolStripSeparator1,
            this.tsrCortar,
            this.tsrCopiar,
            this.tsrPegar,
            this.tsrEliminar,
            this.toolStripSeparator2,
            this.tsrBuscar,
            this.tsrBuscarSiguiente,
            this.toolStripSeparator4,
            this.tsrSeleccionarTodo});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.editarToolStripMenuItem.Text = "Edición";
            // 
            // tsrDeshacer
            // 
            this.tsrDeshacer.Image = global::UT2E5.Properties.Resources.Undo_16x;
            this.tsrDeshacer.Name = "tsrDeshacer";
            this.tsrDeshacer.Size = new System.Drawing.Size(180, 22);
            this.tsrDeshacer.Text = "Deshacer";
            this.tsrDeshacer.Click += new System.EventHandler(this.tsrDeshacer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsrCortar
            // 
            this.tsrCortar.Image = global::UT2E5.Properties.Resources.Cut_6523;
            this.tsrCortar.Name = "tsrCortar";
            this.tsrCortar.Size = new System.Drawing.Size(180, 22);
            this.tsrCortar.Text = "Cortar";
            this.tsrCortar.Click += new System.EventHandler(this.tsrCortar_Click);
            // 
            // tsrCopiar
            // 
            this.tsrCopiar.Image = global::UT2E5.Properties.Resources.Copy_6524;
            this.tsrCopiar.Name = "tsrCopiar";
            this.tsrCopiar.Size = new System.Drawing.Size(180, 22);
            this.tsrCopiar.Text = "Copiar";
            this.tsrCopiar.Click += new System.EventHandler(this.tsrCopiar_Click);
            // 
            // tsrPegar
            // 
            this.tsrPegar.Image = global::UT2E5.Properties.Resources.Paste_6520;
            this.tsrPegar.Name = "tsrPegar";
            this.tsrPegar.Size = new System.Drawing.Size(180, 22);
            this.tsrPegar.Text = "Pegar";
            this.tsrPegar.Click += new System.EventHandler(this.tsrPegar_Click);
            // 
            // tsrEliminar
            // 
            this.tsrEliminar.Name = "tsrEliminar";
            this.tsrEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsrEliminar.Text = "Eliminar";
            this.tsrEliminar.Click += new System.EventHandler(this.tsrEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsrBuscar
            // 
            this.tsrBuscar.Name = "tsrBuscar";
            this.tsrBuscar.Size = new System.Drawing.Size(180, 22);
            this.tsrBuscar.Text = "Buscar";
            this.tsrBuscar.Click += new System.EventHandler(this.tsrBuscar_Click);
            // 
            // tsrBuscarSiguiente
            // 
            this.tsrBuscarSiguiente.Name = "tsrBuscarSiguiente";
            this.tsrBuscarSiguiente.Size = new System.Drawing.Size(180, 22);
            this.tsrBuscarSiguiente.Text = "Buscar siguiente";
            this.tsrBuscarSiguiente.Click += new System.EventHandler(this.tsrBuscarSiguiente_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsrSeleccionarTodo
            // 
            this.tsrSeleccionarTodo.Name = "tsrSeleccionarTodo";
            this.tsrSeleccionarTodo.Size = new System.Drawing.Size(180, 22);
            this.tsrSeleccionarTodo.Text = "Seleccionar todo";
            this.tsrSeleccionarTodo.Click += new System.EventHandler(this.tsrSeleccionarTodo_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrAjusteLinea,
            this.tsrFuente});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // tsrAjusteLinea
            // 
            this.tsrAjusteLinea.Name = "tsrAjusteLinea";
            this.tsrAjusteLinea.Size = new System.Drawing.Size(151, 22);
            this.tsrAjusteLinea.Text = "Ajuste de línea";
            this.tsrAjusteLinea.Click += new System.EventHandler(this.tsrAjusteLinea_Click);
            // 
            // tsrFuente
            // 
            this.tsrFuente.Name = "tsrFuente";
            this.tsrFuente.Size = new System.Drawing.Size(151, 22);
            this.tsrFuente.Text = "Fuente";
            this.tsrFuente.Click += new System.EventHandler(this.tsrFuente_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tsrAcercaDe
            // 
            this.tsrAcercaDe.Name = "tsrAcercaDe";
            this.tsrAcercaDe.Size = new System.Drawing.Size(135, 22);
            this.tsrAcercaDe.Text = "Acerca de...";
            this.tsrAcercaDe.Click += new System.EventHandler(this.tsrAcercaDe_Click);
            // 
            // txtNotepad
            // 
            this.txtNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotepad.Location = new System.Drawing.Point(0, 24);
            this.txtNotepad.Multiline = true;
            this.txtNotepad.Name = "txtNotepad";
            this.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotepad.Size = new System.Drawing.Size(800, 426);
            this.txtNotepad.TabIndex = 1;
            this.txtNotepad.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNotepad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioCerrandose);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsrAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsrGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsrGuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsrSalir;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsrCortar;
        private System.Windows.Forms.ToolStripMenuItem tsrCopiar;
        private System.Windows.Forms.ToolStripMenuItem tsrPegar;
        private System.Windows.Forms.ToolStripMenuItem tsrEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsrBuscar;
        private System.Windows.Forms.ToolStripMenuItem tsrBuscarSiguiente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsrSeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrAjusteLinea;
        private System.Windows.Forms.ToolStripMenuItem tsrFuente;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrAcercaDe;
        private System.Windows.Forms.TextBox txtNotepad;
    }
}

>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
