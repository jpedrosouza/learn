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

namespace ProductsControl.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        TextBox textBoxSearchProduct;
        AddProductWindow addProductWindow = new AddProductWindow();

        public MainWindow()
        {
            InitializeComponent();

            textBoxSearchProduct = this.FindName("productSearch") as TextBox;

            textBoxSearchProduct.Text = "Hello World!";
        }

        private void CloseApplication(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NavigateToAddProductPage(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            this.Content = addProductWindow;
        }
    }
}
