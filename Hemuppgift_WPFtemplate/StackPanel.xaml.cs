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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for StackPanel.xaml
    /// </summary>
    public partial class StackPanel : Window
    {
        public StackPanel()
        {
            InitializeComponent();
        }

        private void HorizontalButton_Click(object sender, RoutedEventArgs e)
        {
            StackRect.Orientation = Orientation.Horizontal;
            
        }

        private void VerticalButton_Click(object sender, RoutedEventArgs e)
        {
            StackRect.Orientation=Orientation.Vertical;
        }
    }
}
