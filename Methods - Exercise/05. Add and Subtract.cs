using System;
using System.Text;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(substract(sum(first,second),third));

        }
        public static int sum(int first, int second)
        {
            return first + second;
        }
        public static int substract(int sum ,int third)
        {
            return sum - third;
        }
    }
}