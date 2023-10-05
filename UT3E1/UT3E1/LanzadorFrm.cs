using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UT3E1.Reports;

namespace UT3E1
{
    public partial class LanzadorFrm : Form
    {
        public LanzadorFrm()
        {
            InitializeComponent();
        }

        private void btnInforme0_Click(object sender, EventArgs e)
        {
            Generador g = new Generador();
            g.CargarInformeFabricantes();
        }

        private void btnInforme1_Click(object sender, EventArgs e)
        {
            Generador g = new Generador();
            g.CargarInformeFacturas();
        }

        private void btnInforme2_Click(object sender, EventArgs e)
        {

        }

        private void btnInforme3_Click(object sender, EventArgs e)
        {

        }
    }
}
