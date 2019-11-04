using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            CalculatingSum(product, count);

        }
        public static void CalculatingSum(string product,int count)
        {
            
           double price = 0;
            switch (product)
            {
                case "water":
                    price = 1;
                    Console.WriteLine($"{ (price *= count):f2}");
                    break;
                case "coffee":
                    price = 1.50;
                    Console.WriteLine($"{ (price *= count):f2}");
                    break;
                case "coke":
                    price = 1.40;
                    Console.WriteLine($"{ (price *= count):f2}");
                    break;
                case "snacks":
                    price = 2;
                    Console.WriteLine($"{ (price *= count):f2}");
                    break;
                default:
                    break;
            }
        }
    }
}