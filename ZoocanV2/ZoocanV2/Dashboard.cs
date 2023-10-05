using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoocanV2.Reports;

namespace ZoocanV2
{
    public partial class frmDashboard : Form
    {

        private const string DUMMY = "Dummy";
        private Herramientas herramientas = new Herramientas();

        /// <summary>
        /// Constructor
        /// </summary>
        #region
        public frmDashboard()
        {
            InitializeComponent();
            CargarLista();
        }
        #endregion

        /// <summary>
        /// Gestión del TreeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        //
        // Crea un objeto DUMMY para hacer que el nodo se pueda expandir
        //
        private void HacerDummy(TreeNode node)
        {
            TreeNode dummy = new TreeNode();
            dummy.Tag = DUMMY;
            node.Nodes.Add(dummy);
        }

        //
        // Carga la lista de refugios que hay en la base de datos y la inserta en el TreeView
        //
        private void CargarLista()
        {
            tvsVistaArbol.Nodes.Clear();
            // Itera toda la lista de refugios
            herramientas.ObtenerRefugios().ForEach(x =>
            {
                // Crea un nodo con el nombre del cuidador y con el Id del mismo como su Tag
                TreeNode child = new TreeNode(x.Nombre);
                child.Tag = x.RefugioId;
                child.Name = "Refugio";

                // Crea dos nodos distintos, uno de Animales y otro de Cuidadores
                TreeNode animales = new TreeNode("Animales");
                TreeNode Cuidadores = new TreeNode("Cuidadores");

                // Asigna el Tag del cuidador a dichos nodos
                animales.Tag = x.RefugioId;
                Cuidadores.Tag = x.RefugioId;

                // Crea el DUMMY en dichos nodos
                HacerDummy(animales);
                HacerDummy(Cuidadores);

                // Añade los nodos al nodo padre
                child.Nodes.Add(Cuidadores);
                child.Nodes.Add(animales);

                // Añade al TreeView el nodo padre
                tvsVistaArbol.Nodes.Add(child);
            });
        }

        //
        // Retorna un valor genérico "Sin datos" o el valor deseado pasado por parámetro
        //
        private string RetornarDato(string nombre)
        {
            return string.IsNullOrEmpty(nombre) ? "Sin datos" : nombre;
        }

        //
        // Aplica el evento BeforeExpand
        //
        private void tvsVistaArbol_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode treenode = e.Node;

            if (treenode.Nodes.Count == 1 && treenode.Nodes[0].Tag.Equals(DUMMY))
            {
                // Borrar los nodos del TreeView antes de cargarlos
                treenode.Nodes.Clear();

                //
                // Obtener los animales asignados al cuidador correspondiente y mostrar un listado
                // de los mismos en el TreeView
                //
                if (treenode.Text.Equals("Animales"))
                {
                    herramientas.ObtenerAnimalesPorRefugio((int)treenode.Tag).ForEach(x =>
                    {
                        TreeNode child = new TreeNode(RetornarDato(x.Nombre));
                        child.Tag = x.AnimalId;
                        child.Name = "Animal";
                        child.ImageIndex = 2;
                        treenode.Nodes.Add(child);
                    });
                }

                //
                // Obtener los Cuidadores asignados al cuidador correspondiente y mostrar un listado
                // de los mismos en el TreeView
                //
                if (treenode.Text.Equals("Cuidadores"))
                {
                    herramientas.ObtenerCuidadoresPorRefugio((int)treenode.Tag).ForEach(x =>
                    {
                        TreeNode child = new TreeNode(RetornarDato(x.Nombre));
                        child.Tag = x.CuidadorId;
                        child.Name = "Cuidador";
                        child.ImageIndex = 2;
                        treenode.Nodes.Add(child);
                    });
                }
            }
        }

        //
        // Aplica el evento AfterSelect
        //
        private void tvsVistaArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treenode = e.Node;

