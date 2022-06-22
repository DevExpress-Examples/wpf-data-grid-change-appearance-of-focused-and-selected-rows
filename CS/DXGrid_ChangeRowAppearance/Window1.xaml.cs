using System.Collections.ObjectModel;
using System.Windows;

namespace DXGrid_ChangeRowAppearance {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = Products.GetData();
        }
        public class Products {
            public static ObservableCollection<Product> GetData() {
                ObservableCollection<Product> data = new ObservableCollection<Product>();
                data.Add(new Product() {
                    ProductName = "Chai",
                    UnitPrice = 18,
                    UnitsOnOrder = 10
                });
                data.Add(new Product() {
                    ProductName = "Ipoh Coffee",
                    UnitPrice = 36.8,
                    UnitsOnOrder = 12
                });
                data.Add(new Product() {
                    ProductName = "Outback Lager",
                    UnitPrice = 12,
                    UnitsOnOrder = 25
                });
                data.Add(new Product() {
                    ProductName = "Boston Crab Meat",
                    UnitPrice = 18.4,
                    UnitsOnOrder = 18
                });
                data.Add(new Product() {
                    ProductName = "Konbu",
                    UnitPrice = 6,
                    UnitsOnOrder = 24
                });
                return data;
            }
        }
        public class Product {
            public string ProductName { get; set; }
            public double UnitPrice { get; set; }
            public int UnitsOnOrder { get; set; }
        }
    }
}