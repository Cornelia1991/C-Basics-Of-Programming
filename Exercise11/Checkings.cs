using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Checkings
    {
        private string checkingMenuSelect;

        public void CheckingsMenu()
        {
            do
            {
                Console.WriteLine("Checkings Account Menu");
                Console.WriteLine("1 - Desposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Check Balance");
                Console.WriteLine("4 - Exit");
                checkingMenuSelect = Console.ReadLine();

                if (checkingMenuSelect == "1")
                {
                    CheckingsDeposit();
                }

            } while (checkingMenuSelect != "4");
        }

        public void CheckingsDeposit()
        {
            double depositAmount;

            Console.Write("Enter the deposit amount: "); 
            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A total of ${depositAmount.ToString("F")} has been despoited into your account");
        }
    }
}
