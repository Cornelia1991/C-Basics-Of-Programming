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
            int[] myArray = { 1, 2, 3};
            int selection;

            Console.Write("Eneter thae array index of the elementyou wish to view: ");
            selection = Int32.Parse(Console.ReadLine());
            Console.WriteLine(myArray[selection]);

            Console.ReadKey();
        }
    }
}
