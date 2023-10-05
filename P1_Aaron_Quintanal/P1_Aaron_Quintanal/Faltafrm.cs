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

    public partial class Faltafrm : Form
    {

        private Falta faltaEditable;

        public Faltafrm()
        {
            InitializeComponent();
            dtpFechaFalta.Value = DateTime.Now;
            cboComboHora.SelectedIndex = 0;
            cboComboGrupo.SelectedIndex = 0;

        }

        public Faltafrm(Falta faltaEditable) : this()
        {
            this.faltaEditable = faltaEditable;
            this.DialogResult = DialogResult.Cancel;

            if(faltaEditable.FaltaId >= 0)
            {
                return;
            }

            this.dtpFechaFalta.Value = this.faltaEditable.Dia;
            this.cboComboHora.SelectedText = this.faltaEditable.Hora.ToString();
            this.cboComboGrupo.SelectedText = this.faltaEditable.Grupo.ToString();
            this.txtObservaciones.Text = this.faltaEditable.Observaciones;
            this.txtProfesorFalta.Text = Herramientas.ObtenerProfesorNombrePorID(this.faltaEditable.ProfeFalta);
            if (this.faltaEditable.ProfeSusti.HasValue)
            {
                this.txtSustitutoFalta.Text = Herramientas.ObtenerProfesorNombrePorID(this.faltaEditable.ProfeSusti.Value);
            }
        }

        private void btnProfesorFalta_Click(object sender, EventArgs e)
        {
            BuscadorProfesorfrm buscadorProfesorfrm = new BuscadorProfesorfrm();

            if (buscadorProfesorfrm.ShowDialog() == DialogResult.OK)
            {
                this.txtProfesorFalta.Text = Herramientas.ObtenerProfesorNombrePorID(buscadorProfesorfrm.ProfesorId.Value);
            }
        }

        private void btnProfesorSustituto_Click(object sender, EventArgs e)
        {
            int idBuscar = new int();
            BuscadorProfesorfrm buscadorProfesorfrm = new BuscadorProfesorfrm(idBuscar);

            if (buscadorProfesorfrm.ShowDialog() == DialogResult.OK)
            {
                //this.profeSusti = cliente.ObtenerProfesor(idBuscar); // No entiendo el error, no se por que no cambia su valor
                //txtProfesorFalta.Text = this.profeSusti.Nombre;
            }
        }

        private void btnEliminarSustituto_Click(object sender, EventArgs e)
        {
            txtSustitutoFalta.Text = string.Empty;
        }

        private void btnCancelarFalta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarFalta_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.faltaEditable.Dia = this.dtpFechaFalta.Value;
                this.faltaEditable.Hora = Convert.ToInt32(this.cboComboHora.SelectedText);
                this.faltaEditable.Grupo = this.cboComboGrupo.SelectedText;
                this.faltaEditable.Observaciones = this.txtObservaciones.Text;
                this.faltaEditable.ProfeFalta = Herramientas.ObtenerProfesorIdPorNombre(this.txtProfesorFalta.Text).Value;
                this.faltaEditable.ProfeSusti = Herramientas.ObtenerProfesorIdPorNombre(this.txtSustitutoFalta.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtProfesorFalta.Text))
            {
                MessageBox.Show("El campo profesor falta es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProfesorFalta.Focus();
                return false;
            }
            if (this.txtProfesorFalta.Text.Equals(this.txtSustitutoFalta.Text))
            {
                MessageBox.Show("El profesor sustituto y el que falta no pueden ser el mismo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProfesorSustituto.Focus();
                return false;
            }
            return true;
        }
    }
}
