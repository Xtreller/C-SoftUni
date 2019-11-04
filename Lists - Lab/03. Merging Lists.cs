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
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int min = Math.Min(firstList.Count, secondList.Count);
            
                for (int i = 0; i < min; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
            List<int> biggerList = new List<int>();
            if (min==firstList.Count)
            {
                biggerList = secondList;
            }
            else
            {
                biggerList = firstList;
            }
            for (int i = min; i < biggerList.Count; i++)
            {
                result.Add(biggerList[i]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
