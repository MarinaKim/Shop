using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public enum TypeSecurity { type1, type2, type3}
    public class Product
    {
        //цепочка конструкторов
        public Product():this(0)
        {

        }
        public Product(double Price):this(Price,"")
        {
            //this.Price = Price;
        }
        public Product(double Price, string Name):this(Price,Name,"")

        {
            //this.Price = Price;
            //this.Name = Name;
        }
        public Product(double Price, string Name, string Manufacture)
        {
            this.Price = Price;
            this.Name = Name;
            this.Manufacture = Manufacture;

        }
        private double Price_, PriceInShop_;
        public double Price {
            get { return Price_; }
            set {
                if (value < 0)
                    Price_ = 0;
                else
                {
                    Price_ = value;
                    PriceInShop = PriceInShop - PriceInShop * 0.03;
                }
            }}
        public double PriceInShop {
            get { return PriceInShop_; }
            set {
                if (value < 0)
                    PriceInShop_ = 0;
                else
                    PriceInShop_ = value;
            } }
        public string Name { get; set; }
        public string Manufacture {get;set;}
        public string Color { get; set; }
        public TypeSecurity TypeSecurity { get; set; }

        public void GetProductInfo()
        {
            Console.WriteLine("{0}\t{1}", Name, Price);
        }

    }
}
