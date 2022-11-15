using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace IndependentWork13WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Яблоки",
                ProdPrice = 145,
                ProdImage = "Data/Яблоки.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Лимоны",
                ProdPrice = 112,
                ProdImage = "Data/Лимоны.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Манго",
                ProdPrice = 210,
                ProdImage = "Data/Манго.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Фен",
                ProdPrice = 1450,
                ProdImage = "Data/Фен.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Утюг",
                ProdPrice = 1875,
                ProdImage = "Data/Утюг.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Чайник",
                ProdPrice = 1928,
                ProdImage = "Data/Чайник.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
