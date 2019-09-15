using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToMethodsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            returnType Name (perameters)
            {
                //do this
            }

             */

            // methods are the same thing as functions in other lanuages

            Console.WriteLine("You're learning how to program!");
            PrintCongrats();

            Console.WriteLine("You are doing well!");
            PrintCongrats();

            Console.WriteLine("You are going to be rich!");
            PrintCongrats();

            Console.ReadKey();
        }

        //basic method does not return or pass data (void with no perameters)
        static void PrintCongrats()
        {
            Console.WriteLine("Congratulations!!!!!");
        }
    }
}
