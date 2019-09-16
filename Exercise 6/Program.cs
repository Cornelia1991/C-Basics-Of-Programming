using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find Prime Number
            //A prime number is a whole number greater than 1 whose only 
            //factors are 1 and itself.

            int userNum;

            do
            {
                Console.WriteLine("Enter a Prime Numer (Press 1 to exit): ");
                userNum = Convert.ToInt32(Console.ReadLine());

                if (PrimeNum(userNum) == true)
                {
                    Console.WriteLine(userNum + " is a prime number");
                }
                else if (PrimeNum(userNum) == false)
                {
                    Console.WriteLine(userNum + " is not a prime number");
                }
            }
            while (Convert.ToInt32(userNum) != 1);



            Console.ReadKey();

        }

        static bool PrimeNum(int x)
        {
            // got help with this prime number equation from tutoral poin
            int a = 0;

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
               return true;
            }
            else
            {
                return false;
            }


            // The same answer in much shorter code for the instructor
            //bool isPrime = true;
            //for (int i = 2; i < nameof x; int++)
            //{
            //    if (x =% if == 0)
            //    {
            //       isPrime = false;
            //    }
            //}
        }
    }
}
