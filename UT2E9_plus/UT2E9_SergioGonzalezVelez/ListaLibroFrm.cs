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
    public partial class ListaLibroFrm : Form
    {
        private Negocio negocio = new Negocio();
        public ListaLibroFrm()
        {
            InitializeComponent();
        }

        private void cmsLibros_Opening(object sender, CancelEventArgs e)
        {
            cmsiVer.Enabled = false;
            cmsiCrear.Enabled = false;
            cmsiBorrar.Enabled = false;

            if(lvwLibros.SelectedItems.Count > 0)
            {
                cmsiVer.Enabled = true;
                cmsiBorrar.Enabled = true;
            } else
            {
                cmsiCrear.Enabled = true;
            }
        }

        private void cmsiCrear_Click(object sender, EventArgs e)
        {
            Libro libronuevo = new Libro();
            LibroFrm frmLibro = new LibroFrm(libronuevo);

            if (frmLibro.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearLibro(libronuevo);
                CargarLibros();
            }
        }

        private void cmsiBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro de borrar el libro seleccionado?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int libroId = Int32.Parse(lvwLibros.SelectedItems[0].Tag.ToString());
                Libro seleccionado = negocio.ObtenerLibro(libroId);
                negocio.BorrarLibro(seleccionado.LibroId);
                CargarLibros();
            }
        }

        private void cmsiVer_Click(object sender, EventArgs e)
        {
            int libroId = Int32.Parse(lvwLibros.SelectedItems[0].Tag.ToString());
            Libro seleccionado = negocio.ObtenerLibro(libroId);
            LibroFrm frmLibro = new LibroFrm(seleccionado);
            if (frmLibro.ShowDialog() == DialogResult.OK)
            {
                negocio.ActualizarLibro(seleccionado);
                CargarLibros();
            }
        }

        private void CargarLibros()
        {
            lvwLibros.Items.Clear();
            List<Libro> libros = negocio.ObtenerLibros();
            foreach (Libro libro in libros)
            {
                string[] datos = { libro.Titulo, libro.Anno.ToString(), libro.Autor };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = libro.LibroId;
                lvwLibros.Items.Add(item);
            }
        }

        private void ListaLibroFrm_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }
    }
}
