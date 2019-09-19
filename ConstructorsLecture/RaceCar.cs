using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsLecture
{
    class RaceCar : Car
    {
        private int numNitros;

        public RaceCar(int numNitros) : base() //calling base class constructor with no parameters
        {
            this.numNitros = numNitros;
        }

        public RaceCar(string color, string brand, int numNitros) : base(color, brand) //calling base class overload constructor
        {
            this.numNitros = numNitros;
        }

        public void UsedNitro()
        {
            if (numNitros > 0)
            {
                Accelerate(20);
            }
            else
            {
                Console.WriteLine("Out of nitro!");
            }
        }
    }
}
