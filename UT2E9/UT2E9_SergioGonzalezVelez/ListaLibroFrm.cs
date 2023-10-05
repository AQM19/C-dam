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
            LibroFrm frmLibro = new LibroFrm(new Libro());
            if (frmLibro.ShowDialog() == DialogResult.OK)
            {
                CargarLibros();
            }
        }

        private void cmsiBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro de borrar el libro seleccionado?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Libro seleccionado = (Libro)lvwLibros.SelectedItems[0].Tag;
                Negocio.BorrarLibro(seleccionado.LibroId);
                CargarLibros();
            }
        }

        private void cmsiVer_Click(object sender, EventArgs e)
        {
            Libro seleccionado = (Libro)lvwLibros.SelectedItems[0].Tag;
            LibroFrm frmLibro = new LibroFrm(seleccionado);
            if (frmLibro.ShowDialog() == DialogResult.OK)
            {
                CargarLibros();
            }
        }

        private void CargarLibros()
        {
            lvwLibros.Items.Clear();
            List<Libro> libros = Negocio.ObtenerLibros();
            foreach (Libro libro in libros)
            {
                string[] datos = { libro.Titulo, libro.Anno.ToString(), libro.Autor };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = libro;
                lvwLibros.Items.Add(item);
            }
        }
    }
}
