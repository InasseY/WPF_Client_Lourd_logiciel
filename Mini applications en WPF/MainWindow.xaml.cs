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

namespace Mini_applications_en_WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int lives = 5;
        private int random = 100;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            random = rnd.Next(1,50) %100;
        }

        private void txbInput_Keydown(object sender, KeyEventArgs e)
        {
            if(lives == 0)
            {
                lblfrom.Content = "Tu as ";
                lblto.Content = "Perdu!";
                return;
            }
            if (e.Key == Key.Enter)
            {
                lives--;
                int userGuessed = Int32.Parse(txtInput.Text);
                if (userGuessed == random)
                {
                    lblfrom.Content = "Tu as ";
                    lblto.Content = "Gagné!";
                    return;
                }
                if(userGuessed < random)
                {
                    lblfrom.Content = "Trop";
                    lblto.Content = "petit";
                    
                }
                else
                {
                    lblfrom.Content = "Trop";
                    lblto.Content = "Grand";
                }
                lblstatus.Content = "Nombres d'essais: " + lives;
                if(lives <= 2)
                {
                    lblstatus.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
            }
        }
    }
}
