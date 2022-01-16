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


namespace Lab14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Печь",
                Price = 10000,
                Image = "E:проекты",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Арбуз",
                Price = 500,
                Image = "C:проекты",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Телевизор",
                Price = 25000,
                Image = "E:проекты",
                ProductType = ProductTypes.Appliances
            });
            ListBox.ItemsSource = products;
        }
    }
}
