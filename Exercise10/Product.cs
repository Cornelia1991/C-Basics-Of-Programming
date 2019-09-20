using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Product
    {
        protected string name;
        protected double price;
        protected int quantity;


        public void UserPrompt()
        {
            Console.Write("Enter a product name: ");
            name = Console.ReadLine();

            Console.Write("Enter the price: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enterthe quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Price: {price.ToString("F")}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Toal: {GetTotalValue().ToString("F")}");
        }

        public double GetTotalValue()
        {
            return price * quantity;
        }

    }
}
