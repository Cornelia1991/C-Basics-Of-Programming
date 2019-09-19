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
            Car myCar = new Car("green", "Honda");
            RaceCar myRaceCar = new RaceCar("red", "Toyota", 5);
            PickupTruck myPickupTruck = new PickupTruck("white", "Ford", 100);

            myCar.DisplaySpeed();
            myRaceCar.DisplaySpeed();
            myPickupTruck.DisplaySpeed();

            Console.ReadKey();

        }
    }
}
