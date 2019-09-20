using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    static class Inventory
    {
        static private List<Product> product; 

        static Inventory()
        {
            product = new List<Product>();
        }

        static public void AddProduct(Product p)
        {
            product.Add(p);
        }

        static public void DisplayInventory()
        {
            double totalinventoryValue = 0;
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine("*****************************************\n");
            foreach (Product p in product)
            {
                p.DisplayInfo();
                Console.WriteLine();
                totalinventoryValue += p.GetTotalValue();
            }

            Console.WriteLine($"Total inventory value: ${totalinventoryValue.ToString("F")}");
        }
    }
}