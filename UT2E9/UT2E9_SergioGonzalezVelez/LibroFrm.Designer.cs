namespace UT2E9_SergioGonzalezVelez
{
    partial class LibroFrm
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
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.lblAnnoLibro = new System.Windows.Forms.Label();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtAnnoLibro = new System.Windows.Forms.TextBox();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.btnCancelarLibro = new System.Windows.Forms.Button();
            this.btnAceptarLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Location = new System.Drawing.Point(36, 26);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(35, 13);
            this.lblTituloLibro.TabIndex = 0;
            this.lblTituloLibro.Text = "Título";
            // 
            // lblAnnoLibro
            // 
            this.lblAnnoLibro.AutoSize = true;
            this.lblAnnoLibro.Location = new System.Drawing.Point(42, 48);
            this.lblAnnoLibro.Name = "lblAnnoLibro";
            this.lblAnnoLibro.Size = new System.Drawing.Size(26, 13);
            this.lblAnnoLibro.TabIndex = 1;
            this.lblAnnoLibro.Text = "Año";
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.Location = new System.Drawing.Point(36, 74);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(32, 13);
            this.lblAutorLibro.TabIndex = 2;
            this.lblAutorLibro.Text = "Autor";
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(77, 19);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(231, 20);
            this.txtTituloLibro.TabIndex = 3;
            // 
            // txtAnnoLibro
            // 
            this.txtAnnoLibro.Location = new System.Drawing.Point(77, 45);
            this.txtAnnoLibro.Name = "txtAnnoLibro";
            this.txtAnnoLibro.Size = new System.Drawing.Size(88, 20);
            this.txtAnnoLibro.TabIndex = 4;
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(77, 71);
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(231, 20);
            this.txtAutorLibro.TabIndex = 5;
            // 
            // btnCancelarLibro
            // 
            this.btnCancelarLibro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarLibro.Location = new System.Drawing.Point(233, 97);
            this.btnCancelarLibro.Name = "btnCancelarLibro";
            this.btnCancelarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarLibro.TabIndex = 6;
            this.btnCancelarLibro.Text = "Cancelar";
            this.btnCancelarLibro.UseVisualStyleBackColor = true;
            this.btnCancelarLibro.Click += new System.EventHandler(this.btnCancelarLibro_Click);
            // 
            // btnAceptarLibro
            // 
            this.btnAceptarLibro.Location = new System.Drawing.Point(141, 97);
            this.btnAceptarLibro.Name = "btnAceptarLibro";
            this.btnAceptarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarLibro.TabIndex = 7;
            this.btnAceptarLibro.Text = "Aceptar";
            this.btnAceptarLibro.UseVisualStyleBackColor = true;
            this.btnAceptarLibro.Click += new System.EventHandler(this.btnAceptarLibro_Click);
            // 
            // LibroFrm
            // 
            this.AcceptButton = this.btnAceptarLibro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarLibro;
            this.ClientSize = new System.Drawing.Size(326, 131);
            this.Controls.Add(this.btnAceptarLibro);
            this.Controls.Add(this.btnCancelarLibro);
            this.Controls.Add(this.txtAutorLibro);
            this.Controls.Add(this.txtAnnoLibro);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.lblAutorLibro);
            this.Controls.Add(this.lblAnnoLibro);
            this.Controls.Add(this.lblTituloLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LibroFrm";
            this.Text = "Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Label lblAnnoLibro;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtAnnoLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.Button btnCancelarLibro;
        private System.Windows.Forms.Button btnAceptarLibro;
    }
}