using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Product
    {
        protected int count = 0;

        protected List<string> productName = new List<string>();
        protected List<Int32> productPrice = new List<Int32>();
        protected List<Int32> productQuantity = new List<Int32>();

        protected string[] nameArray;
        protected int[] priceArray;
        protected int[] quantityArray;


        public string[] GetNameArray() { return nameArray; }
        public string[] SetNameArray(string[] nameArray) => this.nameArray = nameArray;

        public int[] GetPriceArray() {return priceArray;}
        public int[] SetPriceArray(int[] priceArray) => this.priceArray = priceArray;

        public int[] getQuantityArray(){ return quantityArray;}
        public int[] SetQuantityArray(int[] quantityArray) => this.quantityArray = quantityArray;


        public void ProductInfo()
        {
            count++; 

            Console.WriteLine($"Enter Product Name: ");
            string proName = Console.ReadLine();
            Console.WriteLine($"Enter a price: ");
            int proPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Quantitiy: ");
            int proQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Product added to inventory!");

            productName.Add(proName);
            productPrice.Add(proPrice);
            productQuantity.Add(proQuantity);

        }

        public void listToArray()
        {
            nameArray = productName.ToArray();
            priceArray = productPrice.ToArray();
            quantityArray = productQuantity.ToArray();

        }

    }
}
