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
            RaceCar myRaceCar = new RaceCar();

            myRaceCar.UsedNitro();
            myRaceCar.Decelerate(5);

            PickupTruck myPickupTruck = new PickupTruck();
            myPickupTruck.Accelerate(10);
            myPickupTruck.bedLength = 100;


            Console.ReadKey();
        }
    }
}
