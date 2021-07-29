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
    public partial class HomePage : Page
    {
        public HomePage()
        { }

        private void NavigateToAddProductPage(object sender, RoutedEventArgs e)
        {
            AddProductPage addProductPage = new AddProductPage();
            this.Content = addProductPage;
        }

        private void NavigateToListProductsPage(object sender, RoutedEventArgs e)
        {
            ListProductsPage listProductsPage = new ListProductsPage();
            this.Content = listProductsPage;
        }
    }
}
