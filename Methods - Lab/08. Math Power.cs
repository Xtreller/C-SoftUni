using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            raiseToPower(n, pow);
        }
         static double raiseToPower(double n, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= n;
            }
            Console.WriteLine(result);
            return result;

        }

    }
}