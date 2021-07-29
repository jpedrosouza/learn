using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class ListProductsPage : Page
    {
        ListView _productsListView;

        public ListProductsPage()
        {
            InitializeComponent();

            _productsListView = this.FindName("productsList") as ListView;
        }

        public void GetProducts()
        {
            DataTable data = DatabaseConfig.GetProducts();

            foreach (DataRowCollection product in data.Rows)
            {
          

            }
        }
    }
}
