using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= int.MaxValue; i++)
            {

                int n = int.Parse(Console.ReadLine());
                if (n%2!=0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            }
        }

    }
}




