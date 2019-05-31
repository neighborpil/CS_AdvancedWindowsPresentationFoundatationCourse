using System.Windows;
using System.Windows.Media;

namespace Lec17_CustomClassExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var example = new Example();
            example.SayHello();
        }

        private void ColorCheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            if (ColorCheckBox.IsChecked.Value)
            {
                this.Background = Brushes.BurlyWood;
            }
            else
            {
                this.Background = SystemColors.WindowBrush;
            }
        }
    }
}
