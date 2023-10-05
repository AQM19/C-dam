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

namespace UT2E4
{
    public partial class Form1 : Form
    {

        private MessageBoxButtons buttons = MessageBoxButtons.OK;
        private MessageBoxIcon icons = MessageBoxIcon.None;
        private string text = "Mensaje por defecto";
        private string title = "Titulo por defecto";

        public Form1()
        {
            InitializeComponent();

            // RadioButton Tags Buttons group
            rdoBoton1.Tag = MessageBoxButtons.OK;
            rdoBoton2.Tag = MessageBoxButtons.OKCancel;
            rdoBoton3.Tag = MessageBoxButtons.AbortRetryIgnore;
            rdoBoton4.Tag = MessageBoxButtons.YesNoCancel;
            rdoBoton5.Tag = MessageBoxButtons.YesNo;
            rdoBoton6.Tag = MessageBoxButtons.RetryCancel;

            // RadioButton Tags Icons group
            rdoIcon1.Tag = MessageBoxIcon.Asterisk;
            rdoIcon2.Tag = MessageBoxIcon.Error;
            rdoIcon3.Tag = MessageBoxIcon.Exclamation;
            rdoIcon4.Tag = MessageBoxIcon.Hand;
            rdoIcon5.Tag = MessageBoxIcon.Information;
            rdoIcon6.Tag = MessageBoxIcon.Question;
            rdoIcon7.Tag = MessageBoxIcon.Stop;
            rdoIcon8.Tag = MessageBoxIcon.Warning;
        }

        private void CambioRadioGrupoBoton(object sender, EventArgs e)
        {
            buttons = (MessageBoxButtons)((RadioButton)sender).Tag;
        }

        private void CambioRadioGrupoIcono(object sender, EventArgs e)
        {
            icons = (MessageBoxIcon)((RadioButton)sender).Tag;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!txtTitulo.Text.Equals(string.Empty)) text = txtTitulo.Text;
            if (!txtMensaje.Text.Equals(string.Empty)) title = txtMensaje.Text;

            MessageBox.Show(title, text, buttons, icons);
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

namespace UT2E4
{
    public partial class Form1 : Form
    {

        private MessageBoxButtons buttons = MessageBoxButtons.OK;
        private MessageBoxIcon icons = MessageBoxIcon.None;
        private string text = "Mensaje por defecto";
        private string title = "Titulo por defecto";

        public Form1()
        {
            InitializeComponent();

            // RadioButton Tags Buttons group
            rdoBoton1.Tag = MessageBoxButtons.OK;
            rdoBoton2.Tag = MessageBoxButtons.OKCancel;
            rdoBoton3.Tag = MessageBoxButtons.AbortRetryIgnore;
            rdoBoton4.Tag = MessageBoxButtons.YesNoCancel;
            rdoBoton5.Tag = MessageBoxButtons.YesNo;
            rdoBoton6.Tag = MessageBoxButtons.RetryCancel;

            // RadioButton Tags Icons group
            rdoIcon1.Tag = MessageBoxIcon.Asterisk;
            rdoIcon2.Tag = MessageBoxIcon.Error;
            rdoIcon3.Tag = MessageBoxIcon.Exclamation;
            rdoIcon4.Tag = MessageBoxIcon.Hand;
            rdoIcon5.Tag = MessageBoxIcon.Information;
            rdoIcon6.Tag = MessageBoxIcon.Question;
            rdoIcon7.Tag = MessageBoxIcon.Stop;
            rdoIcon8.Tag = MessageBoxIcon.Warning;
        }

        private void CambioRadioGrupoBoton(object sender, EventArgs e)
        {
            buttons = (MessageBoxButtons)((RadioButton)sender).Tag;
        }

        private void CambioRadioGrupoIcono(object sender, EventArgs e)
        {
            icons = (MessageBoxIcon)((RadioButton)sender).Tag;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!txtTitulo.Text.Equals(string.Empty)) text = txtTitulo.Text;
            if (!txtMensaje.Text.Equals(string.Empty)) title = txtMensaje.Text;

            MessageBox.Show(title, text, buttons, icons);
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
