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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void CalculateSumButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TextBoxN.Text, out int n))
            {
                if (n < 1)
                {
                    ResultTextBlock.Text = "Число N должно быть больше или равно 1.";
                    return;
                }

                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                ResultTextBlock.Text = $"Сумма чисел от 1 до {n}: {sum}";
            }
            else
            {
                ResultTextBlock.Text = "Введите корректное число!";
            }
        }
    }
}
