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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TextBoxA.Text, out int A) && int.TryParse(TextBoxB.Text, out int B))
               
                {
                    if (A >= B)
                    {
                        ResultTextBlock.Text = "Число A должно быть меньше числа B.";
                        return;
                    }

                    // Часть 1: Сумма чисел между A и B
                    int sum = 0;
                    for (int i = A + 1; i < B; i++)
                    {
                        sum += i;
                    }

                    // Часть 2: Нечетные числа между A и B
                    string oddNumbers = "Нечетные числа: ";
                    for (int i = A + 1; i < B; i++)
                    {
                        if (i % 2 != 0)
                        {
                            oddNumbers += i + " ";
                        }
                    }

                    ResultTextBlock.Text = $"Сумма чисел между {A} и {B}: {sum}\n{oddNumbers}";
                }
                else
                {
                    ResultTextBlock.Text = "Пожалуйста, введите корректные числа.";
                }
            
        }
    }

}
    

