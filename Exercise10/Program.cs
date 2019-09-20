using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            //Inventory inventory = new Inventory();

            string menuOption;
            do
            {
                Console.WriteLine("Choose an option from the menu");
                Console.WriteLine("1 - Enter Product");
                Console.WriteLine("2 - Display Inventory");
                Console.WriteLine("3 - Exit");
                menuOption = Console.ReadLine();

                if (menuOption == "1")
                {
                    product.ProductInfo();
                }
                else if (menuOption == "2")
                {
                    //Inventory();
                }
                else if (menuOption == "3")
                {
                    Console.WriteLine("BYE BYE");
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }while (menuOption != "3");

            Console.ReadKey();
        }
    }
}
