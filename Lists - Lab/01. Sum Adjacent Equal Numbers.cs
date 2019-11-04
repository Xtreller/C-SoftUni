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
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count - 1 ; i++)
            {
                
                if (numbers[i]==numbers[i+1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.Remove(numbers[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
