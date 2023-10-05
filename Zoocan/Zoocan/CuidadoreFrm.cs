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
    public partial class CuidadoreFrm : Form
    {
        private Negocio negocio;
        private Cuidadore cuidadore;

        public CuidadoreFrm()
        {
            InitializeComponent();
            this.negocio = new Negocio();
            DialogResult = DialogResult.Cancel;
            CargarListas();
        }

        public CuidadoreFrm(Cuidadore cuidadorEditable) : this()
        {
            this.cuidadore = cuidadorEditable;

            if (cuidadore.CuidadorId > 0)
            {
                cboRefugioCuidadore.SelectedItem = negocio.ObtenerRefugio(cuidadore.RefugioId).Nombre;
                txtNombreCuidadore.Text = cuidadore.Nombre;
                txtTelefonoCuidadore.Text = cuidadore.Telefono;
                txtDireccionCuidadore.Text = cuidadore.Direccion;
                txtSalarioCuidadore.Text = cuidadore.SalarioAnual.ToString();
                cboEspecie.SelectedItem = cuidadore.Especie;

                if (cuidadore.Responsable)
                {
                    chbResponsable.Checked = true;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (!string.IsNullOrEmpty(cboRefugioCuidadore.Text))
                {
                    cuidadore.RefugioId = negocio.ObtenerRefugios()
                                        .Where(x => x.Nombre.Equals(cboRefugioCuidadore.SelectedItem.ToString()))
                                        .First().RefugioId;
                }

                cuidadore.Nombre = txtNombreCuidadore.Text;
                cuidadore.Telefono = txtTelefonoCuidadore.Text;
                cuidadore.Direccion = txtDireccionCuidadore.Text;
                cuidadore.SalarioAnual = Convert.ToInt32(txtSalarioCuidadore.Text);
                cuidadore.Especie = cboEspecie.Text;
                if (chbResponsable.Checked)
                {
                    cuidadore.Responsable = true;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private bool ValidarDatos()
        {
            int value;
            if (string.IsNullOrEmpty(cboRefugioCuidadore.Text))
            {
                MessageBox.Show("Refugio asignado obligatorio", "Error!");
                cboRefugioCuidadore.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNombreCuidadore.Text))
            {
                MessageBox.Show("Nombre obligatorio", "Error!");
                txtNombreCuidadore.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefonoCuidadore.Text))
            {
                MessageBox.Show("Telefono obligatorio", "Error!");
                txtTelefonoCuidadore.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccionCuidadore.Text))
            {
                MessageBox.Show("Dirección obligatoria", "Error!");
                txtDireccionCuidadore.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtSalarioCuidadore.Text) || !int.TryParse(txtSalarioCuidadore.Text, out value)){
                MessageBox.Show("Salario obligatorio", "Error!");
                txtSalarioCuidadore.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboEspecie.Text))
            {
                MessageBox.Show("Especie obligatoria", "Error!");
                cboEspecie.Focus();
                return false;
            }
            return true;
        }
        private void CargarListas()
        {
            negocio.ObtenerRefugios().ForEach(x =>
            {
                cboRefugioCuidadore.Items.Add(x.Nombre);
            });
        }
    }
}
