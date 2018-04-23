// Developer Express Code Central Example:
// How to change the appearance of a focused data row and selected rows
// 
// This example demonstrates how to use the View's RowStyle property to apply
// custom styles to focused and selected rows. To identify whether a row is focused
// and selected, the attached IsFocusedRow and IsSelected properties are used.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2066

using System.Windows;
using System.Collections.Generic;

namespace DXGrid_ChangeRowAppearance {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = Products.GetData();
        }
        public class Products {
            public static List<Product> GetData() {
                List<Product> data = new List<Product>();
               data.Add(new Product() { ProductName = "Chai", 
                    UnitPrice = 18, UnitsOnOrder = 10 });
                data.Add(new Product() { ProductName = "Ipoh Coffee",
                    UnitPrice = 36.8, UnitsOnOrder = 12 });
                data.Add(new Product() { ProductName = "Outback Lager",
                    UnitPrice = 12, UnitsOnOrder = 25 });
                data.Add(new Product() { ProductName = "Boston Crab Meat",
                    UnitPrice = 18.4, UnitsOnOrder = 18 });
                data.Add(new Product() { ProductName = "Konbu",
                    UnitPrice = 6, UnitsOnOrder = 24 });
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
