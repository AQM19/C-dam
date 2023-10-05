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
    public partial class frmAnimal : Form
    {
        private Herramientas herramientas = new Herramientas();
        private Animal animal;

        /// <summary>
        /// Constructores
        /// </summary>
        #region
        public frmAnimal()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            CargarListas();
        }

        public frmAnimal(Animal animale) : this()
        {
            this.animal = animale;

            this.txtNombre.Text = this.animal.Nombre;
            this.cboEspecie.Text = this.animal.Especie;
            this.txtRaza.Text = this.animal.Raza;
            this.nudPeso.Value = (decimal)this.animal.Peso;
            this.nudEspacio.Value = (decimal)this.animal.EspacioMin;
            this.dtpNacimiento.Value = this.animal.Nacimiento ?? this.dtpNacimiento.Value;
            this.dtpEntrada.Value = (this.animal.Entrada < DateTime.MinValue)? DateTime.Now : this.dtpEntrada.Value;
            if (this.animal.RefugioId > 0)
            {
                this.cboRefugio.Text = herramientas.ObtenerRefugioPorId(this.animal.RefugioId).Nombre;
            }
        }
        #endregion

        /// <summary>
        /// Obtención de los refugios y agregación al ComboBox de Regfugios.
        /// </summary>
        #region
        private void CargarListas()
        {
            herramientas.ObtenerRefugios().ForEach(o =>
            {
                cboRefugio.Items.Add(o.Nombre);
            });
        }
        #endregion

        /// <summary>
        /// Validación de datos
        /// </summary>
        /// <returns>bool</returns>
        #region
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.cboRefugio.Text))
            {
                MessageBox.Show("El animal debe tener un refugio asignado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboRefugio.Focus();
                return false;
            }
            if (this.dtpEntrada.Value == null)
            {
                MessageBox.Show("El campo de fecha de entrada debe ser obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtpEntrada.Focus();
                return false;
            }
            if (this.dtpEntrada.Value < this.dtpNacimiento.Value)
            {
                MessageBox.Show("Un animal no puede entrar en el zoológico antes de nacer.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtpEntrada.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.cboEspecie.Text))
            {
                MessageBox.Show("El campo especie es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboEspecie.Focus();
                return false;
            }
            if (this.cboEspecie.Text != herramientas.ObtenerEspecieDeRefugioPorNombre(this.cboRefugio.Text))
            {
                MessageBox.Show("Este refugio no recoge esta especie animal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboEspecie.Focus();
                return false;
            }
            if (this.nudPeso.Value <= 0)
            {
                MessageBox.Show("El animal no puede tener peso nulo o negativo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.nudPeso.Focus();
                return false;
            }
            if (this.nudEspacio.Value <= 0)
            {
                MessageBox.Show("El animal necesita un mínimo de espacio para poder entrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.nudEspacio.Focus();
                return false;
            }
            if (this.nudEspacio.Value < herramientas.ObtenerNumeroAnimalesPorNombre(this.cboRefugio.Text))
            {
                MessageBox.Show($"El animal no tiene espacio en el refugio {this.cboRefugio.Text}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.nudEspacio.Focus();
                return false;
            }
            return true;
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
                this.animal.RefugioId = herramientas.ObtenerRefugioPorNombre(this.cboRefugio.Text).RefugioId;
                this.animal.Nombre = this.txtNombre.Text;
                this.animal.Nacimiento = this.dtpNacimiento.Value;
                this.animal.Entrada = this.dtpEntrada.Value;
                this.animal.Especie = this.cboEspecie.Text;
                this.animal.Raza = this.txtRaza.Text;
                this.animal.Peso = (float)this.nudPeso.Value;
                this.animal.EspacioMin = (int)this.nudEspacio.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion
    }
}
