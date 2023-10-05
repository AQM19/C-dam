namespace ZoocanV2
{
    partial class frmAnimal
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
            this.lblRefugio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.cboRefugio = new System.Windows.Forms.ComboBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.nudEspacio = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspacio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRefugio
            // 
            this.lblRefugio.AutoSize = true;
            this.lblRefugio.Location = new System.Drawing.Point(12, 14);
            this.lblRefugio.Name = "lblRefugio";
            this.lblRefugio.Size = new System.Drawing.Size(44, 13);
            this.lblRefugio.TabIndex = 0;
            this.lblRefugio.Text = "Refugio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nacimiento";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(12, 92);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(205, 14);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 4;
            this.lblEspecie.Text = "Especie";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(205, 40);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(32, 13);
            this.lblRaza.TabIndex = 5;
            this.lblRaza.Text = "Raza";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(206, 66);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Location = new System.Drawing.Point(205, 92);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(45, 13);
            this.lblEspacio.TabIndex = 7;
            this.lblEspacio.Text = "Espacio";
            // 
            // cboRefugio
            // 
            this.cboRefugio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRefugio.FormattingEnabled = true;
            this.cboRefugio.Location = new System.Drawing.Point(78, 6);
            this.cboRefugio.Name = "cboRefugio";
            this.cboRefugio.Size = new System.Drawing.Size(121, 21);
            this.cboRefugio.TabIndex = 8;
            // 
            // cboEspecie
            // 
            this.cboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Items.AddRange(new object[] {
            "Acuaticos",
            "Aves",
            "Caninos",
            "Felinos",
            "Reptiles",
            "Roedores",
            "Otros"});
            this.cboEspecie.Location = new System.Drawing.Point(256, 6);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(121, 21);
            this.cboEspecie.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(78, 85);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(121, 20);
            this.dtpEntrada.TabIndex = 12;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(78, 59);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(121, 20);
            this.dtpNacimiento.TabIndex = 11;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(256, 33);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(121, 20);
            this.txtRaza.TabIndex = 13;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(257, 59);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(120, 20);
            this.nudPeso.TabIndex = 14;
            // 
            // nudEspacio
            // 
            this.nudEspacio.Location = new System.Drawing.Point(257, 85);
            this.nudEspacio.Name = "nudEspacio";
            this.nudEspacio.Size = new System.Drawing.Size(120, 20);
            this.nudEspacio.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(302, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(221, 111);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAnimal
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(402, 143);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nudEspacio);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.cboRefugio);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRefugio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAnimal";
            this.ShowIcon = false;
            this.Text = "Animal";
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRefugio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.ComboBox cboRefugio;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudEspacio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}