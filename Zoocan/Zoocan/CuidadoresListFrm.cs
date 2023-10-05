using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoocan
{
    public partial class CuidadoresListFrm : Form
    {

        private Negocio negocio;

        public CuidadoresListFrm()
        {
            InitializeComponent();

            this.negocio = new Negocio();
            CargarLista();
        }

        private void CargarLista()
        {
            lvwListaCuidadores.Items.Clear();
            
            foreach(Cuidadore cuidador in negocio.ObtenerCuidadores())
            {
                string[] datos =
                {
                    cuidador.Nombre,
                    cuidador.Telefono,
                    cuidador.Direccion,
                    cuidador.SalarioAnual.ToString(),
                    cuidador.Especie,
                    cuidador.Responsable.ToString()
                };

                ListViewItem item = new ListViewItem(datos);
                item.Tag = cuidador.CuidadorId;
                lvwListaCuidadores.Items.Add(item);
            }

        }
        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearCuidadore();
        }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCuidadore();
        }
        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarCuidadore();
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCuidadore();
        }
        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarCuidadore();
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarCuidadore();
        }
        private void CrearCuidadore()
        {
            Cuidadore cuidadorenuevo = new Cuidadore();
            CuidadoreFrm frmCuidadore = new CuidadoreFrm(cuidadorenuevo);

            if(frmCuidadore.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearCuidadore(cuidadorenuevo);
                CargarLista();
            }
        }

        private void EditarCuidadore()
        {
            if(lvwListaCuidadores.SelectedItems.Count > 0)
            {
                int cuidadoreId = Int32.Parse(lvwListaCuidadores.SelectedItems[0].Tag.ToString());
                Cuidadore cuidadoreSeleccionado = negocio.ObtenerCuidadorePorId(cuidadoreId);
                CuidadoreFrm frmCuidadore = new CuidadoreFrm(cuidadoreSeleccionado);

                if( frmCuidadore.ShowDialog() == DialogResult.OK )
                {
                    negocio.ActualizarCuidadore(cuidadoreSeleccionado);
                    CargarLista();
                }
            }
        }

        private void BorrarCuidadore()
        {
            if (lvwListaCuidadores.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de borrar el cuidador seleccionado?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int cuidadoreId = Int32.Parse(lvwListaCuidadores.SelectedItems[0].Tag.ToString());
                    Cuidadore cuidadoreSeleccionado = negocio.ObtenerCuidadorePorId(cuidadoreId);
                    negocio.BorrarCuidadore(cuidadoreId);
                    CargarLista();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
