using System;
using System.Linq;

namespace _02.grades
{
    public class StartUp
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            printGrade(number);
        }
        public static void printGrade(double number)
        {

            if (number < 3)
            {
                Console.WriteLine("Fail");
            }
            if (number < 3.50 && number >3)
            {
                Console.WriteLine("Poor");
            }
            if (number < 4.50 && number > 3.49)
            {
                Console.WriteLine("Good");
            }
            if (number < 5.50 && number > 4.49)
            {
                Console.WriteLine("Very good");
            }
            if (number < 6 && number >5.49)
            {
                Console.WriteLine("Excellent");
            }
            return;
        }
    }
}