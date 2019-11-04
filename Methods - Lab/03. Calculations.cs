using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "multiply":
                    multiply(a, b);
                    break;
                case "divide":
                    devide(a, b);
                    break;
                case "add":
                    add(a, b);
                    break;
                case "subtract":
                    substract(a, b);
                    break;
                default:
                    break;
            }

        }
        public static void multiply(int firstNumber, int secondNumb)
        {
            Console.WriteLine(firstNumber*secondNumb);
        }

        public static void devide(int firstNumber, int secondNumb)
        {
            Console.WriteLine(firstNumber / secondNumb);
        }
        public static void substract(int firstNumber, int secondNumb)
        {
            Console.WriteLine(firstNumber - secondNumb);
        }
        public static void add(int firstNumber, int secondNumb)
        {
            Console.WriteLine(firstNumber + secondNumb);
        }
    }
}