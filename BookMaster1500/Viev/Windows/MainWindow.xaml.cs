using System.Windows;

namespace BookMaster1500.Viev.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BrowseKatalogMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CirculatoinMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }


        private void LogoutMi_Click_1(object sender, RoutedEventArgs e)
        {

        }

        // Способ навигации в WPF
        #region Оконная
        // 1. Оконная осуществляет открытие нового экхемпляра окна их другого окна или страницы
        // Алгоритм для реализации (Окно называется TestWindow.xaml)
        // - создать экземпляр окна TestWindow
        // - TestWindow testWindow = new TestWindow()
        // у экземпляра окна вызывается метод Show(). Данный метод открывает модальное окно (данное действие посзовлит пользоваться предыдущем окном). ShowDialog открывает диалоговое окно (нельзя взаимодействовать с предыдущем окном)
        // TestWindow.Show();
        #endregion
        // 2. Страничная

    }
}
