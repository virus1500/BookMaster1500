using BookMaster1500.AppData;
using BookMaster1500.Model;
using BookMaster1500.Viev.Windows;
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
        //Определяем объект пагинации
        PagenationService _booksPageination;
        public BrowseCatalogePage()
        {
            InitializeComponent();
            // Загрузка данных из таблицы в список ListView
            BookAuthorLv.ItemsSource = _books;
        }

        private void SearchBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchByBookTitleTb.Text) && string.IsNullOrWhiteSpace(SearchByAuthorNameTb.Text) && string.IsNullOrWhiteSpace(SearchByBookSubjectTb.Text))
            {
                _booksPageination = new PagenationService(_books);

            }
            else
            {

                //Алгоритм поиска
                List<Book> seachResults = _books.Where(book => book.Title.ToLower().Contains(SearchByBookTitleTb.Text.ToLower()) && book.Authors.ToLower().Contains(SearchByAuthorNameTb.Text.ToLower())).ToList();

                _booksPageination = new PagenationService(seachResults);

                //bookauthorlv.itemssource = _books.where(
            }
            BookAuthorLv.ItemsSource = _booksPageination.CurrentPageOfBooks;

            TotalPagesTbl.DataContext = TotalBooksTbl.DataContext = _booksPageination;
            _booksPageination.UpdaitPaginationButtons(NextBookBtn, PreviousBookBtn);
            CurrentPageTb.Text = _booksPageination.CurrentPageNumber.ToString();


            SearchResultsGrid.Visibility = System.Windows.Visibility.Visible;
        }

        private void PreviousBookBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BookAuthorLv.ItemsSource = _booksPageination.PreviousPage();
            _booksPageination.UpdaitPaginationButtons(NextBookBtn, PreviousBookBtn);
            CurrentPageTb.Text = _booksPageination.CurrentPageNumber.ToString();
        }

        private void CurrentPageTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(CurrentPageTb.Text, out int pageNumber) && pageNumber >= 1 && pageNumber <= _booksPageination.TotalPages)
            {
                BookAuthorLv.ItemsSource = _booksPageination.SetCurrenPage(pageNumber);
                _booksPageination.UpdaitPaginationButtons(NextBookBtn, PreviousBookBtn);
            }
        }

        private void NextBookBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BookAuthorLv.ItemsSource = _booksPageination.NextPage();
            _booksPageination.UpdaitPaginationButtons(NextBookBtn, PreviousBookBtn);
            CurrentPageTb.Text = _booksPageination.CurrentPageNumber.ToString();
        }

        private void BookAuthorLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book selectedBook = BookAuthorLv.SelectedItem as Book;

            BookDetailsGrid.DataContext = selectedBook;
        }

        private void AuthorDetailsHl_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BookAuthorsDetails bookAuthorsDetailsWindow = new BookAuthorsDetails();
            bookAuthorsDetailsWindow.ShowDialog();
        }
    }
}
