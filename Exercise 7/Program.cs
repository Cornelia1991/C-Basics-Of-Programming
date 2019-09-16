using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise us a method to submit 3 numbers

            int firstInt;
            int secondInt;
            int thirdInt;
            int sum;

            do
            {
                //three parameters
                Console.Write("Enter and Integer: ");
                firstInt = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a second Integer: ");
                secondInt = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a third Integer: ");
                thirdInt = Convert.ToInt32(Console.ReadLine());

                sum = AddOfThree(firstInt, secondInt, thirdInt);

                Console.WriteLine("the sum of the three integers is " + sum);


                //four parameters
                Console.Write("Enter and Integer: ");
                firstInt = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a second Integer: ");
                secondInt = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a third Integer: ");
                thirdInt = Convert.ToInt32(Console.ReadLine());

                AddOfThree(firstInt, secondInt, thirdInt, ref sum);
                Console.WriteLine("The sum of the three integers is " + sum);
            }
            while (true );
        }

        static int AddOfThree(int x, int y, int z)
        {
            return x + y + z;
        }


        //add three parameters and stores the sum in the reference paramter
        static void AddOfThree(int x, int y, int z, ref int sum)
        {
            sum = x + y + z;
        }
    }
}
