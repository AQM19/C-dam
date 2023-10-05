using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuardiApp
{
    public partial class frmGuardiaProp : Form
    {
        /// <summary>
        /// Caches
        /// </summary>
        #region
        private Guardia guardia;
        private Profesor profesorFalta;
        private Profesor profesorSusti;
        #endregion

        /// <summary>
        /// Constructores
        /// </summary>
        #region
        private frmGuardiaProp()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        public frmGuardiaProp(Guardia guardia) : this()
        {
            this.guardia = guardia;

            if (guardia.id > 0)
            {
                dtpDia.Text = guardia.fecha.ToString();
                cbmHora.Text = guardia.hora.ToString();
                cmbEstado.Text = guardia.estado;
                txtObservaciones.Text = guardia.observaciones;

                switch (guardia.estado)
                {
                    case "R":
                        cmbEstado.Text = "Realizada";
                        break;
                    case "C":
                        cmbEstado.Text = "Confirmada";
                        break;
                    case "A":
                        cmbEstado.Text = "Anulada";
                        break;
                }

                _ = ObtenerProfesor();
            }
        }
        #endregion

        /// <summary>
        /// Metodos de obtención
        /// </summary>
        /// <returns></returns>
        #region
        private async Task ObtenerProfesor()
        {
            this.profesorFalta = await Herramientas.ObtenerProfesorPorId(this.guardia.prof_falta);
            txtProfFalta.Text = $"{profesorFalta.nombre} {profesorFalta.ape1} {profesorFalta.ape2}";

            if (this.guardia.prof_hace_guardia != null)
            {
                this.profesorSusti = await Herramientas.ObtenerProfesorPorId((int)this.guardia.prof_hace_guardia);
                txtProfSusti.Text = $"{profesorSusti.nombre} {profesorSusti.ape1} {profesorSusti.ape2}";
            }
        }
        private async Task ObtenerHorario()
        {
            Horario horario = await Herramientas.ObtenerHorario(this.profesorFalta.id, this.guardia.hora, (int)this.guardia.dia_semana);
            if (horario != null)
            {
                this.guardia.horario = horario.id;
                this.guardia.grupo = horario?.grupo;
                this.guardia.aula = horario?.aula;
            }
        }
        private string ObtenerEstado(string estado)
        {
            switch (estado)
            {
                case "Realizada":
                    return "R";
                case "Confirmada":
                    return "C";
                default: return "A";
            }
        }
        #endregion

        /// <summary>
        /// Eventos de boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.guardia.id = -1;
                this.guardia.fecha = DateTime.Parse(dtpDia.Value.ToShortDateString());
                this.guardia.hora = cbmHora.SelectedIndex + 1;
                this.guardia.dia_semana = (int?)this.guardia.fecha.DayOfWeek;
                await ObtenerHorario();

                if(this.guardia.horario > 0)
                {
                    this.guardia.estado = ObtenerEstado(cmbEstado.Text);
                    this.guardia.observaciones = txtObservaciones.Text;
                    this.guardia.prof_falta = profesorFalta.id;
                    this.guardia.prof_hace_guardia = profesorSusti?.id;

                    await Herramientas.CrearGuardia(guardia);
                    DialogResult = DialogResult.OK;
                    this.Close();
                } else
                {
                    MessageBox.Show("Este profesor no puede faltar a una hora que no tiene clase.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnProfesorFalta_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            FrmBuscarProfesor buscadorProfesor = new FrmBuscarProfesor(profesor);
            if (buscadorProfesor.ShowDialog() == DialogResult.OK)
            {
                this.profesorFalta = buscadorProfesor.Profesor;

                if (this.profesorFalta != null)
                {
                    txtProfFalta.Text = $"{profesorFalta.nombre} {profesorFalta.ape1} {profesorFalta.ape2}";
                }
            }
        }
        private void btnProfSusti_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            FrmBuscarProfesor buscadorProfesor = new FrmBuscarProfesor(profesor);

            if (buscadorProfesor.ShowDialog() == DialogResult.OK)
            {
                this.profesorSusti = buscadorProfesor.Profesor;

                if (this.profesorSusti != null)
                {
                    txtProfSusti.Text = $"{profesorSusti.nombre} {profesorSusti.ape1} {profesorSusti.ape2}";
                    cmbEstado.SelectedItem = "Realizada";
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.profesorSusti = null;
            txtProfSusti.Text = string.Empty;
            txtProfSusti.Focus();
            cmbEstado.SelectedItem = "Anulada";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        /// <summary>
        /// Validacion de datos
        /// </summary>
        /// <returns>true or false</returns>
        #region
        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtProfFalta.Text))
            {
                MessageBox.Show("El profesor que falta no puede ser nulo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProfFalta.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbmHora.Text))
            {
                MessageBox.Show("La hora no puede ser nula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmHora.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbEstado.Text))
            {
                MessageBox.Show("El estado no puede ser nulo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmHora.Focus();
                return false;
            }
            if (cmbEstado.Text.Equals("Realizada") && string.IsNullOrEmpty(txtProfSusti.Text))
            {
                MessageBox.Show("Una guardia no puede ser realizada por nadie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstado.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }


}
