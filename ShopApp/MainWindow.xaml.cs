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

            var docs = from d in db.PRODUCTS select d;

            // wyswietla w konsoli
            foreach (var item in docs)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.product_name);
                Console.WriteLine(item.product_description);
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
                //id = 7,
                product_brand = txtBrand.Text,
                product_category = txtCategory.Text,
                product_name = txtName.Text,
                product_description = txtDescription.Text,
                //product_discount = txtDiscount.Text,
                //product_price = txtPrice.Text,
                //profit_for_shop = ,
                //quantity_in_stock = 10,
                //quantity_sold = 200,
            };

            db.PRODUCTS.Add(productObject);
            db.SaveChanges();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            ShopEntities db = new ShopEntities();

            var docs = from d in db.PRODUCTS select d;

            // wyświetla w konsoli
            foreach (var item in docs)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.product_name);
                Console.WriteLine(item.product_description);
            }

            this.GridFillName.ItemsSource = db.PRODUCTS.ToList();
            // Jeżeli bede chciała zmienić nagłówki na ładniej napisane albo coś odjąć to 
            // 25/ Zaheer
        }
    }
}