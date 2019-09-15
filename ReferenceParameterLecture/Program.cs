using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameterLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5; //to use the ref keyword variable must be initalizes
            int w;//using out keyout valus does not need to be initailized

            ChangeNumberRef(ref x); //will make x = 1 (using ref keyword)

            ChangeNumberOut(out w);//will make x = 0 (using out keyword)

            Console.WriteLine(x);
            Console.WriteLine(w);

            Console.ReadKey();
        }

        static void ChangeNumberRef(ref int y)
        {
            y = 1;
        }

        static void ChangeNumberOut(out int y)
        {
            y = 0;
        }
    }
}
