<<<<<<< HEAD
﻿namespace UT2E4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBoton6 = new System.Windows.Forms.RadioButton();
            this.rdoBoton5 = new System.Windows.Forms.RadioButton();
            this.rdoBoton4 = new System.Windows.Forms.RadioButton();
            this.rdoBoton3 = new System.Windows.Forms.RadioButton();
            this.rdoBoton2 = new System.Windows.Forms.RadioButton();
            this.rdoBoton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoIcon8 = new System.Windows.Forms.RadioButton();
            this.rdoIcon7 = new System.Windows.Forms.RadioButton();
            this.rdoIcon6 = new System.Windows.Forms.RadioButton();
            this.rdoIcon5 = new System.Windows.Forms.RadioButton();
            this.rdoIcon4 = new System.Windows.Forms.RadioButton();
            this.rdoIcon3 = new System.Windows.Forms.RadioButton();
            this.rdoIcon2 = new System.Windows.Forms.RadioButton();
            this.rdoIcon1 = new System.Windows.Forms.RadioButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblResultadoMensaje = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBoton6);
            this.groupBox1.Controls.Add(this.rdoBoton5);
            this.groupBox1.Controls.Add(this.rdoBoton4);
            this.groupBox1.Controls.Add(this.rdoBoton3);
            this.groupBox1.Controls.Add(this.rdoBoton2);
            this.groupBox1.Controls.Add(this.rdoBoton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de botón";
            // 
            // rdoBoton6
            // 
            this.rdoBoton6.AutoSize = true;
            this.rdoBoton6.Location = new System.Drawing.Point(7, 155);
            this.rdoBoton6.Name = "rdoBoton6";
            this.rdoBoton6.Size = new System.Drawing.Size(121, 17);
            this.rdoBoton6.TabIndex = 5;
            this.rdoBoton6.TabStop = true;
            this.rdoBoton6.Tag = "RetryCancel";
            this.rdoBoton6.Text = "Reintentar/Cancelar";
            this.rdoBoton6.UseVisualStyleBackColor = true;
            this.rdoBoton6.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton5
            // 
            this.rdoBoton5.AutoSize = true;
            this.rdoBoton5.Location = new System.Drawing.Point(7, 131);
            this.rdoBoton5.Name = "rdoBoton5";
            this.rdoBoton5.Size = new System.Drawing.Size(53, 17);
            this.rdoBoton5.TabIndex = 4;
            this.rdoBoton5.TabStop = true;
            this.rdoBoton5.Tag = "YesNo";
            this.rdoBoton5.Text = "Si/No";
            this.rdoBoton5.UseVisualStyleBackColor = true;
            this.rdoBoton5.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton4
            // 
            this.rdoBoton4.AutoSize = true;
            this.rdoBoton4.Location = new System.Drawing.Point(7, 107);
            this.rdoBoton4.Name = "rdoBoton4";
            this.rdoBoton4.Size = new System.Drawing.Size(97, 17);
            this.rdoBoton4.TabIndex = 3;
            this.rdoBoton4.TabStop = true;
            this.rdoBoton4.Tag = "YesNoCancel";
            this.rdoBoton4.Text = "Si/No/Cancela";
            this.rdoBoton4.UseVisualStyleBackColor = true;
            this.rdoBoton4.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton3
            // 
            this.rdoBoton3.AutoSize = true;
            this.rdoBoton3.Location = new System.Drawing.Point(7, 84);
            this.rdoBoton3.Name = "rdoBoton3";
            this.rdoBoton3.Size = new System.Drawing.Size(151, 17);
            this.rdoBoton3.TabIndex = 2;
            this.rdoBoton3.TabStop = true;
            this.rdoBoton3.Tag = "AbortRetryIgnore";
            this.rdoBoton3.Text = "Abortar/Reintentar/Ignorar";
            this.rdoBoton3.UseVisualStyleBackColor = true;
            this.rdoBoton3.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton2
            // 
            this.rdoBoton2.AutoSize = true;
            this.rdoBoton2.Location = new System.Drawing.Point(7, 59);
            this.rdoBoton2.Name = "rdoBoton2";
            this.rdoBoton2.Size = new System.Drawing.Size(109, 17);
            this.rdoBoton2.TabIndex = 1;
            this.rdoBoton2.TabStop = true;
            this.rdoBoton2.Tag = "OKCancel";
            this.rdoBoton2.Text = "Aceptar/Cancelar";
            this.rdoBoton2.UseVisualStyleBackColor = true;
            this.rdoBoton2.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton1
            // 
            this.rdoBoton1.AutoSize = true;
            this.rdoBoton1.Location = new System.Drawing.Point(7, 35);
            this.rdoBoton1.Name = "rdoBoton1";
            this.rdoBoton1.Size = new System.Drawing.Size(62, 17);
            this.rdoBoton1.TabIndex = 0;
            this.rdoBoton1.TabStop = true;
            this.rdoBoton1.Tag = "OK";
            this.rdoBoton1.Text = "Aceptar";
            this.rdoBoton1.UseVisualStyleBackColor = true;
            this.rdoBoton1.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoIcon8);
            this.groupBox2.Controls.Add(this.rdoIcon7);
            this.groupBox2.Controls.Add(this.rdoIcon6);
            this.groupBox2.Controls.Add(this.rdoIcon5);
            this.groupBox2.Controls.Add(this.rdoIcon4);
            this.groupBox2.Controls.Add(this.rdoIcon3);
            this.groupBox2.Controls.Add(this.rdoIcon2);
            this.groupBox2.Controls.Add(this.rdoIcon1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icono";
            // 
            // rdoIcon8
            // 
            this.rdoIcon8.AutoSize = true;
            this.rdoIcon8.Location = new System.Drawing.Point(7, 203);
            this.rdoIcon8.Name = "rdoIcon8";
            this.rdoIcon8.Size = new System.Drawing.Size(82, 17);
            this.rdoIcon8.TabIndex = 7;
            this.rdoIcon8.TabStop = true;
            this.rdoIcon8.Tag = "Warning";
            this.rdoIcon8.Text = "Advertencia";
            this.rdoIcon8.UseVisualStyleBackColor = true;
            this.rdoIcon8.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon7
            // 
            this.rdoIcon7.AutoSize = true;
            this.rdoIcon7.Location = new System.Drawing.Point(7, 179);
            this.rdoIcon7.Name = "rdoIcon7";
            this.rdoIcon7.Size = new System.Drawing.Size(43, 17);
            this.rdoIcon7.TabIndex = 6;
            this.rdoIcon7.TabStop = true;
            this.rdoIcon7.Tag = "Stop";
            this.rdoIcon7.Text = "Alto";
            this.rdoIcon7.UseVisualStyleBackColor = true;
            this.rdoIcon7.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon6
            // 
            this.rdoIcon6.AutoSize = true;
            this.rdoIcon6.Location = new System.Drawing.Point(7, 155);
            this.rdoIcon6.Name = "rdoIcon6";
            this.rdoIcon6.Size = new System.Drawing.Size(68, 17);
            this.rdoIcon6.TabIndex = 5;
            this.rdoIcon6.TabStop = true;
            this.rdoIcon6.Tag = "Question";
            this.rdoIcon6.Text = "Pregunta";
            this.rdoIcon6.UseVisualStyleBackColor = true;
            this.rdoIcon6.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon5
            // 
            this.rdoIcon5.AutoSize = true;
            this.rdoIcon5.Location = new System.Drawing.Point(7, 131);
            this.rdoIcon5.Name = "rdoIcon5";
            this.rdoIcon5.Size = new System.Drawing.Size(80, 17);
            this.rdoIcon5.TabIndex = 4;
            this.rdoIcon5.TabStop = true;
            this.rdoIcon5.Tag = "Information";
            this.rdoIcon5.Text = "Información";
            this.rdoIcon5.UseVisualStyleBackColor = true;
            this.rdoIcon5.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon4
            // 
            this.rdoIcon4.AutoSize = true;
            this.rdoIcon4.Location = new System.Drawing.Point(7, 107);
            this.rdoIcon4.Name = "rdoIcon4";
            this.rdoIcon4.Size = new System.Drawing.Size(52, 17);
            this.rdoIcon4.TabIndex = 3;
            this.rdoIcon4.TabStop = true;
            this.rdoIcon4.Tag = "Hand";
            this.rdoIcon4.Text = "Mano";
            this.rdoIcon4.UseVisualStyleBackColor = true;
            this.rdoIcon4.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon3
            // 
            this.rdoIcon3.AutoSize = true;
            this.rdoIcon3.Location = new System.Drawing.Point(7, 83);
            this.rdoIcon3.Name = "rdoIcon3";
            this.rdoIcon3.Size = new System.Drawing.Size(85, 17);
            this.rdoIcon3.TabIndex = 2;
            this.rdoIcon3.TabStop = true;
            this.rdoIcon3.Tag = "Exclamation";
            this.rdoIcon3.Text = "Exclamación";
            this.rdoIcon3.UseVisualStyleBackColor = true;
            this.rdoIcon3.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon2
            // 
            this.rdoIcon2.AutoSize = true;
            this.rdoIcon2.Location = new System.Drawing.Point(7, 59);
            this.rdoIcon2.Name = "rdoIcon2";
            this.rdoIcon2.Size = new System.Drawing.Size(47, 17);
            this.rdoIcon2.TabIndex = 1;
            this.rdoIcon2.TabStop = true;
            this.rdoIcon2.Tag = "Error";
            this.rdoIcon2.Text = "Error";
            this.rdoIcon2.UseVisualStyleBackColor = true;
            this.rdoIcon2.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon1
            // 
            this.rdoIcon1.AutoSize = true;
            this.rdoIcon1.Location = new System.Drawing.Point(7, 35);
            this.rdoIcon1.Name = "rdoIcon1";
            this.rdoIcon1.Size = new System.Drawing.Size(68, 17);
            this.rdoIcon1.TabIndex = 0;
            this.rdoIcon1.TabStop = true;
            this.rdoIcon1.Tag = "Asterisk";
            this.rdoIcon1.Text = "Asterisco";
            this.rdoIcon1.UseVisualStyleBackColor = true;
            this.rdoIcon1.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(96, 253);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(322, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(19, 253);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(96, 280);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(322, 20);
            this.txtMensaje.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(19, 280);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblResultadoMensaje
            // 
            this.lblResultadoMensaje.AutoSize = true;
            this.lblResultadoMensaje.Location = new System.Drawing.Point(19, 313);
            this.lblResultadoMensaje.Name = "lblResultadoMensaje";
            this.lblResultadoMensaje.Size = new System.Drawing.Size(98, 13);
            this.lblResultadoMensaje.TabIndex = 6;
            this.lblResultadoMensaje.Text = "Resultado Mensaje";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(342, 313);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 346);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblResultadoMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBoton6;
        private System.Windows.Forms.RadioButton rdoBoton5;
        private System.Windows.Forms.RadioButton rdoBoton4;
        private System.Windows.Forms.RadioButton rdoBoton3;
        private System.Windows.Forms.RadioButton rdoBoton2;
        private System.Windows.Forms.RadioButton rdoBoton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoIcon8;
        private System.Windows.Forms.RadioButton rdoIcon7;
        private System.Windows.Forms.RadioButton rdoIcon6;
        private System.Windows.Forms.RadioButton rdoIcon5;
        private System.Windows.Forms.RadioButton rdoIcon4;
        private System.Windows.Forms.RadioButton rdoIcon3;
        private System.Windows.Forms.RadioButton rdoIcon2;
        private System.Windows.Forms.RadioButton rdoIcon1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblResultadoMensaje;
        private System.Windows.Forms.Button btnMostrar;
    }
}

