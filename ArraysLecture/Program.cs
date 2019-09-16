using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumberArray = {2, 5, 7};
            int[] myNumberArray2 = new int[3]; // no value specified, default value 0

            Console.WriteLine(myNumberArray[0]);

            myNumberArray[1] = 12; //replace 5 with 12

            for (int i = 0; i < myNumberArray.Length; i++)
            {
                Console.WriteLine(myNumberArray[i]);
            }

            foreach(int number in myNumberArray)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
