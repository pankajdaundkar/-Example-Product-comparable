using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Product_comparable
{
    public class Product:IComparable<Product>
    {
        public string Name;
        public int Price;

        public Product(string name, int price)
        {
           this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
           if (this.Price < other.Price)
            {
                return -1;
            }
           else if (this.Price > other.Price)
            {
                return 1;
            }
           else
            {
                return 0;
            }

        }

    }
   
    
    
}
