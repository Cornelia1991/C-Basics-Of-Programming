using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string onSale;
            double money;

            Console.Write("Are drinks 2 For 1? ");
            onSale = Console.ReadLine().ToLower();


            //response to on sale
            if (onSale == "yes" || onSale == "no")
            {
                Console.Write("How much money do you have? ");
                money = Convert.ToDouble(Console.ReadLine());

                if (money >= 10)
                {
                    Console.WriteLine("Go Shopping");
                }
                else
                {
                    Console.WriteLine("Stay Home");
                }
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            Console.ReadKey();
        }
    }
}
