using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoocanV2
{
    public partial class frmCuidador : Form
    {
        private Herramientas herramientas = new Herramientas();
        private Cuidador cuidador;
        private Cuidador responsable;

        /// <summary>
        /// Constructores
        /// </summary>
        #region
        public frmCuidador()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            ObtenerListas();
        }

        public frmCuidador(Cuidador cuidador) : this()
        {
            this.cuidador = cuidador;

            this.txtNombre.Text = this.cuidador.Nombre;
            this.txtTelefono.Text = this.cuidador.Telefono;
            this.txtDireccion.Text = this.cuidador.Direccion;
            this.nupSalario.Value = this.cuidador.SalarioAnual;
            this.cboEspecie.Text = this.cuidador.Especie;
            if (this.cuidador.RefugioId > 0)
            {
                this.cboRefugio.Text = herramientas.ObtenerRefugioPorId(this.cuidador.RefugioId).Nombre;
            }
            if (this.cuidador.Responsable)
            {
                this.chkResponsable.Checked = true;
            }
        }
        #endregion

        /// <summary>
        /// Obtención de los refugios y agregación al ComboBox de Regfugios.
        /// </summary>
        #region
        private void ObtenerListas()
        {
            herramientas.ObtenerRefugios().ForEach(o =>
            {
                cboRefugio.Items.Add(o.Nombre);
            });
        }
        #endregion

        /// <summary>
        /// Validar datos
        /// </summary>
        /// <returns>bool</returns>
        #region
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.cboRefugio.Text))
            {
                MessageBox.Show("Los cuidadores han de tener un refugio asignado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboRefugio.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("El campo nombre es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtTelefono.Text))
            {
                MessageBox.Show("El campo teléfono es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTelefono.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDireccion.Text))
            {
                MessageBox.Show("El campo dirección es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDireccion.Focus();
                return false;
            }
            if (this.nupSalario.Value < 0)
            {
                MessageBox.Show("El campo salario debe ser superior a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.nupSalario.Focus();
                return false;
            }
            if (this.cboEspecie.Text != herramientas.ObtenerEspecieDeRefugioPorId(herramientas.ObtenerRefugioPorNombre(this.cboRefugio.Text).RefugioId))
            {
                MessageBox.Show("El cuidador debe estar especializado en la misma especie que se refugia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboEspecie.Focus();
                return false;
            }
            return true;
        }
        #endregion

        /// <summary>
        /// Sustitución de responsabilidad del refugio asignado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void chkResponsable_Click(object sender, EventArgs e)
        {
            if (chkResponsable.Checked)
            {
                Refugio refugio = herramientas.ObtenerRefugioPorNombre(this.cboRefugio.Text);
                if (refugio != null)
                {
                    this.responsable = herramientas.ObtenerCuidadorPorId(refugio.RefugioId);

                    if (cuidador.CuidadorId > 0)
                    {
                        if (MessageBox.Show($"¿Estás seguro de querer sustituir como responsable a {this.responsable.Nombre}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            chkResponsable.Checked = true;
                        }
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Botones de acción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.cuidador.RefugioId = herramientas.ObtenerRefugioPorNombre(this.cboRefugio.Text).RefugioId;
                this.cuidador.Nombre = this.txtNombre.Text;
                this.cuidador.Telefono = this.txtTelefono.Text;
                this.cuidador.Direccion = this.txtDireccion.Text;
                this.cuidador.SalarioAnual = (int)this.nupSalario.Value;
                this.cuidador.Especie = this.cboEspecie.Text;
                this.cuidador.Responsable = this.chkResponsable.Checked;

                if (this.chkResponsable.Checked && this.responsable != null) 
                {
                    this.responsable.Responsable = false;
                    herramientas.ActualizarCuidador(this.responsable);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion
    }
}
