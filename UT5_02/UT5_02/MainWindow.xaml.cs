using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using Path = System.IO.Path;

namespace UT5_02
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int indiceImagenes = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Abrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\Users\\Alumno\\Pictures";
            fileDialog.Filter = "Todos|*.*|jpg|*.jpg|png|*.png|gif|*.gif";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == true)
            {                
                TabItem tabItem = new TabItem();
                tabItem.Header = ObtenerCabecero(fileDialog.FileName);
                tabItem.Content = ObtenerContenido(fileDialog.FileName, tabItem);

                tbcControl.Items.Add(tabItem);
                tbcControl.SelectedItem = tabItem;
                
                MenuItem itemImagen = new MenuItem();
                itemImagen.Header = Path.GetFileName(fileDialog.FileName);
                itemImagen.Tag = $"imgImagen_{indiceImagenes}";
                itemImagen.Click += miImagen_Click;
                mnImagenes.Items.Add(itemImagen);

                ++indiceImagenes;
            }
        }
        private StackPanel ObtenerCabecero(string param)
        {
            StackPanel header = new StackPanel();
            header.Orientation = Orientation.Horizontal;

            TextBlock titulo = new TextBlock();
            titulo.Text = Path.GetFileName(param);

            Image cross = new Image();
            cross.Source = new BitmapImage(new Uri("/Resources/action_Cancel_16xMD.png", UriKind.Relative));
            cross.Height = 16;
            cross.MouseDown += Mouse_Down_Image;

            header.Children.Add(titulo);
            header.Children.Add(cross);

            return header;
        }
        private ScrollViewer ObtenerContenido(string param, TabItem item)
        {
            ScrollViewer scrollViewer = new ScrollViewer();
            Uri uri = new Uri(param);
            Image image = new Image();

            image.Name = $"imgImagen_{indiceImagenes}";
            item.Tag = image.Name;
            image.Source = new BitmapImage(uri);
            scrollViewer.Content = image;

            RegisterName(image.Name, image);

            return scrollViewer;
        }
        private void Mouse_Down_Image(object sender, MouseButtonEventArgs e)
        {
            StackPanel stack = (StackPanel)VisualTreeHelper.GetParent((Image)sender);
            ContentPresenter contentpresenter = (ContentPresenter)VisualTreeHelper.GetParent(stack);
            Grid grid = (Grid)VisualTreeHelper.GetParent(contentpresenter);
            TabItem item = (TabItem)VisualTreeHelper.GetParent(grid);
            tbcControl.Items.Remove(item);
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(tbcControl != null && tbcControl.SelectedItem != null)
            {
                Image image = (Image)FindName((string)((TabItem)tbcControl.SelectedItem).Tag);
                image.Stretch = DarFormato();
            }
        }
        private void tbcControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(tbcControl.SelectedItem != null) //Agregada la condición para que no se rompa al cerrar la pestaña
            {
                Image image = (Image)FindName((string)((TabItem)tbcControl.SelectedItem).Tag);
                cboStretch.SelectedItem = image.Stretch;

                MostrarInformacion(image);
            } else
            {
                tbDimension.Text = string.Empty;
                tbRuta.Text = string.Empty;
            }
        }
        private void MostrarInformacion(Image imagen)
        {
            BitmapImage bitmap = (BitmapImage)imagen.Source;
            BitmapFrame frame = BitmapFrame.Create(bitmap);

            double width = frame.PixelWidth;
            double height = frame.PixelHeight;

            tbDimension.Text = $"Ancho: {width}px, Alto: {height}px";
            tbRuta.Text = imagen.Source.ToString();
            cboStretch.SelectedItem = imagen.Stretch; // No se ejecuta por alguna razón
        }
        private void miImagen_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;

            // Solución con la optimización del tiempo de ejecución.
            TabItem selectedTabItem = tbcControl.Items.OfType<TabItem>().FirstOrDefault(x => x.Tag.ToString() == menuItem.Tag.ToString());
            tbcControl.SelectedItem = selectedTabItem;

            /*
            foreach (TabItem item in tbcControl.Items)
            {
                Image img = (Image)FindName((string)item.Tag);
                if (img.Name == (string)menuItem.Tag)
                {
                    tbcControl.SelectedItem = item;
                    break;
                }
            }
            */
        }
        private Stretch DarFormato()
        {
            switch((cboStretch.SelectedItem as ComboBoxItem).Content)
            {
                case "None":
                    return Stretch.None;
                case "Fill":
                    return Stretch.Fill;
                case "Uniforme":
                    return Stretch.Uniform;
                default:
                    return Stretch.UniformToFill;
            }
        }
        private void MenuItem_Salir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
