using ShoppingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Checkout checkout = new Checkout(ComputerStore.getPricingRules());
            foreach (String item in ComputerStore.shoppingList)
            {
                Console.WriteLine("Product scanned " + item);
                checkout.scan(item);
            }
            Console.WriteLine("Total Bill = " + checkout.computeBill());
            Console.ReadLine();
        }
    }
}
