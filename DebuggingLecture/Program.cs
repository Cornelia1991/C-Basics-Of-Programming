using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingLecture
{
    class Program
    {
        static void Main(string[] args)
        {

            //Manuel Error Handling
            //disadvantages: alot more code, only handles code that I am able to inticipate
            //the code is less readable

            //NEW KEYWORDS 
            //TryParse: converts string to an int TryParse(String, Int32)
            //out: used in TryParse(string s, out int result)
            //Converts the string representation of a number to its 32-bit signed integer equivalent. 
            //A return value indicates whether the conversion succeeded.

            int[] myArray = { 1, 2, 3};
            string selection;
            int parsedInteger;
            bool error = false;

            do
            {
                Console.Write("Eneter thae array index of the elementyou wish to view: ");
                selection = Console.ReadLine();
                if (int.TryParse(selection, out parsedInteger))
                {
                    if (parsedInteger >= 0 && parsedInteger <= myArray.Length - 1)
                    {
                        error = false;
                        Console.WriteLine(myArray[parsedInteger]);
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine($"{selection} is not a valid index for the array. Please try again");
                    }
                }
                else
                {
                    error = true;
                    Console.WriteLine($"{selection} is not an integer. Please try again");
                }
            } while (error);
            Console.ReadKey();
        }
    }
}
