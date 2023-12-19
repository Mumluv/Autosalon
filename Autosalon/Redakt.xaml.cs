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
    /// Логика взаимодействия для Redakt.xaml
    /// </summary>
    public partial class Redakt : Page
    {
        Frame MainFrame;
        public Redakt(Frame MainFrame)
        {
            InitializeComponent();
            this.MainFrame = MainFrame;
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Buyer();
        }
  
    }
}
