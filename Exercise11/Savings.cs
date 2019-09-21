using System;
namespace Exercise11
{
    public class Savings : Checkings
    {
        private double interest; //10 percent

        public Savings() 
        {
            
        }

        public override void Deposit()
        {
            Console.Write("Enter the deposit amount: ");
            deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A total of ${deposit.ToString("F")} has been despoited into your account");
            currentBalance += deposit;
            interest = currentBalance * 0.10;
            Console.WriteLine($"You earned ${interest.ToString("F")} in interest");
            currentBalance += interest;
            Console.WriteLine($"Total Balance: ${currentBalance.ToString("F")}");
        }

    }
}
