namespace P1_Aaron_Quintanal
{
    partial class Faltafrm
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
            this.lblDiaFalta = new System.Windows.Forms.Label();
            this.dtpFechaFalta = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFalta = new System.Windows.Forms.Label();
            this.lblGrupoFalta = new System.Windows.Forms.Label();
            this.cboComboHora = new System.Windows.Forms.ComboBox();
            this.cboComboGrupo = new System.Windows.Forms.ComboBox();
            this.btnProfesorFalta = new System.Windows.Forms.Button();
            this.txtProfesorFalta = new System.Windows.Forms.TextBox();
            this.btnProfesorSustituto = new System.Windows.Forms.Button();
            this.txtSustitutoFalta = new System.Windows.Forms.TextBox();
            this.btnEliminarSustituto = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAceptarFalta = new System.Windows.Forms.Button();
            this.btnCancelarFalta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiaFalta
            // 
            this.lblDiaFalta.AutoSize = true;
            this.lblDiaFalta.Location = new System.Drawing.Point(41, 35);
            this.lblDiaFalta.Name = "lblDiaFalta";
            this.lblDiaFalta.Size = new System.Drawing.Size(23, 13);
            this.lblDiaFalta.TabIndex = 0;
            this.lblDiaFalta.Text = "Dia";
            // 
            // dtpFechaFalta
            // 
            this.dtpFechaFalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFalta.Location = new System.Drawing.Point(70, 32);
            this.dtpFechaFalta.Name = "dtpFechaFalta";
            this.dtpFechaFalta.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaFalta.TabIndex = 1;
            // 
            // lblHoraFalta
            // 
            this.lblHoraFalta.AutoSize = true;
            this.lblHoraFalta.Location = new System.Drawing.Point(191, 35);
            this.lblHoraFalta.Name = "lblHoraFalta";
            this.lblHoraFalta.Size = new System.Drawing.Size(30, 13);
            this.lblHoraFalta.TabIndex = 2;
            this.lblHoraFalta.Text = "Hora";
            // 
            // lblGrupoFalta
            // 
            this.lblGrupoFalta.AutoSize = true;
            this.lblGrupoFalta.Location = new System.Drawing.Point(363, 35);
            this.lblGrupoFalta.Name = "lblGrupoFalta";
            this.lblGrupoFalta.Size = new System.Drawing.Size(36, 13);
            this.lblGrupoFalta.TabIndex = 3;
            this.lblGrupoFalta.Text = "Grupo";
            // 
            // cboComboHora
            // 
            this.cboComboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComboHora.FormattingEnabled = true;
            this.cboComboHora.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboComboHora.Location = new System.Drawing.Point(227, 32);
            this.cboComboHora.Name = "cboComboHora";
            this.cboComboHora.Size = new System.Drawing.Size(121, 21);
            this.cboComboHora.TabIndex = 4;
            // 
            // cboComboGrupo
            // 
            this.cboComboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComboGrupo.FormattingEnabled = true;
            this.cboComboGrupo.Items.AddRange(new object[] {
            "ASIR1",
            "ASIR2",
            "DAM1",
            "DAM2",
            "DAW1",
            "DAW2"});
            this.cboComboGrupo.Location = new System.Drawing.Point(415, 32);
            this.cboComboGrupo.Name = "cboComboGrupo";
            this.cboComboGrupo.Size = new System.Drawing.Size(121, 21);
            this.cboComboGrupo.TabIndex = 5;
            // 
            // btnProfesorFalta
            // 
            this.btnProfesorFalta.Location = new System.Drawing.Point(44, 76);
            this.btnProfesorFalta.Name = "btnProfesorFalta";
            this.btnProfesorFalta.Size = new System.Drawing.Size(75, 23);
            this.btnProfesorFalta.TabIndex = 6;
            this.btnProfesorFalta.Text = "Prof. falta";
            this.btnProfesorFalta.UseVisualStyleBackColor = true;
            this.btnProfesorFalta.Click += new System.EventHandler(this.btnProfesorFalta_Click);
            // 
            // txtProfesorFalta
            // 
            this.txtProfesorFalta.Location = new System.Drawing.Point(134, 79);
            this.txtProfesorFalta.Name = "txtProfesorFalta";
            this.txtProfesorFalta.ReadOnly = true;
            this.txtProfesorFalta.Size = new System.Drawing.Size(312, 20);
            this.txtProfesorFalta.TabIndex = 7;
            // 
            // btnProfesorSustituto
            // 
            this.btnProfesorSustituto.Location = new System.Drawing.Point(44, 116);
            this.btnProfesorSustituto.Name = "btnProfesorSustituto";
            this.btnProfesorSustituto.Size = new System.Drawing.Size(75, 23);
            this.btnProfesorSustituto.TabIndex = 8;
            this.btnProfesorSustituto.Text = "Prof. susti.";
            this.btnProfesorSustituto.UseVisualStyleBackColor = true;
            this.btnProfesorSustituto.Click += new System.EventHandler(this.btnProfesorSustituto_Click);
            // 
            // txtSustitutoFalta
            // 
            this.txtSustitutoFalta.Location = new System.Drawing.Point(134, 119);
            this.txtSustitutoFalta.Name = "txtSustitutoFalta";
            this.txtSustitutoFalta.ReadOnly = true;
            this.txtSustitutoFalta.Size = new System.Drawing.Size(312, 20);
            this.txtSustitutoFalta.TabIndex = 9;
            // 
            // btnEliminarSustituto
            // 
            this.btnEliminarSustituto.Location = new System.Drawing.Point(461, 119);
            this.btnEliminarSustituto.Name = "btnEliminarSustituto";
            this.btnEliminarSustituto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSustituto.TabIndex = 10;
            this.btnEliminarSustituto.Text = "Eliminar";
            this.btnEliminarSustituto.UseVisualStyleBackColor = true;
            this.btnEliminarSustituto.Click += new System.EventHandler(this.btnEliminarSustituto_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(41, 159);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 11;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(44, 175);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(512, 90);
            this.txtObservaciones.TabIndex = 12;
            // 
            // btnAceptarFalta
            // 
            this.btnAceptarFalta.Location = new System.Drawing.Point(400, 271);
            this.btnAceptarFalta.Name = "btnAceptarFalta";
            this.btnAceptarFalta.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarFalta.TabIndex = 13;
            this.btnAceptarFalta.Text = "Aceptar";
            this.btnAceptarFalta.UseVisualStyleBackColor = true;
            this.btnAceptarFalta.Click += new System.EventHandler(this.btnAceptarFalta_Click);
            // 
            // btnCancelarFalta
            // 
            this.btnCancelarFalta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarFalta.Location = new System.Drawing.Point(481, 271);
            this.btnCancelarFalta.Name = "btnCancelarFalta";
            this.btnCancelarFalta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarFalta.TabIndex = 14;
            this.btnCancelarFalta.Text = "Cancelar";
            this.btnCancelarFalta.UseVisualStyleBackColor = true;
            this.btnCancelarFalta.Click += new System.EventHandler(this.btnCancelarFalta_Click);
            // 
            // Faltafrm
            // 
            this.AcceptButton = this.btnAceptarFalta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarFalta;
            this.ClientSize = new System.Drawing.Size(586, 318);
            this.Controls.Add(this.btnCancelarFalta);
            this.Controls.Add(this.btnAceptarFalta);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.btnEliminarSustituto);
            this.Controls.Add(this.txtSustitutoFalta);
            this.Controls.Add(this.btnProfesorSustituto);
            this.Controls.Add(this.txtProfesorFalta);
            this.Controls.Add(this.btnProfesorFalta);
            this.Controls.Add(this.cboComboGrupo);
            this.Controls.Add(this.cboComboHora);
            this.Controls.Add(this.lblGrupoFalta);
            this.Controls.Add(this.lblHoraFalta);
            this.Controls.Add(this.dtpFechaFalta);
            this.Controls.Add(this.lblDiaFalta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Faltafrm";
            this.Text = "Falta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiaFalta;
        private System.Windows.Forms.DateTimePicker dtpFechaFalta;
        private System.Windows.Forms.Label lblHoraFalta;
        private System.Windows.Forms.Label lblGrupoFalta;
        private System.Windows.Forms.ComboBox cboComboHora;
        private System.Windows.Forms.ComboBox cboComboGrupo;
        private System.Windows.Forms.Button btnProfesorFalta;
        private System.Windows.Forms.TextBox txtProfesorFalta;
        private System.Windows.Forms.Button btnProfesorSustituto;
        private System.Windows.Forms.TextBox txtSustitutoFalta;
        private System.Windows.Forms.Button btnEliminarSustituto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAceptarFalta;
        private System.Windows.Forms.Button btnCancelarFalta;
    }
}