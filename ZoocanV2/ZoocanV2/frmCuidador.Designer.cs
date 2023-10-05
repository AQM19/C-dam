namespace ZoocanV2
{
    partial class frmCuidador
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
            this.cboRefugio = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.chkResponsable = new System.Windows.Forms.CheckBox();
            this.nupSalario = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRefugio
            // 
            this.lblRefugio.AutoSize = true;
            this.lblRefugio.Location = new System.Drawing.Point(12, 20);
            this.lblRefugio.Name = "lblRefugio";
            this.lblRefugio.Size = new System.Drawing.Size(44, 13);
            this.lblRefugio.TabIndex = 0;
            this.lblRefugio.Text = "Refugio";
            // 
            // cboRefugio
            // 
            this.cboRefugio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRefugio.FormattingEnabled = true;
            this.cboRefugio.Location = new System.Drawing.Point(75, 12);
            this.cboRefugio.Name = "cboRefugio";
            this.cboRefugio.Size = new System.Drawing.Size(121, 21);
            this.cboRefugio.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 65);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 72);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(75, 91);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 98);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(211, 20);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Salario";
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
            this.cboEspecie.Location = new System.Drawing.Point(262, 38);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(121, 21);
            this.cboEspecie.TabIndex = 11;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(211, 46);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 10;
            this.lblEspecie.Text = "Especie";
            // 
            // chkResponsable
            // 
            this.chkResponsable.AutoSize = true;
            this.chkResponsable.Location = new System.Drawing.Point(213, 67);
            this.chkResponsable.Name = "chkResponsable";
            this.chkResponsable.Size = new System.Drawing.Size(88, 17);
            this.chkResponsable.TabIndex = 12;
            this.chkResponsable.Text = "Responsable";
            this.chkResponsable.UseVisualStyleBackColor = true;
            this.chkResponsable.Click += new System.EventHandler(this.chkResponsable_Click);
            // 
            // nupSalario
            // 
            this.nupSalario.Location = new System.Drawing.Point(262, 13);
            this.nupSalario.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupSalario.Name = "nupSalario";
            this.nupSalario.Size = new System.Drawing.Size(120, 20);
            this.nupSalario.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(308, 88);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(226, 88);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmCuidador
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(408, 126);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nupSalario);
            this.Controls.Add(this.chkResponsable);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboRefugio);
            this.Controls.Add(this.lblRefugio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCuidador";
            this.ShowIcon = false;
            this.Text = "Cuidador";
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRefugio;
        private System.Windows.Forms.ComboBox cboRefugio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.CheckBox chkResponsable;
        private System.Windows.Forms.NumericUpDown nupSalario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}