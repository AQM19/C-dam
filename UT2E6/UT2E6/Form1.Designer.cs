<<<<<<< HEAD
﻿namespace UT2E6
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
            this.lvwDatos = new System.Windows.Forms.ListView();
            this.lblNumeroElementos = new System.Windows.Forms.Label();
            this.txtNumeroElementos = new System.Windows.Forms.TextBox();
            this.lblSumatorio = new System.Windows.Forms.Label();
            this.txtSumatorio = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtNuevoElemento = new System.Windows.Forms.TextBox();
            this.lblNuevoElemento = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwDatos
            // 
            this.lvwDatos.GridLines = true;
            this.lvwDatos.HideSelection = false;
            this.lvwDatos.Location = new System.Drawing.Point(12, 12);
            this.lvwDatos.MultiSelect = false;
            this.lvwDatos.Name = "lvwDatos";
            this.lvwDatos.Size = new System.Drawing.Size(291, 177);
            this.lvwDatos.TabIndex = 0;
            this.lvwDatos.UseCompatibleStateImageBehavior = false;
            this.lvwDatos.View = System.Windows.Forms.View.List;
            // 
            // lblNumeroElementos
            // 
            this.lblNumeroElementos.AutoSize = true;
            this.lblNumeroElementos.Location = new System.Drawing.Point(310, 13);
            this.lblNumeroElementos.Name = "lblNumeroElementos";
            this.lblNumeroElementos.Size = new System.Drawing.Size(110, 13);
            this.lblNumeroElementos.TabIndex = 1;
            this.lblNumeroElementos.Text = "Número de elementos";
            // 
            // txtNumeroElementos
            // 
            this.txtNumeroElementos.Location = new System.Drawing.Point(426, 10);
            this.txtNumeroElementos.Name = "txtNumeroElementos";
            this.txtNumeroElementos.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroElementos.TabIndex = 2;
            this.txtNumeroElementos.Text = "0";
            // 
            // lblSumatorio
            // 
            this.lblSumatorio.AutoSize = true;
            this.lblSumatorio.Location = new System.Drawing.Point(309, 39);
            this.lblSumatorio.Name = "lblSumatorio";
            this.lblSumatorio.Size = new System.Drawing.Size(54, 13);
            this.lblSumatorio.TabIndex = 3;
            this.lblSumatorio.Text = "Sumatorio";
            // 
            // txtSumatorio
            // 
            this.txtSumatorio.Location = new System.Drawing.Point(426, 36);
            this.txtSumatorio.Name = "txtSumatorio";
            this.txtSumatorio.Size = new System.Drawing.Size(111, 20);
            this.txtSumatorio.TabIndex = 4;
            this.txtSumatorio.Text = "0";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(426, 62);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(111, 20);
            this.txtMedia.TabIndex = 5;
            this.txtMedia.Text = "0";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(426, 88);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(111, 20);
            this.txtMaximo.TabIndex = 6;
            this.txtMaximo.Text = "0";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(426, 114);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(111, 20);
            this.txtMinimo.TabIndex = 7;
            this.txtMinimo.Text = "0";
            // 
            // txtNuevoElemento
            // 
            this.txtNuevoElemento.Location = new System.Drawing.Point(426, 140);
            this.txtNuevoElemento.Name = "txtNuevoElemento";
            this.txtNuevoElemento.Size = new System.Drawing.Size(111, 20);
            this.txtNuevoElemento.TabIndex = 8;
            // 
            // lblNuevoElemento
            // 
            this.lblNuevoElemento.AutoSize = true;
            this.lblNuevoElemento.Location = new System.Drawing.Point(309, 143);
            this.lblNuevoElemento.Name = "lblNuevoElemento";
            this.lblNuevoElemento.Size = new System.Drawing.Size(85, 13);
            this.lblNuevoElemento.TabIndex = 10;
            this.lblNuevoElemento.Text = "Nuevo elemento";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(309, 117);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(42, 13);
            this.lblMinimo.TabIndex = 11;
            this.lblMinimo.Text = "Mínimo";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(310, 91);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(43, 13);
            this.lblMaximo.TabIndex = 12;
            this.lblMaximo.Text = "Máximo";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(309, 65);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 13;
            this.lblMedia.Text = "Media";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(394, 166);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 14;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(313, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(543, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 209);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblNuevoElemento);
            this.Controls.Add(this.txtNuevoElemento);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtSumatorio);
            this.Controls.Add(this.lblSumatorio);
            this.Controls.Add(this.txtNumeroElementos);
            this.Controls.Add(this.lblNumeroElementos);
            this.Controls.Add(this.lvwDatos);
            this.Name = "Form1";
            this.Text = "Valores de la lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwDatos;
        private System.Windows.Forms.Label lblNumeroElementos;
        private System.Windows.Forms.TextBox txtNumeroElementos;
        private System.Windows.Forms.Label lblSumatorio;
        private System.Windows.Forms.TextBox txtSumatorio;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtNuevoElemento;
        private System.Windows.Forms.Label lblNuevoElemento;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAdd;
    }
}

