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
    /// Logique d'interaction pour addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Page
    {
        agendaEntities dbj = new agendaEntities();
        public addCustomer()
        {
            InitializeComponent();

        }

        private void Add(object sender, RoutedEventArgs e) // ajouter de nouveaux clients 
        {
            agendaEntities dbj = new agendaEntities();

            Customers custobjt = new Customers()
            {
                firstname = txtName.Text,
                lastname = txtfirstName.Text,
                mail = email.Text,
                phoneNumber = phoneNumber.Text,
                budget = Int32.Parse(budget.Text)
                
            };          
            dbj.Customers.Add(custobjt);
            dbj.SaveChanges();
        }
    }
}
