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

namespace UT2E6
{
    public partial class Form1 : Form
    {
        static bool ordered = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertarElemento();
            //txtNuevoElemento.Focus();
        }

        private void InsertarElemento()
        {
            if (!txtNuevoElemento.Text.Equals(string.Empty))
            {
                int num;

                if (int.TryParse(txtNuevoElemento.Text, out num))
                {
                    lvwDatos.Items.Add(txtNuevoElemento.Text);
                    txtNuevoElemento.Text = string.Empty;

                    ActualizarCampos();
                }
            }
        }

        private void ActualizarCampos()
        {
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            float media = 0;

            for (int i = 0; i < lvwDatos.Items.Count; i++)
            {
                int n = Convert.ToInt32(lvwDatos.Items[i].Text);

                sum += n;
                if (n > max) max = n;
                if (n < min) min = n;

            }

            if (lvwDatos.Items.Count != 0)
            {
                media = sum / lvwDatos.Items.Count;
            }

            txtSumatorio.Text = sum.ToString();
            txtMedia.Text = media.ToString();
            txtMaximo.Text = max.ToString();
            txtMinimo.Text = min.ToString();
            txtNumeroElementos.Text = lvwDatos.Items.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lvwDatos.SelectedItems.Count > 0)
            {
                lvwDatos.SelectedItems[0].Remove();
            }
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            foreach(ListViewItem item in lvwDatos.Items)
            {
                list.Add(Convert.ToInt32(item.Text));
            }

            list.Sort();

            if (ordered)
            {
                ordered = false;
            } else
            {
                list.Reverse();
                ordered = true;
            }
            
            lvwDatos.Items.Clear();

            foreach (int i in list)
            {
                lvwDatos.Items.Add(new ListViewItem(i.ToString()));
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

namespace UT2E6
{
    public partial class Form1 : Form
    {
        static bool ordered = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertarElemento();
            //txtNuevoElemento.Focus();
        }

        private void InsertarElemento()
        {
            if (!txtNuevoElemento.Text.Equals(string.Empty))
            {
                int num;

                if (int.TryParse(txtNuevoElemento.Text, out num))
                {
                    lvwDatos.Items.Add(txtNuevoElemento.Text);
                    txtNuevoElemento.Text = string.Empty;

                    ActualizarCampos();
                }
            }
        }

        private void ActualizarCampos()
        {
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            float media = 0;

            for (int i = 0; i < lvwDatos.Items.Count; i++)
            {
                int n = Convert.ToInt32(lvwDatos.Items[i].Text);

                sum += n;
                if (n > max) max = n;
                if (n < min) min = n;

            }

            if (lvwDatos.Items.Count != 0)
            {
                media = sum / lvwDatos.Items.Count;
            }

            txtSumatorio.Text = sum.ToString();
            txtMedia.Text = media.ToString();
            txtMaximo.Text = max.ToString();
            txtMinimo.Text = min.ToString();
            txtNumeroElementos.Text = lvwDatos.Items.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lvwDatos.SelectedItems.Count > 0)
            {
                lvwDatos.SelectedItems[0].Remove();
            }
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            foreach(ListViewItem item in lvwDatos.Items)
            {
                list.Add(Convert.ToInt32(item.Text));
            }

            list.Sort();

            if (ordered)
            {
                ordered = false;
            } else
            {
                list.Reverse();
                ordered = true;
            }
            
            lvwDatos.Items.Clear();

            foreach (int i in list)
            {
                lvwDatos.Items.Add(new ListViewItem(i.ToString()));
            }

        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
