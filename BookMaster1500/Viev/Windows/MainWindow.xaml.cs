using BookMaster1500.Viev.Pages;
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

            LogoutMi.Visibility = Visibility.Collapsed;
        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void BrowseKatalogMi_Click(object sender, RoutedEventArgs e)
        {
            MaifFrm.Navigate(new BrowseCatalogePage());
        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            MaifFrm.Navigate(new ManageCurstomerPage());
        }

        private void CirculatoinMi_Click(object sender, RoutedEventArgs e)
        {
            MaifFrm.Navigate(new CirculationPage());
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {
            MaifFrm.Navigate(new ReportsPage());
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
        #region
        // 2. Страничная
        // Осуществляет открытие страниц внутри элемента Fraim
        // Алгоритм для реализаии 
        // - определить место для элемента Fraim (данный элемент принимает и отображает страницу)
        // - дать имя фрейму в XAML коде
        // - для навигации обратиться к файлу вызвать метод Navigate и передать в кчестве значения экземпляр страницы
        // MainFrm.Navigate(new TestPage());
        #endregion
    }
}
