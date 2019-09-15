using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            int yourAge;
            string friendName;
            int friendAge;
            int diffOfAge;

            Console.Write("Enter Your Name: ");
            yourName = Console.ReadLine();
            Console.Write("Enter Your Age");
            //convert your age string to int
            yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {yourName} and you are {yourAge}.");
            Console.WriteLine();

            Console.Write("Enter Your Friend's Name: ");
            friendName = Console.ReadLine();
            Console.Write("Enter Your Friend's Age: ");
            //convert frien age to int
            friendAge = Convert.ToInt32(Console.ReadLine());;
            Console.WriteLine($"Your friend's name is {friendName}, your friend's age is {friendAge}.");
            Console.WriteLine();

            diffOfAge = yourAge - friendAge;
            Console.WriteLine($"The age difference between you and {friendName} is {diffOfAge}");

            Console.ReadKey();


        }
    }
}
