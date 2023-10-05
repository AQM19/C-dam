using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

namespace UT5_01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtPrimerValor.Text);
                double y = Convert.ToDouble(txtSegundoValor.Text);
                double result = 0;

                switch (cboOperacion.Text)
                {
                    case "Sumar":
                        result = x + y;
                        setResult($"{x} + {y}", result);
                        break;
                    case "Restar":
                        result = x - y;
                        setResult($"{x} - {y}", result);
                        break;
                    case "Multiplicar":
                        result = x * y;
                        setResult($"{x} * {y}", result);
                        break;
                    case "Dividir":
                        result = x / y;
                        setResult($"{x} / {y}", result);
                        break;
                }

            } catch (Exception ex) {
                string errorMessage = string.Format("An error occurred: {0}", ex.Message);
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error); 
            }
        }
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void setResult(String operation, double result)
        {            
            spResultado.Inlines.Clear();

            Span formatoSalida = new Span();
            
            formatoSalida.FontWeight = FontWeights.Bold;
            formatoSalida.Inlines.Add(operation);
            formatoSalida.Inlines.Add(new LineBreak());

            Run infoSalida = new Run("Resultado igual a " + result);
            infoSalida.Background = new SolidColorBrush(Colors.Aqua);
            formatoSalida.Inlines.Add(infoSalida);
            spResultado.Inlines.Add(formatoSalida);
            
        }
    }
}
