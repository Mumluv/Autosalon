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

namespace Autosalon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Buyers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Redakt(MainFrame);
        }

        private void Marka_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Redakt2(MainFrame);
        }

        private void Emp_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Redakt3(MainFrame);
        }

        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Redakt4(MainFrame);
        }

        private void Sell_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Redakt5(MainFrame);
        }
    }
}
