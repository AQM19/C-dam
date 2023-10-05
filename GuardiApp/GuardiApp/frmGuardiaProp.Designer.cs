namespace GuardiApp
{
    partial class frmGuardiaProp
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
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmHora = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtProfSusti = new System.Windows.Forms.TextBox();
            this.txtProfFalta = new System.Windows.Forms.TextBox();
            this.btnProfSusti = new System.Windows.Forms.Button();
            this.btnProfesorFalta = new System.Windows.Forms.Button();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Realizada",
            "Confirmada",
            "Anulada"});
            this.cmbEstado.Location = new System.Drawing.Point(443, 117);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(397, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Estado";
            // 
            // cbmHora
            // 
            this.cbmHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmHora.FormattingEnabled = true;
            this.cbmHora.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbmHora.Location = new System.Drawing.Point(238, 117);
            this.cbmHora.Name = "cbmHora";
            this.cbmHora.Size = new System.Drawing.Size(121, 21);
            this.cbmHora.TabIndex = 49;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(489, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(408, 315);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 47;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(12, 243);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(552, 66);
            this.txtObservaciones.TabIndex = 46;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(12, 227);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 45;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(438, 185);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtProfSusti
            // 
            this.txtProfSusti.Location = new System.Drawing.Point(107, 185);
            this.txtProfSusti.Name = "txtProfSusti";
            this.txtProfSusti.ReadOnly = true;
            this.txtProfSusti.Size = new System.Drawing.Size(325, 20);
            this.txtProfSusti.TabIndex = 43;
            // 
            // txtProfFalta
            // 
            this.txtProfFalta.Location = new System.Drawing.Point(107, 149);
            this.txtProfFalta.Name = "txtProfFalta";
            this.txtProfFalta.ReadOnly = true;
            this.txtProfFalta.Size = new System.Drawing.Size(457, 20);
            this.txtProfFalta.TabIndex = 42;
            // 
            // btnProfSusti
            // 
            this.btnProfSusti.BackColor = System.Drawing.Color.Transparent;
            this.btnProfSusti.Location = new System.Drawing.Point(12, 182);
            this.btnProfSusti.Name = "btnProfSusti";
            this.btnProfSusti.Size = new System.Drawing.Size(75, 23);
            this.btnProfSusti.TabIndex = 41;
            this.btnProfSusti.Text = "Prof. susti";
            this.btnProfSusti.UseVisualStyleBackColor = false;
            this.btnProfSusti.Click += new System.EventHandler(this.btnProfSusti_Click);
            // 
            // btnProfesorFalta
            // 
            this.btnProfesorFalta.BackColor = System.Drawing.Color.Transparent;
            this.btnProfesorFalta.ForeColor = System.Drawing.Color.Black;
            this.btnProfesorFalta.Location = new System.Drawing.Point(12, 146);
            this.btnProfesorFalta.Name = "btnProfesorFalta";
            this.btnProfesorFalta.Size = new System.Drawing.Size(75, 23);
            this.btnProfesorFalta.TabIndex = 40;
            this.btnProfesorFalta.Text = "Prof. falta";
            this.btnProfesorFalta.UseVisualStyleBackColor = false;
            this.btnProfesorFalta.Click += new System.EventHandler(this.btnProfesorFalta_Click);
            // 
            // dtpDia
            // 
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(43, 118);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(111, 20);
            this.dtpDia.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(202, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Día";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GuardiApp.Properties.Resources.logo_IES_Miguel_Herrero__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // frmGuardiaProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 349);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbmHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtProfSusti);
            this.Controls.Add(this.txtProfFalta);
            this.Controls.Add(this.btnProfSusti);
            this.Controls.Add(this.btnProfesorFalta);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGuardiaProp";
            this.ShowIcon = false;
            this.Text = "Guardia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbmHora;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtProfSusti;
        private System.Windows.Forms.TextBox txtProfFalta;
        private System.Windows.Forms.Button btnProfSusti;
        private System.Windows.Forms.Button btnProfesorFalta;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}