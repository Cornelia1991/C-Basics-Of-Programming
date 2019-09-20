using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Checkings
    {
        private string menuSelect;
        public double deposit;
        public double withdrawl;
        public double currentBalance = 0;

        public void CheckingsMenu()
        {
            

            do
            {
                Console.WriteLine("Checkings Account Menu");
                Console.WriteLine("1 - Desposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Check Balance");
                Console.WriteLine("4 - Exit");
                menuSelect = Console.ReadLine();

                if (menuSelect == "1")
                {
                    CheckingDeposit();
                }
                else if (menuSelect == "2")
                {
                    CheckingWithdraw();
                }
                else if (menuSelect == "3")
                {
                    CheckingBalance();
                }

            } while (menuSelect != "4");
        }

        public void CheckingDeposit()
        { 
            Console.Write("Enter the deposit amount: "); 
            deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A total of ${deposit.ToString("F")} has been despoited into your account");
            currentBalance += deposit;
            Console.WriteLine($"Total Balance: ${currentBalance.ToString("F")}");
        }

        public void CheckingWithdraw()
        {
            Console.Write("Enter withdrawal amount: ");
            withdrawl = Convert.ToDouble(Console.ReadLine());
            if (withdrawl > currentBalance)
            {
                Console.WriteLine("Sorry, you Don't have enough funds to witdraw that amount.");
            }
            else
            {
                Console.WriteLine($"You withdrew ${withdrawl.ToString("F")} form ${currentBalance.ToString("F")}");
                currentBalance -= withdrawl;
                Console.WriteLine($"Current Balance: ${currentBalance.ToString("F")}");
            }
        }

        public void CheckingBalance()
        {
            Console.WriteLine($"Current Balance: ${currentBalance.ToString("F")}");
        }

    }
}
