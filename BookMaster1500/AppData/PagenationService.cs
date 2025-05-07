using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace BookMaster1500.AppData
{
    public class PagenationService<T>
    {
        //Определяем поля для хранения данных
        private const int PageSize = 50;
        private readonly List<T> _items;
        private int _currentPageIndex = 0;
        private int _currentPageNumber = 1;



        //Определяем свойства для  вычисления и хранения данных
        public int CurrentPageNumber
        {
            get
            {
                return _currentPageNumber = _currentPageIndex + 1;
            }
            set
            {
                _currentPageNumber = value;
                _currentPageIndex = value - 1;
            }
        }
        public int ItemsCount => _items.Count;
        public int TotalPages => (ItemsCount + PageSize - 1) / PageSize;

        public List<T> CurrentPageOfItems => _items.Skip(_currentPageIndex * PageSize).Take(PageSize).ToList();
        //Определеяем конструктор класса для создания объекта пагинации, в ко нструстор передаем полный список книг
        public PagenationService(List<T> items)
        {
            _items = items;
        }
        // Определяем методы класса для реалезации действий объекта 
        public List<T> NextPage()
        {
            if (_currentPageIndex < TotalPages - 1)
            {
                _currentPageIndex++;
            }

            return CurrentPageOfItems;

        }
        public List<T> PreviousPage()
        {
            if (_currentPageIndex > 0)
            {
                _currentPageIndex--;
            }
            return CurrentPageOfItems;
        }
        public void UpdaitPaginationButtons(Button nextBtn, Button previousBtn)
        {
            nextBtn.IsEnabled = _currentPageIndex < TotalPages - 1;
            previousBtn.IsEnabled = _currentPageIndex > 0;
        }
        public List<T> SetCurrenPage(int pageNumber)
        {
            CurrentPageNumber = pageNumber;

            return CurrentPageOfItems;
        }
    }
}
