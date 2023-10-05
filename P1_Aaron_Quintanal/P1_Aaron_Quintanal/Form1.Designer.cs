namespace P1_Aaron_Quintanal
{
    partial class frmListadoFaltas
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
            this.mnsListadoFaltas = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwListaProfesores = new System.Windows.Forms.ListView();
            this.chDiaFalta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sustituto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnsListadoFaltas.SuspendLayout();
            this.cmsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsListadoFaltas
            // 
            this.mnsListadoFaltas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tsmiProfesores});
            this.mnsListadoFaltas.Location = new System.Drawing.Point(0, 0);
            this.mnsListadoFaltas.Name = "mnsListadoFaltas";
            this.mnsListadoFaltas.Size = new System.Drawing.Size(800, 24);
            this.mnsListadoFaltas.TabIndex = 0;
            this.mnsListadoFaltas.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivoNuevo,
            this.toolStripMenuItem1,
            this.tsmiArchivoSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmiArchivoNuevo
            // 
            this.tsmiArchivoNuevo.Name = "tsmiArchivoNuevo";
            this.tsmiArchivoNuevo.Size = new System.Drawing.Size(180, 22);
            this.tsmiArchivoNuevo.Text = "Nuevo";
            this.tsmiArchivoNuevo.Click += new System.EventHandler(this.tsmiArchivoNuevo_Click);
            // 
            // tsmiArchivoSalir
            // 
            this.tsmiArchivoSalir.Name = "tsmiArchivoSalir";
            this.tsmiArchivoSalir.Size = new System.Drawing.Size(180, 22);
            this.tsmiArchivoSalir.Text = "Salir";
            this.tsmiArchivoSalir.Click += new System.EventHandler(this.tsmiArchivoSalir_Click);
            // 
            // tsmiProfesores
            // 
            this.tsmiProfesores.Name = "tsmiProfesores";
            this.tsmiProfesores.Size = new System.Drawing.Size(74, 20);
            this.tsmiProfesores.Text = "Profesores";
            this.tsmiProfesores.Click += new System.EventHandler(this.tsmiProfesores_Click);
            // 
            // lvwListaProfesores
            // 
            this.lvwListaProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDiaFalta,
            this.chHora,
            this.chGrupo,
            this.Sustituto});
            this.lvwListaProfesores.ContextMenuStrip = this.cmsMenuStrip;
            this.lvwListaProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwListaProfesores.GridLines = true;
            this.lvwListaProfesores.HideSelection = false;
            this.lvwListaProfesores.Location = new System.Drawing.Point(0, 24);
            this.lvwListaProfesores.MultiSelect = false;
            this.lvwListaProfesores.Name = "lvwListaProfesores";
            this.lvwListaProfesores.Size = new System.Drawing.Size(800, 426);
            this.lvwListaProfesores.TabIndex = 1;
            this.lvwListaProfesores.UseCompatibleStateImageBehavior = false;
            this.lvwListaProfesores.View = System.Windows.Forms.View.Details;
            // 
            // chDiaFalta
            // 
            this.chDiaFalta.Text = "Dia";
            this.chDiaFalta.Width = 169;
            // 
            // chHora
            // 
            this.chHora.Text = "Hora";
            this.chHora.Width = 114;
            // 
            // chGrupo
            // 
            this.chGrupo.Text = "Grupo";
            this.chGrupo.Width = 141;
            // 
            // Sustituto
            // 
            this.Sustituto.Text = "Sustituto";
            this.Sustituto.Width = 365;
            // 
            // cmsMenuStrip
            // 
            this.cmsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevo,
            this.tsmiVer,
            this.tsmiEliminar});
            this.cmsMenuStrip.Name = "cmsMenuStrip";
            this.cmsMenuStrip.Size = new System.Drawing.Size(118, 70);
            this.cmsMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuStrip_Opening);
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(117, 22);
            this.tsmiNuevo.Text = "Nuevo";
            this.tsmiNuevo.Click += new System.EventHandler(this.tsmiNuevo_Click);
            // 
            // tsmiVer
            // 
            this.tsmiVer.Enabled = false;
            this.tsmiVer.Name = "tsmiVer";
            this.tsmiVer.Size = new System.Drawing.Size(117, 22);
            this.tsmiVer.Text = "Ver";
            this.tsmiVer.Click += new System.EventHandler(this.tsmiVer_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Enabled = false;
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(117, 22);
            this.tsmiEliminar.Text = "Eliminar";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // frmListadoFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwListaProfesores);
            this.Controls.Add(this.mnsListadoFaltas);
            this.MainMenuStrip = this.mnsListadoFaltas;
            this.Name = "frmListadoFaltas";
            this.Text = "Listado de faltas";
            this.Load += new System.EventHandler(this.frmListadoFaltas_Load);
            this.mnsListadoFaltas.ResumeLayout(false);
            this.mnsListadoFaltas.PerformLayout();
            this.cmsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsListadoFaltas;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivoNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfesores;
        private System.Windows.Forms.ListView lvwListaProfesores;
        private System.Windows.Forms.ColumnHeader chDiaFalta;
        private System.Windows.Forms.ColumnHeader chHora;
        private System.Windows.Forms.ColumnHeader chGrupo;
        private System.Windows.Forms.ColumnHeader Sustituto;
        private System.Windows.Forms.ContextMenuStrip cmsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiVer;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

