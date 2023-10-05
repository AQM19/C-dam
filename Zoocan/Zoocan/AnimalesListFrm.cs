using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoocan.Reports;

namespace Zoocan
{
    public partial class AnimalesListFrm : Form
    {

        private Negocio negocio;

        public AnimalesListFrm()
        {
            InitializeComponent();
            this.negocio = new Negocio();
            CargarLista();
        }

        private void AnimalesListFrm_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            lvwListaAnimales.Items.Clear();
            foreach (Animale animale in negocio.ObtenerAnimales())
            {

                string nombreRefugio = negocio.ObtenerRefugio(animale.RefugioId).Nombre;

                string[] datos =
                {
                    nombreRefugio,
                    animale.Nombre,
                    animale.Nacimiento.ToString(),
                    animale.Entrada.ToString(),
                    animale.Especie,
                    animale.Raza,
                    animale.Peso.ToString(),
                    animale.EspacioMin.ToString()+"m2" 
                };

                ListViewItem item = new ListViewItem(datos);
                item.Tag = animale.AnimalId;
                lvwListaAnimales.Items.Add(item);
            }
        }

        private void tsmiCrearAnimal_Click(object sender, EventArgs e)
        {
            CrearAnimal();
        }

        private void tsmiEditarAnimal_Click(object sender, EventArgs e)
        {
            EditarAnimal();
        }

        private void tsmiBorrarAnimal_Click(object sender, EventArgs e)
        {
            BorrarAnimal();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearAnimal();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarAnimal();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarAnimal();
        }

        private void CrearAnimal()
        {
            Animale animalnuevo = new Animale();
            AnimaleFrm frmAnimale = new AnimaleFrm(animalnuevo);

            if (frmAnimale.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearAnimale(animalnuevo);
                CargarLista();
            }
        }
        private void EditarAnimal()
        {
            if(lvwListaAnimales.SelectedItems.Count > 0)
            {
                int animaleId = Int32.Parse(lvwListaAnimales.SelectedItems[0].Tag.ToString());
                Animale animaleSeleccionado = negocio.ObtenerAnimale(animaleId);
                AnimaleFrm frmAnimale = new AnimaleFrm(animaleSeleccionado);

                if (frmAnimale.ShowDialog() == DialogResult.OK)
                {
                    negocio.ActualizarAnimale(animaleSeleccionado);
                    CargarLista();
                }
            }
        }
        private void BorrarAnimal()
        {
            if(lvwListaAnimales.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de borrar el animal seleccionado?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int animaleId = (int)lvwListaAnimales.SelectedItems[0].Tag;
                    negocio.BorrarAnimale(animaleId);
                    CargarLista();
                }
            }
        }

        private void informeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerInforme();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerInforme();
        }

        private void VerInforme()
        {
            int animaleId = (int)lvwListaAnimales.SelectedItems[0].Tag;
            Generador generador = new Generador();
            generador.CargarInformePorAnimalId(animaleId);
        }
    }
}
