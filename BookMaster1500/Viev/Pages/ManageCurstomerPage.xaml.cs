using BookMaster1500.AppData;
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
        PagenationService<Customer> _customerPageination;
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

        private void Search_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Customer> seachResults = _customer.Where(customer => customer.Id.ToLower().Contains(SearchClientIDTb.Text.ToLower()) && customer.Name.ToLower().Contains(SearchNameTb.Text.ToLower())).ToList();

            _customerPageination = new PagenationService<Customer>(seachResults);

            CustomerLV.ItemsSource = _customerPageination.CurrentPageOfItems;
        }
    }
}
