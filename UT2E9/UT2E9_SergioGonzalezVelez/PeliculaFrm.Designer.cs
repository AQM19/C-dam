namespace UT2E9_SergioGonzalezVelez
{
    partial class PeliculaFrm
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
            this.btnAceptarPelicula = new System.Windows.Forms.Button();
            this.btnCancelarPelicula = new System.Windows.Forms.Button();
            this.txtGeneroPelicula = new System.Windows.Forms.TextBox();
            this.txtAnnoPelicula = new System.Windows.Forms.TextBox();
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.lblGeneroPelicula = new System.Windows.Forms.Label();
            this.lblAnnoPelicula = new System.Windows.Forms.Label();
            this.lblTituloPelicula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptarPelicula
            // 
            this.btnAceptarPelicula.Location = new System.Drawing.Point(145, 96);
            this.btnAceptarPelicula.Name = "btnAceptarPelicula";
            this.btnAceptarPelicula.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPelicula.TabIndex = 15;
            this.btnAceptarPelicula.Text = "Aceptar";
            this.btnAceptarPelicula.UseVisualStyleBackColor = true;
            this.btnAceptarPelicula.Click += new System.EventHandler(this.btnAceptarPelicula_Click);
            // 
            // btnCancelarPelicula
            // 
            this.btnCancelarPelicula.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarPelicula.Location = new System.Drawing.Point(237, 96);
            this.btnCancelarPelicula.Name = "btnCancelarPelicula";
            this.btnCancelarPelicula.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPelicula.TabIndex = 14;
            this.btnCancelarPelicula.Text = "Cancelar";
            this.btnCancelarPelicula.UseVisualStyleBackColor = true;
            this.btnCancelarPelicula.Click += new System.EventHandler(this.btnCancelarPelicula_Click);
            // 
            // txtGeneroPelicula
            // 
            this.txtGeneroPelicula.Location = new System.Drawing.Point(80, 70);
            this.txtGeneroPelicula.Name = "txtGeneroPelicula";
            this.txtGeneroPelicula.Size = new System.Drawing.Size(231, 20);
            this.txtGeneroPelicula.TabIndex = 13;
            // 
            // txtAnnoPelicula
            // 
            this.txtAnnoPelicula.Location = new System.Drawing.Point(80, 44);
            this.txtAnnoPelicula.Name = "txtAnnoPelicula";
            this.txtAnnoPelicula.Size = new System.Drawing.Size(88, 20);
            this.txtAnnoPelicula.TabIndex = 12;
            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.Location = new System.Drawing.Point(80, 18);
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(231, 20);
            this.txtTituloPelicula.TabIndex = 11;
            // 
            // lblGeneroPelicula
            // 
            this.lblGeneroPelicula.AutoSize = true;
            this.lblGeneroPelicula.Location = new System.Drawing.Point(32, 73);
            this.lblGeneroPelicula.Name = "lblGeneroPelicula";
            this.lblGeneroPelicula.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroPelicula.TabIndex = 10;
            this.lblGeneroPelicula.Text = "Género";
            // 
            // lblAnnoPelicula
            // 
            this.lblAnnoPelicula.AutoSize = true;
            this.lblAnnoPelicula.Location = new System.Drawing.Point(48, 47);
            this.lblAnnoPelicula.Name = "lblAnnoPelicula";
            this.lblAnnoPelicula.Size = new System.Drawing.Size(26, 13);
            this.lblAnnoPelicula.TabIndex = 9;
            this.lblAnnoPelicula.Text = "Año";
            // 
            // lblTituloPelicula
            // 
            this.lblTituloPelicula.AutoSize = true;
            this.lblTituloPelicula.Location = new System.Drawing.Point(39, 21);
            this.lblTituloPelicula.Name = "lblTituloPelicula";
            this.lblTituloPelicula.Size = new System.Drawing.Size(35, 13);
            this.lblTituloPelicula.TabIndex = 8;
            this.lblTituloPelicula.Text = "Título";
            // 
            // PeliculaFrm
            // 
            this.AcceptButton = this.btnAceptarPelicula;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarPelicula;
            this.ClientSize = new System.Drawing.Size(321, 131);
            this.Controls.Add(this.btnAceptarPelicula);
            this.Controls.Add(this.btnCancelarPelicula);
            this.Controls.Add(this.txtGeneroPelicula);
            this.Controls.Add(this.txtAnnoPelicula);
            this.Controls.Add(this.txtTituloPelicula);
            this.Controls.Add(this.lblGeneroPelicula);
            this.Controls.Add(this.lblAnnoPelicula);
            this.Controls.Add(this.lblTituloPelicula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PeliculaFrm";
            this.Text = "PeliculaFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarPelicula;
        private System.Windows.Forms.Button btnCancelarPelicula;
        private System.Windows.Forms.TextBox txtGeneroPelicula;
        private System.Windows.Forms.TextBox txtAnnoPelicula;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.Label lblGeneroPelicula;
        private System.Windows.Forms.Label lblAnnoPelicula;
        private System.Windows.Forms.Label lblTituloPelicula;
    }
}