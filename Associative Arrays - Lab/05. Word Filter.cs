using System;
using System.Linq;
using System.Collections.Generic;


namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2==0)
                .ToArray();

            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }


    }
}
