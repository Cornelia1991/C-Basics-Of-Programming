using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            if (expression)
            //do this

             */

            //if else
            int age = 30;

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
                Console.WriteLine("Congratulation!");
            }
            else
            {
                Console.Write("You are not old enough to vote!");
                Console.WriteLine("Sorry");
            }

            //else if

            if (age >= 21)
            {
                Console.WriteLine("You are old enough to drink");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("You aren't old enough to do anything");
            }

            //----------------------------------------------
            //Switch Statments
            //----------------------------------------------


            /*
              switch(variable)
              {
                case value:
                //do something
                case value: 
                //do something
                break;
                ...
                default:
                // do something
                break;
              }
             */

            int doorNumber = 3;

            if (doorNumber == 1)
            {
                Console.WriteLine("You win a million dollars");
            }
            else if (doorNumber == 2)
            {
                Console.WriteLine("You win a new car");
            }
            else if (doorNumber == 3)
            {
                Console.WriteLine("You Win Nothing");
            }
            else
            {
                Console.WriteLine("You win a new car");
            }

            //same outcome with switch as above

            switch (doorNumber)
            {
                case 1:
                    Console.WriteLine("You win a million dollars");
                    break;
                case 2:
                    Console.WriteLine("You win a new car");
                    break;
                case 3:
                    Console.WriteLine("You win nothing");
                    break;
                default:
                    Console.WriteLine("You win a new car");
                    break;

            }

            Console.ReadKey();
        }
    }
} 
