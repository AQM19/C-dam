using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GuardiApp
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Caches
        /// </summary>
        #region
        private Profesor profesor;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        #region
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = this.txtUsuario.Text;
            string pass = MD5Formatter(this.txtContraseña.Text);

            this.profesor = await Herramientas.ObtenerAdmin(user, pass);

            if (this.profesor != null)
            {
                fmrGuardiasMDI aplicacion = new fmrGuardiasMDI(profesor);
                this.Hide();
                aplicacion.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el inicio de sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                txtContraseña.Clear();
            }

        }
        #endregion

        /// <summary>
        /// Encriptacion del texto a MD5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        #region
        private string MD5Formatter(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            return hashString;
        }
        #endregion
    }
}
