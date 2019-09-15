using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOptiionParementersLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //overloading
            int resultInteger;
            double resultDouble;

            resultInteger = NumbersAdded(3, 5); 
            resultDouble = NumbersAdded(4.3, 7.9);
            resultInteger = NumbersAdded(7, 2, 4);

            Console.WriteLine(resultInteger);
            Console.WriteLine(resultDouble);

            //optional
            Console.WriteLine(RaiseToPower(2)); //2^2 =4
            Console.WriteLine(RaiseToPower(2, 3)); //2^3=8

            Console.ReadKey();
        }
        //overloading
        static int NumbersAdded(int x, int y)
        {
            return x + y;
        }
        static double NumbersAdded(double x, double y)
        {
            return x + y;
        }

        static int NumbersAdded(int x, int y, int z)
        {
            return x + y + z;
        }

        //optional
        static int RaiseToPower(int baseNumber, int power = 2) //int power = 2 is a default value 
        {
            int result = 1;

            for (int i = 0; i <= power; i++)
            {
                result *= baseNumber;
            }
            return baseNumber;
        }
    }
}
