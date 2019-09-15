using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------
            //User Input
            //----------------------------------------------------

            //using ReadKey
            char userInput;
            Console.Write("Enter a character: ");
            userInput = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine("You entered: " + userInput);

            Console.ReadKey();

            //using ReadLine
            string userStringInput;
            Console.Write("Enter some text: ");
            userStringInput = Console.ReadLine();

            Console.WriteLine("You entered: " + userStringInput);

            Console.ReadKey();







            //----------------------------------------------------
            // Data Conversion
            //----------------------------------------------------

            int myInteger = 765;
            double myDouble = 7.2;

            myDouble = myInteger; //inplict coversation
            myInteger = (int)myDouble; //explict conversation 
            // the (int) example is a cast

            //-----------------------------------------------------

            //string myString = "S";
            //myInteger = Convert.ToInt32(myString);

            // cast can't be used to convert from int to string
            //that is why we used convert.ToInt32() in this example
        }
    }
}
