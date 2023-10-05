using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoocan
{
    public partial class RefugiosListFrm : Form
    {

        private Negocio negocio;
        public RefugiosListFrm()
        {
            InitializeComponent();
            this.negocio = new Negocio();
            CargarLista();
        }

        private void CargarLista()
        {
            lvwListRefugios.Items.Clear();
            foreach (Refugio refugio in negocio.ObtenerRefugios())
            {
                string[] datos =
                {
                    refugio.Nombre,
                    refugio.Direccion,
                    refugio.Especie,
                    refugio.Telefono,
                    refugio.MaxAnimales.ToString()
                };

                ListViewItem item = new ListViewItem(datos);
                item.Tag = refugio.RefugioId;
                lvwListRefugios.Items.Add(item);
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearRefugio();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearRefugio();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarRefugio();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarRefugio();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarRefugio();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarRefugio();
        }

        private void CrearRefugio()
        {
            Refugio refugionuevo = new Refugio();
            RefugioFrm frmRefugio = new RefugioFrm(refugionuevo);

            if (frmRefugio.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearRefugio(refugionuevo);
                CargarLista();
            }
        }

        private void EditarRefugio()
        {
            if (lvwListRefugios.SelectedItems.Count > 0)
            {
                int refugioId = (int)lvwListRefugios.SelectedItems[0].Tag;
                Refugio refugioSeleccionado = negocio.ObtenerRefugio(refugioId);
                RefugioFrm frmRefugio = new RefugioFrm(refugioSeleccionado);

                if (frmRefugio.ShowDialog() == DialogResult.OK)
                {
                    negocio.ActualizarRefugio(refugioSeleccionado);
                    CargarLista();
                }
            }
        }

        private void BorrarRefugio()
        {
            if(lvwListRefugios.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de borrar el refugio seleccionado?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int refugioId = (int)lvwListRefugios.SelectedItems[0].Tag;
                    negocio.BorrarRefugio(refugioId);
                    CargarLista();
                }
            }
        }
    }
}
