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
    public partial class frmRefugio : Form
    {
        private Herramientas herramientas = new Herramientas();
        private Refugio refugio;

        /// <summary>
        /// Constructores
        /// </summary>
        #region
        public frmRefugio()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public frmRefugio(Refugio refugio) : this()
        {
            this.refugio = refugio;

            txtNombre.Text = this.refugio.Nombre;
            txtDireccion.Text = this.refugio.Direccion;
            txtTelefono.Text = this.refugio.Telefono;
            txtAnimales.Text = this.refugio.MaxAnimales.ToString();
            cboEspecie.Text = this.refugio.Especie;
            if(herramientas.ObtenerCuidadorResponsablePorRefugioId(this.refugio.RefugioId) != null)
            {
                txtEncargado.Text = herramientas.ObtenerCuidadorResponsablePorRefugioId(this.refugio.RefugioId).Nombre;
            }
        }
        #endregion

        /// <summary>
        /// Botón de búsqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cuidador cuidador = herramientas.ObtenerCuidadorPorNombre(txtEncargado.Text);
            BuscadorCuidador buscador = new BuscadorCuidador(cuidador);

            if(buscador.ShowDialog() == DialogResult.OK)
            {
                cuidador = buscador.Cuidador;
                cuidador.RefugioId = this.refugio.RefugioId;
                herramientas.ActualizarCuidador(cuidador);
                txtEncargado.Text = cuidador.Nombre;
            }
        }
        #endregion

        /// <summary>
        /// Validacion de datos
        /// </summary>
        #region
        private bool ValidarDatos()
        {
            int aux;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("El campo dirección es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDireccion.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text) || !int.TryParse(txtTelefono.Text, out aux))
            {
                MessageBox.Show("El campo teléfono es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtAnimales.Text) || !int.TryParse(txtAnimales.Text, out aux))
            {
                MessageBox.Show("El campo del máximo de animales es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnimales.Focus();
                return false;
            }
            return true;
        }
        #endregion

        /// <summary>
        /// Acción de los botones
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
                this.refugio.Nombre = txtNombre.Text;
                this.refugio.Direccion = txtDireccion.Text;
                this.refugio.Telefono = txtTelefono.Text;
                this.refugio.MaxAnimales = int.Parse(txtAnimales.Text);
                this.refugio.Especie = cboEspecie.Text;

                if(!string.IsNullOrEmpty(txtEncargado.Text) ) {
                    Cuidador cuidador = herramientas.ObtenerCuidadorPorNombre(txtEncargado.Text);
                    if (cuidador != null)
                    {
                        cuidador.RefugioId = this.refugio.RefugioId;
                        herramientas.ActualizarCuidador(cuidador);
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion
    }
}
