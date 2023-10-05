using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoocan
{
    public partial class AnimaleFrm : Form
    {
        private Negocio negocio;
        private Animale animaleAEditar;
        public AnimaleFrm()
        {
            InitializeComponent();
            this.negocio = new Negocio();
            DialogResult = DialogResult.Cancel;
            CargarListas();          
        }

        public AnimaleFrm(Animale animaleEditable) : this()
        {
            this.animaleAEditar = animaleEditable;

            if(animaleEditable.AnimalId > 0)
            {
                cboListadoRefugios.SelectedItem = negocio.ObtenerRefugio(animaleAEditar.RefugioId).Nombre;
                txtNombreAnimale.Text = animaleAEditar.Nombre;
                dtpFechaNacimientoAnimale.Value = animaleAEditar.Nacimiento.Value.Date;
                dtpFechaEntradaAnimale.Value = animaleAEditar.Entrada;
                cboEspecieAnimale.SelectedItem = animaleAEditar.Especie;
                txtRazaAnimale.Text = animaleAEditar.Raza;
                txtAnimalePeso.Text = animaleAEditar.Peso.ToString();
                txtAnimaleEspacio.Text = animaleAEditar.EspacioMin.ToString();
            }
        }

        private bool ValidarDatos()
        {
            int value;
            double doubleaux;
            if (string.IsNullOrEmpty(txtNombreAnimale.Text))
            {
                MessageBox.Show("Nombre obligatorio", "Error!");
                txtNombreAnimale.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(dtpFechaNacimientoAnimale.Text))
            {
                MessageBox.Show("Fecha de nacimiento obligatoria", "Error!");
                dtpFechaNacimientoAnimale.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(dtpFechaEntradaAnimale.Text))
            {
                MessageBox.Show("Fecha de entrada obligatoria", "Error!");
                dtpFechaEntradaAnimale.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(cboEspecieAnimale.Text))
            {
                MessageBox.Show("Especie obligatoria", "Error!");
                cboEspecieAnimale.Focus();
                return false;
            }
            if (!cboEspecieAnimale.Text.Equals(negocio.ObtenerRefugio(animaleAEditar.RefugioId).Especie))
            {
                MessageBox.Show("Ese refugio no puede cuidar a la especie indicada", "Error");
                cboListadoRefugios.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtRazaAnimale.Text))
            {
                MessageBox.Show("Raza obligatoria", "Error!");
                txtRazaAnimale.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtAnimalePeso.Text) || !double.TryParse(txtAnimalePeso.Text, out doubleaux))
            {
                MessageBox.Show("Peso obligatoria", "Error!");
                txtAnimalePeso.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtAnimaleEspacio.Text) || !int.TryParse(txtAnimaleEspacio.Text, out value))
            {
                MessageBox.Show("Espacio obligatoria", "Error!");
                txtAnimaleEspacio.Focus();
                return false;
            }
            return true;
        }
        private void btnCancelarAnimale_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptarAnimale_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                animaleAEditar.RefugioId = cboListadoRefugios.SelectedIndex;
                animaleAEditar.Nombre = txtNombreAnimale.Text;
                animaleAEditar.Nacimiento = dtpFechaNacimientoAnimale.Value;
                animaleAEditar.Entrada = dtpFechaEntradaAnimale.Value;
                animaleAEditar.Especie = cboEspecieAnimale.SelectedItem.ToString();
                animaleAEditar.Raza = txtRazaAnimale.Text;
                animaleAEditar.Peso = (float)double.Parse(txtAnimalePeso.Text);
                animaleAEditar.EspacioMin = Int32.Parse(txtAnimaleEspacio.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnInsertarRefugio_Click(object sender, EventArgs e)
        {
            Refugio refugioNuevo = new Refugio();
            RefugioFrm refugioFrm = new RefugioFrm(refugioNuevo);

            if(refugioFrm.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearRefugio(refugioNuevo);
                CargarListas();
            }
        }
        private void CargarListas()
        {
            negocio.ObtenerRefugios().ForEach(x =>
            {
                cboListadoRefugios.Items.Add(x.Nombre);
            });
        }
    }
}
