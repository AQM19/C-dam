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
            if (Negocio.ObtenerPelicula(peliculaSeleccionada.PeliculaId) != null)
            {
                txtTituloPelicula.Text = pelicula.Titulo;
                txtAnnoPelicula.Text = pelicula.Anno.ToString();
                txtGeneroPelicula.Text = pelicula.Genero;
            }
        }

        private void btnCancelarPelicula_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarPelicula_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string titulo = txtTituloPelicula.Text;
                string genero = txtGeneroPelicula.Text;
                peliculaSeleccionada.Titulo = titulo;
                peliculaSeleccionada.Anno = int.Parse(txtAnnoPelicula.Text);
                peliculaSeleccionada.Genero = genero;

                if (Negocio.ObtenerPelicula(peliculaSeleccionada.PeliculaId) == null)
                {
                    Negocio.CrearPelicula(peliculaSeleccionada);
                }

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
