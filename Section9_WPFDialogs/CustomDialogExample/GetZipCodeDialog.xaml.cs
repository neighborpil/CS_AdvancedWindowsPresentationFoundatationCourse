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

namespace CustomDialogExample
{
    /// <summary>
    /// Interaction logic for GetZipCodeDialog.xaml
    /// </summary>
    public partial class GetZipCodeDialog : Window
    {
        public string Zip { get; set; }

        public GetZipCodeDialog()
        {
            InitializeComponent();
        }

        private void BtnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            Zip = txtAnswer.Text;
        }
    }
}
