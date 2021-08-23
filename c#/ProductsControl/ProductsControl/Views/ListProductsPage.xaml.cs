using System.Data;
using System.Windows.Controls;
using ProductsControl.Configs;

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
