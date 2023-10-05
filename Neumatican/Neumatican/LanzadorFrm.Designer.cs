namespace Neumatican
{
    partial class LanzadorFrm
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
            this.btnInforme1 = new System.Windows.Forms.Button();
            this.btnInforme2 = new System.Windows.Forms.Button();
            this.btnInforme3 = new System.Windows.Forms.Button();
            this.btnInforme4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInforme1
            // 
            this.btnInforme1.Location = new System.Drawing.Point(12, 12);
            this.btnInforme1.Name = "btnInforme1";
            this.btnInforme1.Size = new System.Drawing.Size(75, 23);
            this.btnInforme1.TabIndex = 0;
            this.btnInforme1.Text = "button1";
            this.btnInforme1.UseVisualStyleBackColor = true;
            this.btnInforme1.Click += new System.EventHandler(this.btnInforme1_Click);
            // 
            // btnInforme2
            // 
            this.btnInforme2.Location = new System.Drawing.Point(12, 43);
            this.btnInforme2.Name = "btnInforme2";
            this.btnInforme2.Size = new System.Drawing.Size(75, 23);
            this.btnInforme2.TabIndex = 1;
            this.btnInforme2.Text = "button2";
            this.btnInforme2.UseVisualStyleBackColor = true;
            // 
            // btnInforme3
            // 
            this.btnInforme3.Location = new System.Drawing.Point(189, 12);
            this.btnInforme3.Name = "btnInforme3";
            this.btnInforme3.Size = new System.Drawing.Size(75, 23);
            this.btnInforme3.TabIndex = 2;
            this.btnInforme3.Text = "button3";
            this.btnInforme3.UseVisualStyleBackColor = true;
            // 
            // btnInforme4
            // 
            this.btnInforme4.Location = new System.Drawing.Point(189, 43);
            this.btnInforme4.Name = "btnInforme4";
            this.btnInforme4.Size = new System.Drawing.Size(75, 23);
            this.btnInforme4.TabIndex = 3;
            this.btnInforme4.Text = "button4";
            this.btnInforme4.UseVisualStyleBackColor = true;
            // 
            // LanzadorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 78);
            this.Controls.Add(this.btnInforme4);
            this.Controls.Add(this.btnInforme3);
            this.Controls.Add(this.btnInforme2);
            this.Controls.Add(this.btnInforme1);
            this.Name = "LanzadorFrm";
            this.Text = "LanzadorFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInforme1;
        private System.Windows.Forms.Button btnInforme2;
        private System.Windows.Forms.Button btnInforme3;
        private System.Windows.Forms.Button btnInforme4;
    }
}