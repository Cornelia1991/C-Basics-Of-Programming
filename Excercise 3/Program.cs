using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizzaQuestion;

            do { 
                Console.WriteLine("Do you like pizza? (yes/no) ");
                pizzaQuestion = Console.ReadLine().ToLower();

                if (pizzaQuestion == "yes")
                {
                    Console.WriteLine("You Like Pizza!");
                    break;
                }
                else if (pizzaQuestion == "no")
                {
                    Console.WriteLine("I feel sorry for you");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Please Enter yes/no");
                }
            }
            while (pizzaQuestion != "yes" || pizzaQuestion != "no");
            Console.ReadKey();
        }
    }
}
