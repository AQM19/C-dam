<<<<<<< HEAD
﻿namespace UT2E8
{
    partial class FormPersona
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
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnSalirPersona = new System.Windows.Forms.Button();
            this.txtTelefonoPersona = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tabPersona = new System.Windows.Forms.TabControl();
            this.tbPageCitas = new System.Windows.Forms.TabPage();
            this.lvwListaCitas = new System.Windows.Forms.ListView();
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCrearCitaPersona = new System.Windows.Forms.Button();
            this.tbPageInforme = new System.Windows.Forms.TabPage();
            this.txtObservacionesPersona = new System.Windows.Forms.TextBox();
            this.lblObservacionesPersona = new System.Windows.Forms.Label();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.txtAlergiasPersona = new System.Windows.Forms.TextBox();
            this.dtpFechaPersona = new System.Windows.Forms.DateTimePicker();
            this.lblNacimientoPersona = new System.Windows.Forms.Label();
            this.tabPersona.SuspendLayout();
            this.tbPageCitas.SuspendLayout();
            this.tbPageInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Location = new System.Drawing.Point(14, 16);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePersona.TabIndex = 0;
            this.lblNombrePersona.Text = "Nombre";
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombrePersona.Location = new System.Drawing.Point(64, 13);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(165, 20);
            this.txtNombrePersona.TabIndex = 1;
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPersona.Location = new System.Drawing.Point(235, 11);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPersona.TabIndex = 2;
            this.btnGuardarPersona.Text = "Guardar";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // btnSalirPersona
            // 
            this.btnSalirPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirPersona.Location = new System.Drawing.Point(316, 10);
            this.btnSalirPersona.Name = "btnSalirPersona";
            this.btnSalirPersona.Size = new System.Drawing.Size(75, 23);
            this.btnSalirPersona.TabIndex = 3;
            this.btnSalirPersona.Text = "Salir";
            this.btnSalirPersona.UseVisualStyleBackColor = true;
            this.btnSalirPersona.Click += new System.EventHandler(this.btnSalirPersona_Click);
            // 
            // txtTelefonoPersona
            // 
            this.txtTelefonoPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoPersona.Location = new System.Drawing.Point(64, 40);
            this.txtTelefonoPersona.Name = "txtTelefonoPersona";
            this.txtTelefonoPersona.Size = new System.Drawing.Size(115, 20);
            this.txtTelefonoPersona.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(14, 43);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // tabPersona
            // 
            this.tabPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPersona.Controls.Add(this.tbPageCitas);
            this.tabPersona.Controls.Add(this.tbPageInforme);
            this.tabPersona.Location = new System.Drawing.Point(12, 91);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.SelectedIndex = 0;
            this.tabPersona.Size = new System.Drawing.Size(390, 268);
            this.tabPersona.TabIndex = 6;
            this.tabPersona.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPersona_Selected);
            // 
            // tbPageCitas
            // 
            this.tbPageCitas.Controls.Add(this.lvwListaCitas);
            this.tbPageCitas.Controls.Add(this.btnCrearCitaPersona);
            this.tbPageCitas.Location = new System.Drawing.Point(4, 22);
            this.tbPageCitas.Name = "tbPageCitas";
            this.tbPageCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCitas.Size = new System.Drawing.Size(382, 242);
            this.tbPageCitas.TabIndex = 0;
            this.tbPageCitas.Text = "Citas";
            this.tbPageCitas.UseVisualStyleBackColor = true;
            // 
            // lvwListaCitas
            // 
            this.lvwListaCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwListaCitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFecha});
            this.lvwListaCitas.GridLines = true;
            this.lvwListaCitas.HideSelection = false;
            this.lvwListaCitas.Location = new System.Drawing.Point(6, 37);
            this.lvwListaCitas.Name = "lvwListaCitas";
            this.lvwListaCitas.Size = new System.Drawing.Size(367, 199);
            this.lvwListaCitas.TabIndex = 1;
            this.lvwListaCitas.UseCompatibleStateImageBehavior = false;
            this.lvwListaCitas.View = System.Windows.Forms.View.Details;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            // 
            // btnCrearCitaPersona
            // 
            this.btnCrearCitaPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearCitaPersona.Location = new System.Drawing.Point(299, 7);
            this.btnCrearCitaPersona.Name = "btnCrearCitaPersona";
            this.btnCrearCitaPersona.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCitaPersona.TabIndex = 0;
            this.btnCrearCitaPersona.Text = "Nueva Cita";
            this.btnCrearCitaPersona.UseVisualStyleBackColor = true;
            this.btnCrearCitaPersona.Click += new System.EventHandler(this.btnCrearCitaPersona_Click);
            // 
            // tbPageInforme
            // 
            this.tbPageInforme.Controls.Add(this.txtObservacionesPersona);
            this.tbPageInforme.Controls.Add(this.lblObservacionesPersona);
            this.tbPageInforme.Controls.Add(this.lblAlergias);
            this.tbPageInforme.Controls.Add(this.txtAlergiasPersona);
            this.tbPageInforme.Controls.Add(this.dtpFechaPersona);
            this.tbPageInforme.Controls.Add(this.lblNacimientoPersona);
            this.tbPageInforme.Location = new System.Drawing.Point(4, 22);
            this.tbPageInforme.Name = "tbPageInforme";
            this.tbPageInforme.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageInforme.Size = new System.Drawing.Size(382, 242);
            this.tbPageInforme.TabIndex = 1;
            this.tbPageInforme.Text = "Informe";
            this.tbPageInforme.UseVisualStyleBackColor = true;
            // 
            // txtObservacionesPersona
            // 
            this.txtObservacionesPersona.Location = new System.Drawing.Point(11, 97);
            this.txtObservacionesPersona.Multiline = true;
            this.txtObservacionesPersona.Name = "txtObservacionesPersona";
            this.txtObservacionesPersona.Size = new System.Drawing.Size(364, 141);
            this.txtObservacionesPersona.TabIndex = 5;
            // 
            // lblObservacionesPersona
            // 
            this.lblObservacionesPersona.AutoSize = true;
            this.lblObservacionesPersona.Location = new System.Drawing.Point(8, 80);
            this.lblObservacionesPersona.Name = "lblObservacionesPersona";
            this.lblObservacionesPersona.Size = new System.Drawing.Size(78, 13);
            this.lblObservacionesPersona.TabIndex = 4;
            this.lblObservacionesPersona.Text = "Observacioens";
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Location = new System.Drawing.Point(8, 41);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(44, 13);
            this.lblAlergias.TabIndex = 3;
            this.lblAlergias.Text = "Alergias";
            // 
            // txtAlergiasPersona
            // 
            this.txtAlergiasPersona.Location = new System.Drawing.Point(120, 34);
            this.txtAlergiasPersona.Name = "txtAlergiasPersona";
            this.txtAlergiasPersona.Size = new System.Drawing.Size(255, 20);
            this.txtAlergiasPersona.TabIndex = 2;
            // 
            // dtpFechaPersona
            // 
            this.dtpFechaPersona.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPersona.Location = new System.Drawing.Point(120, 7);
            this.dtpFechaPersona.Name = "dtpFechaPersona";
            this.dtpFechaPersona.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaPersona.TabIndex = 1;
            // 
            // lblNacimientoPersona
            // 
            this.lblNacimientoPersona.AutoSize = true;
            this.lblNacimientoPersona.Location = new System.Drawing.Point(8, 13);
            this.lblNacimientoPersona.Name = "lblNacimientoPersona";
            this.lblNacimientoPersona.Size = new System.Drawing.Size(106, 13);
            this.lblNacimientoPersona.TabIndex = 0;
            this.lblNacimientoPersona.Text = "Fecha de nacimiento";
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 371);
            this.Controls.Add(this.tabPersona);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefonoPersona);
            this.Controls.Add(this.btnSalirPersona);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.txtNombrePersona);
            this.Controls.Add(this.lblNombrePersona);
            this.MinimumSize = new System.Drawing.Size(430, 410);
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            this.tabPersona.ResumeLayout(false);
            this.tbPageCitas.ResumeLayout(false);
            this.tbPageInforme.ResumeLayout(false);
            this.tbPageInforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btnSalirPersona;
        private System.Windows.Forms.TextBox txtTelefonoPersona;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TabControl tabPersona;
        private System.Windows.Forms.TabPage tbPageCitas;
        private System.Windows.Forms.TabPage tbPageInforme;
        private System.Windows.Forms.ListView lvwListaCitas;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.Button btnCrearCitaPersona;
        private System.Windows.Forms.TextBox txtObservacionesPersona;
        private System.Windows.Forms.Label lblObservacionesPersona;
        private System.Windows.Forms.Label lblAlergias;
        private System.Windows.Forms.TextBox txtAlergiasPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaPersona;
        private System.Windows.Forms.Label lblNacimientoPersona;
    }
