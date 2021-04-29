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
    /// Logique d'interaction pour ListCustomers.xaml
    /// </summary>
    public partial class ListCustomers : Page
    {
        agendaEntities dbj = new agendaEntities();
        public ListCustomers()
        {
            InitializeComponent();

            var cust = from d in dbj.Customers //afficher la liste des clients
                       select new
                       {
                           id = d.idCustomer,
                           Prénom = d.firstname,
                           Nom = d.lastname,
                           Email = d.mail,
                           Numéro = d.phoneNumber,
                           Budgets = d.budget,
                           RDV = d.Appointments
                       };
            foreach (var item in cust)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.Nom);
                Console.WriteLine(item.Prénom);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.Numéro);
                Console.WriteLine(item.Budgets);
                Console.WriteLine(item.RDV);
            }
            this.gridCustomers.ItemsSource = cust.ToList();
        }

        private void btn_load(object sender, RoutedEventArgs e)
        {

            this.gridCustomers.ItemsSource = dbj.Customers.ToList(); // actualiser la liste des clients 
        }

        private void gridCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if (this.gridCustomers.SelectedItem.GetType() == typeof(Customers))
            {
              

            }
        }

        private void btn_aclualise(object sender, RoutedEventArgs e)
        {
            var r = from d in dbj.Customers
                    where d.idCustomer == 1
                    select d;

            foreach (var item in r)
            {
                MessageBox.Show(item.firstname);
                item.firstname = "Client ajouté !";
            }
            dbj.SaveChanges();
        }
    }
}
    

