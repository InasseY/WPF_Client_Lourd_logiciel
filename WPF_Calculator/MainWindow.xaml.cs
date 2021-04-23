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

namespace WPF_Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;
        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();
            second = Int32.Parse(TxtResult.Text);
            
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '/';
            TxtResult.Clear();
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '*';
            TxtResult.Clear();

        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '-';
            TxtResult.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '+';
            TxtResult.Clear();
        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            first = 0;
            second = 0;
            op = ' ';
            TxtResult.Text = "0";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(TxtResult.Text);
            int result = 0;

            if(op == '+')
            {
                result = first + second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            if (TxtResult.Text == "0") ;
            {
                TxtResult.Clear();
            }
            TxtResult.Text = result.ToString();
        }

        
    }
}

