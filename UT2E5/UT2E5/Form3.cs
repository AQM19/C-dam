<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E5
{
    public partial class FormularioBuscar : Form
    {

        public string look { get; set; } 

        public FormularioBuscar(string param)
        {
            InitializeComponent();
            this.look = param;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals(string.Empty))
            {
                look = txtBuscar.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E5
{
    public partial class FormularioBuscar : Form
    {

        public string look { get; set; } 

        public FormularioBuscar(string param)
        {
            InitializeComponent();
            this.look = param;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals(string.Empty))
            {
                look = txtBuscar.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
