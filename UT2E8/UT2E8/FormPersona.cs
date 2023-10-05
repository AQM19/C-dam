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
    public partial class FormPersona : Form
    {
        private Persona persona;
        private Informe informe;
        private Clinica clinica = new Clinica();

        public FormPersona()
        {
            InitializeComponent();
            tabPersona.Enabled = false;
        }


        public FormPersona(Persona persona) : this()
        {
            this.persona = persona;
            //btnGuardarPersona.Enabled = false;

            txtNombrePersona.Text = this.persona.Nombre;
            txtTelefonoPersona.Text = this.persona.Telefono;
            tabPersona.Enabled = true;

            CargarListadoCitasPersona(persona);
            PreargarInformePersona();
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            if (!txtNombrePersona.Text.Equals(string.Empty) && !txtTelefonoPersona.Text.Equals(string.Empty))
            {
                if (persona == null)
                {
                    persona = new Persona(txtNombrePersona.Text, txtTelefonoPersona.Text);
                    clinica.CrearPersona(persona);
                }
                if (persona != null)
                {
                    GuardarDatos();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCrearCitaPersona_Click(object sender, EventArgs e)
        {
            Cita citapersona = new Cita(DateTime.Now, persona.Personaid);
            clinica.CrearCita(citapersona);
            lvwListaCitas.Items.Add(citapersona.Fecha.ToString());
        }

        private void CargarListadoCitasPersona(Persona p)
        {
            lvwListaCitas.Items.Clear();
            for(int i = 0; i < clinica.BuscarCitas(p.Personaid).Length; i++)
            {
                ListViewItem item = new ListViewItem(clinica.BuscarCitas(p.Personaid)[i].Fecha.ToString());
                item.Tag = clinica.BuscarCitas(p.Personaid)[i].Citaid;
                lvwListaCitas.Items.Add(item);
            }
        }

        private void tabPersona_Selected(object sender, TabControlEventArgs e)
        {
            Informe informepersona = clinica.BuscarInforme(persona.Personaid);
        }

        private void btnSalirPersona_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreargarInformePersona()
        {
            Informe info = clinica.BuscarInforme((int)persona.Personaid);

            if(info.Nacimiento != null)
            {
                dtpFechaPersona.Value = DateTime.Today;
            } else
            {
                dtpFechaPersona.Value = info.Nacimiento;
            }
            txtAlergiasPersona.Text = info.Alergias;
            txtObservacionesPersona.Text = info.Observaciones;
        }

        private void GuardarDatos()
        {
            Informe info = clinica.BuscarInforme((int)persona.Personaid);
            info.Nacimiento = dtpFechaPersona.Value;
            info.Alergias = txtAlergiasPersona.Text;
            info.Observaciones = txtObservacionesPersona.Text;

            Persona p = clinica.BuscarPersona((int)persona.Personaid);
            p.Nombre = txtNombrePersona.Text;
            p.Telefono = txtTelefonoPersona.Text;
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
    public partial class FormPersona : Form
    {
        private Persona persona;
        private Informe informe;
        private Clinica clinica = new Clinica();

        public FormPersona()
        {
            InitializeComponent();
            tabPersona.Enabled = false;
        }


        public FormPersona(Persona persona) : this()
        {
            this.persona = persona;

            txtNombrePersona.Text = this.persona.Nombre;
            txtTelefonoPersona.Text = this.persona.Telefono;
            tabPersona.Enabled = true;

            CargarListadoCitasPersona(persona);
            PreargarInformePersona();
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            if(!txtNombrePersona.Text.Equals(string.Empty) && !txtTelefonoPersona.Text.Equals(string.Empty))
            {
                persona = new Persona(txtNombrePersona.Text, txtTelefonoPersona.Text);
                clinica.CrearPersona(persona);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("Rellena todos los campos para continuar.");
            }
        }

        private void btnCrearCitaPersona_Click(object sender, EventArgs e)
        {
            Cita citapersona = new Cita(DateTime.Now, persona.Personaid);
            clinica.CrearCita(citapersona);
            lvwListaCitas.Items.Add(citapersona.Fecha.ToString());
        }

        private void CargarListadoCitasPersona(Persona p)
        {
            lvwListaCitas.Items.Clear();
            for(int i = 0; i < clinica.BuscarCitas(p.Personaid).Length; i++)
            {
                ListViewItem item = new ListViewItem(clinica.BuscarCitas(p.Personaid)[i].Fecha.ToString());
                item.Tag = clinica.BuscarCitas(p.Personaid)[i].Citaid;
                lvwListaCitas.Items.Add(item);
            }
        }

        private void tabPersona_Selected(object sender, TabControlEventArgs e)
        {
            Informe informepersona = clinica.BuscarInforme(persona.Personaid);

            
        }

        private void btnSalirPersona_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            GuardarDatos();
            this.Close();
        }

        private void PreargarInformePersona()
        {
            Informe info = clinica.BuscarInforme((int)persona.Personaid);

            if(info.Nacimiento != null)
            {
                dtpFechaPersona.Value = DateTime.Today;
            } else
            {
                dtpFechaPersona.Value = info.Nacimiento;
            }
            txtAlergiasPersona.Text = info.Alergias;
            txtObservacionesPersona.Text = info.Observaciones;
        }

        private void GuardarDatos()
        {
            Informe info = clinica.BuscarInforme((int)persona.Personaid);
            info.Nacimiento = dtpFechaPersona.Value;
            info.Alergias = txtAlergiasPersona.Text;
            info.Observaciones = txtObservacionesPersona.Text;
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
