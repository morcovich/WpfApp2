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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void CalculateBonusButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что поля не пустые и корректно парсятся
            if (decimal.TryParse(SalaryTextBox.Text, out decimal salary) && int.TryParse(YearsTextBox.Text, out int years))
            {
                decimal bonus = 0;

                // Упростили условия
                if (years < 5)
                {
                    bonus = salary * 0.10m;  // 10%
                }
                else if (years < 10)
                {
                    bonus = salary * 0.15m;  // 15%
                }
                else if (years < 15)
                {
                    bonus = salary * 0.25m;  // 25%
                }
                else if (years < 20)
                {
                    bonus = salary * 0.35m;  // 35%
                }
                else if (years < 25)
                {
                    bonus = salary * 0.45m;  // 45%
                }
                else
                {
                    bonus = salary * 0.50m;  // 50%
                }

                // Выводим результат в нужном формате 
                ResultTextBlock.Text = $"Премия сотрудника: {bonus:C}";
            }
            else
            {
                ResultTextBlock.Text = "Введите корректные данные!";
            }
        }

    }
}
