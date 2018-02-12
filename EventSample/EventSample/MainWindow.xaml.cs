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

namespace EventSample
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

        private void OnInnterbutton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("inner button");
        }

        private void OnOuterButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("outer button");
        }

        private void OnSecondRowButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2nd row button");
            e.Handled = true;
        }

        private void OnGridButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button click event in grid");
        }
    }
}
