using BookMaster1500.Model;
using BookMaster1500.Viev.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace BookMaster1500.Viev.Pages
{
    /// <summary>
    /// Логика взаимодействия для ManageCurstomerPage.xaml
    /// </summary>
    public partial class ManageCurstomerPage : Page
    {
        List<Customer> _customer = App.context.Customer.ToList();
        public ManageCurstomerPage()
        {
            InitializeComponent();
            CustomerLV.ItemsSource = _customer;
        }

        private void AddBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddEditCustomer addEditCustomer = new AddEditCustomer();
            addEditCustomer.ShowDialog();
        }
    }
}
