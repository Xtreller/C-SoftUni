using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            printSign(number);
        }
        public static void printSign(int number)
        {
            
            if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if(number==0)
            {
                Console.WriteLine($"The number 0 is zero.");
            }

            return;
        }
    }
}