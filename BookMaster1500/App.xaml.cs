using BookMaster1500.Model;
using System.Windows;

namespace BookMaster1500
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Создаём контекст данных
        public static BookMasterEntities context = new BookMasterEntities();
    }
}
