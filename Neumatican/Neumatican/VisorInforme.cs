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
    public partial class VisorInforme : Form
    {
        public VisorInforme()
        {
            InitializeComponent();
        }

        private void VisorInforme_Load(object sender, EventArgs e)
        {

            this.rpvVisorInforme.RefreshReport();
        }
    }
}
