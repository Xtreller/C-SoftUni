using System;
using System.Linq;
using System.Collections.Generic;


namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToArray();
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }


    }
}
