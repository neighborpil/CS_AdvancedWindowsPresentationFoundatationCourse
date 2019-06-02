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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomDialogExample
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

        private void cmbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string st = (cmbState.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (st.Equals("Alabama"))
            {
                var dialog = new GetZipCodeDialog();
                if (dialog.ShowDialog() == true)
                {
                    lblZip.Content = dialog.Zip;
                }
            }


            //string st = ((ComboBoxItem)cmbState.SelectedItem).Content.ToString();

            //if (st=="Alabama")
            //{
            //    GetZipDialog gzd = new GetZipDialog();

            //   if(gzd.ShowDialog()==true)
            //    {
            //        lblZip.Content = gzd.Zip;
            //    }


            //}
        }
    }
}
