using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainMenuSelect;

            Checkings checkings = new Checkings();
            do
            {
                Console.WriteLine("Welcome Please Make A Selection");
                Console.WriteLine("1 - Checking Account");
                Console.WriteLine("2 - Saving Account");
                Console.WriteLine("3 - Check Balance");
                Console.WriteLine("4 - Exit");
                mainMenuSelect = Console.ReadLine();

                if (mainMenuSelect == "1")
                {
                    checkings.CheckingsMenu();
                }
            } while (mainMenuSelect != "4");


           
        }
    }
}
