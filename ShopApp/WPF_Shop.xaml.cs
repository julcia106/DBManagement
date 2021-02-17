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
using System.Windows.Shapes;

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for WPF_Shop.xaml
    /// </summary>
    public partial class WPF_Shop : Window
    {
        public WPF_Shop()
        {
            InitializeComponent();

            //ShopEntities db = new ShopEntities();

            //var docs = from d in db.PRODUCTS select d;

            //foreach (var item in docs)
            //{
            //    Console.WriteLine(item.id);
            //    Console.WriteLine(item.product_name);
            //    Console.WriteLine(item.product_description);
            //}
        }
    }
}
