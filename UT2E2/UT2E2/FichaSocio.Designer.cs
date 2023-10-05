<<<<<<< HEAD
﻿namespace UT2E2
{
    partial class FichaSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSexGroup1 = new System.Windows.Forms.RadioButton();
            this.rbSexGroup2 = new System.Windows.Forms.RadioButton();
            this.rbSexGroup3 = new System.Windows.Forms.RadioButton();
            this.grpAficiones = new System.Windows.Forms.GroupBox();
            this.txtAficiones = new System.Windows.Forms.TextBox();
            this.chkOtras = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkDeportes = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSituacion = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.grpAficiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo";
            // 
            // rbSexGroup1
            // 
            this.rbSexGroup1.AutoSize = true;
            this.rbSexGroup1.Checked = true;
            this.rbSexGroup1.Location = new System.Drawing.Point(129, 85);
            this.rbSexGroup1.Name = "rbSexGroup1";
            this.rbSexGroup1.Size = new System.Drawing.Size(62, 17);
            this.rbSexGroup1.TabIndex = 5;
            this.rbSexGroup1.TabStop = true;
            this.rbSexGroup1.Text = "Hombre";
            this.rbSexGroup1.UseVisualStyleBackColor = true;
            // 
            // rbSexGroup2
            // 
            this.rbSexGroup2.AutoSize = true;
            this.rbSexGroup2.Location = new System.Drawing.Point(197, 85);
            this.rbSexGroup2.Name = "rbSexGroup2";
            this.rbSexGroup2.Size = new System.Drawing.Size(51, 17);
            this.rbSexGroup2.TabIndex = 6;
            this.rbSexGroup2.Text = "Mujer";
            this.rbSexGroup2.UseVisualStyleBackColor = true;
            // 
            // rbSexGroup3
            // 
            this.rbSexGroup3.AutoSize = true;
            this.rbSexGroup3.Location = new System.Drawing.Point(254, 85);
            this.rbSexGroup3.Name = "rbSexGroup3";
            this.rbSexGroup3.Size = new System.Drawing.Size(50, 17);
            this.rbSexGroup3.TabIndex = 7;
            this.rbSexGroup3.Text = "Otros";
            this.rbSexGroup3.UseVisualStyleBackColor = true;
            // 
            // grpAficiones
            // 
            this.grpAficiones.Controls.Add(this.txtAficiones);
            this.grpAficiones.Controls.Add(this.chkOtras);
            this.grpAficiones.Controls.Add(this.chkLectura);
            this.grpAficiones.Controls.Add(this.chkMusica);
            this.grpAficiones.Controls.Add(this.chkDeportes);
            this.grpAficiones.Location = new System.Drawing.Point(23, 118);
            this.grpAficiones.Name = "grpAficiones";
            this.grpAficiones.Size = new System.Drawing.Size(324, 113);
            this.grpAficiones.TabIndex = 8;
            this.grpAficiones.TabStop = false;
            this.grpAficiones.Text = "Aficiones";
            // 
            // txtAficiones
            // 
            this.txtAficiones.Enabled = false;
            this.txtAficiones.Location = new System.Drawing.Point(7, 43);
            this.txtAficiones.Multiline = true;
            this.txtAficiones.Name = "txtAficiones";
            this.txtAficiones.Size = new System.Drawing.Size(311, 64);
            this.txtAficiones.TabIndex = 4;
            // 
            // chkOtras
            // 
            this.chkOtras.AutoSize = true;
            this.chkOtras.Location = new System.Drawing.Point(215, 19);
            this.chkOtras.Name = "chkOtras";
            this.chkOtras.Size = new System.Drawing.Size(51, 17);
            this.chkOtras.TabIndex = 3;
            this.chkOtras.Text = "Otras";
            this.chkOtras.UseVisualStyleBackColor = true;
            this.chkOtras.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(147, 19);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(62, 17);
            this.chkLectura.TabIndex = 2;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(81, 19);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(60, 17);
            this.chkMusica.TabIndex = 1;
            this.chkMusica.Text = "Musica";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            this.chkDeportes.AutoSize = true;
            this.chkDeportes.Location = new System.Drawing.Point(6, 19);
            this.chkDeportes.Name = "chkDeportes";
            this.chkDeportes.Size = new System.Drawing.Size(69, 17);
            this.chkDeportes.TabIndex = 0;
            this.chkDeportes.Text = "Deportes";
            this.chkDeportes.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(129, 51);
            this.dtpFecha.MaxDate = new System.DateTime(2022, 10, 7, 15, 2, 52, 0);
            this.dtpFecha.MinDate = new System.DateTime(1903, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(175, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Situacion";
            // 
            // cboSituacion
            // 
            this.cboSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacion.Items.AddRange(new object[] {
            "Becario",
            "Empleado",
            "Excedencia",
            "Jubilado"});
            this.cboSituacion.Location = new System.Drawing.Point(104, 237);
            this.cboSituacion.Name = "cboSituacion";
            this.cboSituacion.Size = new System.Drawing.Size(200, 21);
            this.cboSituacion.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(278, 279);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(197, 279);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 314);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboSituacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.grpAficiones);
            this.Controls.Add(this.rbSexGroup3);
            this.Controls.Add(this.rbSexGroup2);
            this.Controls.Add(this.rbSexGroup1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ficha socio";
            this.grpAficiones.ResumeLayout(false);
            this.grpAficiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSexGroup1;
        private System.Windows.Forms.RadioButton rbSexGroup2;
        private System.Windows.Forms.RadioButton rbSexGroup3;
        private System.Windows.Forms.GroupBox grpAficiones;
        private System.Windows.Forms.TextBox txtAficiones;
        private System.Windows.Forms.CheckBox chkOtras;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkDeportes;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSituacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

=======
﻿namespace UT2E2
{
    partial class FichaSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSexGroup1 = new System.Windows.Forms.RadioButton();
            this.rbSexGroup2 = new System.Windows.Forms.RadioButton();
            this.rbSexGroup3 = new System.Windows.Forms.RadioButton();
            this.grpAficiones = new System.Windows.Forms.GroupBox();
            this.txtAficiones = new System.Windows.Forms.TextBox();
            this.chkOtras = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkDeportes = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSituacion = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.grpAficiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo";
            // 
            // rbSexGroup1
            // 
            this.rbSexGroup1.AutoSize = true;
            this.rbSexGroup1.Checked = true;
            this.rbSexGroup1.Location = new System.Drawing.Point(129, 85);
            this.rbSexGroup1.Name = "rbSexGroup1";
            this.rbSexGroup1.Size = new System.Drawing.Size(62, 17);
            this.rbSexGroup1.TabIndex = 5;
            this.rbSexGroup1.TabStop = true;
            this.rbSexGroup1.Text = "Hombre";
            this.rbSexGroup1.UseVisualStyleBackColor = true;
            // 
            // rbSexGroup2
            // 
            this.rbSexGroup2.AutoSize = true;
            this.rbSexGroup2.Location = new System.Drawing.Point(197, 85);
            this.rbSexGroup2.Name = "rbSexGroup2";
            this.rbSexGroup2.Size = new System.Drawing.Size(51, 17);
            this.rbSexGroup2.TabIndex = 6;
            this.rbSexGroup2.Text = "Mujer";
            this.rbSexGroup2.UseVisualStyleBackColor = true;
            // 
            // rbSexGroup3
            // 
            this.rbSexGroup3.AutoSize = true;
            this.rbSexGroup3.Location = new System.Drawing.Point(254, 85);
            this.rbSexGroup3.Name = "rbSexGroup3";
            this.rbSexGroup3.Size = new System.Drawing.Size(50, 17);
            this.rbSexGroup3.TabIndex = 7;
            this.rbSexGroup3.Text = "Otros";
            this.rbSexGroup3.UseVisualStyleBackColor = true;
            // 
            // grpAficiones
            // 
            this.grpAficiones.Controls.Add(this.txtAficiones);
            this.grpAficiones.Controls.Add(this.chkOtras);
            this.grpAficiones.Controls.Add(this.chkLectura);
            this.grpAficiones.Controls.Add(this.chkMusica);
            this.grpAficiones.Controls.Add(this.chkDeportes);
            this.grpAficiones.Location = new System.Drawing.Point(23, 118);
            this.grpAficiones.Name = "grpAficiones";
            this.grpAficiones.Size = new System.Drawing.Size(324, 113);
            this.grpAficiones.TabIndex = 8;
            this.grpAficiones.TabStop = false;
            this.grpAficiones.Text = "Aficiones";
            // 
            // txtAficiones
            // 
            this.txtAficiones.Enabled = false;
            this.txtAficiones.Location = new System.Drawing.Point(7, 43);
            this.txtAficiones.Multiline = true;
            this.txtAficiones.Name = "txtAficiones";
            this.txtAficiones.Size = new System.Drawing.Size(311, 64);
            this.txtAficiones.TabIndex = 4;
            // 
            // chkOtras
            // 
            this.chkOtras.AutoSize = true;
            this.chkOtras.Location = new System.Drawing.Point(215, 19);
            this.chkOtras.Name = "chkOtras";
            this.chkOtras.Size = new System.Drawing.Size(51, 17);
            this.chkOtras.TabIndex = 3;
            this.chkOtras.Text = "Otras";
            this.chkOtras.UseVisualStyleBackColor = true;
            this.chkOtras.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(147, 19);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(62, 17);
            this.chkLectura.TabIndex = 2;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(81, 19);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(60, 17);
            this.chkMusica.TabIndex = 1;
            this.chkMusica.Text = "Musica";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            this.chkDeportes.AutoSize = true;
            this.chkDeportes.Location = new System.Drawing.Point(6, 19);
            this.chkDeportes.Name = "chkDeportes";
            this.chkDeportes.Size = new System.Drawing.Size(69, 17);
            this.chkDeportes.TabIndex = 0;
            this.chkDeportes.Text = "Deportes";
            this.chkDeportes.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(129, 51);
            this.dtpFecha.MaxDate = new System.DateTime(2022, 10, 7, 15, 2, 52, 0);
            this.dtpFecha.MinDate = new System.DateTime(1903, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(175, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Situacion";
            // 
            // cboSituacion
            // 
            this.cboSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacion.Items.AddRange(new object[] {
            "Becario",
            "Empleado",
            "Excedencia",
            "Jubilado"});
            this.cboSituacion.Location = new System.Drawing.Point(104, 237);
            this.cboSituacion.Name = "cboSituacion";
            this.cboSituacion.Size = new System.Drawing.Size(200, 21);
            this.cboSituacion.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(278, 279);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(197, 279);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 314);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboSituacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.grpAficiones);
            this.Controls.Add(this.rbSexGroup3);
            this.Controls.Add(this.rbSexGroup2);
            this.Controls.Add(this.rbSexGroup1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ficha socio";
            this.grpAficiones.ResumeLayout(false);
            this.grpAficiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSexGroup1;
        private System.Windows.Forms.RadioButton rbSexGroup2;
        private System.Windows.Forms.RadioButton rbSexGroup3;
        private System.Windows.Forms.GroupBox grpAficiones;
        private System.Windows.Forms.TextBox txtAficiones;
        private System.Windows.Forms.CheckBox chkOtras;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkDeportes;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSituacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
