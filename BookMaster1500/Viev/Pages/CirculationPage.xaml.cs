using BookMaster1500.AppData;
using BookMaster1500.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BookMaster1500.Viev.Pages
{
    /// <summary>
    /// Логика взаимодействия для CirculationPage.xaml
    /// </summary>
    public partial class CirculationPage : Page
    {
        PagenationService<Circulation> _circulationPagenation;
        List<Circulation> _circulations = App.context.Circulation.ToList();
        public CirculationPage()
        {
            InitializeComponent();
            CurculatuonLv.ItemsSource = _circulations;
        }

        private void CirculationBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Circulation> searchResults = _circulations.Where(circulation => circulation.CustomerId.ToLower().Contains(ClientIDTb.Text.ToLower())).ToList();

            _circulationPagenation = new PagenationService<Circulation>(searchResults);

            CurculatuonLv.ItemsSource = _circulationPagenation.CurrentPageOfItems;
            HistoryCustomerLv.ItemsSource = _circulationPagenation.CurrentPageOfItems;
        }

        private void CurculatuonLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Circulation selectedBook = ClientIDTb. as Circulation;

            //LeftGrid.DataContext = selectedBook;
        }
    }
}
