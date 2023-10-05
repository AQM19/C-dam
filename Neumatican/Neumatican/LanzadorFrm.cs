using Neumatican.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neumatican
{
    public partial class LanzadorFrm : Form
    {
        public LanzadorFrm()
        {
            InitializeComponent();
        }

        private void btnInforme1_Click(object sender, EventArgs e)
        {
            Generador g = new Generador();
            g.CargarInformeFabricantes();
        }
    }
}
