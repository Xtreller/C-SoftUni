using System;
using System.Text;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine($"{dividedFactorials(n, k):f2}");

        }
        public static double NumbFactoriel(double n)
        {
            double sum = 1;
            while (n != 0)
            {
                sum *= n;
                n--;
            }
            return sum;
        }
        public static double dividedFactorials(double n, double k)
        {

            return NumbFactoriel(n) / NumbFactoriel(k);
        }

    }
}