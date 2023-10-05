using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E9_SergioGonzalezVelez
{
    public partial class Contendor : Form
    {
        public Contendor()
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.Cascade);
            
        }

        private void msiCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void msiHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void msiVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void msiPelículas_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in this.MdiChildren)
            {
                if (typeof(ListaPeliculaFrm).IsInstanceOfType(f))
                {
                    abierto = true;
                    break;
                }
            }
            if (!abierto)
            {
                ListaPeliculaFrm hijo = new ListaPeliculaFrm();
                hijo.MdiParent = this;
                hijo.Show();
            }
        }

        private void msiLibros_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in this.MdiChildren)
            {
                if(typeof(ListaLibroFrm).IsInstanceOfType(f))
                {
                    abierto = true;
                    break;
                }
            }
            if(!abierto)
            {
                ListaLibroFrm hijo = new ListaLibroFrm();
                hijo.MdiParent = this;
                hijo.Show();
            }
        }

        private void msiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
