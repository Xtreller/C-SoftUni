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
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
             

            for (int i = p; i <=10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }
            if (p>10)
            {
                Console.WriteLine($"{n} X {p} = {n * p}");

            }
        }
    }
}




