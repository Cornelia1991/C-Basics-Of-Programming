using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture2
{
    class Car
    {
        public string color;
        public string brand;
        public int currentSpeed;

        public void Accelerate(int speedIncrease)
        {
            currentSpeed += speedIncrease;
        }

        public void Decelerate(int speedDecrease)
        {
            currentSpeed -= speedDecrease;
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"The {color} {brand} is traveling at {currentSpeed} km/h");
        }
    }
}
