using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CustomDependencyProperty
{
    class MLStackPanel : StackPanel
    {
        public bool IsBrownBackground
        {
            get => (bool)GetValue(IsBrownBackgroundProperty);
            set => SetValue(IsBrownBackgroundProperty, value);
        }

        public static DependencyProperty IsBrownBackgroundProperty = DependencyProperty.Register("IsBrownBackground", typeof(bool), typeof(MLStackPanel));

        //public static DependencyProperty IsBrownBackgroundProperty = DependencyProperty.Register("IsBrownBackground", typeof(bool), typeof(MLStackPanel), new PropertyMetadata(false, OnIsBrownBkgrdChanged, CoerceIsBrownBkgrdChanged));

        //private static object CoerceIsBrownBkgrdChanged(DependencyObject d, object baseValue)
        //{
        //    MLStackPanel m = d as MLStackPanel;
        //    if (m.IsBrownBackground == false)
        //    {
        //        MessageBox.Show("The IsBrownBackground depdendency property is being changed to true");
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("The IsBrownBackground depdendency property is being changed to false");
        //        return false;
        //    }

        //}

        //private static void OnIsBrownBkgrdChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        //{
        //    MLStackPanel msp = source as MLStackPanel;

        //    if (msp.IsBrownBackground == true)
        //    {
        //        msp.Background = System.Windows.Media.Brushes.BurlyWood;
        //    }
        //    else
        //    {
        //        msp.Background = System.Windows.Media.Brushes.LightGray;
        //    }

        //}

    }
}
