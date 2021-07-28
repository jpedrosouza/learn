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
    public partial class AddProductWindow : Page
    {

        TextBox productName, productInventory, productPrice;

        public AddProductWindow()
        {
            InitializeComponent();

            productName = this.FindName("productName") as TextBox;
            productInventory = this.FindName("productInventory") as TextBox;
            productPrice = this.FindName("productPrice") as TextBox;
        }

        private void BackToHome(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Content = mainWindow;
        }

        /// <summary>
        /// Save product in SQLite internal database.
        /// </summary>

        private void SaveProduct(object sender, RoutedEventArgs e)
        {
            Product product = new Product();

            product.name = productName.Text;
            productInventory = int.Parse(productInventory.Text);
            productPrice = double.Parse(productPrice.Text);

            DatabaseConfig.AddProduct(product);
        }
    }
}
