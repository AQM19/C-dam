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
    public partial class LibroFrm : Form
    {
        private Libro libroSeleccionado;
        private LibroFrm()
        {
            InitializeComponent();
        }

        public LibroFrm(Libro libro) : this()
        {
            libroSeleccionado = libro;
            if(Negocio.ObtenerLibro(libroSeleccionado.LibroId) != null)
            {
                txtTituloLibro.Text = libro.Titulo;
                txtAnnoLibro.Text = libro.Anno.ToString();
                txtAutorLibro.Text = libro.Autor;
            }            
        }

        private void btnCancelarLibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarDatos()
        {
            int anno;
            if(string.IsNullOrEmpty(txtTituloLibro.Text))
            {
                MessageBox.Show("Título obligatorio", "Error!");
                txtTituloLibro.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtAnnoLibro.Text) || !int.TryParse(txtAnnoLibro.Text, out anno))
            {
                MessageBox.Show("Año incorrecto", "Error!");
                txtAnnoLibro.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtAutorLibro.Text))
            {
                MessageBox.Show("Autor obligatorio", "Error!");
                txtAutorLibro.Focus();
                return false;
            }
            return true;
        }

        private void btnAceptarLibro_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                string titulo = txtTituloLibro.Text;
                string autor = txtAutorLibro.Text;
                libroSeleccionado.Titulo = titulo;
                libroSeleccionado.Anno = int.Parse(txtAnnoLibro.Text);
                libroSeleccionado.Autor = autor;

                if(Negocio.ObtenerLibro(libroSeleccionado.LibroId) == null)
                {
                    Negocio.CrearLibro(libroSeleccionado);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
