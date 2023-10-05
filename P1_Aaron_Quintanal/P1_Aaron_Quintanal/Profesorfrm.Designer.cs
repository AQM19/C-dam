namespace P1_Aaron_Quintanal
{
    partial class Profesorfrm
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
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblTelefonoProfe = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.txtTelefonoProfe = new System.Windows.Forms.TextBox();
            this.txtCodigoPofe = new System.Windows.Forms.TextBox();
            this.grpCuerpoProfe = new System.Windows.Forms.GroupBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbFP = new System.Windows.Forms.RadioButton();
            this.rbSecundaria = new System.Windows.Forms.RadioButton();
            this.btnCancelarProfe = new System.Windows.Forms.Button();
            this.btnAceptarProfe = new System.Windows.Forms.Button();
            this.grpCuerpoProfe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(33, 41);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 0;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblTelefonoProfe
            // 
            this.lblTelefonoProfe.AutoSize = true;
            this.lblTelefonoProfe.Location = new System.Drawing.Point(33, 79);
            this.lblTelefonoProfe.Name = "lblTelefonoProfe";
            this.lblTelefonoProfe.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoProfe.TabIndex = 1;
            this.lblTelefonoProfe.Text = "Teléfono";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(219, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(90, 38);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(297, 20);
            this.txtNombreProfe.TabIndex = 3;
            // 
            // txtTelefonoProfe
            // 
            this.txtTelefonoProfe.Location = new System.Drawing.Point(90, 76);
            this.txtTelefonoProfe.Name = "txtTelefonoProfe";
            this.txtTelefonoProfe.Size = new System.Drawing.Size(112, 20);
            this.txtTelefonoProfe.TabIndex = 4;
            this.txtTelefonoProfe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoProfe_KeyPress);
            // 
            // txtCodigoPofe
            // 
            this.txtCodigoPofe.Location = new System.Drawing.Point(275, 76);
            this.txtCodigoPofe.Name = "txtCodigoPofe";
            this.txtCodigoPofe.ReadOnly = true;
            this.txtCodigoPofe.Size = new System.Drawing.Size(112, 20);
            this.txtCodigoPofe.TabIndex = 5;
            // 
            // grpCuerpoProfe
            // 
            this.grpCuerpoProfe.Controls.Add(this.rbOtro);
            this.grpCuerpoProfe.Controls.Add(this.rbFP);
            this.grpCuerpoProfe.Controls.Add(this.rbSecundaria);
            this.grpCuerpoProfe.Location = new System.Drawing.Point(36, 117);
            this.grpCuerpoProfe.Name = "grpCuerpoProfe";
            this.grpCuerpoProfe.Size = new System.Drawing.Size(351, 79);
            this.grpCuerpoProfe.TabIndex = 6;
            this.grpCuerpoProfe.TabStop = false;
            this.grpCuerpoProfe.Text = "Cuerpo";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(208, 40);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.TabStop = true;
            this.rbOtro.Tag = "Otro";
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbSecundaria_CheckedChanged);
            // 
            // rbFP
            // 
            this.rbFP.AutoSize = true;
            this.rbFP.Location = new System.Drawing.Point(136, 40);
            this.rbFP.Name = "rbFP";
            this.rbFP.Size = new System.Drawing.Size(44, 17);
            this.rbFP.TabIndex = 1;
            this.rbFP.TabStop = true;
            this.rbFP.Tag = "FP";
            this.rbFP.Text = "F.P.";
            this.rbFP.UseVisualStyleBackColor = true;
            this.rbFP.CheckedChanged += new System.EventHandler(this.rbSecundaria_CheckedChanged);
            // 
            // rbSecundaria
            // 
            this.rbSecundaria.AutoSize = true;
            this.rbSecundaria.Checked = true;
            this.rbSecundaria.Location = new System.Drawing.Point(33, 40);
            this.rbSecundaria.Name = "rbSecundaria";
            this.rbSecundaria.Size = new System.Drawing.Size(79, 17);
            this.rbSecundaria.TabIndex = 0;
            this.rbSecundaria.TabStop = true;
            this.rbSecundaria.Tag = "Secundaria";
            this.rbSecundaria.Text = "Secundaria";
            this.rbSecundaria.UseVisualStyleBackColor = true;
            this.rbSecundaria.CheckedChanged += new System.EventHandler(this.rbSecundaria_CheckedChanged);
            // 
            // btnCancelarProfe
            // 
            this.btnCancelarProfe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarProfe.Location = new System.Drawing.Point(312, 212);
            this.btnCancelarProfe.Name = "btnCancelarProfe";
            this.btnCancelarProfe.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProfe.TabIndex = 7;
            this.btnCancelarProfe.Text = "Cancelar";
            this.btnCancelarProfe.UseVisualStyleBackColor = true;
            this.btnCancelarProfe.Click += new System.EventHandler(this.btnCancelarProfe_Click);
            // 
            // btnAceptarProfe
            // 
            this.btnAceptarProfe.Location = new System.Drawing.Point(222, 212);
            this.btnAceptarProfe.Name = "btnAceptarProfe";
            this.btnAceptarProfe.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarProfe.TabIndex = 8;
            this.btnAceptarProfe.Text = "Aceptar";
            this.btnAceptarProfe.UseVisualStyleBackColor = true;
            this.btnAceptarProfe.Click += new System.EventHandler(this.btnAceptarProfe_Click);
            // 
            // Profesorfrm
            // 
            this.AcceptButton = this.btnAceptarProfe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarProfe;
            this.ClientSize = new System.Drawing.Size(432, 272);
            this.Controls.Add(this.btnAceptarProfe);
            this.Controls.Add(this.btnCancelarProfe);
            this.Controls.Add(this.grpCuerpoProfe);
            this.Controls.Add(this.txtCodigoPofe);
            this.Controls.Add(this.txtTelefonoProfe);
            this.Controls.Add(this.txtNombreProfe);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTelefonoProfe);
            this.Controls.Add(this.lblNombreProfe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Profesorfrm";
            this.Text = "Profesor";
            this.grpCuerpoProfe.ResumeLayout(false);
            this.grpCuerpoProfe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblTelefonoProfe;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.TextBox txtTelefonoProfe;
        private System.Windows.Forms.TextBox txtCodigoPofe;
        private System.Windows.Forms.GroupBox grpCuerpoProfe;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbFP;
        private System.Windows.Forms.RadioButton rbSecundaria;
        private System.Windows.Forms.Button btnCancelarProfe;
        private System.Windows.Forms.Button btnAceptarProfe;
    }
}