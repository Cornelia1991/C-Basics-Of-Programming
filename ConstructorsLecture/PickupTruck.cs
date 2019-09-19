using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsLecture
{
    class PickupTruck : Car
    {
        public int bedLength;

        public PickupTruck(int bedLength) : base()
        {
            this.bedLength = bedLength;
        }
        public PickupTruck(string color, string brand, int bedLength) : base(color, brand)
        {
            this.bedLength = bedLength;
        }

        public override void DisplaySpeed()
        {
           Console.WriteLine($"The {color} {brand} is traveling at {currentSpeed} km/h and has a bed lebgth of {bedLength} inches");
        }
    }
}
