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

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ShopEntities db = new ShopEntities();

            var docs = from d in db.PRODUCTS
                       select new
                       {
                           ProductName = d.product_name,
                           ProductBrand = d.product_brand,
                       };

            foreach (var item in docs)
            {
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductBrand);
            }

            this.GridFillName.ItemsSource = docs.ToList();
            // Jeżeli bede chciała zmienić nagłówki na ładniej napisane albo coś odjąć to 
            // 25/ Zaheer
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //context.SaveChanges();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ShopEntities db = new ShopEntities();

            PRODUCT productObject = new PRODUCT()
            {
                  product_brand = "Braun",
                  product_category = "Epilator",
                  product_name = "SilkEpil"
            };

            db.PRODUCTS.Add(productObject);
            db.SaveChanges();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            ShopEntities db = new ShopEntities();

            var docs = from d in db.PRODUCTS
                       select new
                       {
                           ProductName = d.product_name,
                           ProductBrand = d.product_brand,
                       }; 

            foreach (var item in docs)
            {
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductBrand);
            }

            this.GridFillName.ItemsSource = docs.ToList();
            // Jeżeli bede chciała zmienić nagłówki na ładniej napisane albo coś odjąć to 
            // 25/ Zaheer
        }
    }
}