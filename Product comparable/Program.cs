using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_comparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Mobile = new Product("Mobile", 12000);
            Product Laptop = new Product("Laptop", 30000);

            int result = Mobile.CompareTo(Laptop);

            if(result < 0) 
            {
                Console.WriteLine("Mobile has less price than Laptop");
            }
            else if(result > 0) 
            {
                Console.WriteLine("Mobile has more price than Laptop");
            }
            else
            {
                Console.WriteLine("Mobile and Laptop has same price");
            }
        }
    }
}
