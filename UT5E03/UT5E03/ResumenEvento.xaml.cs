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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UT5E03
{
    /// <summary>
    /// Lógica de interacción para ResumenEvento.xaml
    /// </summary>
    public partial class ResumenEvento : Window
    {

        private Evento _evento;
        private int _cont = 0;

        public ResumenEvento()
        {
            InitializeComponent();
        }
        public ResumenEvento(Evento evento) : this()
        {
            this._evento = evento;

            if(this._evento != null)
            {
                txtNombre.Text = this._evento.Nombre;
                txtAforo.Text = this._evento.Aforo.ToString();
                txtDescripcion.Text = this._evento.Descripcion;
                txtHora.Text = this._evento.Hora.ToString("hh:mm:ss");
                txtPromotor.Text = this._evento.Promotor;

                switch (this._evento.Tipo)
                {
                    case TipoEventoEnum.Todos:
                        txtTipo.Text = "Todos";
                        break;
                    case TipoEventoEnum.MenorDe10:
                        txtTipo.Text = "Menor de 10";
                        break;
                    case TipoEventoEnum.MayorDe16:
                        txtTipo.Text = "Mayor de 16";
                        break;
                    case TipoEventoEnum.MayorDe18:
                        txtTipo.Text = "Mayor de 18";
                        break;
                }

                dtpFecha.SelectedDate = this._evento.Fecha;

                Span span = new Span();

                if (this._evento.Seguridad) {
                    span.Inlines.Add(AgregarLinea("Seguridad"));
                    span.Inlines.Add(new LineBreak());
                }
                if (this._evento.Montaje) {
                    span.Inlines.Add(AgregarLinea("Montaje"));
                    span.Inlines.Add(new LineBreak());
                }
                if (this._evento.Bar) {
                    span.Inlines.Add(AgregarLinea("Bar"));
                    span.Inlines.Add(new LineBreak());
                }
                if (this._evento.Sanitarios) {
                    span.Inlines.Add(AgregarLinea("Sanitarios"));
                    span.Inlines.Add(new LineBreak());
                }

                tbRequisitos.Inlines.Add(span);
            }
            
        }
        private Run AgregarLinea(string param)
        {
            Run salida = new Run(param);
            if(_cont % 2 == 0)
            {
                salida.Background = new SolidColorBrush(Colors.Aqua);
            } else
            {
                salida.Background = new SolidColorBrush(Colors.LightGreen);
            }
            ++_cont;
            return salida;
        }
        private void Button_Click_Aceptar(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
        private void Button_Click_Cancelar(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
