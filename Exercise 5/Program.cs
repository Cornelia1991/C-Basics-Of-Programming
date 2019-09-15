using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name:  ");
            
            Console.WriteLine("Hello"+ NameEntered());

            Console.Write("Enter another name:  ");
            Console.WriteLine("Hello " + NameEntered());

            Console.Write("Enter a third name:  ");
            Console.WriteLine("Hello " + NameEntered() + " How are you doing today?");

            Console.ReadKey();
        }

        static string NameEntered()
        {
            return Console.ReadLine();  
        }
    }
}
