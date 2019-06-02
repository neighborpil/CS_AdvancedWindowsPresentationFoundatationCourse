using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace CommonDialogExample
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

        private void OpenFileDialogButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = @"C:\"
            };


            if (dialog.ShowDialog() == true)
                Process.Start("notepad.exe", dialog.FileName);
        }

        private void ColorDialogButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.FullOpen = true;
            //dialog.AllowFullOpen = true;
            dialog.ShowDialog();
        }
    }
}
