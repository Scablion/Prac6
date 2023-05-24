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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        static int fx(int a)
        {
            int secNum = a % 100 / 10;

            return secNum;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(mean.Text);
            int b = int.Parse(mean2.Text);
            int c = int.Parse(mean3.Text);
            Answer.Text = $"f({a}) + f({b}) - f({c}) = " + Convert.ToString(fx(a) + fx(b) - fx(c));
        }
    }
}