=======
﻿namespace UT2E4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBoton6 = new System.Windows.Forms.RadioButton();
            this.rdoBoton5 = new System.Windows.Forms.RadioButton();
            this.rdoBoton4 = new System.Windows.Forms.RadioButton();
            this.rdoBoton3 = new System.Windows.Forms.RadioButton();
            this.rdoBoton2 = new System.Windows.Forms.RadioButton();
            this.rdoBoton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoIcon8 = new System.Windows.Forms.RadioButton();
            this.rdoIcon7 = new System.Windows.Forms.RadioButton();
            this.rdoIcon6 = new System.Windows.Forms.RadioButton();
            this.rdoIcon5 = new System.Windows.Forms.RadioButton();
            this.rdoIcon4 = new System.Windows.Forms.RadioButton();
            this.rdoIcon3 = new System.Windows.Forms.RadioButton();
            this.rdoIcon2 = new System.Windows.Forms.RadioButton();
            this.rdoIcon1 = new System.Windows.Forms.RadioButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblResultadoMensaje = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBoton6);
            this.groupBox1.Controls.Add(this.rdoBoton5);
            this.groupBox1.Controls.Add(this.rdoBoton4);
            this.groupBox1.Controls.Add(this.rdoBoton3);
            this.groupBox1.Controls.Add(this.rdoBoton2);
            this.groupBox1.Controls.Add(this.rdoBoton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de botón";
            // 
            // rdoBoton6
            // 
            this.rdoBoton6.AutoSize = true;
            this.rdoBoton6.Location = new System.Drawing.Point(7, 155);
            this.rdoBoton6.Name = "rdoBoton6";
            this.rdoBoton6.Size = new System.Drawing.Size(121, 17);
            this.rdoBoton6.TabIndex = 5;
            this.rdoBoton6.TabStop = true;
            this.rdoBoton6.Tag = "RetryCancel";
            this.rdoBoton6.Text = "Reintentar/Cancelar";
            this.rdoBoton6.UseVisualStyleBackColor = true;
            this.rdoBoton6.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton5
            // 
            this.rdoBoton5.AutoSize = true;
            this.rdoBoton5.Location = new System.Drawing.Point(7, 131);
            this.rdoBoton5.Name = "rdoBoton5";
            this.rdoBoton5.Size = new System.Drawing.Size(53, 17);
            this.rdoBoton5.TabIndex = 4;
            this.rdoBoton5.TabStop = true;
            this.rdoBoton5.Tag = "YesNo";
            this.rdoBoton5.Text = "Si/No";
            this.rdoBoton5.UseVisualStyleBackColor = true;
            this.rdoBoton5.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton4
            // 
            this.rdoBoton4.AutoSize = true;
            this.rdoBoton4.Location = new System.Drawing.Point(7, 107);
            this.rdoBoton4.Name = "rdoBoton4";
            this.rdoBoton4.Size = new System.Drawing.Size(97, 17);
            this.rdoBoton4.TabIndex = 3;
            this.rdoBoton4.TabStop = true;
            this.rdoBoton4.Tag = "YesNoCancel";
            this.rdoBoton4.Text = "Si/No/Cancela";
            this.rdoBoton4.UseVisualStyleBackColor = true;
            this.rdoBoton4.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton3
            // 
            this.rdoBoton3.AutoSize = true;
            this.rdoBoton3.Location = new System.Drawing.Point(7, 84);
            this.rdoBoton3.Name = "rdoBoton3";
            this.rdoBoton3.Size = new System.Drawing.Size(151, 17);
            this.rdoBoton3.TabIndex = 2;
            this.rdoBoton3.TabStop = true;
            this.rdoBoton3.Tag = "AbortRetryIgnore";
            this.rdoBoton3.Text = "Abortar/Reintentar/Ignorar";
            this.rdoBoton3.UseVisualStyleBackColor = true;
            this.rdoBoton3.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton2
            // 
            this.rdoBoton2.AutoSize = true;
            this.rdoBoton2.Location = new System.Drawing.Point(7, 59);
            this.rdoBoton2.Name = "rdoBoton2";
            this.rdoBoton2.Size = new System.Drawing.Size(109, 17);
            this.rdoBoton2.TabIndex = 1;
            this.rdoBoton2.TabStop = true;
            this.rdoBoton2.Tag = "OKCancel";
            this.rdoBoton2.Text = "Aceptar/Cancelar";
            this.rdoBoton2.UseVisualStyleBackColor = true;
            this.rdoBoton2.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // rdoBoton1
            // 
            this.rdoBoton1.AutoSize = true;
            this.rdoBoton1.Location = new System.Drawing.Point(7, 35);
            this.rdoBoton1.Name = "rdoBoton1";
            this.rdoBoton1.Size = new System.Drawing.Size(62, 17);
            this.rdoBoton1.TabIndex = 0;
            this.rdoBoton1.TabStop = true;
            this.rdoBoton1.Tag = "OK";
            this.rdoBoton1.Text = "Aceptar";
            this.rdoBoton1.UseVisualStyleBackColor = true;
            this.rdoBoton1.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoBoton);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoIcon8);
            this.groupBox2.Controls.Add(this.rdoIcon7);
            this.groupBox2.Controls.Add(this.rdoIcon6);
            this.groupBox2.Controls.Add(this.rdoIcon5);
            this.groupBox2.Controls.Add(this.rdoIcon4);
            this.groupBox2.Controls.Add(this.rdoIcon3);
            this.groupBox2.Controls.Add(this.rdoIcon2);
            this.groupBox2.Controls.Add(this.rdoIcon1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icono";
            // 
            // rdoIcon8
            // 
            this.rdoIcon8.AutoSize = true;
            this.rdoIcon8.Location = new System.Drawing.Point(7, 203);
            this.rdoIcon8.Name = "rdoIcon8";
            this.rdoIcon8.Size = new System.Drawing.Size(82, 17);
            this.rdoIcon8.TabIndex = 7;
            this.rdoIcon8.TabStop = true;
            this.rdoIcon8.Tag = "Warning";
            this.rdoIcon8.Text = "Advertencia";
            this.rdoIcon8.UseVisualStyleBackColor = true;
            this.rdoIcon8.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon7
            // 
            this.rdoIcon7.AutoSize = true;
            this.rdoIcon7.Location = new System.Drawing.Point(7, 179);
            this.rdoIcon7.Name = "rdoIcon7";
            this.rdoIcon7.Size = new System.Drawing.Size(43, 17);
            this.rdoIcon7.TabIndex = 6;
            this.rdoIcon7.TabStop = true;
            this.rdoIcon7.Tag = "Stop";
            this.rdoIcon7.Text = "Alto";
            this.rdoIcon7.UseVisualStyleBackColor = true;
            this.rdoIcon7.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon6
            // 
            this.rdoIcon6.AutoSize = true;
            this.rdoIcon6.Location = new System.Drawing.Point(7, 155);
            this.rdoIcon6.Name = "rdoIcon6";
            this.rdoIcon6.Size = new System.Drawing.Size(68, 17);
            this.rdoIcon6.TabIndex = 5;
            this.rdoIcon6.TabStop = true;
            this.rdoIcon6.Tag = "Question";
            this.rdoIcon6.Text = "Pregunta";
            this.rdoIcon6.UseVisualStyleBackColor = true;
            this.rdoIcon6.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon5
            // 
            this.rdoIcon5.AutoSize = true;
            this.rdoIcon5.Location = new System.Drawing.Point(7, 131);
            this.rdoIcon5.Name = "rdoIcon5";
            this.rdoIcon5.Size = new System.Drawing.Size(80, 17);
            this.rdoIcon5.TabIndex = 4;
            this.rdoIcon5.TabStop = true;
            this.rdoIcon5.Tag = "Information";
            this.rdoIcon5.Text = "Información";
            this.rdoIcon5.UseVisualStyleBackColor = true;
            this.rdoIcon5.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon4
            // 
            this.rdoIcon4.AutoSize = true;
            this.rdoIcon4.Location = new System.Drawing.Point(7, 107);
            this.rdoIcon4.Name = "rdoIcon4";
            this.rdoIcon4.Size = new System.Drawing.Size(52, 17);
            this.rdoIcon4.TabIndex = 3;
            this.rdoIcon4.TabStop = true;
            this.rdoIcon4.Tag = "Hand";
            this.rdoIcon4.Text = "Mano";
            this.rdoIcon4.UseVisualStyleBackColor = true;
            this.rdoIcon4.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon3
            // 
            this.rdoIcon3.AutoSize = true;
            this.rdoIcon3.Location = new System.Drawing.Point(7, 83);
            this.rdoIcon3.Name = "rdoIcon3";
            this.rdoIcon3.Size = new System.Drawing.Size(85, 17);
            this.rdoIcon3.TabIndex = 2;
            this.rdoIcon3.TabStop = true;
            this.rdoIcon3.Tag = "Exclamation";
            this.rdoIcon3.Text = "Exclamación";
            this.rdoIcon3.UseVisualStyleBackColor = true;
            this.rdoIcon3.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon2
            // 
            this.rdoIcon2.AutoSize = true;
            this.rdoIcon2.Location = new System.Drawing.Point(7, 59);
            this.rdoIcon2.Name = "rdoIcon2";
            this.rdoIcon2.Size = new System.Drawing.Size(47, 17);
            this.rdoIcon2.TabIndex = 1;
            this.rdoIcon2.TabStop = true;
            this.rdoIcon2.Tag = "Error";
            this.rdoIcon2.Text = "Error";
            this.rdoIcon2.UseVisualStyleBackColor = true;
            this.rdoIcon2.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // rdoIcon1
            // 
            this.rdoIcon1.AutoSize = true;
            this.rdoIcon1.Location = new System.Drawing.Point(7, 35);
            this.rdoIcon1.Name = "rdoIcon1";
            this.rdoIcon1.Size = new System.Drawing.Size(68, 17);
            this.rdoIcon1.TabIndex = 0;
            this.rdoIcon1.TabStop = true;
            this.rdoIcon1.Tag = "Asterisk";
            this.rdoIcon1.Text = "Asterisco";
            this.rdoIcon1.UseVisualStyleBackColor = true;
            this.rdoIcon1.CheckedChanged += new System.EventHandler(this.CambioRadioGrupoIcono);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(96, 253);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(322, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(19, 253);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(96, 280);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(322, 20);
            this.txtMensaje.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(19, 280);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblResultadoMensaje
            // 
            this.lblResultadoMensaje.AutoSize = true;
            this.lblResultadoMensaje.Location = new System.Drawing.Point(19, 313);
            this.lblResultadoMensaje.Name = "lblResultadoMensaje";
            this.lblResultadoMensaje.Size = new System.Drawing.Size(98, 13);
            this.lblResultadoMensaje.TabIndex = 6;
            this.lblResultadoMensaje.Text = "Resultado Mensaje";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(342, 313);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 346);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblResultadoMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBoton6;
        private System.Windows.Forms.RadioButton rdoBoton5;
        private System.Windows.Forms.RadioButton rdoBoton4;
        private System.Windows.Forms.RadioButton rdoBoton3;
        private System.Windows.Forms.RadioButton rdoBoton2;
        private System.Windows.Forms.RadioButton rdoBoton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoIcon8;
        private System.Windows.Forms.RadioButton rdoIcon7;
        private System.Windows.Forms.RadioButton rdoIcon6;
        private System.Windows.Forms.RadioButton rdoIcon5;
        private System.Windows.Forms.RadioButton rdoIcon4;
        private System.Windows.Forms.RadioButton rdoIcon3;
        private System.Windows.Forms.RadioButton rdoIcon2;
        private System.Windows.Forms.RadioButton rdoIcon1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblResultadoMensaje;
        private System.Windows.Forms.Button btnMostrar;
    }
}

>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
