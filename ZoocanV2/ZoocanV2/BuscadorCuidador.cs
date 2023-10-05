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
    public partial class BuscadorCuidador : Form
    {

        Herramientas herramientas = new Herramientas();
        private Cuidador cuidador;


        /// <summary>
        /// Constructores
        /// </summary>
        #region
        public BuscadorCuidador()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public BuscadorCuidador(Cuidador cuidador) : this()
        {
            if(cuidador != null ) 
            {
                this.cuidador = cuidador;
                txtCuidador.Text = this.cuidador.Nombre;
            }
        }
        #endregion

        /// <summary>
        /// Getter
        /// </summary>
        #region
        public Cuidador Cuidador
        {
            get { return this.cuidador; }
        }
        #endregion

        /// <summary>
        /// Botón de búsqueda por nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cuidador cuidador = herramientas.ObtenerCuidadorPorNombre(txtCuidador.Text);

                if(cuidador == null)
                {
                    MessageBox.Show("No se encontró el cuidador", "Error");
                }

                this.cuidador = cuidador;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        /// <summary>
        /// Validación de datos
        /// </summary>
        /// <returns>bool</returns>
        #region
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtCuidador.Text))
            {
                MessageBox.Show("El campo nombre es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCuidador.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
