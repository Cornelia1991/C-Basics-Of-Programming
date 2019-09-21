using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingLecture2
{
    class Program
    {
        //Try Catch 
        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3};
            int selection;
            bool error;

            do
            {
                error = false;
                try
                {
                    Console.Write("Enter the array index of the element you with to view: ");
                    selection = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(myArray[selection]);
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message + "Please try again");
                }
            } while (error);

            Console.ReadKey();  
        }
    }
}
