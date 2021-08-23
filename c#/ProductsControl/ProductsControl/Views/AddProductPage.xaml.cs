using System.Windows;
using System.Windows.Controls;
using ProductsControl.Configs;
using ProductsControl.Models;

namespace ProductsControl.Views
{
    public partial class AddProductPage : Page
    {

        MainWindow mainWindow;
        TextBox _productName, _productInventory, _productPrice;

        public AddProductPage(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            _productName = this.FindName("productName") as TextBox;
            _productInventory = this.FindName("productInventory") as TextBox;
            _productPrice = this.FindName("productPrice") as TextBox;

        }

        private void BackToHome(object sender, RoutedEventArgs e)
        {
            mainWindow.BackToHome();
        }

        /// <summary>
        /// Save product in SQLite internal database.
        /// </summary>

        private void SaveProduct(object sender, RoutedEventArgs e)
        {
            Product product = new Product();

            product.name = _productName.Text;
            product.inventory = int.Parse(_productInventory.Text);
            product.price = double.Parse(_productPrice.Text);

            DatabaseConfig.AddProduct(product);
        }
    }
}
