namespace UT3E1
{
    partial class LanzadorFrm
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
            this.btnInforme1 = new System.Windows.Forms.Button();
            this.btnInforme2 = new System.Windows.Forms.Button();
            this.btnInforme3 = new System.Windows.Forms.Button();
            this.btnInforme0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInforme1
            // 
            this.btnInforme1.Location = new System.Drawing.Point(161, 12);
            this.btnInforme1.Name = "btnInforme1";
            this.btnInforme1.Size = new System.Drawing.Size(122, 72);
            this.btnInforme1.TabIndex = 0;
            this.btnInforme1.Text = "Informe 1";
            this.btnInforme1.UseVisualStyleBackColor = true;
            this.btnInforme1.Click += new System.EventHandler(this.btnInforme1_Click);
            // 
            // btnInforme2
            // 
            this.btnInforme2.Location = new System.Drawing.Point(317, 12);
            this.btnInforme2.Name = "btnInforme2";
            this.btnInforme2.Size = new System.Drawing.Size(122, 72);
            this.btnInforme2.TabIndex = 1;
            this.btnInforme2.Text = "Informe 2";
            this.btnInforme2.UseVisualStyleBackColor = true;
            this.btnInforme2.Click += new System.EventHandler(this.btnInforme2_Click);
            // 
            // btnInforme3
            // 
            this.btnInforme3.Location = new System.Drawing.Point(468, 12);
            this.btnInforme3.Name = "btnInforme3";
            this.btnInforme3.Size = new System.Drawing.Size(122, 72);
            this.btnInforme3.TabIndex = 2;
            this.btnInforme3.Text = "Informe 3";
            this.btnInforme3.UseVisualStyleBackColor = true;
            this.btnInforme3.Click += new System.EventHandler(this.btnInforme3_Click);
            // 
            // btnInforme0
            // 
            this.btnInforme0.Location = new System.Drawing.Point(12, 12);
            this.btnInforme0.Name = "btnInforme0";
            this.btnInforme0.Size = new System.Drawing.Size(122, 72);
            this.btnInforme0.TabIndex = 3;
            this.btnInforme0.Text = "Informe 0";
            this.btnInforme0.UseVisualStyleBackColor = true;
            this.btnInforme0.Click += new System.EventHandler(this.btnInforme0_Click);
            // 
            // LanzadorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 100);
            this.Controls.Add(this.btnInforme0);
            this.Controls.Add(this.btnInforme3);
            this.Controls.Add(this.btnInforme2);
            this.Controls.Add(this.btnInforme1);
            this.Name = "LanzadorFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInforme1;
        private System.Windows.Forms.Button btnInforme2;
        private System.Windows.Forms.Button btnInforme3;
        private System.Windows.Forms.Button btnInforme0;
    }
}

