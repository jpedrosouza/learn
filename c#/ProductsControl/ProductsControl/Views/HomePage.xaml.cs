using System.Windows;
using System.Windows.Controls;

namespace ProductsControl.Views
{
    public partial class HomePage : Page
    {

        MainWindow mainWindow;

        public HomePage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void NavigateToAddProductPage(object sender, RoutedEventArgs e)
        {
            mainWindow.NavigateToAddProductPage();
        }

        private void NavigateToListProductsPage(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new ListProductsPage();
        }

        private void CloseApplication(object sender, RoutedEventArgs e)
        {
            mainWindow.CloseApplication();
        }
    }
}
