<<<<<<< HEAD
﻿using System;
using System.Collections;
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
    public partial class FichaSocio : Form
    {
        public FichaSocio()
        {
            InitializeComponent();
            this.cboSituacion.SelectedIndex = 0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOtras.Checked)
            {
                txtAficiones.Enabled = true;
            } else
            {
                txtAficiones.Clear();
                txtAficiones.Enabled = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            dtpFecha.Value = DateTime.Today;
            rbSexGroup1.Checked = true;
            chkDeportes.Checked = false;
            chkLectura.Checked = false;
            chkMusica.Checked = false;
            chkOtras.Checked = false;
            cboSituacion.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string name = txtNombre.Text;
            DateTime date = dtpFecha.Value;
            string sex = rbSexGroup1.Checked ? "Hombre" : rbSexGroup2.Checked ? "Mujer" : "Otros";
            string hobbie = String.Empty;
            string otherhobbies = String.Empty;
            string situation = cboSituacion.Text;

            if (chkDeportes.Checked) hobbie += "Deportes ";
            if (chkMusica.Checked) hobbie += "Musica ";
            if (chkLectura.Checked) hobbie += " Lectura";
            if (chkOtras.Checked) otherhobbies = txtAficiones.Text;

            Socio socio = new Socio();
            socio.Nombre = name;
            socio.Fecha = date;
            socio.Sexo = sex;
            socio.Aficion = hobbie.Trim();
            socio.OtrasAficiones = otherhobbies;
            socio.Situacion = situation;

            Resumen child = new Resumen(socio);
            child.Show();
        }
    }
}
=======
﻿using System;
using System.Collections;
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
    public partial class FichaSocio : Form
    {
        public FichaSocio()
        {
            InitializeComponent();
            this.cboSituacion.SelectedIndex = 0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOtras.Checked)
            {
                txtAficiones.Enabled = true;
            } else
            {
                txtAficiones.Clear();
                txtAficiones.Enabled = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            dtpFecha.Value = DateTime.Today;
            rbSexGroup1.Checked = true;
            chkDeportes.Checked = false;
            chkLectura.Checked = false;
            chkMusica.Checked = false;
            chkOtras.Checked = false;
            cboSituacion.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string name = txtNombre.Text;
            DateTime date = dtpFecha.Value;
            string sex = rbSexGroup1.Checked ? "Hombre" : rbSexGroup2.Checked ? "Mujer" : "Otros";
            string hobbie = String.Empty;
            string otherhobbies = String.Empty;
            string situation = cboSituacion.Text;

            if (chkDeportes.Checked) hobbie += "Deportes ";
            if (chkMusica.Checked) hobbie += "Musica ";
            if (chkLectura.Checked) hobbie += " Lectura";
            if (chkOtras.Checked) otherhobbies = txtAficiones.Text;

            Socio socio = new Socio();
            socio.Nombre = name;
            socio.Fecha = date;
            socio.Sexo = sex;
            socio.Aficion = hobbie.Trim();
            socio.OtrasAficiones = otherhobbies;
            socio.Situacion = situation;

            Resumen child = new Resumen(socio);
            child.Show();
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
