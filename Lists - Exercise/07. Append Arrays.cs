using System;
using System.Linq;
using System.Collections.Generic;
namespace ListsAndShit
{
    class Program
    {
        static void Main()
        {
            List<string> ListArrays = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();
            List<int> result = new List<int>();
            foreach (string item in ListArrays)
            {
             result.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList());
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
