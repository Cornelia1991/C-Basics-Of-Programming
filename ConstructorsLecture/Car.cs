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
        private string color;
        private string brand;
        private int currentSpeed;

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



        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            if (isBrandValid(brand))
            {
                this.brand = brand;
            }
            else
            {
                Console.WriteLine("Invalid brand");
            }
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

        private bool isBrandValid(string brand)
        {
            List<string> brandNames = new List<string> { "Toyota", "Honda", "Ford" };

            if (brandNames.Contains(brand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
