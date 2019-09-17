using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] groceryList = new string[5];
            string search;
            int searchCount = 0;

            for (int i = 0; i < groceryList.Length; i++)
            {
                Console.Write($"Enter Grocery Item {i + 1}: ");
                groceryList[i] = Console.ReadLine();
            }

            Console.Write("Enter a string to search for: ");
            search = Console.ReadLine();

            foreach(string item in groceryList)
            {
                if (item.Contains(search))
                    searchCount++;
            }

            Console.WriteLine($"There are {searchCount} elements with the substring {search}");
            

            Console.ReadKey();
        }
    }
}
