using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardiApp
{
    public partial class frmListaGuardias : Form
    {
        /// <summary>
        /// Caches
        /// </summary>
        #region
        WebConsumer consumer;
        List<Guardia> guardias;
        string diaSemana = string.Empty;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        #region
        public frmListaGuardias()
        {
            InitializeComponent();
            this.consumer = new WebConsumer();
            CargarLista();
        }
        #endregion

        /// <summary>
        /// Cargar listado formateado
        /// </summary>
        #region
        private async void CargarLista()
        {
            lvGuardias.Items.Clear();

            this.guardias = await Herramientas.ObtenerGuardias();

            foreach (Guardia guardia in guardias)
            {
                string[] datos = {
                    guardia.prof_falta.ToString(),
                    guardia.prof_hace_guardia.ToString(),
                    ObtenerEstado(guardia.estado),
                    guardia.fecha.ToShortDateString(),
                    guardia.horario.ToString(),
                    ObtenerDiaSemana(guardia.dia_semana),

                    guardia.hora.ToString(),
                    guardia.grupo.ToString(),
                    guardia.aula.ToString()
                };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = guardia.id;
                if(guardia.estado.Equals("C"))
                {
                    item.BackColor = Color.Red;
                }
                if(guardia.estado.Equals("A"))
                {
                    item.BackColor = Color.LightGray;
                }
                lvGuardias.Items.Add(item);
            }
        }
        
        private string ObtenerEstado(string estado)
        {
            switch (estado)
            {
                case "R":
                    return "Realizada";
                case "C":
                    return "Confirmada";
                case "A":
                    return "Anulada";
                default:
                    return "null";
            }
        }

        private string ObtenerDiaSemana(int? dia)
        {
            switch (dia)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miercoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                default:
                    return string.Empty;
            }
        }
        #endregion

        /// <summary>
        /// CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        // Create
        private void tsmiNueva_Click(object sender, EventArgs e)
        {
            Guardia guardia = new Guardia();
            frmGuardiaProp nuevaGuardia = new frmGuardiaProp(guardia);
            if (nuevaGuardia.ShowDialog() == DialogResult.OK)
            {
                CargarLista();
            }
        }
        //Update
        private void tsmiEditar_Click(object sender, EventArgs e)
        {
            if(lvGuardias.SelectedItems.Count > 0)
            {
                int id = (int)lvGuardias.SelectedItems[0].Tag;
                Guardia guardia = this.guardias.FirstOrDefault(x => x.id == id);
                frmGuardiaProp nuevaGuardia = new frmGuardiaProp(guardia);
                if(nuevaGuardia.ShowDialog() == DialogResult.OK)
                {
                    Herramientas.ActualizarGuardia(guardia);
                    CargarLista();
                }
            }
        }
        //Delete
        private async void tsmiBorrar_Click(object sender, EventArgs e)
        {
            if(lvGuardias.SelectedItems.Count > 0)
            {
                int id = (int)lvGuardias.SelectedItems[0].Tag;
                await Herramientas.EliminarGuardia(id);
                CargarLista();
            }
        }
        #endregion

        /// <summary>
        /// Control del context menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void CmsGuardiasLv_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiEditar.Enabled = false;
            this.tsmiBorrar.Enabled = false;


            if (lvGuardias.SelectedItems.Count == 1)
            {
                this.tsmiEditar.Enabled = true;
                this.tsmiBorrar.Enabled = true;
            }

        }
        #endregion

        /// <summary>
        /// Filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // En proceso
        }
        #endregion
    }
}
