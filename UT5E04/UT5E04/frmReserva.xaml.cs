using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UT5E04
{
    /// <summary>
    /// Lógica de interacción para Reserva.xaml
    /// </summary>
    public partial class frmReserva : Window
    {

        private Reserva nuevaReserva;

        public frmReserva()
        {
            InitializeComponent(); 
        }

        public frmReserva(Reserva nuevaReserva) : this()
        {
            this.nuevaReserva = nuevaReserva;
            this.dtpFecha.SelectedDate = DateTime.Today;

            if (nuevaReserva.ReservaId != 0)
            {
                txtNombre.Text = this.nuevaReserva.Nombre;
                dtpFecha.SelectedDate = this.nuevaReserva.Fecha;
                txtTelefono.Text = this.nuevaReserva.Telefono;
                txtComensales.Text = this.nuevaReserva.Comensales.ToString();
                if (!this.nuevaReserva.Asiste) chkAsiste.IsChecked = false;
                txtObservaciones.Text = this.nuevaReserva.Observaciones;
            }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDatos())
            {
                this.nuevaReserva.Nombre = this.txtNombre.Text;
                this.nuevaReserva.Fecha = (DateTime)this.dtpFecha.SelectedDate;
                this.nuevaReserva.Telefono = this.txtTelefono.Text;
                this.nuevaReserva.Comensales = Int32.Parse(this.txtComensales.Text);
                this.nuevaReserva.Asiste = (bool)this.chkAsiste.IsChecked;
                this.nuevaReserva.Observaciones = this.txtObservaciones.Text;

                this.DialogResult = true;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtNombre.Focus();
                return false;
            }
            if(dtpFecha.SelectedDate == null)
            {
                MessageBox.Show("El campo fecha no puede estar vacío", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                dtpFecha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El campo teléfono no puede estar vacío", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTelefono.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtComensales.Text))
            {
                MessageBox.Show("El campo comensales no puede estar vacío", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtComensales.Focus();
                return false;
            }
            return true;
        }

        private void format_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);

            if (!char.IsDigit(c) && c != 8 && c != 9)
            {
                e.Handled = true;
            }
        }
    }
}
