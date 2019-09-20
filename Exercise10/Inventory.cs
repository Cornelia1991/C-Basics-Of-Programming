using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Inventory : Product
    {
        private int total;
        private List<Int32> productTotal = new List<Int32>();
        int[] totalArray;

        Inventory()
        {
            DisplayInventoy();
        }


        public void CalualateTotals()
        {
            for (int i = 0; i < count; i++)
            {
                total = priceArray[i] * quantityArray[i];
                productTotal.Add(total);
                totalArray = productTotal.ToArray();
            }
        }

        public void DisplayInventoy()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"You added {quantityArray[i]} {nameArray[i]} for a total of {priceArray[i]}");
            }
        }
    }
}
