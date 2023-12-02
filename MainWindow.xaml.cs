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

namespace задачка
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(applesWeightTextBox.Text, out double weight) && double.TryParse(applesPriceTextBox.Text, out double price))
            {
                double totalPrice = (weight / 1) * 1;
                resultTextBlock.Text = $"Общая цена за Ү кг яблок составляет {totalPrice:F2} рублей.";
                resultTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                resultTextBlock.Text = "Пожалуйста, введите действительные цифры для веса и цены.";
                resultTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}



    //public class zz
    //{
    //    public static double zzz(double x, double a, double y)
    //    {
    //        double costPerKg = a / x;
    //        double totalCost = costPerKg * y;
    //        return Math.Round(totalCost, 2);
    //    }
    //}
  
