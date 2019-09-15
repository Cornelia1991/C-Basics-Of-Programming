using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterationStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------
            //While Loop
            //--------------------------------------------------
            /*
             while(expression)
             {
                //do this 
             }
             */

            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine("While Loop " + i);
                i++;
            }

            //--------------------------------------------------
            //Do While Loop
            //--------------------------------------------------
            /*
             do
             {
                 //do this
             }
             while(expression)
             */
             //will run at least once

            do
            {
                Console.WriteLine("Do While Loop "+ i);
                i++;
            }
            while (i <= 3);

            //--------------------------------------------------
            //For Loop
            //--------------------------------------------------
            /*
                for (initalize variable; expression; update varable)
                {
                    //do something
                }
             */

            for(i = 1; i <= 3; i++)
            {
                Console.WriteLine("For Loop " + i);
            }

            //--------------------------------------------------
            //Break Statement
            //--------------------------------------------------
            for (i = 1; i <= 3; i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.WriteLine("Break Statment " + i);
            }

            //--------------------------------------------------
            //Contine Statement
            //--------------------------------------------------
            for (i = 1; i <= 3; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine("Continue Statment " + i);
            }

            Console.ReadKey();
        }
    }
}
