using BookMaster1500.Model;
using System.Collections.Generic;
using System.Linq;

namespace BookMaster1500.AppData
{
    public class PagenationService
    {
        //Определяем поля для хранения данных
        private const int PageSize = 50;
        private readonly List<Book> _books;
        private int _currentPageIndex;
        private int _currentPageNumber;


        //Определяем свойства для  вычисления и хранения данных
        public int BooksCount => _books.Count;
        public int TotalPages => (BooksCount + PageSize - 1) / PageSize;

        public List<Book> CurrentPageOfBooks => _books.Skip(_currentPageIndex * PageSize).Take(PageSize).ToList();
        //Определеяем конструктор класса для создания объекта пагинации, в ко нструстор передаем полный список книг
        public PagenationService(List<Book> books)
        {
            _books = books;
        }
        // Определяем методы класса для реалезации действий объекта 
        public List<Book> NextPage()
        {
            if (_currentPageIndex < TotalPages - 1)
            {
                _currentPageIndex++;
            }

            return CurrentPageOfBooks;

        }
        public List<Book> PreviousPage()
        {
            if (_currentPageIndex > 0)
            {
                _currentPageIndex--;
            }
            return CurrentPageOfBooks;
        }
    }
}
