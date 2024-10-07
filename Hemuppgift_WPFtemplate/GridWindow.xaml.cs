using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrEmpty(TxtRow.Text) || string.IsNullOrEmpty(TxtColumn.Text) || TxtColumn.Text.Length > 1 || TxtRow.Text.Length > 1 || !char.IsDigit(TxtRow.Text[0]) || !char.IsDigit(TxtColumn.Text[0]))
            {
                MessageBox.Show("Felaktig Input");
            }
            else
            {
            int row = Convert.ToInt32(TxtRow.Text);
            int column = Convert.ToInt32(TxtColumn.Text);
            
            Button button = new Button()
            {
                Content = $"Row {TxtRow.Text} Column {TxtColumn.Text}",
                Background = Brushes.LightGreen,
            };

            Grid.SetRow(button , row);
            Grid.SetColumn(button , column);
            GrdGridWindow.Children.Add(button);
            }
        }

    }
}