=======
﻿namespace UT2E8
{
    partial class FormPersona
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
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnSalirPersona = new System.Windows.Forms.Button();
            this.txtTelefonoPersona = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tabPersona = new System.Windows.Forms.TabControl();
            this.tbPageCitas = new System.Windows.Forms.TabPage();
            this.lvwListaCitas = new System.Windows.Forms.ListView();
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCrearCitaPersona = new System.Windows.Forms.Button();
            this.tbPageInforme = new System.Windows.Forms.TabPage();
            this.txtObservacionesPersona = new System.Windows.Forms.TextBox();
            this.lblObservacionesPersona = new System.Windows.Forms.Label();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.txtAlergiasPersona = new System.Windows.Forms.TextBox();
            this.dtpFechaPersona = new System.Windows.Forms.DateTimePicker();
            this.lblNacimientoPersona = new System.Windows.Forms.Label();
            this.tabPersona.SuspendLayout();
            this.tbPageCitas.SuspendLayout();
            this.tbPageInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Location = new System.Drawing.Point(14, 16);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePersona.TabIndex = 0;
            this.lblNombrePersona.Text = "Nombre";
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombrePersona.Location = new System.Drawing.Point(64, 13);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(165, 20);
            this.txtNombrePersona.TabIndex = 1;
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPersona.Location = new System.Drawing.Point(235, 11);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPersona.TabIndex = 2;
            this.btnGuardarPersona.Text = "Guardar";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // btnSalirPersona
            // 
            this.btnSalirPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirPersona.Location = new System.Drawing.Point(316, 10);
            this.btnSalirPersona.Name = "btnSalirPersona";
            this.btnSalirPersona.Size = new System.Drawing.Size(75, 23);
            this.btnSalirPersona.TabIndex = 3;
            this.btnSalirPersona.Text = "Salir";
            this.btnSalirPersona.UseVisualStyleBackColor = true;
            this.btnSalirPersona.Click += new System.EventHandler(this.btnSalirPersona_Click);
            // 
            // txtTelefonoPersona
            // 
            this.txtTelefonoPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoPersona.Location = new System.Drawing.Point(64, 40);
            this.txtTelefonoPersona.Name = "txtTelefonoPersona";
            this.txtTelefonoPersona.Size = new System.Drawing.Size(115, 20);
            this.txtTelefonoPersona.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(14, 43);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // tabPersona
            // 
            this.tabPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPersona.Controls.Add(this.tbPageCitas);
            this.tabPersona.Controls.Add(this.tbPageInforme);
            this.tabPersona.Location = new System.Drawing.Point(12, 91);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.SelectedIndex = 0;
            this.tabPersona.Size = new System.Drawing.Size(390, 268);
            this.tabPersona.TabIndex = 6;
            this.tabPersona.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPersona_Selected);
            // 
            // tbPageCitas
            // 
            this.tbPageCitas.Controls.Add(this.lvwListaCitas);
            this.tbPageCitas.Controls.Add(this.btnCrearCitaPersona);
            this.tbPageCitas.Location = new System.Drawing.Point(4, 22);
            this.tbPageCitas.Name = "tbPageCitas";
            this.tbPageCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCitas.Size = new System.Drawing.Size(382, 242);
            this.tbPageCitas.TabIndex = 0;
            this.tbPageCitas.Text = "Citas";
            this.tbPageCitas.UseVisualStyleBackColor = true;
            // 
            // lvwListaCitas
            // 
            this.lvwListaCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwListaCitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFecha});
            this.lvwListaCitas.GridLines = true;
            this.lvwListaCitas.HideSelection = false;
            this.lvwListaCitas.Location = new System.Drawing.Point(6, 37);
            this.lvwListaCitas.Name = "lvwListaCitas";
            this.lvwListaCitas.Size = new System.Drawing.Size(367, 199);
            this.lvwListaCitas.TabIndex = 1;
            this.lvwListaCitas.UseCompatibleStateImageBehavior = false;
            this.lvwListaCitas.View = System.Windows.Forms.View.Details;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            // 
            // btnCrearCitaPersona
            // 
            this.btnCrearCitaPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearCitaPersona.Location = new System.Drawing.Point(299, 7);
            this.btnCrearCitaPersona.Name = "btnCrearCitaPersona";
            this.btnCrearCitaPersona.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCitaPersona.TabIndex = 0;
            this.btnCrearCitaPersona.Text = "Nueva Cita";
            this.btnCrearCitaPersona.UseVisualStyleBackColor = true;
            this.btnCrearCitaPersona.Click += new System.EventHandler(this.btnCrearCitaPersona_Click);
            // 
            // tbPageInforme
            // 
            this.tbPageInforme.Controls.Add(this.txtObservacionesPersona);
            this.tbPageInforme.Controls.Add(this.lblObservacionesPersona);
            this.tbPageInforme.Controls.Add(this.lblAlergias);
            this.tbPageInforme.Controls.Add(this.txtAlergiasPersona);
            this.tbPageInforme.Controls.Add(this.dtpFechaPersona);
            this.tbPageInforme.Controls.Add(this.lblNacimientoPersona);
            this.tbPageInforme.Location = new System.Drawing.Point(4, 22);
            this.tbPageInforme.Name = "tbPageInforme";
            this.tbPageInforme.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageInforme.Size = new System.Drawing.Size(382, 242);
            this.tbPageInforme.TabIndex = 1;
            this.tbPageInforme.Text = "Informe";
            this.tbPageInforme.UseVisualStyleBackColor = true;
            // 
            // txtObservacionesPersona
            // 
            this.txtObservacionesPersona.Location = new System.Drawing.Point(11, 97);
            this.txtObservacionesPersona.Multiline = true;
            this.txtObservacionesPersona.Name = "txtObservacionesPersona";
            this.txtObservacionesPersona.Size = new System.Drawing.Size(364, 141);
            this.txtObservacionesPersona.TabIndex = 5;
            // 
            // lblObservacionesPersona
            // 
            this.lblObservacionesPersona.AutoSize = true;
            this.lblObservacionesPersona.Location = new System.Drawing.Point(8, 80);
            this.lblObservacionesPersona.Name = "lblObservacionesPersona";
            this.lblObservacionesPersona.Size = new System.Drawing.Size(78, 13);
            this.lblObservacionesPersona.TabIndex = 4;
            this.lblObservacionesPersona.Text = "Observacioens";
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Location = new System.Drawing.Point(8, 41);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(44, 13);
            this.lblAlergias.TabIndex = 3;
            this.lblAlergias.Text = "Alergias";
            // 
            // txtAlergiasPersona
            // 
            this.txtAlergiasPersona.Location = new System.Drawing.Point(120, 34);
            this.txtAlergiasPersona.Name = "txtAlergiasPersona";
            this.txtAlergiasPersona.Size = new System.Drawing.Size(255, 20);
            this.txtAlergiasPersona.TabIndex = 2;
            // 
            // dtpFechaPersona
            // 
            this.dtpFechaPersona.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPersona.Location = new System.Drawing.Point(120, 7);
            this.dtpFechaPersona.Name = "dtpFechaPersona";
            this.dtpFechaPersona.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaPersona.TabIndex = 1;
            // 
            // lblNacimientoPersona
            // 
            this.lblNacimientoPersona.AutoSize = true;
            this.lblNacimientoPersona.Location = new System.Drawing.Point(8, 13);
            this.lblNacimientoPersona.Name = "lblNacimientoPersona";
            this.lblNacimientoPersona.Size = new System.Drawing.Size(106, 13);
            this.lblNacimientoPersona.TabIndex = 0;
            this.lblNacimientoPersona.Text = "Fecha de nacimiento";
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 371);
            this.Controls.Add(this.tabPersona);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefonoPersona);
            this.Controls.Add(this.btnSalirPersona);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.txtNombrePersona);
            this.Controls.Add(this.lblNombrePersona);
            this.MinimumSize = new System.Drawing.Size(430, 410);
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            this.tabPersona.ResumeLayout(false);
            this.tbPageCitas.ResumeLayout(false);
            this.tbPageInforme.ResumeLayout(false);
            this.tbPageInforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btnSalirPersona;
        private System.Windows.Forms.TextBox txtTelefonoPersona;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TabControl tabPersona;
        private System.Windows.Forms.TabPage tbPageCitas;
        private System.Windows.Forms.TabPage tbPageInforme;
        private System.Windows.Forms.ListView lvwListaCitas;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.Button btnCrearCitaPersona;
        private System.Windows.Forms.TextBox txtObservacionesPersona;
        private System.Windows.Forms.Label lblObservacionesPersona;
        private System.Windows.Forms.Label lblAlergias;
        private System.Windows.Forms.TextBox txtAlergiasPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaPersona;
        private System.Windows.Forms.Label lblNacimientoPersona;
    }
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
}