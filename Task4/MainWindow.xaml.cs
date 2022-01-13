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

namespace Task4
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
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDouble = rateDollar * sumDollar;
            resSum1.Text = resDouble.ToString();

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate2.Text);
            double sumDollar = Convert.ToDouble(sum2.Text);
            double resDouble = rateDollar * sumDollar;
            resSum2.Text = resDouble.ToString();

        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate3.Text);
            double sumDollar = Convert.ToDouble(sum3.Text);
            double resDouble = rateDollar * sumDollar;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate4.Text);
            double sumDollar = Convert.ToDouble(sum4.Text);
            double resDouble = rateDollar * sumDollar;
            resSum4.Text = resDouble.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double inchDouble = Convert.ToDouble(inch.Text);
            double resDouble = inchDouble * 0.0254;
            result1.Text = resDouble.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double footDouble = Convert.ToDouble(foot.Text);
            double resDouble = footDouble * 0.3048;
            result2.Text = resDouble.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double mileDouble = Convert.ToDouble(mile.Text);
            double resDouble = mileDouble * 1609.34;
            result3.Text = resDouble.ToString();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            double verstDouble = Convert.ToDouble(verst.Text);
            double resDouble = verstDouble * 1066.8;
            result4.Text = resDouble.ToString();
        }
    }
}
