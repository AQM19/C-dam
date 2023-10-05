namespace ZoocanV2
{
    partial class VisorInforme
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
            this.rpvVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvVisor
            // 
            this.rpvVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvVisor.Location = new System.Drawing.Point(0, 0);
            this.rpvVisor.Name = "rpvVisor";
            this.rpvVisor.ServerReport.BearerToken = null;
            this.rpvVisor.Size = new System.Drawing.Size(800, 450);
            this.rpvVisor.TabIndex = 0;
            // 
            // VisorInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvVisor);
            this.Name = "VisorInforme";
            this.Text = "VisorInforme";
            this.Load += new System.EventHandler(this.VisorInforme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvVisor;
    }
}