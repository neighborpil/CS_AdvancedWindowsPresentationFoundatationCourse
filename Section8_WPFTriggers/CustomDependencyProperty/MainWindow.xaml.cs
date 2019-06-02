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

namespace CustomDependencyProperty
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

        private void bkgColor_Click(object sender, RoutedEventArgs e)
        {
            if (chkBkgColor.IsChecked.Value==true)
            {
                mlStack.IsBrownBackground = true;
            }
            else
            {
                mlStack.IsBrownBackground = false;
            }
        }
    }
}
