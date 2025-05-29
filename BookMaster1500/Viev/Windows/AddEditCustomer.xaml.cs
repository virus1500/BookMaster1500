using System.Windows;

namespace BookMaster1500.Viev.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditCustomer.xaml
    /// </summary>
    public partial class AddEditCustomer : Window
    {
        public AddEditCustomer()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
