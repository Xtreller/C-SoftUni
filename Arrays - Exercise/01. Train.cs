using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                firstArr[i] = people;
                sum += people;
            }
            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(sum);
        }

    }
}