=======
﻿namespace UT2E6
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
            this.lvwDatos = new System.Windows.Forms.ListView();
            this.lblNumeroElementos = new System.Windows.Forms.Label();
            this.txtNumeroElementos = new System.Windows.Forms.TextBox();
            this.lblSumatorio = new System.Windows.Forms.Label();
            this.txtSumatorio = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtNuevoElemento = new System.Windows.Forms.TextBox();
            this.lblNuevoElemento = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwDatos
            // 
            this.lvwDatos.GridLines = true;
            this.lvwDatos.HideSelection = false;
            this.lvwDatos.Location = new System.Drawing.Point(12, 12);
            this.lvwDatos.MultiSelect = false;
            this.lvwDatos.Name = "lvwDatos";
            this.lvwDatos.Size = new System.Drawing.Size(291, 177);
            this.lvwDatos.TabIndex = 0;
            this.lvwDatos.UseCompatibleStateImageBehavior = false;
            this.lvwDatos.View = System.Windows.Forms.View.List;
            // 
            // lblNumeroElementos
            // 
            this.lblNumeroElementos.AutoSize = true;
            this.lblNumeroElementos.Location = new System.Drawing.Point(310, 13);
            this.lblNumeroElementos.Name = "lblNumeroElementos";
            this.lblNumeroElementos.Size = new System.Drawing.Size(110, 13);
            this.lblNumeroElementos.TabIndex = 1;
            this.lblNumeroElementos.Text = "Número de elementos";
            // 
            // txtNumeroElementos
            // 
            this.txtNumeroElementos.Location = new System.Drawing.Point(426, 10);
            this.txtNumeroElementos.Name = "txtNumeroElementos";
            this.txtNumeroElementos.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroElementos.TabIndex = 2;
            this.txtNumeroElementos.Text = "0";
            // 
            // lblSumatorio
            // 
            this.lblSumatorio.AutoSize = true;
            this.lblSumatorio.Location = new System.Drawing.Point(309, 39);
            this.lblSumatorio.Name = "lblSumatorio";
            this.lblSumatorio.Size = new System.Drawing.Size(54, 13);
            this.lblSumatorio.TabIndex = 3;
            this.lblSumatorio.Text = "Sumatorio";
            // 
            // txtSumatorio
            // 
            this.txtSumatorio.Location = new System.Drawing.Point(426, 36);
            this.txtSumatorio.Name = "txtSumatorio";
            this.txtSumatorio.Size = new System.Drawing.Size(111, 20);
            this.txtSumatorio.TabIndex = 4;
            this.txtSumatorio.Text = "0";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(426, 62);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(111, 20);
            this.txtMedia.TabIndex = 5;
            this.txtMedia.Text = "0";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(426, 88);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(111, 20);
            this.txtMaximo.TabIndex = 6;
            this.txtMaximo.Text = "0";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(426, 114);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(111, 20);
            this.txtMinimo.TabIndex = 7;
            this.txtMinimo.Text = "0";
            // 
            // txtNuevoElemento
            // 
            this.txtNuevoElemento.Location = new System.Drawing.Point(426, 140);
            this.txtNuevoElemento.Name = "txtNuevoElemento";
            this.txtNuevoElemento.Size = new System.Drawing.Size(111, 20);
            this.txtNuevoElemento.TabIndex = 8;
            // 
            // lblNuevoElemento
            // 
            this.lblNuevoElemento.AutoSize = true;
            this.lblNuevoElemento.Location = new System.Drawing.Point(309, 143);
            this.lblNuevoElemento.Name = "lblNuevoElemento";
            this.lblNuevoElemento.Size = new System.Drawing.Size(85, 13);
            this.lblNuevoElemento.TabIndex = 10;
            this.lblNuevoElemento.Text = "Nuevo elemento";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(309, 117);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(42, 13);
            this.lblMinimo.TabIndex = 11;
            this.lblMinimo.Text = "Mínimo";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(310, 91);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(43, 13);
            this.lblMaximo.TabIndex = 12;
            this.lblMaximo.Text = "Máximo";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(309, 65);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 13;
            this.lblMedia.Text = "Media";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(394, 166);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 14;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(313, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(543, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 209);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblNuevoElemento);
            this.Controls.Add(this.txtNuevoElemento);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtSumatorio);
            this.Controls.Add(this.lblSumatorio);
            this.Controls.Add(this.txtNumeroElementos);
            this.Controls.Add(this.lblNumeroElementos);
            this.Controls.Add(this.lvwDatos);
            this.Name = "Form1";
            this.Text = "Valores de la lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwDatos;
        private System.Windows.Forms.Label lblNumeroElementos;
        private System.Windows.Forms.TextBox txtNumeroElementos;
        private System.Windows.Forms.Label lblSumatorio;
        private System.Windows.Forms.TextBox txtSumatorio;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtNuevoElemento;
        private System.Windows.Forms.Label lblNuevoElemento;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAdd;
    }
}

>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
