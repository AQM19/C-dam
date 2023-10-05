using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoocan
{
    public partial class Dashboard : Form
    {

        private Negocio negocio;
        public const string DUMMY = "Dummy";

        public Dashboard()
        {
            this.negocio = new Negocio();
            InitializeComponent();
        }

        private void refugiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EstaAbierto(typeof(RefugiosListFrm))) return;            

            RefugiosListFrm hijo = new RefugiosListFrm();
            hijo.MdiParent = this;
            hijo.Show();
        }

        private bool EstaAbierto(Type form)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (form.IsInstanceOfType(f)) return true;
            }
            return false;
        }

        private void cuidadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EstaAbierto(typeof(CuidadoreFrm))) return;
            
            CuidadoresListFrm hijo = new CuidadoresListFrm();
            hijo.MdiParent = this;
            hijo.Show();
        }

        private void animalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EstaAbierto(typeof(AnimaleFrm))) return;

            AnimalesListFrm hijo = new AnimalesListFrm();
            hijo.MdiParent = this;
            hijo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
