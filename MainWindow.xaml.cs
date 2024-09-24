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

namespace kamil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int proizvedenie;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(one.Text);
            int b = Convert.ToInt32(two.Text);
            int c = Convert.ToInt32(two.Text);
            int Result = a + b + c;
           int proizvedenie = a * b * c;
            result.Text = "Сумма 3 чисел равно " + Result +"\nПроизведение 3 чисел " + proizvedenie;
        }


        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            int aa = Convert.ToInt32(one_Copy.Text);

            int P = aa + aa + aa + aa;

            int S = aa * aa;
            result_Copy.Text = "периметр квадрата =" + P + "\nПлощадь=" + S; 
        }
    }
}
