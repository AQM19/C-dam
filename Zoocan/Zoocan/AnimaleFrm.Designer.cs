namespace Zoocan
{
    partial class AnimaleFrm
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
            this.lblRefugioAnimal = new System.Windows.Forms.Label();
            this.cboListadoRefugios = new System.Windows.Forms.ComboBox();
            this.btnInsertarRefugio = new System.Windows.Forms.Button();
            this.lblNombreAnimale = new System.Windows.Forms.Label();
            this.txtNombreAnimale = new System.Windows.Forms.TextBox();
            this.lblNacimientoAnimale = new System.Windows.Forms.Label();
            this.lblEntradaAnimale = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoAnimale = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntradaAnimale = new System.Windows.Forms.DateTimePicker();
            this.lblEspecieAnimale = new System.Windows.Forms.Label();
            this.lblRazaAnimale = new System.Windows.Forms.Label();
            this.txtRazaAnimale = new System.Windows.Forms.TextBox();
            this.lblPesoAnimale = new System.Windows.Forms.Label();
            this.lblEspacioAnimale = new System.Windows.Forms.Label();
            this.txtAnimalePeso = new System.Windows.Forms.TextBox();
            this.txtAnimaleEspacio = new System.Windows.Forms.TextBox();
            this.btnCancelarAnimale = new System.Windows.Forms.Button();
            this.btnAceptarAnimale = new System.Windows.Forms.Button();
            this.cboEspecieAnimale = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRefugioAnimal
            // 
            this.lblRefugioAnimal.AutoSize = true;
            this.lblRefugioAnimal.Location = new System.Drawing.Point(13, 23);
            this.lblRefugioAnimal.Name = "lblRefugioAnimal";
            this.lblRefugioAnimal.Size = new System.Drawing.Size(44, 13);
            this.lblRefugioAnimal.TabIndex = 1;
            this.lblRefugioAnimal.Text = "Refugio";
            // 
            // cboListadoRefugios
            // 
            this.cboListadoRefugios.FormattingEnabled = true;
            this.cboListadoRefugios.Location = new System.Drawing.Point(80, 15);
            this.cboListadoRefugios.Name = "cboListadoRefugios";
            this.cboListadoRefugios.Size = new System.Drawing.Size(132, 21);
            this.cboListadoRefugios.TabIndex = 2;
            // 
            // btnInsertarRefugio
            // 
            this.btnInsertarRefugio.Location = new System.Drawing.Point(218, 15);
            this.btnInsertarRefugio.Name = "btnInsertarRefugio";
            this.btnInsertarRefugio.Size = new System.Drawing.Size(21, 21);
            this.btnInsertarRefugio.TabIndex = 3;
            this.btnInsertarRefugio.Text = "+";
            this.btnInsertarRefugio.UseVisualStyleBackColor = true;
            this.btnInsertarRefugio.Click += new System.EventHandler(this.btnInsertarRefugio_Click);
            // 
            // lblNombreAnimale
            // 
            this.lblNombreAnimale.AutoSize = true;
            this.lblNombreAnimale.Location = new System.Drawing.Point(13, 49);
            this.lblNombreAnimale.Name = "lblNombreAnimale";
            this.lblNombreAnimale.Size = new System.Drawing.Size(44, 13);
            this.lblNombreAnimale.TabIndex = 4;
            this.lblNombreAnimale.Text = "Nombre";
            // 
            // txtNombreAnimale
            // 
            this.txtNombreAnimale.Location = new System.Drawing.Point(80, 42);
            this.txtNombreAnimale.Name = "txtNombreAnimale";
            this.txtNombreAnimale.Size = new System.Drawing.Size(159, 20);
            this.txtNombreAnimale.TabIndex = 5;
            // 
            // lblNacimientoAnimale
            // 
            this.lblNacimientoAnimale.AutoSize = true;
            this.lblNacimientoAnimale.Location = new System.Drawing.Point(13, 74);
            this.lblNacimientoAnimale.Name = "lblNacimientoAnimale";
            this.lblNacimientoAnimale.Size = new System.Drawing.Size(60, 13);
            this.lblNacimientoAnimale.TabIndex = 6;
            this.lblNacimientoAnimale.Text = "Nacimiento";
            // 
            // lblEntradaAnimale
            // 
            this.lblEntradaAnimale.AutoSize = true;
            this.lblEntradaAnimale.Location = new System.Drawing.Point(13, 101);
            this.lblEntradaAnimale.Name = "lblEntradaAnimale";
            this.lblEntradaAnimale.Size = new System.Drawing.Size(44, 13);
            this.lblEntradaAnimale.TabIndex = 7;
            this.lblEntradaAnimale.Text = "Entrada";
            // 
            // dtpFechaNacimientoAnimale
            // 
            this.dtpFechaNacimientoAnimale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoAnimale.Location = new System.Drawing.Point(80, 68);
            this.dtpFechaNacimientoAnimale.Name = "dtpFechaNacimientoAnimale";
            this.dtpFechaNacimientoAnimale.Size = new System.Drawing.Size(158, 20);
            this.dtpFechaNacimientoAnimale.TabIndex = 8;
            // 
            // dtpFechaEntradaAnimale
            // 
            this.dtpFechaEntradaAnimale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntradaAnimale.Location = new System.Drawing.Point(80, 94);
            this.dtpFechaEntradaAnimale.Name = "dtpFechaEntradaAnimale";
            this.dtpFechaEntradaAnimale.Size = new System.Drawing.Size(158, 20);
            this.dtpFechaEntradaAnimale.TabIndex = 10;
            // 
            // lblEspecieAnimale
            // 
            this.lblEspecieAnimale.AutoSize = true;
            this.lblEspecieAnimale.Location = new System.Drawing.Point(13, 127);
            this.lblEspecieAnimale.Name = "lblEspecieAnimale";
            this.lblEspecieAnimale.Size = new System.Drawing.Size(45, 13);
            this.lblEspecieAnimale.TabIndex = 12;
            this.lblEspecieAnimale.Text = "Especie";
            // 
            // lblRazaAnimale
            // 
            this.lblRazaAnimale.AutoSize = true;
            this.lblRazaAnimale.Location = new System.Drawing.Point(13, 153);
            this.lblRazaAnimale.Name = "lblRazaAnimale";
            this.lblRazaAnimale.Size = new System.Drawing.Size(32, 13);
            this.lblRazaAnimale.TabIndex = 13;
            this.lblRazaAnimale.Text = "Raza";
            // 
            // txtRazaAnimale
            // 
            this.txtRazaAnimale.Location = new System.Drawing.Point(80, 146);
            this.txtRazaAnimale.Name = "txtRazaAnimale";
            this.txtRazaAnimale.Size = new System.Drawing.Size(159, 20);
            this.txtRazaAnimale.TabIndex = 15;
            // 
            // lblPesoAnimale
            // 
            this.lblPesoAnimale.AutoSize = true;
            this.lblPesoAnimale.Location = new System.Drawing.Point(14, 179);
            this.lblPesoAnimale.Name = "lblPesoAnimale";
            this.lblPesoAnimale.Size = new System.Drawing.Size(31, 13);
            this.lblPesoAnimale.TabIndex = 17;
            this.lblPesoAnimale.Text = "Peso";
            // 
            // lblEspacioAnimale
            // 
            this.lblEspacioAnimale.AutoSize = true;
            this.lblEspacioAnimale.Location = new System.Drawing.Point(141, 176);
            this.lblEspacioAnimale.Name = "lblEspacioAnimale";
            this.lblEspacioAnimale.Size = new System.Drawing.Size(45, 13);
            this.lblEspacioAnimale.TabIndex = 18;
            this.lblEspacioAnimale.Text = "Espacio";
            // 
            // txtAnimalePeso
            // 
            this.txtAnimalePeso.Location = new System.Drawing.Point(80, 172);
            this.txtAnimalePeso.Name = "txtAnimalePeso";
            this.txtAnimalePeso.Size = new System.Drawing.Size(47, 20);
            this.txtAnimalePeso.TabIndex = 19;
            // 
            // txtAnimaleEspacio
            // 
            this.txtAnimaleEspacio.Location = new System.Drawing.Point(192, 173);
            this.txtAnimaleEspacio.Name = "txtAnimaleEspacio";
            this.txtAnimaleEspacio.Size = new System.Drawing.Size(47, 20);
            this.txtAnimaleEspacio.TabIndex = 20;
            // 
            // btnCancelarAnimale
            // 
            this.btnCancelarAnimale.Location = new System.Drawing.Point(163, 216);
            this.btnCancelarAnimale.Name = "btnCancelarAnimale";
            this.btnCancelarAnimale.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAnimale.TabIndex = 21;
            this.btnCancelarAnimale.Text = "Cancelar";
            this.btnCancelarAnimale.UseVisualStyleBackColor = true;
            this.btnCancelarAnimale.Click += new System.EventHandler(this.btnCancelarAnimale_Click);
            // 
            // btnAceptarAnimale
            // 
            this.btnAceptarAnimale.Location = new System.Drawing.Point(82, 216);
            this.btnAceptarAnimale.Name = "btnAceptarAnimale";
            this.btnAceptarAnimale.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAnimale.TabIndex = 22;
            this.btnAceptarAnimale.Text = "Aceptar";
            this.btnAceptarAnimale.UseVisualStyleBackColor = true;
            this.btnAceptarAnimale.Click += new System.EventHandler(this.btnAceptarAnimale_Click);
            // 
            // cboEspecieAnimale
            // 
            this.cboEspecieAnimale.FormattingEnabled = true;
            this.cboEspecieAnimale.Items.AddRange(new object[] {
            "Caninos",
            "Felinos",
            "Reptiles",
            "Aves",
            "Roedores",
            "Acuaticos",
            "Otros"});
            this.cboEspecieAnimale.Location = new System.Drawing.Point(80, 120);
            this.cboEspecieAnimale.Name = "cboEspecieAnimale";
            this.cboEspecieAnimale.Size = new System.Drawing.Size(158, 21);
            this.cboEspecieAnimale.TabIndex = 23;
            // 
            // AnimaleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 251);
            this.Controls.Add(this.cboEspecieAnimale);
            this.Controls.Add(this.btnAceptarAnimale);
            this.Controls.Add(this.btnCancelarAnimale);
            this.Controls.Add(this.txtAnimaleEspacio);
            this.Controls.Add(this.txtAnimalePeso);
            this.Controls.Add(this.lblEspacioAnimale);
            this.Controls.Add(this.lblPesoAnimale);
            this.Controls.Add(this.txtRazaAnimale);
            this.Controls.Add(this.lblRazaAnimale);
            this.Controls.Add(this.lblEspecieAnimale);
            this.Controls.Add(this.dtpFechaEntradaAnimale);
            this.Controls.Add(this.dtpFechaNacimientoAnimale);
            this.Controls.Add(this.lblEntradaAnimale);
            this.Controls.Add(this.lblNacimientoAnimale);
            this.Controls.Add(this.txtNombreAnimale);
            this.Controls.Add(this.lblNombreAnimale);
            this.Controls.Add(this.btnInsertarRefugio);
            this.Controls.Add(this.cboListadoRefugios);
            this.Controls.Add(this.lblRefugioAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnimaleFrm";
            this.Text = "AnimaleFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRefugioAnimal;
        private System.Windows.Forms.ComboBox cboListadoRefugios;
        private System.Windows.Forms.Button btnInsertarRefugio;
        private System.Windows.Forms.Label lblNombreAnimale;
        private System.Windows.Forms.TextBox txtNombreAnimale;
        private System.Windows.Forms.Label lblNacimientoAnimale;
        private System.Windows.Forms.Label lblEntradaAnimale;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoAnimale;
        private System.Windows.Forms.DateTimePicker dtpFechaEntradaAnimale;
        private System.Windows.Forms.Label lblEspecieAnimale;
        private System.Windows.Forms.Label lblRazaAnimale;
        private System.Windows.Forms.TextBox txtRazaAnimale;
        private System.Windows.Forms.Label lblPesoAnimale;
        private System.Windows.Forms.Label lblEspacioAnimale;
        private System.Windows.Forms.TextBox txtAnimalePeso;
        private System.Windows.Forms.TextBox txtAnimaleEspacio;
        private System.Windows.Forms.Button btnCancelarAnimale;
        private System.Windows.Forms.Button btnAceptarAnimale;
        private System.Windows.Forms.ComboBox cboEspecieAnimale;
    }
}