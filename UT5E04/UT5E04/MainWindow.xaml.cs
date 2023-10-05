using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UT5E04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Negocio negocio;

        public MainWindow()
        {
            InitializeComponent();
            this.negocio = new Negocio();
        }

        /// <summary>
        /// Apertura del contextmenu, habilitar botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void lvReservas_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            if (lvReservas.SelectedItems.Count > 0)
            {
                cmiVer.IsEnabled = true;
                cmiBorrar.IsEnabled = true;
                cmiConfirmar.IsEnabled = true;
            }
        }
        #endregion

        /// <summary>
        /// Width dinámico SizeChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void DockPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            gvcNombre.Width = lvReservas.ActualWidth - 360;
        }
        #endregion

        /// <summary>
        /// Botones CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void cmiEditar_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = negocio.ObtenerReserva(((Reserva)lvReservas.SelectedItem).ReservaId);
            frmReserva frmReserva = new frmReserva(reserva);

            if (frmReserva.ShowDialog() == true)
            {
                CargarDatos();
            }
        }

        private void cmiBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas borrar la reserva?", "Atención", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                negocio.BorrarReserva(((Reserva)lvReservas.SelectedItem).ReservaId);
                CargarDatos();
            }
        }

        private void CrearReserva(object sender, RoutedEventArgs e)
        {
            Reserva nuevaReserva = new Reserva();
            frmReserva frmReserva = new frmReserva(nuevaReserva);

            if (frmReserva.ShowDialog() == true)
            {
                negocio.CrearReserva(nuevaReserva);
                CargarDatos();
            }
        }

        private void lvReservas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Reserva reservaSeleccionada = (Reserva)lvReservas.SelectedItem;

            if (reservaSeleccionada != null)
            {
                frmReserva frmReserva = new frmReserva(reservaSeleccionada);

                if (frmReserva.ShowDialog() == true)
                {
                    CargarDatos();
                }
            }
        }
        #endregion

        /// <summary>
        /// Cargar listas de datos
        /// </summary>
        #region
        private void CargarDatos()
        {
            lvReservas.Items.Clear();

            foreach (Reserva r in negocio.ObtenerReservas())
            {
                lvReservas.Items.Add(r);
            }

            this.tbRegistros.Text = $"{lvReservas.Items.Count.ToString()} registros";
        }
        #endregion

        /// <summary>
        /// Aplicación de filtros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void Button_Click_Filtrar(object sender, RoutedEventArgs e)
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvReservas.Items);
            vista.Filter = FiltroVista;

            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                this.tbFiltro.Text = "Sin filtro";
            }
            else
            {
                this.tbFiltro.Text = $"Filtrando por {txtFiltro.Text}";
            }

        }

        private bool FiltroVista(object item)
        {
            if (string.IsNullOrEmpty(this.txtFiltro.Text))
            {
                return true;
            }

            Reserva reserva = item as Reserva;
            return reserva.Nombre.Contains(this.txtFiltro.Text) || reserva.Fecha.ToShortDateString().Contains(this.txtFiltro.Text);
        }
        #endregion

        /// <summary>
        /// Cambiar dato de asistencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        #region
        private void cmiConfirmar_Click(object sender, RoutedEventArgs args)
        {
            Reserva reservaSeleccionada = (Reserva)lvReservas.SelectedItem;
            negocio.ConfirmarAsistencia(reservaSeleccionada);
            this.chkConfirmarMenuItem.IsChecked = reservaSeleccionada.Asiste;
            CargarDatos();
        }
        #endregion

        /// <summary>
        /// SEPARADOR PARA ALEJANDRO!!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void SEPARADOR_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("  /\\_/\\\r\n ( o.o )\r\n > ^ <\nSEPARADOR","SEPARADOR");
        }
        #endregion
    }
}
