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

namespace UT2E2
{
    public partial class Resumen : Form
    {
        private Resumen()
        {
            InitializeComponent();
        }

        public Resumen (Socio socio) : this()
        {
            lblNombre.Text = socio.Nombre;
            lblNacimiento.Text = socio.Fecha.ToShortDateString();
            lblSexo.Text = socio.Sexo;
            lblAficiones.Text = socio.Aficion;
            txtOtrasAficiones.Text = socio.OtrasAficiones;
            lblSituacion.Text = socio.Situacion;
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

namespace UT2E2
{
    public partial class Resumen : Form
    {
        private Resumen()
        {
            InitializeComponent();
        }

        public Resumen (Socio socio) : this()
        {
            lblNombre.Text = socio.Nombre;
            lblNacimiento.Text = socio.Fecha.ToShortDateString();
            lblSexo.Text = socio.Sexo;
            lblAficiones.Text = socio.Aficion;
            txtOtrasAficiones.Text = socio.OtrasAficiones;
            lblSituacion.Text = socio.Situacion;
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
