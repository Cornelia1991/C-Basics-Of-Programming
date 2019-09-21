using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        //Stuctures are value tpyes (directly contains data)
        //Classes are refrence types (hold address of data)

        //Instance of a structure are called values
        //Instance of a class are called objects

        static void Main(string[] args)
        {
            Vector MyVector = new Vector(1, 2, 3); //referred to as values
            Vector MyVector2;

            MyVector.X = 3;
            MyVector.Y = 2;
            MyVector.Z = 1;

            MyVector.DisplayVector();

            MyVector2 = MyVector; //makes copy of each field

            Console.ReadKey();
        }
    }
}