            if (treenode.Name.Equals("Refugio"))
            {
                treenode.SelectedImageIndex = 1;

                // Asigna a los label correspondientes la información del cuidador seleccionado
                Refugio refugio = herramientas.ObtenerRefugioPorId((int)treenode.Tag);
                lblRefugio.Text = RetornarDato(refugio.Nombre);
                lblDireccionRefugio.Text = RetornarDato(refugio.Direccion);
                lblMaxAnimalesRefugio.Text = RetornarDato(refugio.MaxAnimales.ToString());
                lblTelefonoRefugio.Text = RetornarDato(refugio.Telefono);
                lblEspecieRefugio.Text = refugio.Especie;

                // Instancia la lista de imágenes
                ImageList imgLi = imgListaIconos;

                // Insertar Tag en los listados
                lvwListaAnimales.Tag = refugio.RefugioId;
                lvwListaCuidadores.Tag = refugio.RefugioId;

                ActualizarAnimales((int)treenode.Tag);
                ActualizarCuidadores((int)treenode.Tag);
            }
        }

        //
        // Actualiza la lista de los animales.
        //
        private void ActualizarAnimales(int id)
        {
            lvwListaAnimales.Items.Clear();
            string[] itemAnimal = new string[3];

            herramientas.ObtenerAnimalesPorRefugio(id).ForEach(x =>
            {
                // Asigna los datos a los campos del array
                itemAnimal[0] = RetornarDato(x.Nombre);
                itemAnimal[1] = RetornarDato(x.Especie);
                itemAnimal[2] = RetornarDato(x.Raza);

                // Crea el ListViewItem y asigna los valores correspondientes
                ListViewItem listViewItem = new ListViewItem(itemAnimal);
                listViewItem.Tag = x.AnimalId;
                listViewItem.ImageIndex = 2;

                // Agrega el item a la lista
                lvwListaAnimales.Items.Add(listViewItem);
            });
        }
        //
        // Actualiza el ListView de los Cuidadores.
        //
        private void ActualizarCuidadores(int id)
        {
            lvwListaCuidadores.Items.Clear();
            string[] itemCuidador = new string[3];

            herramientas.ObtenerCuidadoresPorRefugio(id).ForEach(x =>
            {
                // Asigna los datos a los campos del array
                itemCuidador[0] = RetornarDato(x.Nombre);
                itemCuidador[1] = RetornarDato(x.Especie);
                itemCuidador[2] = (x.Responsable) ? "Responsable" : "No responsable";

                // Crea un ListViewItem y asigna los valores correspondientes
                ListViewItem listViewItem = new ListViewItem(itemCuidador);
                listViewItem.Tag = x.CuidadorId;
                listViewItem.ImageIndex = 2;

                // Agrega el item a la lista
                lvwListaCuidadores.Items.Add(listViewItem);
            });
        }
        #endregion

        /// <summary>
        /// Gatito
        /// </summary>
        #region
        /// Toma, un gatito y algo mas <3...
        /// 
        ///  /\_/\
        /// ( o.o )
        ///  >^<
        ///  El gatito ha resuelto la mayoría de problemas anteriores
        ///  Se han quitado los estáticos de Herramientas
        ///  Se ha mejorado la experiencia del TreeView con sus eventos
        ///  Se ha mejorado la visibilidad de las opciones del menú
        ///  
        /// Por tanto el gatito está contento y se ha traído a su amigo el patete
        /// 
        ///       __
        ///     <(o ) ___
        ///      ( ._> /
        ///       `---'
        /// El patete ayuda a depurar con su técnica de depuración del patito de goma
        /// https://es.wikipedia.org/wiki/M%C3%A9todo_de_depuraci%C3%B3n_del_patito_de_goma
        /// https://imgur.com/a/gsxAZO8
        #endregion

        /// <summary>
        /// Menu de selección del MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region

        //
        // Botón para crear un cuidador totalmente nuevo.
        //
        private void tsmiNuevoRefugio_Click(object sender, EventArgs e)
        {
            CrearRefugio();
        }

        //
        // Botón para crear un cuidador totalmente nuevo.
        //
        private void tsmiNuevoCuidador_Click(object sender, EventArgs e)
        {
            CrearCuidador();
        }

        //
        // Botón para crear un animal totalmente nuevo.
        //
        private void tsmiNuevoAnimal_Click(object sender, EventArgs e)
        {
            CrearAnimal();
        }

        //
        // Botón de editar aquello que esté seleccionado.
        //
        private void tsmiEditar_Click(object sender, EventArgs e)
        {
            if (tvsVistaArbol.Focused)
            {
                int id = (int)tvsVistaArbol.SelectedNode.Tag;
                if (tvsVistaArbol.SelectedNode.Name.Equals("Refugio"))
                {
                    EditarRefugio(id);
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Cuidador"))
                {
                    EditarCuidador(id);
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Animal"))
                {
                    EditarAnimal(id);
                }
            }
            if (lvwListaAnimales.Focused)
            {
                int id = (int)lvwListaAnimales.SelectedItems[0].Tag;
                EditarAnimal(id);
            }
            if (lvwListaCuidadores.Focused)
            {
                int id = (int)lvwListaCuidadores.SelectedItems[0].Tag;
                EditarCuidador(id);
            }
        }

        //
        // Botón para borrar aquello que esté seleccionado.
        //
        private void tsmiBorrar_Click(object sender, EventArgs e)
        {
            if (tvsVistaArbol.Focused)
            {
                int id = (int)tvsVistaArbol.SelectedNode.Tag;
                if (tvsVistaArbol.SelectedNode.Name.Equals("Refugio"))
                {
                    BorrarRefugio(id);
                    tvsVistaArbol.SelectedNode.Remove();
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Cuidador"))
                {
                    BorrarCuidador(id);
                    tvsVistaArbol.SelectedNode.Remove();
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Animal"))
                {
                    BorrarAnimal(id);
                    tvsVistaArbol.SelectedNode.Remove();
                }
            }
            if (lvwListaAnimales.Focused)
            {
                int id = (int)lvwListaAnimales.SelectedItems[0].Tag;
                BorrarAnimal(id);
            }
            if (lvwListaCuidadores.Focused)
            {
                int id = (int)lvwListaCuidadores.SelectedItems[0].Tag;
                BorrarCuidador(id);
            }
        }
        #endregion

        /// <summary>
        /// Menu de selección del ContextMenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void cmsiNuevo_Click(object sender, EventArgs e)
        {
            // Creacion de refugio
            if (tvsVistaArbol.Focused)
            {
                if (tvsVistaArbol.SelectedNode.Name.Equals("Cuidador"))
                {
                    CrearCuidador();
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Animal"))
                {
                    CrearAnimal();
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Refugio"))
                {
                    CrearRefugio();
                }
            }

            // Creacion de los animales
            if (lvwListaAnimales.Focused)
            {
                CrearAnimal((int)lvwListaAnimales.Tag);
            }

            // Creacion de Cuidadores
            if (lvwListaCuidadores.Focused)
            {
                CrearCuidador((int)lvwListaCuidadores.Tag);
            }
        }

        private void cmsiEditar_Click(object sender, EventArgs e)
        {
            if (tvsVistaArbol.Focused)
            {
                int id = (int)tvsVistaArbol.SelectedNode.Tag;
                if (tvsVistaArbol.SelectedNode.Name.Equals("Cuidador"))
                {
                    EditarCuidador(id);
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Animal"))
                {
                    EditarAnimal(id);
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Refugio"))
                {
                    EditarRefugio(id);
                }
            }
            if (lvwListaAnimales.Focused)
            {
                int id = (int)lvwListaAnimales.SelectedItems[0].Tag;
                EditarAnimal(id);
            }
            if (lvwListaCuidadores.Focused)
            {
                int id = (int)lvwListaCuidadores.SelectedItems[0].Tag;
                EditarCuidador(id);
            }
        }

        private void cmsiBorrar_Click(object sender, EventArgs e)
        {
            if (tvsVistaArbol.Focused)
            {
                int id = (int)tvsVistaArbol.SelectedNode.Tag;
                if (tvsVistaArbol.SelectedNode.Name.Equals("Cuidador"))
                {
                    BorrarCuidador(id);
                    tvsVistaArbol.SelectedNode.Remove();
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Animal"))
                {
                    BorrarAnimal(id);
                    tvsVistaArbol.SelectedNode.Remove();
                }
                if (tvsVistaArbol.SelectedNode.Name.Equals("Refugio"))
                {
                    BorrarRefugio(id);
                    tvsVistaArbol.SelectedNode.Remove();
                }
            }
            if (lvwListaAnimales.Focused)
            {
                int id = (int)lvwListaAnimales.SelectedItems[0].Tag;
                BorrarAnimal(id);
            }
            if (lvwListaCuidadores.Focused)
            {
                int id = (int)lvwListaCuidadores.SelectedItems[0].Tag;
                BorrarCuidador(id);
            }
        }
        #endregion

        /// <summary>
        /// Crear
        /// </summary>
        #region
        private void CrearRefugio()
        {
            Refugio refugio = new Refugio();
            frmRefugio frmRefugio = new frmRefugio(refugio);

            if (frmRefugio.ShowDialog() == DialogResult.OK)
            {
                herramientas.CrearRefugio(refugio);
                CargarLista();
            }
        }

        private void CrearAnimal()
        {
            Animal animal = new Animal();
            frmAnimal frmAnimal = new frmAnimal(animal);

            if (frmAnimal.ShowDialog() == DialogResult.OK)
            {
                herramientas.CrearAnimale(animal);
                ActualizarAnimales((int)lvwListaAnimales.Tag);
            }
        }
        private void CrearAnimal(int id)
        {
            Animal animal = new Animal();
            animal.RefugioId = id;
            frmAnimal frmAnimal = new frmAnimal(animal);

            if (frmAnimal.ShowDialog() == DialogResult.OK)
            {
                herramientas.CrearAnimale(animal);
                ActualizarAnimales((int)lvwListaAnimales.Tag);
            }
        }

        private void CrearCuidador()
        {
            Cuidador cuidador = new Cuidador();
            frmCuidador frmCuidador = new frmCuidador(cuidador);

            if (frmCuidador.ShowDialog() == DialogResult.OK)
            {
                herramientas.CrearCuidador(cuidador);
                ActualizarCuidadores((int)lvwListaCuidadores.Tag);
            }
        }
        private void CrearCuidador(int id)
        {
            Cuidador cuidador = new Cuidador();
            cuidador.RefugioId = id;
            frmCuidador frmCuidador = new frmCuidador(cuidador);

            if (frmCuidador.ShowDialog() == DialogResult.OK)
            {
                herramientas.CrearCuidador(cuidador);
                ActualizarCuidadores((int)lvwListaCuidadores.Tag);
            }
        }
        #endregion

        /// <summary>
        /// Editar
        /// </summary>
        #region
        private void EditarRefugio(int id)
        {
            if (id > 0)
            {
                Refugio refugio = herramientas.ObtenerRefugioPorId(id);
                frmRefugio frmRefugio = new frmRefugio(refugio);

                if (frmRefugio.ShowDialog() == DialogResult.OK)
                {
                    herramientas.ActualizarRefugio(refugio);
                    CargarLista();
                }
            }
        }

        private void EditarAnimal(int id)
        {
            if (id > 0)
            {
                Animal animal = herramientas.ObtenerAnimale(id);
                frmAnimal frmAnimal = new frmAnimal(animal);

                if (frmAnimal.ShowDialog() == DialogResult.OK)
                {
                    herramientas.ActualizarAnimale(animal);
                    ActualizarAnimales(animal.RefugioId);
                }
            }
        }

        private void EditarCuidador(int id)
        {
            if (id > 0)
            {
                Cuidador cuidador = herramientas.ObtenerCuidadorPorId(id);
                frmCuidador frmCuidador = new frmCuidador(cuidador);

                if (frmCuidador.ShowDialog() == DialogResult.OK)
                {
                    herramientas.ActualizarCuidador(cuidador);
                    ActualizarCuidadores(cuidador.RefugioId);
                }
            }
        }
        #endregion

        /// <summary>
        /// Borrar
        /// </summary>
        #region
        private void BorrarRefugio(int id)
        {
            if (id > 0)
            {
                bool puedeEliminar = true;

                if (herramientas.ObtenerNumeroCuidadores(id) > 0)
                {
                    puedeEliminar = false;
                    throw new ZoocanException("No puedes eliminar un refugio que tenga Cuidadores trabajando.");
                }
                if (herramientas.ObtenerNumeroAnimalesPorId(id) > 0)
                {
                    puedeEliminar = false;
                    throw new ZoocanException("No puedes eliminar un refugio que tenga animales dentro.");
                }
                if (puedeEliminar)
                {
                    if (MessageBox.Show("¿Estás seguro de querer eliminar este refugio?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        herramientas.BorrarRefugio(id);
                        CargarLista();
                    }
                }
            }
        }

        private void BorrarAnimal(int id)
        {
            if (id > 0)
            {
                if (MessageBox.Show("¿Estás seguro de querer eliminar este animal?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    herramientas.BorrarAnimale(id);
                    ActualizarAnimales((int)lvwListaAnimales.Tag);

                    if (herramientas.ObtenerAnimalesPorRefugio((int)lvwListaAnimales.Tag).Count() == 0)
                    {
                        MessageBox.Show("El refugio se ha quedado sin animales.");
                    }
                }
            }
        }

        private void BorrarCuidador(int id)
        {
            if (id > 0)
            {
                if (MessageBox.Show("¿Estás seguro de querer eliminar este animal?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    herramientas.BorrarCuidador(id);
                    ActualizarCuidadores((int)lvwListaCuidadores.Tag);

                    if (herramientas.ObtenerCuidadoresPorRefugio((int)lvwListaCuidadores.Tag).Count == 0)
                    {
                        MessageBox.Show("El refugio se ha quedado sin Cuidadores.");
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Sale de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //
        // Asigna por defecto como inhabilitados los ToolStripMenuItem salvo que haya
        // algo en alguna de las listas seleccionado
        //
        #region
        private void cmsContextMenu_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiEditar.Enabled = false;
            this.tsmiBorrar.Enabled = false;
            this.informeToolStripMenuItem.Enabled = false;
            this.informeGeneralToolStripMenuItem.Enabled = false;

            if (this.tvsVistaArbol.SelectedNode.Nodes.Count > 0 ||
                this.lvwListaAnimales.SelectedItems.Count > 0 ||
                this.lvwListaCuidadores.SelectedItems.Count > 0)
            {
                this.tsmiEditar.Enabled = true;
                this.tsmiBorrar.Enabled = true;
                this.informeToolStripMenuItem.Enabled = true;
                this.informeGeneralToolStripMenuItem.Enabled = true;
            }
        }
        #endregion

        /// <summary>
        /// Informes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tvsVistaArbol.SelectedNode.Nodes.Count > 0)
            {
                Generador g = new Generador();
                g.CargarInformeRefugio((int)this.tvsVistaArbol.SelectedNode.Tag);
            }
            if (this.lvwListaAnimales.SelectedItems.Count > 0)
            {
                Generador g = new Generador();
                g.CargarInformeAnimal((int)this.lvwListaAnimales.SelectedItems[0].Tag);
            }
        }

        private void informeGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tvsVistaArbol.SelectedNode.Nodes.Count > 0)
            {
                Generador g = new Generador();
                g.CargarInformeAnimalesRefugio((int)this.tvsVistaArbol.SelectedNode.Tag);
            }
        }
        #endregion
    }
}
