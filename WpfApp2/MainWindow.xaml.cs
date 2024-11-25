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

namespace WpfApp2
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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Window pW = new Window1();
            pW.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window pW = new Window2();
            pW.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window pW = new Window3();
            pW.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Window pW = new Window4();
            pW.Show();
        }

        
    }
}
