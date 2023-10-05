using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace P1_Aaron_Quintanal
{
    public partial class Profesorfrm : Form
    {

        private Profesore profeEditable;
        private string cuerpoSeleccionado;

        public Profesorfrm()
        {
            InitializeComponent();
            this.cuerpoSeleccionado = "Secundaria";
        }

        public Profesorfrm(Profesore profeEditable) : this()
        {
            this.profeEditable = profeEditable;
            this.DialogResult = DialogResult.Cancel;

            txtNombreProfe.Text = profeEditable.Nombre;
            txtTelefonoProfe.Text = profeEditable.Telefono;
            txtCodigoPofe.Text = profeEditable.Codigo;

            switch (profeEditable.Cuerpo)
            {
                case "Secundaria":
                    rbSecundaria.Checked = true;
                    break;
                case "FP":
                    rbFP.Checked = true;
                    break;
                case "Otro":
                    rbOtro.Checked = true;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        private void btnCancelarProfe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarProfe_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.profeEditable.Nombre = txtNombreProfe.Text;
                this.profeEditable.Telefono = txtTelefonoProfe.Text;
                this.profeEditable.Cuerpo = cuerpoSeleccionado;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombreProfe.Text))
            {
                MessageBox.Show("El campo nombre es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreProfe.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefonoProfe.Text))
            {
                MessageBox.Show("El campo teléfono es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefonoProfe.Focus();
                return false;
            }
            return true;
        }

        private void txtTelefonoProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pulsada = e.KeyChar;
            if(pulsada == '\b' || (pulsada >= '0' && pulsada <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void rbSecundaria_CheckedChanged(object sender, EventArgs e)
        {
            this.cuerpoSeleccionado = (string)((RadioButton)sender).Tag;
        }
    }
}
