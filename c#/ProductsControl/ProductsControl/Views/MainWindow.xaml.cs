using ProductsControl.Configs;
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

        public MainWindow()
        {
            InitializeComponent();
            BackToHome();
        }

        /// <summary>
        /// Set HomePage in Window.
        /// </summary>

        public void BackToHome()
        {
            this.Content = new HomePage(this);
        }

        public void NavigateToAddProductPage()
        {
            this.Content = new AddProductPage(this);
        }

        /// <summary>
        /// Close Application.
        /// </summary>

        public void CloseApplication()
        {
            this.Close();
        }
    }
}
