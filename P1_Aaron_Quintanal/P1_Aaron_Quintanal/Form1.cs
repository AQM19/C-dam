using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Aaron_Quintanal
{
    public partial class frmListadoFaltas : Form
    {

        private Cliente cliente;

        public frmListadoFaltas()
        {
            this.cliente = new Cliente();
            InitializeComponent();
        }

        private void tsmiProfesores_Click(object sender, EventArgs e)
        {
            ListProfesores listadoProfesores = new ListProfesores();
            listadoProfesores.ShowDialog();
        }

        private void CargarLista()
        {
            lvwListaProfesores.Items.Clear();

            foreach (Falta falta in cliente.ObtenerFaltas())
            {


                string[] datos =
                {
                    falta.Dia.ToShortDateString(),
                    falta.Hora.ToString(),
                    falta.Grupo,
                    falta.ProfeSusti.HasValue?Herramientas.ObtenerProfesorNombrePorID(falta.ProfeSusti.Value):"FALTA"
                };

                ListViewItem item = new ListViewItem(datos);
                item.Tag = falta.FaltaId;
                lvwListaProfesores.Items.Add(item);
            }
        }

        private void tsmiVer_Click(object sender, EventArgs e)
        {
            Falta faltaEditable = cliente.ObtenerFalta((int)this.lvwListaProfesores.SelectedItems[0].Tag);
            Faltafrm faltaFrm = new Faltafrm(faltaEditable);

            if (faltaFrm.ShowDialog() == DialogResult.OK)
            {
                cliente.ActualizarFalta(faltaEditable);
                CargarLista();
            }
        }

        private void tsmiNuevo_Click(object sender, EventArgs e)
        {
            crearNuevo();
        }

        private void tsmiEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de querer eliminar esta falta?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cliente.EliminarFalta((int)lvwListaProfesores.SelectedItems[0].Tag);
                CargarLista();
            }
        }

        private void frmListadoFaltas_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void tsmiArchivoNuevo_Click(object sender, EventArgs e)
        {
            crearNuevo();
        }

        private void crearNuevo()
        {
            Falta nuevaFalta = new Falta();
            Faltafrm faltaFrm = new Faltafrm(nuevaFalta);

            if (faltaFrm.ShowDialog() == DialogResult.OK)
            {
                cliente.CrearFalta(nuevaFalta);
                CargarLista();
            }
        }

        private void tsmiArchivoSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmsMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiVer.Enabled = false;
            this.tsmiEliminar.Enabled = false;

            if (this.lvwListaProfesores.SelectedItems.Count == 1)
            {
                this.tsmiVer.Enabled = true;
                this.tsmiEliminar.Enabled = true;
            }
        }
    }
}

