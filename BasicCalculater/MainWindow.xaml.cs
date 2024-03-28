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

namespace BasicCalculater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sum_Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int one = int.Parse(num1.Text);
                int two = int.Parse(num2.Text);
                int sum = one + two;
                rslt.Text = sum.ToString();
            }
            catch (Exception )
            {
                MessageBox.Show("enter a valid integer pls");
            }
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void num2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Mul_Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int one = int.Parse(num1.Text);
                int two = int.Parse(num2.Text);
                int sum = one * two;
                rslt.Text = sum.ToString();
            }
            catch (Exception )
            {
                MessageBox.Show("enter valid integer pls");
            }
        }

        private void Div_Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int one = int.Parse(num1.Text);
                int two = int.Parse(num2.Text);
                if (two == 0)
                {
                    MessageBox.Show("cant divide by zero");
                }
                else
                {
                    double sum = (double)one / two;
                    rslt.Text = sum.ToString();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("enter valid integer pls");
            }
        }

        private void Sub_Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int one = int.Parse(num1.Text);
                int two = int.Parse(num2.Text);
                int sum = one - two;
                rslt.Text = sum.ToString();
            }
            catch (Exception )
            {
                MessageBox.Show("enter valid integer pls");
            }
        }
    }
}
