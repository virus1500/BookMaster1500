using BookMaster1500.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace BookMaster1500.Viev.Pages
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogePage.xaml
    /// </summary>
    public partial class BrowseCatalogePage : Page
    {
        List<Book> _books = App.context.Book.ToList();
        public BrowseCatalogePage()
        {
            InitializeComponent();
            // Загрузка данных из таблицы в список ListView
            BookAuthorLv.ItemsSource = _books;
        }

        private void SearchBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //Алгоритм поиска
            BookAuthorLv.ItemsSource = _books.Where(book => book.Title.ToLower().Contains(SearchByBookTitleTb.Text.ToLower()) && book.Authors.ToLower().Contains(SearchByAuthorNameTb.Text.ToLower()));

        }
    }
}
