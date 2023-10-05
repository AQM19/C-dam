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

namespace UT2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("+");
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("-");
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("*");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("/");
            }
        }

        private bool ValidarEntrada()
        {
            int aux;

            if (!int.TryParse(txtOperando1.Text, out aux))
            {
                MessageBox.Show("Operador 1 es erróneo.");
                txtOperando1.Focus();
                return false;
            }
            if (!int.TryParse(txtOperando2.Text, out aux))
            {
                MessageBox.Show("Operador 2 es erróneo.");
                txtOperando2.Focus();
                return false;
            }

            return true;
        }

        private string ObtenerResultado(string operando)
        {
            int x = Convert.ToInt32(txtOperando1.Text);
            int y = Convert.ToInt32(txtOperando2.Text);

            switch (operando)
            {
                case "+":
                    return Convert.ToString(x + y);
                case "-":
                    return Convert.ToString(x - y);
                case "*":
                    return Convert.ToString(x * y);
                case "/":
                    return Convert.ToString(x / y);
            }

            return "Syntax Error";
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

namespace UT2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("+");
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("-");
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("*");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                txtResultado.Text = ObtenerResultado("/");
            }
        }

        private bool ValidarEntrada()
        {
            int aux;

            if (!int.TryParse(txtOperando1.Text, out aux))
            {
                MessageBox.Show("Operador 1 es erróneo.");
                txtOperando1.Focus();
                return false;
            }
            if (!int.TryParse(txtOperando2.Text, out aux))
            {
                MessageBox.Show("Operador 2 es erróneo.");
                txtOperando2.Focus();
                return false;
            }

            return true;
        }

        private string ObtenerResultado(string operando)
        {
            int x = Convert.ToInt32(txtOperando1.Text);
            int y = Convert.ToInt32(txtOperando2.Text);

            switch (operando)
            {
                case "+":
                    return Convert.ToString(x + y);
                case "-":
                    return Convert.ToString(x - y);
                case "*":
                    return Convert.ToString(x * y);
                case "/":
                    return Convert.ToString(x / y);
            }

            return "Syntax Error";
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
