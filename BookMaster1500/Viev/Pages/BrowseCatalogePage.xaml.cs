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
        List<BookAuthor> _bookAuthors = App.context.BookAuthor.ToList();
        public BrowseCatalogePage()
        {
            InitializeComponent();
            // Загрузка данных из таблицы в список ListView
            BookAuthorLv.ItemsSource = _bookAuthors;
        }

        private void SearchBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //Алгоритм поиска
            BookAuthorLv.ItemsSource = _bookAuthors.Where(bookAuthors => bookAuthors.Book.Title.ToLower().Contains(SearchByBookTitleTb.Text.ToLower()) && bookAuthors.Author.Name.ToLower().Contains(SearchByAuthorNameTb.Text.ToLower()));
        }
    }
}
