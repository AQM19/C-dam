namespace DEMO_Split
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Primero");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Segundo");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("DAM", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Informática", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.tvArbol = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvArbol);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtInfo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(800, 180);
            this.txtInfo.TabIndex = 0;
            // 
            // tvArbol
            // 
            this.tvArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvArbol.Location = new System.Drawing.Point(0, 0);
            this.tvArbol.Name = "tvArbol";
            treeNode1.Name = "Nodo3";
            treeNode1.Text = "Primero";
            treeNode2.Name = "Nodo4";
            treeNode2.Text = "Segundo";
            treeNode3.Name = "Nodo2";
            treeNode3.Text = "DAM";
            treeNode4.Name = "ndInfo";
            treeNode4.Text = "Informática";
            this.tvArbol.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvArbol.Size = new System.Drawing.Size(800, 266);
            this.tvArbol.TabIndex = 0;
            this.tvArbol.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvArbol_BeforeExpand);
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArbol_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

