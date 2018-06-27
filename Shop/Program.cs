
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopWW.PrintShopInfo();
            ShopWW shop = new ShopWW();
            shop.Address = "Кунаева 24";
            shop.Phone = " 8 777 3483493";

            Catalog catalog = new Catalog() { Name = "Смартфоны: " };

            Product product = new Product();
            product.Name = "Смартфон Samsung Galaxy s9";
            product.Manufacture = "Xiaomi";
            product.Price = 79800;
            product.TypeSecurity = TypeSecurity.type1;

            catalog.Products.Add(product);
            shop.Catalogs.Add(catalog);
            
            shop.PrintCatalog();
        }
    }
}
