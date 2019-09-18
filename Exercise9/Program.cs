using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{

    enum direction {North, South, East, West};

    class Program
    {
        static void Main(string[] args)
        {
            List<string> direction = new List<string>();
            string newInstruction;

            do
            {
                Console.Write("Enter the next direction (n/s/e/w or 0 to finsh)");
                newInstruction = Console.ReadLine();
  

                direction.Add(newInstruction);


            } while (newInstruction != "0");

            foreach (string newItem in direction)
            {
                Console.WriteLine(newItem);
            }



            Console.ReadKey();
        }
    }
}
