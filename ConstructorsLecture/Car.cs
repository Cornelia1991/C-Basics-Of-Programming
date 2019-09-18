using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsLecture
{

    //constructor is always named after class
    //constructore does not return a value

    class Car
    {
        public string color;
        public string brand;
        public int currentSpeed;

        //default constructor: no parameters
        public Car()
        {
            currentSpeed = 0;
        }

        //custructor "overloading"
        public Car(string carColor, string carBrand)
        {
            color = carColor;
            brand = carBrand;
            currentSpeed = 0;
        }

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
