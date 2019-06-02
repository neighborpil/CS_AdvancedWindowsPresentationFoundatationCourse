﻿using System;
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

namespace DependencyPropertyScenario
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

        private void chkBkgColor_Click(object sender, RoutedEventArgs e)
        {
            if  (chkBkgColor.IsChecked.Value==true)
            {
                this.Background = System.Windows.Media.Brushes.BurlyWood;
            }
            else
            {
                this.Background= System.Windows.Media.Brushes.LightGray;
            }
        }
    }
}
