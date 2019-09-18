using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Car.GetNumCarObjects()); //output 0

            Car Car1 = new Car("red", "Toyota");
            Console.WriteLine(Car.GetNumCarObjects());//ouput 1

            Car Car2 = new Car("green", "Honda");
            Console.WriteLine(Car.GetNumCarObjects()); //output 2

            Console.ReadKey();
        }
    }
}
