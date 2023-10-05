using System;
using System.Windows.Forms;

namespace GuardiApp
{
    public partial class fmrGuardiasMDI : Form
    {
        /// <summary>
        /// Cache
        /// </summary>
        #region
        private Profesor profesor;
        #endregion

        /// <summary>
        /// Constructores
        /// </summary>
        #region
        public fmrGuardiasMDI()
        {
            InitializeComponent();
        }
        public fmrGuardiasMDI(Profesor profe) : this()
        {
            this.profesor = profe;
        }
        #endregion

        /// <summary>
        /// Evento de boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void tsmiPestañasGuardias_Click(object sender, EventArgs e)
        {
            bool abierto = false;

            foreach (Form f in this.MdiChildren)
            {
                if (typeof(frmListaGuardias).IsInstanceOfType(f))
                {
                    abierto = true;
                }
            }

            if (!abierto)
            {
                frmListaGuardias hijo = new frmListaGuardias();
                hijo.MdiParent = this;
                hijo.Show();
            }
        }
        #endregion
    }
}