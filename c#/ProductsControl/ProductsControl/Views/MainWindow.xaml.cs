using System.Windows;

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
