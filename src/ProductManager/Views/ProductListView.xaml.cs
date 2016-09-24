using ProductManager.Data;
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

namespace ProductManager.Views
{
    /// <summary>
    /// Interaction logic for ProductListView.xaml
    /// </summary>
    public partial class ProductListView : Page
    {
        private List<Product> _products;

        public ProductListView()
        {
            InitializeComponent();

            _products = new List<Product>();

            _products.Add(new Product {
                Name = "Shirt",
                Price = 99
            } );

            _products.Add(new Product
            {
                Name = "Pants",
                Price = 56.66m
            });

            LVProducts.ItemsSource = _products;
        }

    }
}
