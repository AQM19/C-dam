namespace GuardiApp
{
    partial class fmrGuardiasMDI
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
            this.tsmiPestañasGuardias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPestañas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmiPestañasGuardias
            // 
            this.tsmiPestañasGuardias.Name = "tsmiPestañasGuardias";
            this.tsmiPestañasGuardias.Size = new System.Drawing.Size(120, 22);
            this.tsmiPestañasGuardias.Text = "Guardias";
            this.tsmiPestañasGuardias.Click += new System.EventHandler(this.tsmiPestañasGuardias_Click);
            // 
            // tsmiPestañas
            // 
            this.tsmiPestañas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPestañasGuardias});
            this.tsmiPestañas.Name = "tsmiPestañas";
            this.tsmiPestañas.Size = new System.Drawing.Size(65, 20);
            this.tsmiPestañas.Text = "Pestañas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPestañas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fmrGuardiasMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "fmrGuardiasMDI";
            this.ShowIcon = false;
            this.Text = "GuardiApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmiPestañasGuardias;
        private System.Windows.Forms.ToolStripMenuItem tsmiPestañas;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}