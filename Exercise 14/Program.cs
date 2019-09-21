using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find the distance between tow points using xand y corrdinates
namespace Exercise_14
{
    class Program
    {

        static void Main(string[] args)
        {
            Point point = new Point();

            point.FindPoint();

            Console.ReadKey();
        }
    }

    class Point
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public void FindPoint()
        {
            Console.Write("Enter the x coordinate for point 1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 1: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the x coordinate for point 2: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The distance between these two points is {PointEquation().ToString("F")}");
        }

        public double PointEquation()
        {
            return Math.Sqrt(Math.Pow(x2 -x1, 2)+ Math.Pow(y2 - y1, 2));
        }
    }
}


//after coordinates are entered
//the distance between these two points is ...