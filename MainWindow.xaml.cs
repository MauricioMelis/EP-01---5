using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EP_01___5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectionComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                switch (selectedItem.Content.ToString())
                {
                    case "Iphone 15":
                        cuartoRecuadro.Content = "Pantalla\t6.1\", 1179 x 2556 pixels\r\n Procesador\tApple A16 Bionic\r\n Almacenamiento\t128GB/256GB/512GB\r\n Expansión\tsin microSD\r\n Cámara\tDual, 48MP+12MP\r\n OS\tiOS 17\r\n Perfil\t7.8 mm\r\n Peso\t171 g\r\n Precio\t800 USD";
                        break;
                    case "Iphone 16":
                        
                        cuartoRecuadro.Content = "Chip A18 Bionic\r\nNuevo botón de acción.\r\nCambio en el diseño de la cámara.\r\nMarcos más finos.\r\nMejoras en la batería.\r\nCarga más rápida.\r\nMejoras en las cámaras traseras.";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un tipo de iPhone.");
            }
        }

        private void changer_Click(object sender, RoutedEventArgs e)
        {
            primerRecuadro.Background = new SolidColorBrush(Colors.White);
            segundoRecuadro.Background = new SolidColorBrush(Colors.Yellow);
            tercerRecuadro.Background = new SolidColorBrush(Colors.Violet);
            cuartoRecuadro.Background = new SolidColorBrush(Colors.Chocolate);
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            primerRecuadro.Background = new SolidColorBrush(Colors.LightGreen);
            segundoRecuadro.Background = new SolidColorBrush(Colors.LightBlue);
            tercerRecuadro.Background = new SolidColorBrush(Colors.LightGray);
            cuartoRecuadro.Background = new SolidColorBrush(Colors.LightSteelBlue);
            cuartoRecuadro.Content = "Información";
        }
    }
}
