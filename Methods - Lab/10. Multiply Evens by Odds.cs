using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(multiplyedSum(Math.Abs(number)));

        }
        public static int sumOfDigits(int number,int expectedRemainder)
        {
            int sum = 0;

            while (number>0)
            {

                int lastNumb = number % 10;
                number /= 10;
                if (lastNumb%2==expectedRemainder)
                {
                    sum += lastNumb;
                }
                
            }
            return sum;

        }
        public static int sumOfEvenDigits(int number)
        {
           return sumOfDigits(number, 0);
        }
        public static int sumOfOddDigits(int number)
        {
           return sumOfDigits(number, 1);
        }
        public static int multiplyedSum(int number)
        {
            return sumOfEvenDigits(number)*sumOfOddDigits(number);
        }
        
        
       
        
    }
}