﻿using System;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void CalculateSquaresButton_Click(object sender, RoutedEventArgs e)
        {
            
                string squares = "Квадраты чисел от 10 до 20:\n";
                for (int i = 10; i <= 20; i++)
                {
                    squares += $"{i}^2 = {i * i}\n";
                }
                ResultTextBlock.Text = squares;
            
        }
    }

}
  
