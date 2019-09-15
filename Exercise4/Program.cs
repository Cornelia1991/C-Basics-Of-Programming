using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string doorNumber;

            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine("Enter a Door Number 1 - 5: ");
                doorNumber = Console.ReadLine();

                switch (doorNumber)
                {
                    case "1":
                        Console.WriteLine("You Win Movie Tickets");
                        break;
                    case "2":
                        Console.WriteLine("You Win A Pair of  Socks");
                        break;
                    case "3":
                        Console.WriteLine("You Win A Car");
                        break;
                    case "4":
                        Console.WriteLine("You Win A Hug");
                        break;
                    case "5":
                        Console.WriteLine("You Win A Vaction");
                        break;
                    default:
                        Console.WriteLine("Invalid: You Don't Win Anything");
                        break;
                }
                Console.WriteLine($"You have {i} attemps reamining");
            }
            Console.ReadKey();
        }
    }
}
