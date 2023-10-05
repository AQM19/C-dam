using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E7
{
    public partial class Form1 : Form
    {

        public const string DUMMY = "Dummy";
        private ListViewComparer lvwColumnSorter;

        public Form1()
        {
            InitializeComponent();

            // Usar el Tag del Nodo para poder acceder a la ruta
            DirectoryInfo directorio = new DirectoryInfo(@"C:\");


            TreeNode raiz = new TreeNode(directorio.Name);
            raiz.Tag = directorio;

            HacerDummy(raiz);
            tvwArbol.Nodes.Add(raiz);

            lvwColumnSorter = new ListViewComparer();
            this.lvwListado.ListViewItemSorter = lvwColumnSorter;
        }

        private void HacerDummy(TreeNode node)
        {
            TreeNode dummy = new TreeNode();
            dummy.Tag = DUMMY;
            node.Nodes.Add(dummy);
        }

        private void tvwArbol_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode tn = e.Node;

            if (tn.Nodes.Count == 1 && tn.Nodes[0].Tag.Equals(DUMMY))
            {
                // Borrar los nodos del TreeView antes de cargarlos
                tn.Nodes.Clear();

                // Obtener los directorios y los ficheros
                DirectoryInfo[] directorios = ((DirectoryInfo)tn.Tag).GetDirectories();

                // Con cada directorio crear un nodo hijo
                // agregarle el nombre, añadir su path a la Tag
                // crear un Dummy para obtener su +
                // y añadirlo a los nodos del arbol
                foreach (DirectoryInfo d in directorios)
                {
                    TreeNode child = new TreeNode(d.Name);
                    child.Tag = d;
                    //child.ImageIndex = 1;
                    HacerDummy(child);

                    tn.Nodes.Add(child);
                }
            }
        }

        private void tvwArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = e.Node;
            tn.SelectedImageIndex = 1;

            // Limpiar lista
            lvwListado.Items.Clear();

            try
            {
                DirectoryInfo[] directorios = ((DirectoryInfo)tn.Tag).GetDirectories();
                FileInfo[] ficheros = ((DirectoryInfo)tn.Tag).GetFiles();
                ImageList imglist = imgListaIconos;
                string[] item = new string[3];

                for(int i = 0; i < directorios.Length; i++)
                {
                    item[0] = directorios[i].Name;
                    item[1] = directorios[i].LastWriteTimeUtc.ToShortDateString();
                    //item[2] = directorios[i].GetFiles().Length.ToString();
                    // Esto es para ver el tamaño de los directorios

                    lvwListado.Items.Add(new ListViewItem(item)).ImageIndex = 0;
                    
                }

                for(int i = 0; i < ficheros.Length; i++)
                {
                    item[0] = ficheros[i].Name;
                    item[1] = ficheros[i].LastWriteTimeUtc.ToShortDateString();
                    item[2] = ficheros[i].Length.ToString();

                    lvwListado.Items.Add(new ListViewItem(item)).ImageIndex = 2;
                }

            } catch (Exception ex) {
                MessageBox.Show("No se tiene acceso");
            }

        }

        private void lvwListado_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvwListado.Sort();
        }
    }
}
