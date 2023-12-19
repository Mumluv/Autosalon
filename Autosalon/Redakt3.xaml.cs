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
    /// Логика взаимодействия для Redakt3.xaml
    /// </summary>
    public partial class Redakt3 : Page
    {
        Frame MainFrame;
        public Redakt3(Frame MainFrame)
        {
            InitializeComponent();
            this.MainFrame = MainFrame;
        }

        private void Add3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Emp();
        }
    }
}
