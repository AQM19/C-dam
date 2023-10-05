using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace UT5E03
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private TipoEventoEnum _evento = TipoEventoEnum.Todos;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDatos())
            {
                Evento nuevoEvento = new Evento
                {
                    Nombre = tbNombre.Text,
                    Fecha = dtpFecha.SelectedDate.Value,
                    Hora = DateTime.Parse(tbHora.Text),
                    Aforo = Int32.Parse(tbAforo.Text),
                    Promotor = cboPromotor.Text,
                    Tipo = _evento,
                    Seguridad = (bool)chkSeguridad.IsChecked,
                    Montaje = (bool)chkMontaje.IsChecked,
                    Bar = (bool)chkBar.IsChecked,
                    Sanitarios = (bool)chkSanitarios.IsChecked,
                    Descripcion = tbDescripcion.Text
                };

                ResumenEvento resumen = new ResumenEvento(nuevoEvento);
                if(resumen.ShowDialog() == true)
                {
                    MessageBox.Show("Evento creado correctamente.");
                }
            }
        }

        /// <summary>
        /// Validación del campo fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private bool ValidarFecha()
        {
            DateTime dateTimeResult;
            if (!DateTime.TryParse(dtpFecha.Text, out dateTimeResult))
            {
                MessageBox.Show("La fecha no es válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            return true;
        }
        #endregion

        /// <summary>
        /// Validación del campo hora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void tbHora_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);

            if (!char.IsDigit(c) && c != ':' && c != 8 && c != 9)
            {
                e.Handled = true;
            }
        }
        private void tbHora_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = tbHora.Text;
            if (text.Length == 2 || text.Length == 5)
            {
                text += ":";
            }
            if (text.Length > 8)
            {
                text = text.Substring(0, 8);
            }
            if (text.Length == 8 && !Regex.IsMatch(text, @"^\d{2}:\d{2}:\d{2}$"))
            {
                text = text.Substring(0, text.Length - 1);
            }
            tbHora.Text = text;
            tbHora.Select(tbHora.Text.Length, 0);
        }
        private void tbHora_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidarHora();
        }
        private bool ValidarHora()
        {
            DateTime dateTimeResult;
            if (!DateTime.TryParse(tbHora.Text, out dateTimeResult))
            {
                MessageBox.Show("La hora no es válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            return true;
        }
        #endregion

        /// <summary>
        /// Validación del campo aforo
        /// </summary>
        /// <returns></returns>
        #region
        private void tbAforo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);

            if (!char.IsDigit(c) && c != 8 && c != 9)
            {
                e.Handled = true;
            }
        }
        private bool ValidarAforo()
        {
            string text = tbAforo.Text;
            int aux;
            if (!Int32.TryParse(text, out aux))
            {
                MessageBox.Show("El aforo no es válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            return true;
        }
        #endregion
        
        /// <summary>
        /// Validación total de los datos
        /// </summary>
        /// <returns></returns>
        #region
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                tbNombre.Focus();
                return false;
            }
            if (!ValidarHora())
            {
                tbHora.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbAforo.Text))
            {
                MessageBox.Show("El campo aforo no puede estar vacío.");
                tbAforo.Focus();
                return false;
            }
            if (!ValidarAforo())
            {
                tbAforo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbHora.Text))
            {
                MessageBox.Show("El campo de hora no puede estar vacío.");
                tbHora.Focus();
                return false;
            }
            return true;
        }
        #endregion

        /// <summary>
        /// Uso común de los RadioButtons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rbTipo = (RadioButton)sender;
            
            switch (rbTipo.Tag)
            {
                case "Todos":
                    _evento = TipoEventoEnum.Todos;
                    break;
                case "10":
                    _evento = TipoEventoEnum.MenorDe10;
                    break;
                case "16":
                    _evento = TipoEventoEnum.MayorDe16;
                    break;
                case "18":
                    _evento = TipoEventoEnum.MayorDe18;
                    break;
            }            
        }
        #endregion
    }
}
