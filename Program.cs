using System;
using System.Collections.Generic;

namespace CoffeeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);
            DisplayMenu(coffee);

            Console.WriteLine("Please enter discount percent!");
            int discount = Convert.ToInt32(Console.ReadLine());
            DisplayMenuAfterDiscount(discount, coffee);
        }

        private static void DisplayMenu(Dictionary<string, int> coffee)
        {
            Console.WriteLine(" **** Coffee Shop Manu ***");
            foreach (var item in coffee)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }

        private static void DisplayMenuAfterDiscount(int discount, Dictionary<string, int> coffee)
        {
            Console.WriteLine(" **** Coffee Shop Manu After Discount ***");
            foreach (var item in coffee)
            {
                var discountValue = item.Value * discount / 100;
                Console.WriteLine("{0}: {1}", item.Key, item.Value - discountValue);
            }

            Console.Write("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
