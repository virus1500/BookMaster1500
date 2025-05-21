using BookMaster1500.Model;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace BookMaster1500.Viev.Windows
{
    /// <summary>
    /// Логика взаимодействия для BookAuthorsDetails.xaml
    /// </summary>
    public partial class BookAuthorsDetails : Window
    {
        public BookAuthorsDetails(Book selectedAuthors)
        {
            InitializeComponent();

            AuthorsCmb.ItemsSource = selectedAuthors.BookAuthor;

            Title = $"Авторы книги \"{selectedAuthors.Title}\"";
        }

        private void AuthorsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataContext = AuthorsCmb.SelectedItem as BookAuthor;

            Author selectedAuthors = (AuthorsCmb.SelectedItem as BookAuthor).Author;

            OpenWikipediaTbl.Visibility = string.IsNullOrEmpty(selectedAuthors.Wikipedia) ? Visibility.Collapsed : Visibility.Visible;
        }

        private void OpenWikipediaHl_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(e.Uri.AbsoluteUri);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
