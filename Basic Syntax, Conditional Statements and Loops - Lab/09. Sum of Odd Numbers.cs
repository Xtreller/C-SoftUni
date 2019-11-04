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
            int counter = 1;
            int oddnumb = 0;
            for (int i = 1; counter <= n; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                    oddnumb += i;
                    counter++;
                }
            }
            Console.WriteLine($"Sum: {oddnumb}");
        }
    }
}




