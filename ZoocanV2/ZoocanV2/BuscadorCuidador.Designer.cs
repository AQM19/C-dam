﻿namespace ZoocanV2
{
    partial class BuscadorCuidador
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
            this.txtCuidador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCuidador
            // 
            this.txtCuidador.Location = new System.Drawing.Point(12, 12);
            this.txtCuidador.Name = "txtCuidador";
            this.txtCuidador.Size = new System.Drawing.Size(178, 20);
            this.txtCuidador.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ZoocanV2.Properties.Resources.action_add_16xMD;
            this.btnBuscar.Location = new System.Drawing.Point(196, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(20, 20);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscadorCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 43);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCuidador);
            this.Name = "BuscadorCuidador";
            this.Text = "Buscador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuidador;
        private System.Windows.Forms.Button btnBuscar;
    }
}