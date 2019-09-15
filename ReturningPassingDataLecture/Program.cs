using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningPassingDataLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //return string literal
            Console.WriteLine("You're learning how to program");
            Console.WriteLine(ReturnCongratMessage());

            //data passed into the method
            int result = NumberSquared(12);
            Console.WriteLine(result); //returns 144

            //passing in mutilple data
            Console.WriteLine(MuiltipleData(7,10));


            Console.ReadKey();
        }
        // return string literal
        static string ReturnCongratMessage()
        {
            return "Congratulations";
        }

        //data passed into the method (returns and expects and int value)
        static int NumberSquared(int x)
        {
            return x * x;
        }

        //passing in mutilple data
        static int MuiltipleData(int x, int y)
        {
            return x + y;
        }
    }
}
