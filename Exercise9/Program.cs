using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    // ask user enter next direction n, s, e, w or 0 to exit
    //if the input is invalid notify the user of an invalid entry
    // Print out arrows for n, s, e, w

    class Program
    {
        static void Main(string[] args)
        {
            List<string> direction = new List<string>();
            string newInstruction;

            do
            {
                Console.Write("Enter the next direction (n/s/e/w or 0 to finsh)  ");
                newInstruction = Console.ReadLine();
                bool onlyValid = newInstruction == "n" || newInstruction == "s" || newInstruction == "e" || newInstruction == "w" || newInstruction == "0";

                if (!onlyValid)
                {
                    direction.Remove(newInstruction);
                    Console.WriteLine("Invalid Entry");
                }
                else
                {
                    direction.Add(newInstruction);
                }


                switch(newInstruction)
                {
                    case "n":
                        direction.Remove("n");
                        direction.Add("^");
                        break;
                    case "s":
                        direction.Remove("s");
                        direction.Add("v");
                        break;
                    case "e":
                        direction.Remove("e");
                        direction.Add(">");
                        break;
                    case "w":
                        direction.Remove("w");
                        direction.Add("<");
                        break;
                    case "0":
                        direction.Remove("0");
                        direction.Add("Route Complete!");
                        break;
                }


            } while (newInstruction != "0");

            foreach (string newItem in direction)
            {
                Console.WriteLine( newItem);
            }



            Console.ReadKey();
        }
    }
}
