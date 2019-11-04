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
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var dict = new SortedDictionary<double, int>();

            foreach (int number in numbers)
            {
                if (!(dict.ContainsKey(number)))
                {
                    dict.Add(number,0);
                }
                dict[number]++;

            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }


    }
}
