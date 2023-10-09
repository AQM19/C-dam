using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardiApp
{
    public partial class FrmBuscarProfesor : Form
    {
        /// <summary>
        /// Cache
        /// </summary>
        #region
        private Profesor profesor = null;
        public Profesor Profesor
        {
            get => profesor;
            set => profesor = value;
        }
        #endregion

        /// <summary>
        /// Constructores
        /// </summary>
        #region
        private FrmBuscarProfesor()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        public FrmBuscarProfesor(Profesor profesor) : this()
        {
            this.Profesor = profesor;
        }
        #endregion

        /// <summary>
        /// Evento de botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtProfesor.Text))
            {
                string profe = this.txtProfesor.Text;

                if (Int32.TryParse(profe, out int idProfesor))
                {
                    
                    idProfesor = Int32.Parse(profe);
                    this.Profesor = await Herramientas.ObtenerProfesorPorId(idProfesor);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    this.Profesor = await Herramientas.ObtenerProfesorPorNombre(profe);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        #endregion
    }
}