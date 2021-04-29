using Agenda_Again.Models;
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

namespace Agenda_Again
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        agendaEntities dbj = new agendaEntities();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void listBro (object sender, RoutedEventArgs e)
        {
            Main.Content = new ListBrokers();
           
        }
        private void addBro(object sender, RoutedEventArgs e)
        {
            Main.Content = new addBroker();

        }
        private void listCust(object sender, RoutedEventArgs e)
        {
            Main.Content = new ListCustomers();

        }
        private void addCust(object sender, RoutedEventArgs e)
        {
            Main.Content = new addCustomer();

        }
    }
}
