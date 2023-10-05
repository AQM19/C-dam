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
    public partial class RefugioFrm : Form
    {
        private Refugio refugio;
        private Negocio negocio;

        public RefugioFrm()
        {
            InitializeComponent();
            this.negocio = new Negocio();
            DialogResult = DialogResult.Cancel;
            CargarListas();           
        }

        public RefugioFrm(Refugio refugioEditable) : this()
        {
            this.refugio = refugioEditable;

            if(refugio.RefugioId > 0)
            {
                if(negocio.ObtenerCuidadoreResponsable(refugio.RefugioId) != null)
                {
                    cboCuidadorRefugio.Text = negocio.ObtenerCuidadoreResponsable(refugio.RefugioId).Nombre;
                }
                
                txtNombreRefugio.Text = refugio.Nombre;
                txtDireccionRefugio.Text = refugio.Direccion;
                txtEspecieRefugio.Text = refugio.Especie;
                txtTelefonoRefugio.Text = refugio.Telefono;
                txtMaximoAnimalesRefugio.Text = refugio.MaxAnimales.ToString();
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
                AsignarRefugio();
                refugio.Nombre = txtNombreRefugio.Text;
                refugio.Direccion = txtDireccionRefugio.Text;
                refugio.Especie = txtEspecieRefugio.Text;
                refugio.Telefono = txtTelefonoRefugio.Text;
                refugio.MaxAnimales = Convert.ToInt32(txtMaximoAnimalesRefugio.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void AsignarRefugio()
        {
            if (!string.IsNullOrEmpty(cboCuidadorRefugio.Text))
            {
                Cuidadore cuidadore = negocio.ObtenerCuidadorePorNombre(cboCuidadorRefugio.Text);
                cuidadore.RefugioId = refugio.RefugioId;
                negocio.ActualizarCuidadore(cuidadore);
            }
        }

        private bool ValidarDatos()
        {
            int value;
            if(string.IsNullOrEmpty(txtNombreRefugio.Text))
            {
                MessageBox.Show("Nombre obligatorio", "Error!");
                txtNombreRefugio.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtDireccionRefugio.Text))
            {
                MessageBox.Show("Dirección obligatoria", "Error!");
                txtDireccionRefugio.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtEspecieRefugio.Text))
            {
                MessageBox.Show("Especie obligatoria", "Error!");
                txtEspecieRefugio.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtTelefonoRefugio.Text))
            {
                MessageBox.Show("Teléfono obligatorio", "Error!");
                txtTelefonoRefugio.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtMaximoAnimalesRefugio.Text) && int.TryParse(txtMaximoAnimalesRefugio.Text, out value))
            {
                MessageBox.Show("Cantidad máxima obligatoria", "Error!");
                txtMaximoAnimalesRefugio.Focus();
                return false;
            }
            return true;
        }

        private void btnCrearCuidador_Click(object sender, EventArgs e)
        {
            Cuidadore cuidadoreNuevo = new Cuidadore();
            CuidadoreFrm cuidadoreFrm = new CuidadoreFrm(cuidadoreNuevo);

            if(cuidadoreFrm.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearCuidadore(cuidadoreNuevo);
                CargarListas();
            }
        }

        private void CargarListas()
        {
            negocio.ObtenerCuidadores().Where(x => !x.Responsable).ToList().ForEach(x =>
            {
                cboCuidadorRefugio.Items.Add(x.Nombre);
            });
        }
    }
}
