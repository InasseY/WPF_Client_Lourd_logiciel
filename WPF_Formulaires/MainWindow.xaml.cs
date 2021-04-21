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

namespace WPF_Formulaires
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string name { get; set; } = "Entrez votre nom";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Faire un bouton dans un nouveau projet Application WPF.
            // Ce bouton doit permettre de faire apparaitre un message de votre choix dans une nouvelle fenêtre (comme une alert en JavaScript). 
            MessageBox.Show("Hello Sunnny Girl");
        }


            private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            //Dans un nouveau projet Application WPF, demander son nom à l'utilisateur
            //et afficher un message du type "Bonjour [nom]" en utilisant un évènement Click. 
            MessageBox.Show("Hello"+" "+(txtName.Text));

        }

        private void NameInputButton_Click1(object sender, RoutedEventArgs e)
        {
            {
                name = messageText1.Text;
                NameLabel1.Content = $"Bonjour {name.ToString()}";
            }
        }
    }
}