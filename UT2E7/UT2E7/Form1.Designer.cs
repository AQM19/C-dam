namespace UT2E7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splExplorer = new System.Windows.Forms.SplitContainer();
            this.tvwArbol = new System.Windows.Forms.TreeView();
            this.lvwListado = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamaño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListaIconos = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splExplorer)).BeginInit();
            this.splExplorer.Panel1.SuspendLayout();
            this.splExplorer.Panel2.SuspendLayout();
            this.splExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splExplorer
            // 
            this.splExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splExplorer.Location = new System.Drawing.Point(0, 0);
            this.splExplorer.Name = "splExplorer";
            // 
            // splExplorer.Panel1
            // 
            this.splExplorer.Panel1.Controls.Add(this.tvwArbol);
            // 
            // splExplorer.Panel2
            // 
            this.splExplorer.Panel2.Controls.Add(this.lvwListado);
            this.splExplorer.Size = new System.Drawing.Size(800, 450);
            this.splExplorer.SplitterDistance = 266;
            this.splExplorer.TabIndex = 0;
            // 
            // tvwArbol
            // 
            this.tvwArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwArbol.ImageIndex = 0;
            this.tvwArbol.ImageList = this.imgListaIconos;
            this.tvwArbol.Location = new System.Drawing.Point(0, 0);
            this.tvwArbol.Name = "tvwArbol";
            this.tvwArbol.SelectedImageIndex = 0;
            this.tvwArbol.Size = new System.Drawing.Size(266, 450);
            this.tvwArbol.TabIndex = 0;
            this.tvwArbol.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwArbol_BeforeExpand);
            this.tvwArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwArbol_AfterSelect);
            // 
            // lvwListado
            // 
            this.lvwListado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Fecha,
            this.Tamaño});
            this.lvwListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwListado.HideSelection = false;
            this.lvwListado.Location = new System.Drawing.Point(0, 0);
            this.lvwListado.Name = "lvwListado";
            this.lvwListado.Size = new System.Drawing.Size(530, 450);
            this.lvwListado.SmallImageList = this.imgListaIconos;
            this.lvwListado.TabIndex = 0;
            this.lvwListado.UseCompatibleStateImageBehavior = false;
            this.lvwListado.View = System.Windows.Forms.View.Details;
            this.lvwListado.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwListado_ColumnClick);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 243;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha de modificación";
            this.Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fecha.Width = 154;
            // 
            // Tamaño
            // 
            this.Tamaño.Text = "Tamaño";
            this.Tamaño.Width = 127;
            // 
            // imgListaIconos
            // 
            this.imgListaIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListaIconos.ImageStream")));
            this.imgListaIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListaIconos.Images.SetKeyName(0, "folder_Closed_16xLG.png");
            this.imgListaIconos.Images.SetKeyName(1, "folder_Open_16xLG.png");
            this.imgListaIconos.Images.SetKeyName(2, "document_16xLG.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splExplorer.Panel1.ResumeLayout(false);
            this.splExplorer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splExplorer)).EndInit();
            this.splExplorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splExplorer;
        private System.Windows.Forms.TreeView tvwArbol;
        private System.Windows.Forms.ListView lvwListado;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Tamaño;
        private System.Windows.Forms.ImageList imgListaIconos;
    }
}

