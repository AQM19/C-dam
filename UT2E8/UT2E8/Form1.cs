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

namespace UT2E8
{
    public partial class Form1 : Form
    {

        private static Clinica clinica;

        public Form1()
        {
            InitializeComponent();
            lvwListaNombres.ContextMenuStrip = cmsPersonas;
            clinica = new Clinica();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersona formPersona = new FormPersona();
            if(formPersona.ShowDialog() == DialogResult.OK)
            {
                CargarListadoDePersonas();
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvwListaNombres.SelectedItems.Count != 0)
            {
                Persona p = clinica.BuscarPersona((int)lvwListaNombres.SelectedItems[0].Tag);
                FormPersona formPersona = new FormPersona(p);
                if (formPersona.ShowDialog() == DialogResult.OK)
                {
                    CargarListadoDePersonas();
                }
            }
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvwListaNombres.SelectedItems.Count != 0)
            {
                clinica.BorrarPersona((int)lvwListaNombres.SelectedItems[0].Tag);
                CargarListadoDePersonas();
            }
        }

        private void CargarListadoDePersonas()
        {
            lvwListaNombres.Items.Clear();
            for (int i = 0; i < clinica.ObtenerPersonas().Length; i++)
            {
                ListViewItem item = new ListViewItem(clinica.ObtenerPersonas()[i].Nombre);
                item.Tag = clinica.ObtenerPersonas()[i].Personaid;
                lvwListaNombres.Items.Add(item);
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

namespace UT2E8
{
    public partial class Form1 : Form
    {

        private static Clinica clinica;

        public Form1()
        {
            InitializeComponent();
            lvwListaNombres.ContextMenuStrip = cmsPersonas;
            clinica = new Clinica();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersona formPersona = new FormPersona();
            if(formPersona.ShowDialog() == DialogResult.OK)
            {
                CargarListadoDePersonas();
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona p = clinica.BuscarPersona((int)lvwListaNombres.SelectedItems[0].Tag);
            FormPersona formPersona = new FormPersona(p);
            if(formPersona.ShowDialog() == DialogResult.OK)
            {
                CargarListadoDePersonas();
            }

        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clinica.BorrarPersona((int)lvwListaNombres.SelectedItems[0].Tag);
            CargarListadoDePersonas();
        }

        private void CargarListadoDePersonas()
        {
            lvwListaNombres.Items.Clear();
            for (int i = 0; i < clinica.ObtenerPersonas().Length; i++)
            {
                ListViewItem item = new ListViewItem(clinica.ObtenerPersonas()[i].Nombre);
                item.Tag = clinica.ObtenerPersonas()[i].Personaid;
                lvwListaNombres.Items.Add(item);
            }
        }

    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
