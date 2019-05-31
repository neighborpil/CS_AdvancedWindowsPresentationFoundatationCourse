using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lec27_CreatingADependencyProperty
{
    public class MlStackPanel : StackPanel
    {
        public static DependencyProperty IsBrownBackgroundProperty = 
            DependencyProperty.Register("IsBrownBackground",
                typeof(bool),
                typeof(MlStackPanel),
                new PropertyMetadata(
                    false, 
                    (DependencyObject o, DependencyPropertyChangedEventArgs e) =>
                    {
                        MlStackPanel panel = o as MlStackPanel;

                        if (panel.IsBrownBackground)
                            panel.Background = Brushes.BurlyWood;  
                        else
                            panel.Background = SystemColors.WindowBrush;
                    },
                    (DependencyObject d, object baseValue) =>
                    {
                        var mlStackPanel = d as MlStackPanel;
                        if (mlStackPanel.IsBrownBackground == false)
                        {
                            //MessageBox.Show("The IsBrownBackground dependency property is being changed to true");
                            return true;
                        }

                        //MessageBox.Show("The IsBrownBackground dependency property is being changed to false");
                        return false;
                    }));


        public bool IsBrownBackground
        {
            get => (bool) GetValue(IsBrownBackgroundProperty);
            set => SetValue(IsBrownBackgroundProperty, value);
        }
    } 
}
