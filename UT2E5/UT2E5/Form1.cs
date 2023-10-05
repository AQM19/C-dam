<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E5
{
    public partial class Form1 : Form
    {

        static Documento documento;
        static DialogResult result;
        static string look;
        static int init;

        public Form1()
        {
            InitializeComponent();

            documento = new Documento();

            tsrNuevo.ShortcutKeys       = Keys.Control | Keys.N;
            tsrAbrir.ShortcutKeys       = Keys.Control | Keys.A;
            tsrGuardar.ShortcutKeys     = Keys.Control | Keys.G;
            tsrDeshacer.ShortcutKeys    = Keys.Control | Keys.Z;
            tsrCortar.ShortcutKeys      = Keys.Control | Keys.X;
            tsrCopiar.ShortcutKeys      = Keys.Control | Keys.C;
            tsrPegar.ShortcutKeys       = Keys.Control | Keys.V;
            tsrEliminar.ShortcutKeys    = Keys.Delete;
        }

        private void tsrAjusteLinea_Click(object sender, EventArgs e)
        {
            if (tsrAjusteLinea.Checked)
            {
                tsrAjusteLinea.Checked = false;
                txtNotepad.WordWrap = false;
            } else
            {
                tsrAjusteLinea.Checked = true;
                txtNotepad.WordWrap = true;
            }
        }

        private void tsrNuevo_Click(object sender, EventArgs e)
        {
            EventoConCambios();
        }

        private void NuevoDocumento()
        {
            documento = new Documento();
            txtNotepad.Text = documento.Texto;
        }

        private void EventoConCambios()
        {
            if (!documento.EstaModificado(txtNotepad.Text))
            {
                result = MessageBox.Show("¿Deseas guardar los cambios?", String.Empty, MessageBoxButtons.YesNoCancel);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                    saveFileDialog.RestoreDirectory = false;

                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        FileStream stream = File.Create(saveFileDialog.FileName);
                        stream.Close();
                        documento.EscribirTexto(txtNotepad.Text);
                        documento.GuardarComo(txtNotepad.Text, @saveFileDialog.FileName);
                    }

                    NuevoDocumento();
                    
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    NuevoDocumento();
                }
            }
        }

        private void tsrAbrir_Click(object sender, EventArgs e)
        {
            EventoConCambios();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Abrir";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documento = new Documento(openFileDialog.FileName);
                txtNotepad.Text = documento.Texto;
            }
            else
            {
                MessageBox.Show("Error al abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsrGuardar_Click(object sender, EventArgs e)
        {
            if (documento.Ruta.Equals(string.Empty))
            {
                EventoGuardarComo();
            }

            documento.EscribirTexto(txtNotepad.Text);
            documento.Guardar();
        }

        private void tsrGuardarComo_Click(object sender, EventArgs e)
        {
            EventoGuardarComo();
        }

        private void EventoGuardarComo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Guardar como";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documento = new Documento(openFileDialog.FileName);
                txtNotepad.Text = documento.Texto;
            }
        }

        private void tsrSalir_Click(object sender, EventArgs e)
        {
            EventoConCambios();
            
            Application.Exit();
        }

        private void FormularioCerrandose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            EventoConCambios();

            e.Cancel = false;
        }

        private void tsrFuente_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowColor = true;

            if(fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtNotepad.Font = fontDialog.Font;
                txtNotepad.ForeColor = fontDialog.Color;
            }
        }

        private void tsrAcercaDe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void tsrDeshacer_Click(object sender, EventArgs e)
        {
            if (txtNotepad.CanUndo)
            {
                txtNotepad.Undo();
                txtNotepad.ClearUndo();
            }
        }

        private void tsrCortar_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtNotepad.SelectedText))
            {
                txtNotepad.Cut();
            }
        }

        private void tsrCopiar_Click(object sender, EventArgs e)
        {
            if(txtNotepad.SelectionLength > 0)
            {
                txtNotepad.Copy();
            }
        }

        private void tsrPegar_Click(object sender, EventArgs e)
        {
            // Comprueba que hay algo en el Clipboard para poder pegarlo
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Si quiero comprobar que se quiera sobreescribir el texto seleccionado hago esto
                // Lo comento ya que no es funcionalidad del bloc de notas original pero me apetece tenerlo cerca en un ejercicio
                /*
                if(txtNotepad.SelectionLength > 0)
                {
                    if(MessageBox.Show("¿Quieres sobreescribir el texto seleccionado?","Pegar",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        txtNotepad.SelectionStart = txtNotepad.SelectionStart + txtNotepad.SelectionLength;
                    }                    
                }
                */
                txtNotepad.Paste();
            }
        }

        private void tsrEliminar_Click(object sender, EventArgs e)
        {
            if(txtNotepad.SelectionLength > 0)
            {
                txtNotepad.SelectedText = String.Empty;
            }
        }

        private void tsrSeleccionarTodo_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectAll();
        }

        private void tsrBuscar_Click(object sender, EventArgs e)
        {
            string param = string.Empty;
            FormularioBuscar form3 = new FormularioBuscar(param);

            if(form3.ShowDialog() == DialogResult.OK)
            {
                look = form3.look;
                BuscarSiguiente();
            }
        }

        private void BuscarSiguiente()
        {
            string text = txtNotepad.Text;
            int init = txtNotepad.SelectionStart;

            if (text.Contains(look))
            {
                if (!string.IsNullOrEmpty(look))
                {
                    if (init == text.Length - look.Length)
                    {
                        init = text.IndexOf(look);
                        txtNotepad.Select(init, look.Length);
                    }
                    else
                    {
                        init = text.IndexOf(look, init + look.Length);
                        txtNotepad.Select(init, look.Length);
                    }
                }
            }
        }

        private void tsrBuscarSiguiente_Click(object sender, EventArgs e)
        {
            BuscarSiguiente();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E5
{
    public partial class Form1 : Form
    {

        static Documento documento;
        static DialogResult result;
        static string look;
        static int init;

        public Form1()
        {
            InitializeComponent();

            documento = new Documento();

            tsrNuevo.ShortcutKeys       = Keys.Control | Keys.N;
            tsrAbrir.ShortcutKeys       = Keys.Control | Keys.A;
            tsrGuardar.ShortcutKeys     = Keys.Control | Keys.G;
            tsrDeshacer.ShortcutKeys    = Keys.Control | Keys.Z;
            tsrCortar.ShortcutKeys      = Keys.Control | Keys.X;
            tsrCopiar.ShortcutKeys      = Keys.Control | Keys.C;
            tsrPegar.ShortcutKeys       = Keys.Control | Keys.V;
            tsrEliminar.ShortcutKeys    = Keys.Delete;
        }

        private void tsrAjusteLinea_Click(object sender, EventArgs e)
        {
            if (tsrAjusteLinea.Checked)
            {
                tsrAjusteLinea.Checked = false;
                txtNotepad.WordWrap = false;
            } else
            {
                tsrAjusteLinea.Checked = true;
                txtNotepad.WordWrap = true;
            }
        }

        private void tsrNuevo_Click(object sender, EventArgs e)
        {
            EventoConCambios();
        }

        private void NuevoDocumento()
        {
            documento = new Documento();
            txtNotepad.Text = documento.Texto;
        }

        private void EventoConCambios()
        {
            if (!documento.EstaModificado(txtNotepad.Text))
            {
                result = MessageBox.Show("¿Deseas guardar los cambios?", String.Empty, MessageBoxButtons.YesNoCancel);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                    saveFileDialog.RestoreDirectory = false;

                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        FileStream stream = File.Create(saveFileDialog.FileName);
                        stream.Close();
                        documento.EscribirTexto(txtNotepad.Text);
                        documento.GuardarComo(txtNotepad.Text, @saveFileDialog.FileName);
                    }

                    NuevoDocumento();
                    
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    NuevoDocumento();
                }
            }
        }

        private void tsrAbrir_Click(object sender, EventArgs e)
        {
            EventoConCambios();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Abrir";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documento = new Documento(openFileDialog.FileName);
                txtNotepad.Text = documento.Texto;
            }
            else
            {
                MessageBox.Show("Error al abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsrGuardar_Click(object sender, EventArgs e)
        {
            if (documento.Ruta.Equals(string.Empty))
            {
                EventoGuardarComo();
            }

            documento.EscribirTexto(txtNotepad.Text);
            documento.Guardar();
        }

        private void tsrGuardarComo_Click(object sender, EventArgs e)
        {
            EventoGuardarComo();
        }

        private void EventoGuardarComo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Guardar como";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documento = new Documento(openFileDialog.FileName);
                txtNotepad.Text = documento.Texto;
            }
        }

        private void tsrSalir_Click(object sender, EventArgs e)
        {
            EventoConCambios();
            
            Application.Exit();
        }

        private void FormularioCerrandose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            EventoConCambios();

            e.Cancel = false;
        }

        private void tsrFuente_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowColor = true;

            if(fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtNotepad.Font = fontDialog.Font;
                txtNotepad.ForeColor = fontDialog.Color;
            }
        }

        private void tsrAcercaDe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void tsrDeshacer_Click(object sender, EventArgs e)
        {
            if (txtNotepad.CanUndo)
            {
                txtNotepad.Undo();
                txtNotepad.ClearUndo();
            }
        }

        private void tsrCortar_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtNotepad.SelectedText))
            {
                txtNotepad.Cut();
            }
        }

        private void tsrCopiar_Click(object sender, EventArgs e)
        {
            if(txtNotepad.SelectionLength > 0)
            {
                txtNotepad.Copy();
            }
        }

        private void tsrPegar_Click(object sender, EventArgs e)
        {
            // Comprueba que hay algo en el Clipboard para poder pegarlo
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Si quiero comprobar que se quiera sobreescribir el texto seleccionado hago esto
                // Lo comento ya que no es funcionalidad del bloc de notas original pero me apetece tenerlo cerca en un ejercicio
                /*
                if(txtNotepad.SelectionLength > 0)
                {
                    if(MessageBox.Show("¿Quieres sobreescribir el texto seleccionado?","Pegar",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        txtNotepad.SelectionStart = txtNotepad.SelectionStart + txtNotepad.SelectionLength;
                    }                    
                }
                */
                txtNotepad.Paste();
            }
        }

        private void tsrEliminar_Click(object sender, EventArgs e)
        {
            if(txtNotepad.SelectionLength > 0)
            {
                txtNotepad.SelectedText = String.Empty;
            }
        }

        private void tsrSeleccionarTodo_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectAll();
        }

        private void tsrBuscar_Click(object sender, EventArgs e)
        {
            string param = string.Empty;
            FormularioBuscar form3 = new FormularioBuscar(param);

            if(form3.ShowDialog() == DialogResult.OK)
            {
                look = form3.look;
                BuscarSiguiente();
            }
        }

        private void BuscarSiguiente()
        {
            string text = txtNotepad.Text;
            int init = txtNotepad.SelectionStart;

            if (text.Contains(look))
            {
                if (!string.IsNullOrEmpty(look))
                {
                    if (init == text.Length - look.Length)
                    {
                        init = text.IndexOf(look);
                        txtNotepad.Select(init, look.Length);
                    }
                    else
                    {
                        init = text.IndexOf(look, init + look.Length);
                        txtNotepad.Select(init, look.Length);
                    }
                }
            }
        }

        private void tsrBuscarSiguiente_Click(object sender, EventArgs e)
        {
            BuscarSiguiente();
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
