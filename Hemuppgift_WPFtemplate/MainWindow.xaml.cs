using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void BtnStack_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Show();
        }

        private void BtnWrap_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel wrapPanel = new WrapPanel();
            wrapPanel.Show();
        }

        private void BtnDock_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dockPanel = new DockPanel();
            dockPanel.Show();
        }
    }
}