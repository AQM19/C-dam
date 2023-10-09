namespace GuardiApp
{
    partial class frmListaGuardias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaGuardias));
            this.tsmiGuardiasBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.guardiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardiasNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardiasEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.msGuardias = new System.Windows.Forms.MenuStrip();
            this.CmsGuardiasLv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.chAula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiaSemana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHorario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProfGuardia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProfFalta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lvGuardias = new System.Windows.Forms.ListView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.msGuardias.SuspendLayout();
            this.CmsGuardiasLv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmiGuardiasBorrar
            // 
            this.tsmiGuardiasBorrar.Image = global::GuardiApp.Properties.Resources.elimianr;
            this.tsmiGuardiasBorrar.Name = "tsmiGuardiasBorrar";
            this.tsmiGuardiasBorrar.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardiasBorrar.Text = "Borrar";
            this.tsmiGuardiasBorrar.Click += new System.EventHandler(this.tsmiBorrar_Click);
            // 
            // guardiasToolStripMenuItem
            // 
            this.guardiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGuardiasNueva,
            this.tsmiGuardiasEditar,
            this.tsmiGuardiasBorrar});
            this.guardiasToolStripMenuItem.Name = "guardiasToolStripMenuItem";
            this.guardiasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.guardiasToolStripMenuItem.Text = "Guardias";
            // 
            // tsmiGuardiasNueva
            // 
            this.tsmiGuardiasNueva.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGuardiasNueva.Image")));
            this.tsmiGuardiasNueva.Name = "tsmiGuardiasNueva";
            this.tsmiGuardiasNueva.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardiasNueva.Text = "Nueva";
            this.tsmiGuardiasNueva.Click += new System.EventHandler(this.tsmiNueva_Click);
            // 
            // tsmiGuardiasEditar
            // 
            this.tsmiGuardiasEditar.Image = global::GuardiApp.Properties.Resources.editar;
            this.tsmiGuardiasEditar.Name = "tsmiGuardiasEditar";
            this.tsmiGuardiasEditar.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardiasEditar.Text = "Editar";
            this.tsmiGuardiasEditar.Click += new System.EventHandler(this.tsmiEditar_Click);
            // 
            // msGuardias
            // 
            this.msGuardias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardiasToolStripMenuItem});
            this.msGuardias.Location = new System.Drawing.Point(0, 0);
            this.msGuardias.Name = "msGuardias";
            this.msGuardias.Size = new System.Drawing.Size(800, 24);
            this.msGuardias.TabIndex = 23;
            this.msGuardias.Text = "menuStrip1";
            // 
            // CmsGuardiasLv
            // 
            this.CmsGuardiasLv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNueva,
            this.tsmiEditar,
            this.tsmiBorrar});
            this.CmsGuardiasLv.Name = "CmsGuardiasLv";
            this.CmsGuardiasLv.Size = new System.Drawing.Size(109, 70);
            this.CmsGuardiasLv.Opening += new System.ComponentModel.CancelEventHandler(this.CmsGuardiasLv_Opening);
            // 
            // tsmiNueva
            // 
            this.tsmiNueva.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNueva.Image")));
            this.tsmiNueva.Name = "tsmiNueva";
            this.tsmiNueva.Size = new System.Drawing.Size(108, 22);
            this.tsmiNueva.Text = "Nueva";
            this.tsmiNueva.Click += new System.EventHandler(this.tsmiNueva_Click);
            // 
            // tsmiEditar
            // 
            this.tsmiEditar.Image = global::GuardiApp.Properties.Resources.editar;
            this.tsmiEditar.Name = "tsmiEditar";
            this.tsmiEditar.Size = new System.Drawing.Size(108, 22);
            this.tsmiEditar.Text = "Editar";
            this.tsmiEditar.Click += new System.EventHandler(this.tsmiEditar_Click);
            // 
            // tsmiBorrar
            // 
            this.tsmiBorrar.Image = global::GuardiApp.Properties.Resources.elimianr;
            this.tsmiBorrar.Name = "tsmiBorrar";
            this.tsmiBorrar.Size = new System.Drawing.Size(108, 22);
            this.tsmiBorrar.Text = "Borrar";
            this.tsmiBorrar.Click += new System.EventHandler(this.tsmiBorrar_Click);
            // 
            // chAula
            // 
            this.chAula.Text = "Aula";
            this.chAula.Width = 72;
            // 
            // chGrupo
            // 
            this.chGrupo.Text = "Grupo";
            this.chGrupo.Width = 65;
            // 
            // chHora
            // 
            this.chHora.Text = "Hora";
            this.chHora.Width = 65;
            // 
            // chDiaSemana
            // 
            this.chDiaSemana.Text = "Día Semana";
            this.chDiaSemana.Width = 82;
            // 
            // chHorario
            // 
            this.chHorario.Text = "Horario";
            this.chHorario.Width = 68;
            // 
            // chFecha
            // 
            this.chFecha.Text = "Fecha";
            this.chFecha.Width = 100;
            // 
            // chEstado
            // 
            this.chEstado.Text = "Estado";
            this.chEstado.Width = 72;
            // 
            // chProfGuardia
            // 
            this.chProfGuardia.Text = "Prof. Guardia";
            this.chProfGuardia.Width = 120;
            // 
            // chProfFalta
            // 
            this.chProfFalta.Text = "Prof. Falta";
            this.chProfFalta.Width = 120;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 30);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(676, 20);
            this.txtFiltro.TabIndex = 26;
            // 
            // lvGuardias
            // 
            this.lvGuardias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProfFalta,
            this.chProfGuardia,
            this.chEstado,
            this.chFecha,
            this.chHorario,
            this.chDiaSemana,
            this.chHora,
            this.chGrupo,
            this.chAula});
            this.lvGuardias.ContextMenuStrip = this.CmsGuardiasLv;
            this.lvGuardias.FullRowSelect = true;
            this.lvGuardias.GridLines = true;
            this.lvGuardias.HideSelection = false;
            this.lvGuardias.Location = new System.Drawing.Point(0, 56);
            this.lvGuardias.MultiSelect = false;
            this.lvGuardias.Name = "lvGuardias";
            this.lvGuardias.Size = new System.Drawing.Size(800, 394);
            this.lvGuardias.TabIndex = 24;
            this.lvGuardias.UseCompatibleStateImageBehavior = false;
            this.lvGuardias.View = System.Windows.Forms.View.Details;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(694, 27);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 33;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmListaGuardias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msGuardias);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lvGuardias);
            this.Controls.Add(this.btnFiltrar);
            this.Name = "frmListaGuardias";
            this.ShowIcon = false;
            this.Text = "Listado de guardias";
            this.msGuardias.ResumeLayout(false);
            this.msGuardias.PerformLayout();
            this.CmsGuardiasLv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmiGuardiasBorrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardiasNueva;
        private System.Windows.Forms.ToolStripMenuItem guardiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardiasEditar;
        private System.Windows.Forms.MenuStrip msGuardias;
        private System.Windows.Forms.ToolStripMenuItem tsmiBorrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmiNueva;
        private System.Windows.Forms.ContextMenuStrip CmsGuardiasLv;
        private System.Windows.Forms.ColumnHeader chAula;
        private System.Windows.Forms.ColumnHeader chGrupo;
        private System.Windows.Forms.ColumnHeader chHora;
        private System.Windows.Forms.ColumnHeader chDiaSemana;
        private System.Windows.Forms.ColumnHeader chHorario;
        private System.Windows.Forms.ColumnHeader chFecha;
        private System.Windows.Forms.ColumnHeader chEstado;
        private System.Windows.Forms.ColumnHeader chProfGuardia;
        private System.Windows.Forms.ColumnHeader chProfFalta;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ListView lvGuardias;
        private System.Windows.Forms.Button btnFiltrar;
    }
}