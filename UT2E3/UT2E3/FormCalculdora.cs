using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E3
{
    public partial class FormCalculdora : Form
    {
        private Calculadora _calculadora = new Calculadora();
        private bool clean = false;
        public FormCalculdora()
        {
            InitializeComponent();

            // set tags
            btnPlus.Tag             = OperacionEnum.Suma;
            btnMinus.Tag            = OperacionEnum.Resta;
            btnMultiplication.Tag   = OperacionEnum.Multiplicacion;
            btnDivision.Tag         = OperacionEnum.Division;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (clean)
            {
                this.txtVisor.Text = String.Empty;
                clean = false;
            }

            this.txtVisor.Text += ((Button)sender).Tag;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(!this.txtVisor.Text.Contains(","))
            {
                this.txtVisor.Text += ",";
            }
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            _calculadora.Visor      = float.Parse(this.txtVisor.Text);
            _calculadora.Operacion  = (OperacionEnum)((Button)sender).Tag;
            this.txtVisor.Text      = _calculadora.Visor.ToString();
            clean = true;
        }

        private void btnEquality_Click(object sender, EventArgs e)
        {
            calcularResultado();
        }

        private void calcularResultado()
        {
            _calculadora.Visor = float.Parse(this.txtVisor.Text);
            _calculadora.Calcular();
            this.txtVisor.Text = _calculadora.Visor.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtVisor.Text = "0";
            _calculadora.Borrar();
            clean = true;
        }

        private void btnMemmorySave_Click(object sender, EventArgs e)
        {
            _calculadora.Memoria = float.Parse(this.txtVisor.Text);
        }

        private void btnMemmoryRecoil_Click(object sender, EventArgs e)
        {
            this.txtVisor.Text = _calculadora.Memoria.ToString();
        }

        private void AnyKeyPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                calcularResultado();
            }
        }
    }
}
