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
    public partial class ListaPeliculaFrm : Form
    {
        private Negocio negocio = new Negocio();
        public ListaPeliculaFrm()
        {
            InitializeComponent();
        }

        private void cmsPelicula_Opening(object sender, CancelEventArgs e)
        {
            cmsiVerPelicula.Enabled = false;
            cmsiCrearPelicula.Enabled = false;
            cmsiBorrarPelicula.Enabled = false;

            if (lvwPeliculas.SelectedItems.Count > 0)
            {
                cmsiVerPelicula.Enabled = true;
                cmsiBorrarPelicula.Enabled = true;
            }
            else
            {
                cmsiCrearPelicula.Enabled = true;
            }
        }

        private void cmsiCrearPelicula_Click(object sender, EventArgs e)
        {
            Pelicula nuevapelicula = new Pelicula();
            PeliculaFrm frmPelicula = new PeliculaFrm(nuevapelicula);

            if (frmPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearPelicula(nuevapelicula);
                CargarPeliculas();
            }
        }

        private void cmsiVerPelicula_Click(object sender, EventArgs e)
        {
            int peliculaId = Int32.Parse(lvwPeliculas.SelectedItems[0].Tag.ToString());
            Pelicula seleccionado = negocio.ObtenerPelicula(peliculaId);
            PeliculaFrm frmPelicula = new PeliculaFrm(seleccionado);
            if (frmPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.ActualizarPelicula(seleccionado);
                CargarPeliculas();
            }
        }

        private void cmsiBorrarPelicula_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de borrar la película seleccionada?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int peliculaId = Int32.Parse(lvwPeliculas.SelectedItems[0].Tag.ToString());
                Pelicula seleccionado = negocio.ObtenerPelicula(peliculaId);
                negocio.BorrarPelicula(seleccionado.PeliculaId);
                CargarPeliculas();
            }
        }

        private void CargarPeliculas()
        {
            lvwPeliculas.Items.Clear();
            List<Pelicula> peliculas = negocio.ObtenerPeliculas();
            foreach (Pelicula pelicula in peliculas)
            {
                string[] datos = { pelicula.Titulo, pelicula.Anno.ToString(), pelicula.Genero };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = pelicula.PeliculaId;
                lvwPeliculas.Items.Add(item);
            }
        }

        private void ListaPeliculaFrm_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
        }
    }
}
