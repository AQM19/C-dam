namespace P1_Aaron_Quintanal
{
    partial class ListProfesores
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
            this.lvwListadoProfesores = new System.Windows.Forms.ListView();
            this.chCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuProfesores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNuevoProfe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerProfe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarProfe = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuProfesores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwListadoProfesores
            // 
            this.lvwListadoProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigo,
            this.chNombre,
            this.chTelefono});
            this.lvwListadoProfesores.ContextMenuStrip = this.cmsMenuProfesores;
            this.lvwListadoProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwListadoProfesores.FullRowSelect = true;
            this.lvwListadoProfesores.GridLines = true;
            this.lvwListadoProfesores.HideSelection = false;
            this.lvwListadoProfesores.Location = new System.Drawing.Point(0, 0);
            this.lvwListadoProfesores.MultiSelect = false;
            this.lvwListadoProfesores.Name = "lvwListadoProfesores";
            this.lvwListadoProfesores.Size = new System.Drawing.Size(800, 450);
            this.lvwListadoProfesores.TabIndex = 0;
            this.lvwListadoProfesores.UseCompatibleStateImageBehavior = false;
            this.lvwListadoProfesores.View = System.Windows.Forms.View.Details;
            this.lvwListadoProfesores.SelectedIndexChanged += new System.EventHandler(this.lvwListadoProfesores_SelectedIndexChanged);
            // 
            // chCodigo
            // 
            this.chCodigo.Text = "Codigo";
            this.chCodigo.Width = 286;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 248;
            // 
            // chTelefono
            // 
            this.chTelefono.Text = "Telefono";
            this.chTelefono.Width = 256;
            // 
            // cmsMenuProfesores
            // 
            this.cmsMenuProfesores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoProfe,
            this.tsmiVerProfe,
            this.tsmiEliminarProfe});
            this.cmsMenuProfesores.Name = "cmsMenuProfesores";
            this.cmsMenuProfesores.Size = new System.Drawing.Size(181, 92);
            this.cmsMenuProfesores.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuProfesores_Opening);
            // 
            // tsmiNuevoProfe
            // 
            this.tsmiNuevoProfe.Name = "tsmiNuevoProfe";
            this.tsmiNuevoProfe.Size = new System.Drawing.Size(117, 22);
            this.tsmiNuevoProfe.Text = "Nuevo";
            this.tsmiNuevoProfe.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // tsmiVerProfe
            // 
            this.tsmiVerProfe.Enabled = false;
            this.tsmiVerProfe.Name = "tsmiVerProfe";
            this.tsmiVerProfe.Size = new System.Drawing.Size(117, 22);
            this.tsmiVerProfe.Text = "Ver";
            this.tsmiVerProfe.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // tsmiEliminarProfe
            // 
            this.tsmiEliminarProfe.Enabled = false;
            this.tsmiEliminarProfe.Name = "tsmiEliminarProfe";
            this.tsmiEliminarProfe.Size = new System.Drawing.Size(117, 22);
            this.tsmiEliminarProfe.Text = "Eliminar";
            this.tsmiEliminarProfe.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // ListProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwListadoProfesores);
            this.Name = "ListProfesores";
            this.Text = "ListProfesorescs";
            this.Load += new System.EventHandler(this.ListProfesorescs_Load);
            this.cmsMenuProfesores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwListadoProfesores;
        private System.Windows.Forms.ColumnHeader chCodigo;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chTelefono;
        private System.Windows.Forms.ContextMenuStrip cmsMenuProfesores;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoProfe;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerProfe;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarProfe;
    }
}