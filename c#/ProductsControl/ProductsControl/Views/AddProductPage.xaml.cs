using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProductsControl.Configs;
using ProductsControl.Models;

namespace ProductsControl.Views
{
    public partial class AddProductPage : Page
    {

        TextBox _productName, _productInventory, _productPrice;

        public AddProductPage()
        {
            InitializeComponent();

            DatabaseConfig.CreateDatabase();
            DatabaseConfig.CreateProductsTable();

            _productName = this.FindName("productName") as TextBox;
            _productInventory = this.FindName("productInventory") as TextBox;
            _productPrice = this.FindName("productPrice") as TextBox;

        }

        private void BackToHome(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
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
