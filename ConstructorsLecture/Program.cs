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
            RaceCar myRaceCar = new RaceCar(5);
            RaceCar myRaceCar2 = new RaceCar("red", "Toyota", 5);

            Console.ReadKey();
        }
    }
}
