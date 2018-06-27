using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
   public class Catalog
    {
        public string Name { get; set; }
        public List<Product> Products = new List<Product>();

    }
}
