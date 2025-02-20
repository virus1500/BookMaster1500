using System.Linq;
using System.Windows.Controls;

namespace BookMaster1500.Viev.Pages
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogePage.xaml
    /// </summary>
    public partial class BrowseCatalogePage : Page
    {
        public BrowseCatalogePage()
        {
            InitializeComponent();

            BookAuthorLv.ItemsSource = App.context.BookAuthor.ToList();
        }
    }
}
