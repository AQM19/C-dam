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
    public partial class ListProfesores : Form
    {

        private Cliente cliente;

        public ListProfesores()
        {
            InitializeComponent();
            this.cliente = new Cliente();
            CargarLista();
        }

        private void ListProfesorescs_Load(object sender, EventArgs e)
        {
            //CargarLista();
        }

        private void CargarLista()
        {
            lvwListadoProfesores.Items.Clear();

            foreach(Profesore profe in cliente.ObtenerProfesores())
            {
                string[] datos =
                {
                    profe.Codigo,
                    profe.Nombre,
                    profe.Telefono
                };

                ListViewItem item = new ListViewItem(datos);
                item.Tag = profe.ProfesorId;
                lvwListadoProfesores.Items.Add(item);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesore nuevoProfesor = new Profesore();
            Profesorfrm profesorfrm = new Profesorfrm(nuevoProfesor);

            if(profesorfrm.ShowDialog() == DialogResult.OK)
            {
                cliente.CrearProfesor(nuevoProfesor);
                CargarLista();
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int profeId = int.Parse(lvwListadoProfesores.SelectedItems[0].Tag.ToString());
            Profesore profeEditable = cliente.ObtenerProfesor(profeId);
            Profesorfrm profesorfrm = new Profesorfrm(profeEditable);

            if(profesorfrm.ShowDialog() == DialogResult.OK)
            {
                cliente.ActualizarProfesor(profeEditable);
                CargarLista();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de querer eliminar este profesor?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cliente.EliminarProfesor((int)this.lvwListadoProfesores.SelectedItems[0].Tag);
                CargarLista();
            }
        }

        private void lvwListadoProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsmiVerProfe.Enabled = true;
            tsmiEliminarProfe.Enabled = true;
        }

        private void cmsMenuProfesores_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiVerProfe.Enabled = false;
            this.tsmiEliminarProfe.Enabled = false;

            if(this.lvwListadoProfesores.SelectedItems.Count == 1)
            {
                this.tsmiVerProfe.Enabled = true;
                this.tsmiEliminarProfe.Enabled = true;
            }
        }
    }
}
