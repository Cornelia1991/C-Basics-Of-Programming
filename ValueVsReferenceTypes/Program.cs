using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = {1,2,3,};
            int[] myArray2;

            myArray2 = myArray1; //does not copy the array of myArray1 only the address of where it is stored
                                // Now there are not 2 different arrays
                                // both arrays are referenicing the same array

            //showning that the two arrays are the same
            Console.WriteLine(myArray2[0]); //output 1
            Console.WriteLine(myArray2[1]); //output 2
            Console.WriteLine(myArray2[2]); //output 3
            myArray2[0] = 7;
            Console.WriteLine(myArray1[0]); //output 7

            //set value back to 1
            myArray1[0] = 1;

            //shows how to clone array
            myArray2 = (int[])myArray1.Clone();
            //shows that the arrays are now referencing to differnt arrays
            myArray2[0] = 7;
            Console.WriteLine(myArray1[0]); //output 1
        }
    }
}
