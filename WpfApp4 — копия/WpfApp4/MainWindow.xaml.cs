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

namespace WpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(mean.Text);
                int b = Convert.ToInt32(mean2.Text);
                int h = Convert.ToInt32(mean3.Text);
                double X = Convert.ToDouble(mean4.Text);
                double Y = Tas(a, b, h, X);
                Answer.Text = $"Значение выражения: \n{Y:f2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static double Tas(int A, int B, int h, double x)
        {
            double res = 0;
            for (int i = A; i <= B; i += h)
            {
                if (x == 1 || x == -1)
                {
                    res += 1;
                }
                else if (x >= 0 && x != 1)
                {
                    res =  1 / (1 - x);
                }
                else 
                { 
                    res = 1 / (1 + x); 
                }
            }
            return res;
        }

    }
}
