using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Aaron_Quintanal
{
    public partial class BuscadorProfesorfrm : Form
    {
        private int? id = null;

        public BuscadorProfesorfrm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        public BuscadorProfesorfrm(int? id) : this()
        {
            this.id = id;
        }

        public int? ProfesorId
        {
            get { return id; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int? profe = Herramientas.ObtenerProfesorIdPorCodigo(this.txtBuscadorProfesor.Text);

                if (profe == null)
                {
                    MessageBox.Show("No se encontró al profesor", "Error");
                }

                this.id = profe;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtBuscadorProfesor.Text))
            {
                MessageBox.Show("Codigo o nombre requerido");
                txtBuscadorProfesor.Focus();
                return false;
            }
            return true;
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int? profe = Herramientas.ObtenerProfesorIdPorNombre(this.txtBuscadorProfesor.Text);

                if(profe == null)
                {
                    MessageBox.Show("No se encontró al profesor", "Error");
                }

                this.id = profe;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
