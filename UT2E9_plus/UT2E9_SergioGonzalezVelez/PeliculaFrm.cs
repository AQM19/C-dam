using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E9_SergioGonzalezVelez
{  
    public partial class PeliculaFrm : Form
    {
        private Pelicula peliculaSeleccionada;
        private PeliculaFrm()
        {
            InitializeComponent();
        }
        public PeliculaFrm(Pelicula pelicula) : this()
        {
            peliculaSeleccionada = pelicula;

            txtTituloPelicula.Text = pelicula.Titulo;
            txtAnnoPelicula.Text = pelicula.Anno.ToString();
            txtGeneroPelicula.Text = pelicula.Genero;
        }

        private void btnCancelarPelicula_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarPelicula_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                peliculaSeleccionada.Titulo = txtTituloPelicula.Text;
                peliculaSeleccionada.Anno = int.Parse(txtAnnoPelicula.Text);
                peliculaSeleccionada.Genero = txtGeneroPelicula.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private bool ValidarDatos()
        {
            int anno;
            if (string.IsNullOrEmpty(txtTituloPelicula.Text))
            {
                MessageBox.Show("Título obligatorio", "Error!");
                txtTituloPelicula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAnnoPelicula.Text) || !int.TryParse(txtAnnoPelicula.Text, out anno))
            {
                MessageBox.Show("Año incorrecto", "Error!");
                txtAnnoPelicula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGeneroPelicula.Text))
            {
                MessageBox.Show("Género obligatorio", "Error!");
                txtGeneroPelicula.Focus();
                return false;
            }
            return true;
        }
    }
}
