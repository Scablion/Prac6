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
using static WpfApp4.Class1;

namespace WpfApp4
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(mean.Text);
            int b = Convert.ToInt32(mean2.Text);
            int c = Convert.ToInt32(mean3.Text);
            int d = Convert.ToInt32(mean4.Text);
            int ee = Convert.ToInt32(mean5.Text);
            int f = Convert.ToInt32(mean6.Text);
            int g = Convert.ToInt32(mean7.Text);

            //double S1 = Fxyz(a,b,f);
            //double S2 = Fxyz(g,f,c);
            //double S3 = Fxyz(ee,g,d);
            //double SAll = S1 + S2 + S3;
            //Answer.Text = Convert.ToString(SAll);

            Answer.Items.Add($"s1 = {Fxyz(a, b, f)}\n");
            Answer.Items.Add ( $"s3 = {Fxyz(ee,g,d)}\n");
            Answer.Items.Add ( $"s2 = {Fxyz(g,f,c)}");
            //double S2 = Fxyz(g,f,c);
            //double S3 = Fxyz(ee,g,d);
            //double SAll = S1 + S2 + S3;
            //Answer.Text = Convert.ToString(SAll);

        }

    }
}
